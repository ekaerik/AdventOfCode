namespace _2021
{
    public class Day6
    {
        public long[] Execute(int numberOfDays, int[] lanternFishes, bool includeFishes = true)
        {
            var schools = lanternFishes
                .GroupBy(x => x)
                .Select(x => new FishSchool
                {
                    Timer = x.Key,
                    Count = x.Count()
                })
                .ToList();
            var days = Enumerable.Range(1, numberOfDays);
            foreach (var day in days)
            {
                long newFishes = 0;
                foreach (var school in schools)
                {
                    if (school.Timer == 0)
                    {   
                        school.Timer = 6;
                        newFishes += school.Count;
                    }
                    else
                    {
                        school.Timer--;
                    }
                }
                if (newFishes > 0)
                    schools.Add(new FishSchool
                    {
                        Timer = 8,
                        Count = newFishes
                    });

                schools = schools
                    .GroupBy(x => x.Timer)
                    .Select(x => new FishSchool
                    {
                        Timer = x.Key,
                        Count = x.Sum(x => x.Count)
                    })
                    .ToList();
            }

            if (includeFishes)
                return schools.SelectMany(s => Enumerable.Range(0, (int)s.Count).Select(f => s.Timer)).ToArray();

            return new[] {schools.Sum(x => x.Count)};
        }

        public class Fish
        {
            public int Timer { get; set; }
        }

        public class FishSchool
        {
            public long Timer { get; set; }
            public long Count { get; set; }
        }
    }
}

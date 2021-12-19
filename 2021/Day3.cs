namespace _2021
{
    public class Day3
    {
        public Diagnostics Execute(string[] input)
        {
            var parsedInput = input.Select(x => x.ToCharArray()).ToArray();
            var inputBinaryLenght = input[0].Length;
            var gamma = "0";
            var epsilon = "0";

            for (var i = 0; i < inputBinaryLenght; i++)
            {
                var sum = parsedInput.Select(x => int.Parse(x[i].ToString())).Sum();
                if (sum > input.Length / 2)
                {
                    gamma += "1";
                    epsilon += "0";
                }
                else
                {
                    gamma += "0";
                    epsilon += "1";
                }
            }

            var oxygenGeneratorRating = calculate(parsedInput, (zeroes, ones) => zeroes <= ones);
            var CO2ScrubberRating = calculate(parsedInput, (zeroes, ones) => zeroes > ones);
            
            return new Diagnostics
            {
                GammaRate = Convert.ToInt32(gamma, 2),
                EpsilonRate = Convert.ToInt32(epsilon, 2),
                OxygenGeneratorRating = Convert.ToInt32(oxygenGeneratorRating, 2),
                CO2ScrubberRating = Convert.ToInt32(CO2ScrubberRating, 2)
            };
        }

        private string calculate(char[][] input, Func<int, int, bool> predicate)
        {
            char[][] remaining = input.ToArray();
            var inputBinaryLenght = input[0].Length;
            for (var i = 0; i < inputBinaryLenght; i++)
            {
                if (remaining.Length == 1)
                    break;

                var valuesInPosition = remaining.Select(x => x[i]);
                var zeroes = valuesInPosition.Count(x => x.Equals('0'));
                var ones = valuesInPosition.Count(x => x.Equals('1'));

                var carry = predicate(zeroes, ones) ? '1' : '0';
                remaining = remaining.Where(x => x[i] == carry).ToArray();
            }

            if (remaining.Count() > 1)
                return null;

            return new string(remaining.Single());
        }


        public class Diagnostics
        {
            public int GammaRate { get; set; }
            public int EpsilonRate { get; set; }
            public int PowerConsumption { get => GammaRate * EpsilonRate; }

            public int OxygenGeneratorRating { get; set; }
            public int CO2ScrubberRating { get; set; }
            public int LifeSupportRating { get => OxygenGeneratorRating * CO2ScrubberRating; }
        }
    }
}

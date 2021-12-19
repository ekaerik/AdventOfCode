namespace _2021
{
    public class Day2
    {
        public Position Execute(string[] input)
        {
            var position = new Position();

            foreach(var item in input)
            {
                var command = item.Split(' ');
                var direction = Enum.Parse(typeof(SubmarineDirection), command[0]);
                var steps = int.Parse(command[1]);
                switch (direction)
                {
                    case SubmarineDirection.forward:
                        position.Horizontal += steps;                        
                        break;
                    case SubmarineDirection.down:
                        position.Depth += steps;
                        break;
                    case SubmarineDirection.up:
                        position.Depth -= steps;
                        break;
                }
            }

            return position;
        }

        public Position Execute2(string[] input)
        {
            var position = new Position();

            foreach (var item in input)
            {
                var command = item.Split(' ');
                var direction = Enum.Parse(typeof(SubmarineDirection), command[0]);
                var steps = int.Parse(command[1]);
                switch (direction)
                {
                    case SubmarineDirection.forward:
                        position.Depth += position.Aim * steps;
                        position.Horizontal += steps;
                        break;
                    case SubmarineDirection.down:
                        position.Aim += steps;
                        break;
                    case SubmarineDirection.up:
                        position.Aim -= steps;
                        break;
                }
            }

            return position;
        }

        private enum SubmarineDirection
        {
            forward,
            up,
            down
        }

        public class Position
        {
            public int Horizontal { get; set; }
            public int Aim { get; set; }
            public int Depth { get; set; }
            public int Result { get => Horizontal * Depth; }
        }
    }
}

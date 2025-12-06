using FluentAssertions;
using Xunit.Abstractions;

namespace AdventOfCode.Day1;

public class SecretEntrace_Part1(ITestOutputHelper output)
{
    [Fact]
    public void Should_solve_part1()
    {
        var rotations = Input.Data;

        var dial = new Dial();
        foreach (var rotation in rotations)
        {
            var direction = rotation[0];
            var steps = int.Parse(rotation[1..]);

            if (direction == 'L')
                dial.Left(steps);
            else
                dial.Right(steps);
        }

        output.WriteLine($"The dial was turned past 0 a total of {dial.Counter} times.");
    }

    private class Dial
    {
        public int Position { get; private set; } = 50;
        public int Counter;

        public void Left(int steps) => Turn(true, steps);
        public void Right(int steps) => Turn(false, steps);

        private void Turn(bool left, int steps)
        {
            if (steps > 100)
            {
                var overflow = steps / 100;
                steps -= overflow * 100;
            }

            var temp = left ? Position - steps : Position + steps;
            Position = left switch
            {
                true when temp < 0 => 100 - Math.Abs(temp),
                false when temp >= 100 => Math.Abs(100 - temp),
                _ => temp
            };

            if (Position == 0)
                Counter++;
        }
    }
}

public class SecretEntrace_Part2(ITestOutputHelper output)
{
    [Fact]
    public void Should_solve_part2()
    {
        var rotations = Input.Data;

        var dial = new Dial();
        foreach (var rotation in rotations)
        {
            var direction = rotation[0];
            var steps = int.Parse(rotation[1..]);

            if (direction == 'L')
                dial.Left(steps);
            else
                dial.Right(steps);
        }

        output.WriteLine($"The dial was turned past 0 a total of {dial.Counter} times.");
    }

    private class Dial
    {
        public int Position { get; private set; } = 50;
        public int Counter;

        public void Left(int steps) => Turn(true, steps);
        public void Right(int steps) => Turn(false, steps);

        private void Turn(bool left, int steps)
        {
            if (steps > 100)
            {
                var overflow = steps / 100;
                steps -= overflow * 100;
                Counter += overflow;
            }

            var temp = left ? Position - steps : Position + steps;
            if (temp > 0 && temp < 100)
            {
                Position = temp;
            }
            else if (left && temp < 0)
            {
                if (Position != 0)
                    Counter++;

                Position = 100 - Math.Abs(temp);
            }
            else if (!left && temp > 100)
            {
                if (Position != 0)
                    Counter++;

                Position = Math.Abs(100 - temp);
            }
            else
            {
                Position = 0;
            }

            if (Position == 0)
                Counter++;
        }
    }
}


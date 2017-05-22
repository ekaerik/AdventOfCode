using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AdventOfCOde
{
    public class Day1 : IDay
    {

        public void Open()
        {

        }

        public Distance Open(string[] rawDirections)
        {
            var currentLocation = new Coordinate { X = 0, Y = 0 };
            var regex = new Regex(@"([RL])(\d*)");


            var direction = new Direction2();
            return
                (
                from dir in rawDirections
                let match = regex.Match(dir)
                let turn = match.Groups[1].Value
                let distance = int.Parse(match.Groups[2].Value)
                select direction.Move(turn, distance)
                ).Last();
        }

    }

    public class Direction2
    {
        Coordinate currentLocation;
        CardinalDirection cardinalDirection;

        public Direction2()
        {
            currentLocation = new Coordinate();
            cardinalDirection = CardinalDirection.North;
        }
        
        public Distance Move(string turn, int distance)
        {
            if (cardinalDirection == CardinalDirection.North)
            {
                if (turn == "R")
                {
                    cardinalDirection = CardinalDirection.East;
                    currentLocation.X = currentLocation.X + distance;
                }
                if (turn == "L")
                {
                    cardinalDirection = CardinalDirection.West;
                    currentLocation.X = currentLocation.X - distance;
                }
            }
            else if (cardinalDirection == CardinalDirection.East)
            {
                if (turn == "R")
                {
                    cardinalDirection = CardinalDirection.South;
                    currentLocation.Y = currentLocation.Y - distance;
                }
                if (turn == "L")
                {
                    cardinalDirection = CardinalDirection.North;
                    currentLocation.Y = currentLocation.Y + distance;
                }
            }
            else if (cardinalDirection == CardinalDirection.South)
            {
                if (turn == "R")
                {
                    cardinalDirection = CardinalDirection.West;
                    currentLocation.X = currentLocation.X - distance;
                }
                if (turn == "L")
                {
                    cardinalDirection = CardinalDirection.East;
                    currentLocation.X = currentLocation.X + distance;
                }
            }
            else if (cardinalDirection == CardinalDirection.West)
            {
                if (turn == "R")
                {
                    cardinalDirection = CardinalDirection.North;
                    currentLocation.Y = currentLocation.Y + distance;
                }
                if (turn == "L")
                {
                    cardinalDirection = CardinalDirection.South;
                    currentLocation.Y = currentLocation.Y - distance;
                }
            }
            return new Distance
            {
                Coordinate = currentLocation,
                Blocks = Math.Abs(currentLocation.X + currentLocation.Y)
            };
        }

        public enum CardinalDirection
        {
            North,
            East,
            South,
            West
        }

    }
    
    public class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Distance
    {
        public int Blocks { get; set; }
        public Coordinate Coordinate { get; set; }

    }
}

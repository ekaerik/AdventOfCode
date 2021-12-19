namespace _2021
{
    public class Day4
    {
        public int Execute(int[] draws, int[] input)
        {
            var boards = createBoards(input);

            foreach (var draw in draws)
            {
                foreach (var board in boards)
                {
                    var bingo = board.DrawNumber(draw);
                    if (bingo)
                        return board.CalculateScore(draw);
                }
            }

            throw new Exception("This is not supposed to happen");
        }

        public object Execute2(int[] draws, int[] input)
        {
            var boards = createBoards(input);

            var winners = new List<Board>();
            foreach (var draw in draws)
            {
                foreach (var board in boards)
                {
                    if (board.Bingo)
                        continue;

                    var bingo = board.DrawNumber(draw);
                    if (bingo)
                        winners.Add(board);
                }

                if (winners.Count == boards.Length)
                    return winners[winners.Count - 1].CalculateScore(draw);
            }

            throw new Exception("This is not supposed to happen");
        }

        private Board[] createBoards(int[] boardsInput)
        {
            List<Board> boards = new List<Board>();
            var totalBoards = boardsInput.Length / 25;
            var currentBoard = 0;
            while (currentBoard < totalBoards)
            {
                boards.Add(new Board(boardsInput.Skip(currentBoard * 25).Take(25).ToArray()));
                currentBoard++;
            }

            return boards.ToArray();
        }


        private class Board
        {
            private Square[][] rows = new Square[5][];
            private Square[][] cols = new Square[5][];

            public bool Bingo;

            public Board(int[] board)
            {
                rows[0] = board.Take(5).Select(x => new Square(x)).ToArray();
                rows[1] = board.Skip(5).Take(5).Select(x => new Square(x)).ToArray();
                rows[2] = board.Skip(10).Take(5).Select(x => new Square(x)).ToArray();
                rows[3] = board.Skip(15).Take(5).Select(x => new Square(x)).ToArray();
                rows[4] = board.Skip(20).Take(5).Select(x => new Square(x)).ToArray();

                cols[0] = rows.Select(x => new Square(x[0].Number)).ToArray();
                cols[1] = rows.Select(x => new Square(x[1].Number)).ToArray();
                cols[2] = rows.Select(x => new Square(x[2].Number)).ToArray();
                cols[3] = rows.Select(x => new Square(x[3].Number)).ToArray();
                cols[4] = rows.Select(x => new Square(x[4].Number)).ToArray();
            }

            public bool DrawNumber(int number)
            {
                foreach (var row in rows)
                {
                    var maybeHaveNumber = row.SingleOrDefault(x => x.Number == number);
                    if (maybeHaveNumber != null)
                    {
                        maybeHaveNumber.Drawn = true;
                        if (rows.Any(r => r.All(s => s.Drawn)))
                            Bingo = true;
                    }
                }

                foreach(var col in cols)
                {
                    var maybeHaveNumber = col.SingleOrDefault(x => x.Number == number);
                    if (maybeHaveNumber != null)
                    {
                        maybeHaveNumber.Drawn = true;
                        if (cols.Any(c => c.All(s => s.Drawn)))
                            Bingo = true;
                    }
                }

                return Bingo;
            }

            internal int CalculateScore(int draw) =>
                rows.SelectMany(x => x.Where(s => !s.Drawn)).Select(x => x.Number).Sum() * draw;

            private class Square
            {
                public int Number { get; }
                public bool Drawn { get; set; }

                public Square(int number)
                {
                    Number = number;
                }
            }
        }

    }
}

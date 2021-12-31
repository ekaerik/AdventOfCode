namespace _2021
{
    public class Day10
    {
        public (int part1, long part2) Execute(string[] example)
        {
            var part1 = 0;
            var part2 = 0;
            var missingClosingBrackets = new List<string>();
            foreach (var line in example)
            {
                char? fault = null;
                var stack = new Stack<char>();
                foreach (var c in line)
                {
                    fault = null;
                    char pop;
                    switch (c)
                    {
                        case '('
                            or '['
                            or '{'
                            or '<':
                            stack.Push(c);
                            break;
                        case ')':
                            pop = stack.Pop();
                            if (pop != '(')
                                fault = ')';
                            break;
                        case ']':
                            pop = stack.Pop();
                            if (pop != '[')
                                fault = ']';
                            break;
                        case '}':
                            pop = stack.Pop();
                            if (pop != '{')
                                fault = '}';
                            break;
                        case '>':
                            pop = stack.Pop();
                            if (pop != '<')
                                fault = '>';
                            break;
                    }

                    if (fault == null)
                        continue;

                    part1 += fault switch
                    {
                        ')' => 3,
                        ']' => 57,
                        '}' => 1197,
                        '>' => 25137
                    };
                    break;
                }

                var isIncomplete = fault == null;
                if (isIncomplete)
                {
                    var missingChars = new List<char>();
                    while (stack.Count > 0)
                    {
                        var pop = stack.Pop();
                        switch (pop)
                        {
                            case '(':
                                missingChars.Add(')');
                                break;
                            case '[':
                                missingChars.Add(']');
                                break;
                            case '{':
                                missingChars.Add('}');
                                break;
                            case '<':
                                missingChars.Add('>');
                                break;
                        }
                    }
                    missingClosingBrackets.Add(new string(missingChars.ToArray()));
                }
            }

            var scores = new List<long>();

            foreach (var missingClosingBracket in missingClosingBrackets)
            {
                long score = 0;
                foreach (var bracket in missingClosingBracket)
                {
                    score *= 5;
                    score += bracket switch
                    {
                        ')' => 1,
                        ']' => 2,
                        '}' => 3,
                        '>' => 4
                    };
                }
                scores.Add(score);
            }

            return (part1, scores.OrderBy(x => x).Skip(scores.Count / 2).First());

        }
    }
}

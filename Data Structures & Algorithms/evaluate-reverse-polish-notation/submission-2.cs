public class Solution {
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        var value = 0;

        foreach (var token in tokens)
        {
            if (char.IsAsciiDigit(token.Last()))
            {
                stack.Push(int.Parse(token));
                continue;
            }

            var value2 = stack.Pop();
            var value1 = stack.Pop();

            stack.Push(Calculate(value1, value2, token));
        }

        return stack.Pop();
    }

    private int Calculate(int value1, int value2, string operators)
    {
        if (operators == "*") return value1 * value2;
        if (operators == "/") return value1 / value2;
        if (operators == "+") return value1 + value2;
        if (operators == "-") return value1 - value2;

        return 0;
    }
}

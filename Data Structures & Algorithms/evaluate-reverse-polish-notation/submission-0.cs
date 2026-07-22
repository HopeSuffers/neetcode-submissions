public class Solution {
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<string>();

        foreach (var variable in tokens)
        {
            var c = variable.First();

            if (variable != "+" && variable != "-" && variable != "*" && variable != "/")
            {
                stack.Push(variable);
                continue;
            }

            var num2 = int.Parse(stack.Pop());
            var num1 = int.Parse(stack.Pop());

            var result = MathOperation(num1, num2, c);
            stack.Push(result.ToString());
        }

        return int.Parse(stack.Peek());
    }

    private int MathOperation(int number1, int number2, char operator1)
    {
        switch (operator1)
        {
            case '*': return number1 * number2;
            case '/': return number1 / number2;
            case '-': return number1 - number2;
            case '+': return number1 + number2;
            default: return 0;
        }
    }
}

public class Solution {
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c is '(' or '{' or '[')
            {
                stack.Push(c);
                continue;
            }

            if (stack.Count == 0)
                return false;

            if ((c == ')' && stack.Pop() != '(') || (c == ']' && stack.Pop() != '[') ||
                (c == '}' && stack.Pop() != '{'))
            {
                return false;
            }
        }

        return stack.Count == 0;
    }
}

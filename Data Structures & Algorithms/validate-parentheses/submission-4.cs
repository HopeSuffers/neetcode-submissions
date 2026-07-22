public class Solution {
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (var character in s)
        {
            if (character == '(' || character == '[' || character == '{')
            {
                stack.Push(character);
                continue;
            }

            if (stack.Count == 0)
                return false;

            if (character == ')' && stack.Pop() != '(') return false;
            if (character == ']' && stack.Pop() != '[') return false;
            if (character == '}' && stack.Pop() != '{') return false;
        }

        return stack.Count == 0;
    }
}

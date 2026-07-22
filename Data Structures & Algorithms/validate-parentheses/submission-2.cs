public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach (var cha in s) {
            if (cha == '{' || cha == '(' || cha == '[') {
                stack.Push(cha);
                continue;
            }

            if (stack.Count == 0)
                return false;

            if (cha == '}' && stack.Pop() != '{')
                return false;
            if (cha == ']' && stack.Pop() != '[')
                return false;
            if (cha == ')' && stack.Pop() != '(')
                return false;
        }

        return stack.Count == 0;
    }
}

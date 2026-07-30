public class Solution
{
    public List<string> GenerateParenthesis(int n)
    {
        var list = new List<string>();
        var current = "";

        void Dfs(int leftCounter, int rightCounter)
        {
            if (current.Length == n * 2)
            {
                list.Add(current);
                return;
            }

            if (leftCounter < n)
            {
                current += "(";
                Dfs(leftCounter + 1, rightCounter);
                current = current.Substring(0, current.Length - 1);
            }

            if (rightCounter < leftCounter)
            {
                current += ")";
                Dfs(leftCounter, rightCounter + 1);
                current = current.Substring(0, current.Length - 1);
            }
        }

        Dfs(0, 0);
        return list;
    }
}
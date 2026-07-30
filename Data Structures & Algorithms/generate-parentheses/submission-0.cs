public class Solution {
    public List<string> GenerateParenthesis(int n) {
        var returnList = new List<string>();
        var current = "";

        void Dfs(int openCounter, int closedCounter) {
            if (current.Length == n * 2) {
                returnList.Add(current);
                return;
            }

            if (openCounter < n) {
                current += "(";
                Dfs(openCounter + 1, closedCounter);
                current = current.Substring(0, current.Length - 1);
            }

            if (closedCounter < openCounter) {
                current += ")";
                Dfs(openCounter, closedCounter + 1);
                current = current.Substring(0, current.Length - 1);
            }
        }

        Dfs(0, 0);
        return returnList;
    }
}
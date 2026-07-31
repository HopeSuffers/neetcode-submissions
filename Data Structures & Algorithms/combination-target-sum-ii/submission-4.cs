public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var returnList = new List<List<int>>();
        var current = new List<int>();

        void Dfs(int start, int difference)
        {
            if (difference == 0)
            {
                returnList.Add(new List<int>(current));
                return;
            }

            for (int index = start; index < candidates.Length; index++)
            {
                if(index > start && candidates[index] == candidates[index-1] )
                    continue;
                if (difference - candidates[index] < 0)
                    break;

                current.Add(candidates[index]);
                Dfs(index+1, difference - candidates[index]);
                current.RemoveAt(current.Count - 1);
            }
        }

        Dfs(0, target);
        return returnList;
    }
}

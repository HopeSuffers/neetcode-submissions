public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var returnList = new List<List<int>>();
        var current = new List<int>();

        void Dfs(int index, int difference)
        {
            if (difference == 0)
            {
                returnList.Add(new List<int>(current));
                return;
            }

            for (int i = index; i < candidates.Length; i++)
            {
                if (i > index && candidates[i] == candidates[i - 1]) 
                    continue;
               
                if (candidates[i] > difference)
                    break;
                
                current.Add(candidates[i]);
                Dfs(i + 1, difference - candidates[i]);
                current.RemoveAt(current.Count - 1);
                
            }
        }
        
        Dfs(0, target);
        return returnList;
    }
}

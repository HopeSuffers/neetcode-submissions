public class Solution {
    public int MaxCoins(int[] nums)
    {
        var list = nums.ToList();
        list.Insert(0, 1);
        list.Add(1);

        var memo = new Dictionary<(int, int), int>();
        return Dfs(1, list.Count - 2);

       int Dfs(int left, int right)
       {
           if (left > right)
               return 0;

           if (memo.ContainsKey((left, right)))
               return memo[(left, right)];

           var best = 0;
           for (int i = left; i < right+1; i++)
           {
               var coins = list[left - 1] * list[i] * list[right + 1];
               coins += Dfs(left, i - 1) + Dfs(i + 1, right);
               best = Math.Max(best, coins);
           }

           memo[(left, right)] = best;
           return best;
       }
    }
}

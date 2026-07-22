public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> hashSet = nums.ToHashSet();
        int highScore = 0;

        foreach (var num in hashSet)
        {
            if (!hashSet.Contains(num - 1))
            {
                int score = 1;
                int current = num;

                while (hashSet.Contains(current + 1))
                {
                    score++;
                    current++;
                }
                
                highScore = Math.Max(highScore, score);
            }
        }

        return highScore;
    }
}

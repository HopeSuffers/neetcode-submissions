public class Solution {
    public int LongestConsecutive(int[] nums)
    {
        HashSet<int> hashSet = nums.ToHashSet();
        var highScore = 0;

        foreach (var VARIABLE in hashSet)
        {
            if (hashSet.Contains(VARIABLE - 1)) continue;
            
            var current = VARIABLE;
            var score = 1;

            while (hashSet.Contains(current + 1))
            {
                current++;
                score++;
            }

            highScore = Math.Max(score, highScore);
        }

        return highScore;
    }
}

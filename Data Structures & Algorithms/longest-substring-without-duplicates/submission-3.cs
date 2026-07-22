public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        var hashSet = new HashSet<char>();
        var best = 0;
        var left = 0;

        foreach (var c in s)
        {
            if (hashSet.Contains(c))
            {
                best = Math.Max(hashSet.Count, best);

                while (hashSet.Count > 0 && hashSet.Contains(c))
                {
                    hashSet.Remove(s[left]);
                    left++;
                }
            }

            hashSet.Add(c);
        }

        best = Math.Max(hashSet.Count, best);
        return best;
    }
}

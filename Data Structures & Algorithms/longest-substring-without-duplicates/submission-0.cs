public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        HashSet<char> hashSet = new HashSet<char>();

        var left = 0;
        var best = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (hashSet.Contains(s[right]))
            {
                hashSet.Remove(s[left]);
                left++;
            }

            hashSet.Add(s[right]);

            int currentLength = right - left + 1;
            best = Math.Max(currentLength, best);
        } 
        
        return best;
    }
}

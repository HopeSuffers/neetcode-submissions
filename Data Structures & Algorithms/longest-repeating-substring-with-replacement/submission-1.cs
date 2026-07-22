public class Solution {
    public int CharacterReplacement(string s, int k)
    {
        var dic = new Dictionary<char, int>();
        
        var left = 0;
        var best = 0;
        var mostUsed = 0;

        for (int right = 0; right < s.Length; right++)
        {
            var c = s[right];
            
            if (!dic.ContainsKey(s[right]))
                dic[s[right]] = 0;
        
            dic[c]++;
            
            mostUsed = Math.Max(mostUsed, dic[c]);
            var length = right - left + 1;
            var needReplacment = length - mostUsed;

            while (needReplacment > k)
            {
                dic[s[left]]--;
                left++;

                length = right - left + 1;
                needReplacment = length - mostUsed;
            }

            best = Math.Max(best, length);
        }

        return best;
    }
}

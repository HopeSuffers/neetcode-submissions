public class Solution {
    public int CharacterReplacement(string s, int k)
    {
        var dic = new Dictionary<char, int>();

        var best = 0;
        var left = 0;
        var highestFrequency = 0;

        for (int right = 0; right < s.Length; right++)
        {
            var character = s[right];

            if (!dic.ContainsKey(character))
                dic[character] = 0;

            dic[character]++;

            var length = right - left + 1;
            highestFrequency = Math.Max(highestFrequency, dic[character]);
            var needReplacement = length - highestFrequency;

            while (needReplacement > k)
            {
                dic[s[left]]--;
                left++;

                length = right - left + 1;
                needReplacement = length - highestFrequency;
            }

            best = Math.Max(best, length);
        }

        return best;
    }
}

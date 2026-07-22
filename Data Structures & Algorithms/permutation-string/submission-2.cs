public class Solution {
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
            return false;

        var s1Count = new int[26];
        var substringCount = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            s1Count[s1[i] - 'a']++;
            substringCount[s2[i] - 'a']++;
        }

        if (s1Count.SequenceEqual(substringCount))
            return true;

        for (int right = s1.Length; right < s2.Length; right++)
        {
            substringCount[s2[right] - 'a']++;

            int left = right - s1.Length;
            substringCount[s2[left] - 'a']--;

            if (s1Count.SequenceEqual(substringCount))
                return true;
        }

        return false;
    }
}

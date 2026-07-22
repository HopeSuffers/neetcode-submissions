public class Solution {
    public string MinWindow(string s, string t)
    {
        if (t.Length > s.Length)
            return "";
        
        var bestString = "";
        
        var sCount = new int[128];
        var tCount = new int[128];

        for (int i = 0; i < t.Length; i++)
        {
            tCount[t[i]]++;
            sCount[s[i]]++;
        }

        if (sCount.SequenceEqual(tCount))
            return s.Substring(0, t.Length);


        var left = 0;
        for (int right = t.Length; right < s.Length; right++)
        {
            sCount[s[right]]++;

            if(!ContainsAll(sCount, tCount))
                continue;

            while (ContainsAll(sCount, tCount))
            {
                sCount[s[left]]--;
                left++;
            }

            var current = s.Substring(left - 1, right - left + 2);

            if (bestString == "" || current.Length < bestString.Length)
                bestString = current;
        }

        return bestString;
    }

    bool ContainsAll(int[] sCount, int[] tCount)
    {
        for (int i = 0; i < 128; i++)
        {
            if (sCount[i] < tCount[i])
                return false;
        }

        return true;
    }
}

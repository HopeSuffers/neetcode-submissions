public class Solution {
    public List<int> PartitionLabels(string s)
    {
        var result = new List<int>();
        var dic = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!dic.ContainsKey(s[i]))
            {
                dic[s[i]] = i;
                continue;
            }

            dic[s[i]] = Math.Max(dic[s[i]], i);
        }

        int counter = 0;
        int end = 0;
        for (int i = 0; i < s.Length; i++)
        {
            counter++;
            if (dic[s[i]] > end)
                end = dic[s[i]];

            if (i < end)
                continue;

            result.Add(counter);
            end = 0;
            counter = 0;
        }

        return result;
    }
}

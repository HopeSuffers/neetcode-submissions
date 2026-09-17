public class Solution {
     public List<List<string>> GroupAnagrams(string[] strs)
    {
        var dic = new Dictionary<string, List< string>>();

        foreach (var str in strs)
        {
            var sorted = string.Concat(str.OrderBy(x => x));

            if (dic.ContainsKey(sorted))
                dic[sorted].Add(str);
            else
                dic.Add(sorted, new List<string> { str });
        }

        return dic.Select(variable => variable.Value).ToList();
    }
}

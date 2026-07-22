public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>>  groups = new Dictionary<string, List<string>>();
        
        foreach (var str in strs)
        {
            var key = string.Concat(str.OrderBy(x => x));

            if (!groups.ContainsKey(key))
                 groups[key] = new List<string>();


            groups[key].Add(str);
        }

        return groups.Values.ToList();
    }
}

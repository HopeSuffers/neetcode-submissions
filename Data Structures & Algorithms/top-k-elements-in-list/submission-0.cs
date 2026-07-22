public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dictionary = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dictionary.ContainsKey(num))
            {
                dictionary[num]++;
                continue;
            }

            dictionary.Add(num, 1);
        }
        
        var ordered = dictionary.OrderByDescending(x => x.Value);
        return ordered.Take(k).Select(x => x.Key).ToArray();
    }
}

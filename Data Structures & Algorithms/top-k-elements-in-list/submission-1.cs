public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dic = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (!dic.ContainsKey(num))
                dic.Add(num, 0);

            dic[num]++;
        }

        var list = dic.ToList();
        list.Sort((a,b) => b.Value.CompareTo(a.Value));

        var result = new List<int>();
        for (var i = 0; i < k; i++)
            result.Add(list[i].Key);

        return result.ToArray();
    }
}

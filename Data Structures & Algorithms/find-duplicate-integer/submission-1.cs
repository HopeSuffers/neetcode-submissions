public class Solution {
    public int FindDuplicate(int[] nums)
    {
        var hashSet = new HashSet<int>();
        return nums.FirstOrDefault(num => !hashSet.Add(num));
    }
}

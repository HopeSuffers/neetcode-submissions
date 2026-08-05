public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var arr = nums1.Concat(nums2).ToArray();
        Array.Sort(arr);

        if (arr.Length % 2 == 1)
            return arr[arr.Length / 2];

        int middleRight = arr.Length / 2;
        int middleLeft = middleRight - 1;

        return (arr[middleLeft] + (double)arr[middleRight]) / 2;
    }
}

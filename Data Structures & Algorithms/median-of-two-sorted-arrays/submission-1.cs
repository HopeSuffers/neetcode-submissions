public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);

        int[] smaller = nums1;
        int[] larger = nums2;

        int totalLength = smaller.Length + larger.Length;
        int leftHalfSize = (totalLength + 1) / 2;

        int left = 0;
        int right = smaller.Length;

        while (left <= right) {
            int smallerPartition = left + (right - left) / 2;
            int largerPartition = leftHalfSize - smallerPartition;

            int smallerLeft = smallerPartition == 0 ? int.MinValue : smaller[smallerPartition - 1];

            int smallerRight =
                smallerPartition == smaller.Length ? int.MaxValue : smaller[smallerPartition];

            int largerLeft = largerPartition == 0 ? int.MinValue : larger[largerPartition - 1];

            int largerRight =
                largerPartition == larger.Length ? int.MaxValue : larger[largerPartition];

            bool validPartition = smallerLeft <= largerRight && largerLeft <= smallerRight;

            if (validPartition) {
                if (totalLength % 2 == 1) {
                    return Math.Max(smallerLeft, largerLeft);
                }

                int leftMiddle = Math.Max(smallerLeft, largerLeft);
                int rightMiddle = Math.Min(smallerRight, largerRight);

                return ((double)leftMiddle + rightMiddle) / 2;
            }

            if (smallerLeft > largerRight) {
                right = smallerPartition - 1;
            } else {
                left = smallerPartition + 1;
            }
        }

        throw new InvalidOperationException("The input arrays must be sorted.");
    }
}

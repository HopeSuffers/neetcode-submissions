public class Solution {
    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var diff = numbers[right] + numbers[left];

            if (diff == target)
                return [left + 1, right + 1];

            if (diff > target)
                right--;
            else left++;
        }

        return null;
    }
}

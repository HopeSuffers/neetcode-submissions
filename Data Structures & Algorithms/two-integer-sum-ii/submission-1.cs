public class Solution {
    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var rigth = numbers.Length - 1;

        while (left < rigth)
        {
            var sum = numbers[left] + numbers[rigth];
            if (sum == target)
                return new[] { left + 1, rigth + 1 };

            if (sum < target)
                left++;
            else rigth--;
        }

        return Array.Empty<int>();
    }
}

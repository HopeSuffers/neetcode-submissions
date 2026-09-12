public class Solution
{
    public string Multiply(string num1, string num2)
    {
        if (num1 == "0" || num2 == "0")
            return "0";

        int[] result = new int[num1.Length + num2.Length];

        for (int i = num1.Length - 1; i >= 0; i--)
        {
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                int a = num1[i] - '0';
                int b = num2[j] - '0';

                int product = a * b;

                int low = i + j + 1;
                int high = i + j;

                int sum = product + result[low];

                result[low] = sum % 10;
                result[high] += sum / 10;
            }
        }

        int start = 0;

        while (start < result.Length && result[start] == 0)
            start++;

        return string.Concat(result.Skip(start));
    }
}
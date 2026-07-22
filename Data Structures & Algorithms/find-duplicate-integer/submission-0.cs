public class Solution {
    public int FindDuplicate(int[] nums) 
    {
        {
            Stack<int> stack = new Stack<int>();

            foreach (var num in nums)
            {
                if (stack.Contains(num))
                    return num;

                stack.Push(num);
            }
        }
        
        return 0;
    }
}

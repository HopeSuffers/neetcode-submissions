public class Solution 
{
    public bool hasDuplicate(int[] nums)
    {
        Stack<int> stack = new Stack<int>();

        foreach (var num in nums)
        {
            if (stack.Contains(num))
                return true;
            
            stack.Push(num);
        }

        return false;
    }
}
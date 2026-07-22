public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        var arrayReturn = new int[temperatures.Length];
        var stack = new Stack<int>();
        
        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i])
            {
                var previous = stack.Pop();
                arrayReturn[previous] = i - previous;
            }
            
            stack.Push(i);
        }

        return arrayReturn;
    }
}

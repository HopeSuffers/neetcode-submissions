public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        var result = new int [temperatures.Length];
        var stack = new Stack<int>();

        for (var i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                var previous = stack.Pop();
                result[previous] = i - previous;
            }
            
            stack.Push(i);
        }

        return result;
    }
}

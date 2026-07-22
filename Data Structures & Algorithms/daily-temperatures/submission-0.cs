public class Solution {
    public int[] DailyTemperatures(int[] temperatures)
    {
        var answer = new int[temperatures.Length];
        var stack = new Stack<int>();

        for (var i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                var previousDay = stack.Pop();
                answer[previousDay] = i - previousDay;
            }
            
            stack.Push(i);
        }

        return answer;
    }
}

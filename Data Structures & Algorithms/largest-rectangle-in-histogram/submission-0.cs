public class Solution {
    public int LargestRectangleArea(int[] heights)
    {
        List<int> result = new List<int>();
        Stack<int> stack = new Stack<int>();
        
        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] == 0)
            {
                while (stack.Count != 0)
                {
                    var rectangleArea = (i - stack.Pop()) * (stack.Count + 1);
                    result.Add(rectangleArea);
                }

                continue;
            }
            
            if (stack.Count == 0)
            {
                stack.Push(i);
                continue;
            }

            var combinedRectArea = Math.Min(heights[i - 1], heights[i]);

            while (stack.Count != combinedRectArea)
            {
                if (stack.Count < combinedRectArea)
                {
                    stack.Push(i - 1);
                }
                else
                {
                    var rectangleArea = (i - stack.Pop()) * (stack.Count + 1);
                    result.Add(rectangleArea);
                }
            }
        }

        while (stack.Count != 0)
        {
            var rectangleArea = (heights.Length - stack.Pop()) * (stack.Count + 1);
            result.Add(rectangleArea);
        }

        heights = heights.OrderByDescending(x => x).ToArray();
        result.Add(heights[0]);

        return result.Max();
    }
}

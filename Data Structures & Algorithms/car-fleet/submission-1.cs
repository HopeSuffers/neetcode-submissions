public class Solution {
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var list = new List<(int position, int speed)>();

        for (int i = 0; i < position.Length; i++)
        {
            list.Add((position[i], speed[i]));
        }

        list.Sort((a, b) => b.position.CompareTo(a.position));
        var stack = new Stack<double>();
        
        foreach (var car in list)
        {
            var time = (double)(target - car.position) / car.speed;

            if (stack.Count == 0 || time > stack.Peek())
                stack.Push(time);
        }

        return stack.Count;
    }
}

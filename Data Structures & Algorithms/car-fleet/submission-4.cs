public class Solution {
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var cars = new List<(int position, int speed)>();

        for (int i = 0; i < position.Length; i++)
            cars.Add((position[i], speed[i]));

        cars = cars.OrderByDescending(x => x.position).ToList();
        var stack = new Stack<double>();

        foreach (var car in cars)
        {
            double reachesTargetIn = (double)(target - car.position) / car.speed;

            if (stack.Count > 0 && stack.Peek() >= reachesTargetIn)
                continue;

            stack.Push(reachesTargetIn);
        }

        return stack.Count;
    }
}

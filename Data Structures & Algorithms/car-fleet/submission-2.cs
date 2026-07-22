public class Solution {
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var cars = new List<(int position, int speed)>();

        for (int i = 0; i < position.Length; i++)
        {
            cars.Add((position[i], speed[i]));
        }
        
        cars.Sort((a, b) => b.position.CompareTo(a.position));
        Stack<double> fleetTime = new Stack<double>();
        
        foreach (var car in cars)
        {
            double time = (double)(target - car.position) / car.speed;
            
            if (fleetTime.Count == 0 || time > fleetTime.Peek())
                fleetTime.Push(time);
        }

        return fleetTime.Count;
    }
}

public class Solution {
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var cars = new List<(int position, int speed)> { };
        
        cars.AddRange(position.Select((t, i) => (t, speed[i])));

        cars.Sort((a, b) => b.position.CompareTo(a.position));
        Stack<double> timeFleet = new Stack<double>();

        foreach (var car in cars)
        {
            var time = (double)(target - car.position) / car.speed;

            if (timeFleet.Count == 0 || timeFleet.Peek() < time)
                timeFleet.Push(time);
        }

        return timeFleet.Count;
    }
}

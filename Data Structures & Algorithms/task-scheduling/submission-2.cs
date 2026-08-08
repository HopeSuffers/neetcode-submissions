public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        var array = new int[26];

        foreach (var task in tasks) array[task - 'A']++;

        var maxHeap = new PriorityQueue<int, int>();

        for (int i = 0; i < array.Length; i++)
            if (array[i] > 0)
                maxHeap.Enqueue(array[i], -array[i]);

        var time = 0;
        var queue = new Queue<(int time, int timeLeft)>();

        while (maxHeap.Count > 0 || queue.Count > 0) {
            time++;
            if (maxHeap.Count > 0) {
                var task = maxHeap.Dequeue();
                task--;

                if (task > 0)
                    queue.Enqueue((task, time + n));
            }

            if (queue.Count > 0 && queue.Peek().timeLeft == time) {
                var task = queue.Dequeue();
                maxHeap.Enqueue(task.time, -task.time);
            }
        }

        return time;
    }
}

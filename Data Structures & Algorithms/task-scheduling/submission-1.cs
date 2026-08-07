public class Solution {
     public int LeastInterval(char[] tasks, int n)
    {
        var maxHeap = new PriorityQueue<int, int>();
        var bitArray = new int[26];

        foreach (var task in tasks)
            bitArray[task - 'A']++;

        foreach (var bit in bitArray)
        {
            if (bit > 0)
                maxHeap.Enqueue(bit, -bit);
        }

        var queue = new Queue<(int count, int availableTime)>() { };
        var time = 0;

        while (maxHeap.Count > 0 || queue.Count > 0)
        {
            time++;

            if (maxHeap.Count > 0)
            {
                var count = maxHeap.Dequeue();
                count--;

                if (count > 0)
                {
                    queue.Enqueue((count, time + n));
                }
            }

            if (queue.Count > 0 && queue.Peek().availableTime == time)
            {
                var task = queue.Dequeue();
                maxHeap.Enqueue(task.count, -task.count);
            }
        }

        return time;
    }
}

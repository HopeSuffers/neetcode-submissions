public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var queue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        foreach (var stone in stones)
            queue.Enqueue(stone, stone);

        while (queue.Count > 1)
        {
            var stone1 = queue.Dequeue();
            var stone2 = queue.Dequeue();

            var result = Math.Abs(stone2 - stone1);
            queue.Enqueue(result, result);
        }

        return queue.Peek();
    }
}

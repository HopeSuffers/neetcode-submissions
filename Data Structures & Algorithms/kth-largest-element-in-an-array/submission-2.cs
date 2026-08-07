public class Solution {
    public int FindKthLargest(int[] nums, int k)
    {
        var queue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        foreach (var num in nums)
            queue.Enqueue(num, num);

        for (int i = 1; i < k; i++)
            queue.Dequeue();

        return queue.Peek();
    }
}
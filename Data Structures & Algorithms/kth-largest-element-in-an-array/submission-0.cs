public class Solution {
    public int FindKthLargest(int[] nums, int k)
    {
        var queue = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        foreach (var num in nums)
        {
            queue.Enqueue(num, num);
        }

        if (k > queue.Count)
            return -1;
        
        for (var i = 0; i < k; i++)
        {
            if (i == k - 1)
                return queue.Dequeue();

            queue.Dequeue();
        }

        return -1;
    }
}
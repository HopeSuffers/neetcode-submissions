public class Solution {
    public int FindKthLargest(int[] nums, int k)
    {
        var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        foreach (var num in nums)
            maxHeap.Enqueue(num, num);
        
        for (var i = 1; i < k; i++)
            maxHeap.Dequeue();

        return maxHeap.Dequeue();
    }
}
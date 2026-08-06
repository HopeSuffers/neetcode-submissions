public class KthLargest {
    private PriorityQueue<int, int> queue;
    private int size;
    public KthLargest(int k, int[] nums) {
        queue = new PriorityQueue<int, int>();
        size = k;

        foreach (var num in nums) Add(num);
    }

    public int Add(int val) {
        queue.Enqueue(val, val);

        if (queue.Count > size)
            queue.Dequeue();

        return queue.Peek();
    }
}
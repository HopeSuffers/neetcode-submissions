public class KthLargest
{
    private int k;
    private PriorityQueue<int, int> heap;
    
    public KthLargest(int k, int[] nums)
    {
        this.k = k;
        heap = new PriorityQueue<int, int>();

        foreach (var num in nums)
        {
            Add(num);
        }
    }
    
    public int Add(int val) {
        heap.Enqueue(val, val);

        if (heap.Count > k)
        {
            heap.Dequeue();
        }

        return heap.Peek();
    }
}

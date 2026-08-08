public class MedianFinder {
    private PriorityQueue<int, int> leftHeap;
    private PriorityQueue<int, int> rightHeap;
    public int size;

    public MedianFinder() {
        leftHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        rightHeap = new PriorityQueue<int, int>();
        size = 0;
    }

    public void AddNum(int num) {
        if (leftHeap.Count == 0 && rightHeap.Count == 0) {
            leftHeap.Enqueue(num, num);
            return;
        }

        if (num < leftHeap.Peek()) {
            leftHeap.Enqueue(num, num);

            if (leftHeap.Count <= rightHeap.Count + 1)
                return;

            var curr = leftHeap.Dequeue();
            rightHeap.Enqueue(curr, curr);
        } else {
            rightHeap.Enqueue(num, num);

            if (rightHeap.Count <= leftHeap.Count)
                return;

            var curr = rightHeap.Dequeue();
            leftHeap.Enqueue(curr, curr);
        }
    }

    public double FindMedian() {
        var size = leftHeap.Count + rightHeap.Count;

        if (size % 2 == 1)
            return leftHeap.Peek();

        var left = leftHeap.Peek();
        var right = rightHeap.Peek();

        return (double)(left + right) / 2;
    }
}
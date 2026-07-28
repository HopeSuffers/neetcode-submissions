public class Solution
{
    public int LastStoneWeight(int[] stones)
    {
        var maxHeap = new PriorityQueue<int, int>(
            Comparer<int>.Create((a, b) => b.CompareTo(a))
        );

        foreach (var stone in stones)
        {
            maxHeap.Enqueue(stone, stone);
        }

        while (maxHeap.Count > 1)
        {
            var max1 = maxHeap.Dequeue();
            var max2 = maxHeap.Dequeue();

            var smashValue = max2 - max1;

            switch (smashValue)
            {
                case 0:
                    continue;
                case < 0:
                    maxHeap.Enqueue(Math.Abs(smashValue), Math.Abs(smashValue));
                    break;
                default:
                    maxHeap.Enqueue(smashValue, smashValue);
                    break;
            }
        }

        return maxHeap.Count > 0 ? maxHeap.Peek() : 0;
    }
}

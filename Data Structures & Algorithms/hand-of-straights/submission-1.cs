public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize)
    {
        if (hand.Length % groupSize != 0)
            return false;

        Array.Sort(hand);

        var min = hand.Min();
        var max = hand.Max();
        var diff = max - min;

        int[] frequency = new int[diff + 1];

        for (int i = 0; i < hand.Length; i++)
            frequency[hand[i] - min] += 1;


        for (int i = 0; i < frequency.Length; i++)
        {
            while (frequency[i] > 0)
            {
                if (!CreateHands(i, groupSize))
                    return false;
            }
        }

        return true;

        bool CreateHands(int start, int end)
        {
            for (int i = 0; i < end; i++)
            {
                if (start >= frequency.Length)
                    return false;

                if (frequency[start] < 1)
                    return false;

                frequency[start]--;
                start++;
            }

            return true;
        }
    }
}

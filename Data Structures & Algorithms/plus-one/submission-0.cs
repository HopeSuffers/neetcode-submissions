public class Solution {
    public int[] PlusOne(int[] digits)
    {
        var list = digits.ToList();
        int pos = list.Count-1;

        while (pos >= 0 && list[pos] == 9 )
        {
            list[pos] = 0;
            pos--;
        }

        if (pos < 0)
            list.Insert(0, 1);
        else
            list[pos]++;

        return list.ToArray();
    }
}

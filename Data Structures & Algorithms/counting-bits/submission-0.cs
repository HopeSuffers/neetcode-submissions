public class Solution {
    public int[] CountBits(int n) {
        var returnArray = new int[n + 1];

        for (var i = 1; i <= n; i++) {
            var tmp = Convert.ToString(i, 2);
            for (var j = tmp.Length - 1; j >= 0; j--) {
                if (tmp[j] == '1')
                    returnArray[i] += 1;
            }
        }

        return returnArray;
    }
}

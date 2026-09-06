public class Solution {
    public uint ReverseBits(uint n)
    {
        var str = Convert.ToString(n, 2);
        for (var i = str.Length; i < 32; i++)
            str = str.Insert(0, "0");

        var returnString = "";
        for (var i = str.Length -1; i >= 0; i--)
            returnString += str[i];

        return Convert.ToUInt32(returnString, 2);
    }
}

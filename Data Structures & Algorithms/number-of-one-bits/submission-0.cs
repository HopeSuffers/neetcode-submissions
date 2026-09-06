public class Solution {
    public int HammingWeight(uint n) {
        var binary = Convert.ToString(n, 2);
        return binary.Count(c => c == '1');
    }
}

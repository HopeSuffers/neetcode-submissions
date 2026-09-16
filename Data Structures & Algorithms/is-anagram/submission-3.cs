public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        s = string.Concat(s.OrderBy(s => s));
        t = string.Concat(t.OrderBy(t => t));

        return s == t;
    }
}
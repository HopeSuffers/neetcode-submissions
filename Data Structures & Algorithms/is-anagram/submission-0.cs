public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        
        s = string.Concat(s.OrderBy(x => x));
        t = string.Concat(t.OrderBy(x => x));

        return s.Equals(t);
    }
}
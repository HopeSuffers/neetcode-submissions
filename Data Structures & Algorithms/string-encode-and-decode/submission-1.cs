public class Solution
{
    public string Encode(IList<string> strs)
    {
        var result = new StringBuilder();

        foreach (var str in strs)
        {
            result.Append(str.Length);
            result.Append('#');
            result.Append(str);
        }

        return result.ToString();
    }

    public List<string> Decode(string s)
    {
        var result = new List<string>();
        int i = 0;

        while (i < s.Length)
        {
            int j = i;

            while (s[j] != '#')
                j++;

            int length = int.Parse(s.Substring(i, j - i));

            j++;

            result.Add(s.Substring(j, length));

            i = j + length;
        }

        return result;
    }
}
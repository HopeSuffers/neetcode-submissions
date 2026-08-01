public class Solution
{
    public List<List<string>> Partition(string s)
    {
        var returnList = new List<List<string>>();
        var current = new List<string>();

        Dfs(0);
        return returnList;

        void Dfs(int start)
        {
            if (start >= s.Length)
            {
                returnList.Add(new List<string>(current));
                return;
            }

            for (int index = start; index < s.Length; index++)
            {
                var substring = s.Substring(start, index - start + 1);

                if (!IsPalindrom(substring))
                    continue;

                current.Add(substring);
                Dfs(index + 1);
                current.RemoveAt(current.Count-1);
            }
        }

        bool IsPalindrom(string s)
        {
            if (s.Length < 1)
                return false;

            var left = 0;
            var right = s.Length - 1;

            while (left < right)
            {
                if (s[left] != s[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}
public class Solution {
    public List<List<string>> Partition(string s) {
        var list = new List<List<string>>();
        var current = new List<string>();

        void Dfs(int index) {
            if (index >= s.Length) {
                list.Add(new List<string>(current));
            }

            for (int i = index; i < s.Length; i++) {
                string substring = s.Substring(index, i - index + 1);
                if (!IsPalindrom(substring))
                    continue;

                current.Add(substring);
                Dfs(i + 1);
                current.RemoveAt(current.Count - 1);
            }
        }

        Dfs(0);
        return list;

        bool IsPalindrom(string s) {
            var left = 0;
            var right = s.Length - 1;

            while (left < right) {
                if (s[left] != s[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}

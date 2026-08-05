public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        var bestPath = int.MaxValue;
        var current = new HashSet<string>();
        Dfs(beginWord, 1);
        return bestPath == int.MaxValue ? 0 : bestPath;

        void Dfs(string s, int start)
        {
            if (start >= bestPath)
                return;

            if (s == endWord)
            {
                bestPath = Math.Min(bestPath, start);
                return;
            }

            for (int index = 0; index < wordList.Count; index++)
            {
                var word = wordList[index];

                if (current.Contains(word) || CharacterDifference(word, s) != 1)
                    continue;

                current.Add(word);
                Dfs(word, start + 1);
                current.Remove(word);
            }
        }

        int CharacterDifference(string s1, string s2)
        {
            int difference = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                    difference++;
            }

            return difference;
        }
    }
}

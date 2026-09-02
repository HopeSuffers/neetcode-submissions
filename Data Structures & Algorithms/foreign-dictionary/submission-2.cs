public class Solution {
     public string foreignDictionary(string[] words)
    {
        var graph = new Dictionary<char, HashSet<char>>();

        foreach (var word in words)
            foreach (var c in word)
                graph[c] = new HashSet<char>();

        for (int i = 0; i < words.Length-1; i++)
        {
            var first = words[i];
            var second = words[i + 1];

            var minLength = Math.Min(first.Length, second.Length);

            if (first.Length > second.Length && first.StartsWith(second))
                return "";

            for (int j = 0; j < minLength; j++)
            {
                if (first[j] == second[j])
                    continue;

                graph[first[j]].Add(second[j]);
                break;
            }
        }

        var state = new Dictionary<char, int>();

        foreach (var graphKey in graph.Keys)
            state[graphKey] = 0;

        var result = new List<char>();

        foreach (var graphKey in graph.Keys)
        {
            if (state[graphKey] == 0 && !Dfs(graphKey))
                return "";
        }

        result.Reverse();
        return new string(result.ToArray());

        bool Dfs(char c)
        {
            if (state[c] == 1)
                return false;

            if (state[c] == 2)
                return true;

            state[c] = 1;

            foreach (var neighbor in graph[c])
            {
                if (!Dfs(neighbor))
                    return false;
            }

            state[c] = 2;
            result.Add(c);
            return true;
        }
    }
}

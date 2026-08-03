public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var dic = new Dictionary<int, List<int>>();

        for (int i = 0; i < numCourses; i++) dic[i] = new List<int>();

        foreach (var prerequisite in prerequisites) {
            var course = prerequisite[0];
            var requisite = prerequisite[1];

            dic[course].Add(requisite);
        }

        var visited = new HashSet<int>();

        for (int i = 0; i < numCourses; i++) {
            if (Dfs(i))
                return false;
        }

        return true;

        bool Dfs(int course) {
            if (visited.Contains(course))
                return true;

            if (dic[course].Count == 0)
                return false;

            visited.Add(course);

            foreach (var requisite in dic[course]) {
                if (Dfs(requisite))
                    return true;
            }

            visited.Remove(course);
            dic[course].Clear();

            return false;
        }
    }
}
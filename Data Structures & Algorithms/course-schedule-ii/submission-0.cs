public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var listReturn = new List<int>();
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
                return Array.Empty<int>();
        }

        return listReturn.ToArray();

        bool Dfs(int course) {
            if (visited.Contains(course))
                return true;

            visited.Add(course);

            foreach (var i in dic[course]) {
                if (Dfs(i))
                    return true;
            }

            if (!listReturn.Contains(course))
                listReturn.Add(course);

            visited.Remove(course);
            dic[course].Clear();

            return false;
        }
    }
}

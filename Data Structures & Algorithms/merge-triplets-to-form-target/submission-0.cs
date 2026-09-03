public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target)
    {
        bool first = false;
        bool second = false;
        bool third = false;
        
        foreach (var triplet in triplets)
        {
            int x = triplet[0];
            int y = triplet[1];
            int z = triplet[2];
            
            if (x > target[0] || y > target[1]|| z > target[2])
                continue;

            if (x == target[0])
                first = true;

            if (y == target[1])
                second = true;

            if (z == target[2])
                third = true;

            if (first && second && third)
                return true;
        }

        return false;
    }
}

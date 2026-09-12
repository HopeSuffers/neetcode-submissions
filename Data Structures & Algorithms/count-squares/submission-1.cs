public class CountSquares
{
    private List<int[]> _allPoints;
    private Dictionary<(int, int), int> _dic;

    public CountSquares()
    {
        _allPoints = new List<int[]> { };
        _dic = new Dictionary<(int, int), int>();
    }

    public void Add(int[] point)
    {
        _allPoints.Add(point);
        if (!_dic.ContainsKey((point[0], point[1])))
            _dic.Add((point[0], point[1]), 0);

        _dic[(point[0], point[1])]++;
    }

    public int Count(int[] point)
    {
        var counter = 0;

        foreach (var diagonal in _allPoints)
        {
            var diffX = diagonal[0] - point[0];
            var diffY = diagonal[1] - point[1];

            if (!IsValidDiagonal(diffX, diffY))
                continue;

            _dic.TryGetValue((point[0] + diffX, point[1]), out var corner1);
            _dic.TryGetValue((point[0], point[1] + diffY), out var corner2);

            counter += corner1 * corner2;
        }

        return counter;

        bool IsValidDiagonal(int diffX, int diffY)
        {
            return diffX != 0 && Math.Abs(diffX) == Math.Abs(diffY);
        }
    }
}
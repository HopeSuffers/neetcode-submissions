public class TimeMap
{
    private Dictionary<string, List<(string, int)>> dic;
    public TimeMap()
    {
        dic = new Dictionary<string, List<(string, int)>>();
    }
    
    public void Set(string key, string value, int timestamp)
    {
        if (!dic.ContainsKey(key))
            dic[key] = new List<(string value, int timestamp)>();
            
        dic[key].Add((value, timestamp));
    }
    
    public string Get(string key, int timestamp)
    {
        if (!dic.TryGetValue(key, out var list))
            return "";

        var left = 0;
        var right = list.Count - 1;

        string result = "";
        
        while (left <= right)
        {
            var middle = left + (right - left) / 2;
            if (list[middle].Item2 <= timestamp)
            {
                result = list[middle].Item1;

                left = middle + 1;
            }
            else right = middle - 1;
        }

        return result;
    }
}


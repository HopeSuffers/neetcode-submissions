public class Solution {
    public List<string> LetterCombinations(string digits)
    {
        var returnList = new List<string>();
        var current = "";

        if (string.IsNullOrEmpty(digits))
            return returnList;
        
        Dfs(0);
        return returnList;

        void Dfs(int index)
        {
            if (index >= digits.Length)
            {
                returnList.Add(current);
                return;
            }

            var letters = DigitsToLetter(digits[index].ToString());

            foreach (var letter in letters)
            {
                current += letter;
                Dfs(index + 1);
                current = current.Substring(0, current.Length - 1);
            }
        }

        string DigitsToLetter(string s)
        {
            switch (s)
            {
                case "2" : return "abc";
                case "3" : return "def";
                case "4" : return "ghi";
                case "5" : return "jkl";
                case "6" : return "mno";
                case "7" : return "pqrs";
                case "8" : return "tuv";
                case "9" : return "wxyz";
            }

            return null;
        }

    }
}

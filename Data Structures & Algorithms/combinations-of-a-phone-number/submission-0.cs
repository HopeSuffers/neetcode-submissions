public class Solution {
    public List<string> LetterCombinations(string digits)
    {
        var result = new List<string>();

        if (string.IsNullOrEmpty(digits))
            return result;

        var current = "";

        void Dfs(int index)
        {
            if (index == digits.Length)
            {
                result.Add(current);
                return;
            }

            string letters = DigitsToLetters(digits[index].ToString());

            foreach (var letter in letters)
            {
                current += letter;
                
                Dfs(index + 1);
                current = current.Substring(0, current.Length - 1);
            }
        }
        
        Dfs(0);
        return result;
    }

    string DigitsToLetters(string s)
    {
        foreach (var c in s)
        {
            switch (c)
            {
                case '2': return "abc";
                case '3': return "def";
                case '4': return "ghi";
                case '5': return "jkl";
                case '6': return "mno";
                case '7': return "pqrs";
                case '8': return "tuv";
                case '9': return "wxyz";
            }
        }

        return null;
    }
}

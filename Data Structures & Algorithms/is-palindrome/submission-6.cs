public class Solution {
    public bool IsPalindrome(string s)
    {
        var left = 0;
        var rigth = s.Length - 1;

        while (left < rigth)
        {
            while (left < rigth && !char.IsLetterOrDigit(s[left]))
                left++;
            
            while (left < rigth && !char.IsLetterOrDigit(s[rigth]))
                rigth--;

            if (char.ToLower(s[left]) != char.ToLower(s[rigth]))
                return false;

            left++;
            rigth--;
        }

        return true;
    }
}

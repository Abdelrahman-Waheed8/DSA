using System;


public class validPalindrome {

    public validPalindrome() {}
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length -1;

        while(left < right)
        {
            if(char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false; 
            }
            else
            {
                left++;
                right--;
            }

            if(!char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            else if(!char.IsLetterOrDigit(s[right]))
            {
                right++;
            }

        }
        return true;
    }
}
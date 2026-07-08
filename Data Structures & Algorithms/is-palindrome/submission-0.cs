public class Palindromee {
    public bool IsPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) return true;

        int left = 0;
        int right = s.Length - 1;

        while (left < right) {
            // Move the left pointer forward if the character is not alphanumeric
            if (!char.IsLetterOrDigit(s[left])) {
                left++;
            }
            // Move the right pointer backward if the character is not alphanumeric
            else if (!char.IsLetterOrDigit(s[right])) {
                right--;
            }
            // Both characters are alphanumeric; compare them case-insensitively
            else {
                if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right])) {
                    return false; // Mismatch found
                }
                left++;
                right--;
            }
        }

        return true; // All valid pairs matched
    }
}
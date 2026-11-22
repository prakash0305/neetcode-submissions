public class Solution {
    public bool IsPalindrome(string s) {
        string result = "";

    // Remove spaces and special characters
    foreach (char c in s)
    {
        if (char.IsLetterOrDigit(c))
        {
            result += char.ToLower(c);
        }
    }

    // Check palindrome
    int left = 0;
    int right = result.Length - 1;

    while (left < right)
    {
        if (result[left] != result[right])
        {
            return false;
        }

        left++;
        right--;
    }

    return true;
    }
}

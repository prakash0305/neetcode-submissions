public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
         int n = nums.Length;
    int[] result = new int[n];

    // Initially, every result is 1
    for (int i = 0; i < n; i++)
    {
        result[i] = 1;
    }

    // Multiply elements on the left
    int left = 1;

    for (int i = 0; i < n; i++)
    {
        result[i] = left;
        left = left * nums[i];
    }

    // Multiply elements on the right
    int right = 1;

    for (int i = n - 1; i >= 0; i--)
    {
        result[i] = result[i] * right;
        right = right * nums[i];
    }

    return result;
    }
}

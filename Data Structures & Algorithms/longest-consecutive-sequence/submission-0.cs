public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);

    int longest = 0;

    foreach (int num in set)
    {
        // Start counting only from the first number
        if (!set.Contains(num - 1))
        {
            int count = 1;
            int current = num;

            while (set.Contains(current + 1))
            {
                current++;
                count++;
            }

            if (count > longest)
            {
                longest = count;
            }
        }
    }

    return longest;
    }
}

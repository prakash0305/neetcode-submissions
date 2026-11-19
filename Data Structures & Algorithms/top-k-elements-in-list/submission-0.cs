public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

    // Count each number
    foreach (int num in nums)
    {
        if (dict.ContainsKey(num))
            dict[num]++;
        else
            dict[num] = 1;
    }

    int[] result = new int[k];

    // Find the number with highest frequency
    for (int i = 0; i < k; i++)
    {
        int max = 0;
        int number = 0;

        foreach (var item in dict)
        {
            if (item.Value > max)
            {
                max = item.Value;
                number = item.Key;
            }
        }

        result[i] = number;

        // Remove it so we don't select it again
        dict.Remove(number);
    }

    return result;
    }
}

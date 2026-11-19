public class Solution {

    public string Encode(IList<string> strs) {
        string result = "";

        foreach (string word in strs)
        {
            result += word.Length + "#" + word;
        }

        return result;
    }

    public List<string> Decode(string s) {
 List<string> result = new List<string>();

        int i = 0;

        while (i < s.Length)
        {
            string num = "";

            // Read the length
            while (s[i] != '#')
            {
                num += s[i];
                i++;
            }

            int length = int.Parse(num);

            i++; // Skip #

            // Read the actual word
            string word = s.Substring(i, length);

            result.Add(word);

            i += length;
        }

        return result;
   }
}

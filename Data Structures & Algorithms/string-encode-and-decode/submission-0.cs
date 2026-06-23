public class Solution {

    public string Encode(IList<string> strs) {
        string Encoded = ""; int count;
        foreach(string s in strs)
        {
            count = s.Length;
            Encoded += string.Join("#", count.ToString(), s);
        }
        return Encoded;
    }

    public List<string> Decode(string s) {
        int digit;
        var decodedStrings = new List<string>();
        int i = 0;
        while(i <s.Length)
        {
            int length = 0;
            while(s[i] != '#')
            {
                digit = s[i] - '0';
                length = (length *10) + digit;
                i++;
            }

            i++;

            string decoded = "";
            for(int j = 0; j < length; j++)
            {
                decoded += s[i];
                i++;
            }
            decodedStrings.Add(decoded);
        }
        return decodedStrings;
   }
}

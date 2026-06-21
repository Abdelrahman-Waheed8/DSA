public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {return false;}
        Dictionary<char, int> firstString = new();
        Dictionary<char, int> secondString = new();

        for(int i = 0 ; i < s.Length; i++)
        {
            if(firstString.ContainsKey(s[i]))
            {
                firstString[s[i]]++;
            }
            else
            {
                firstString[s[i]] = 1;
            }

            if(secondString.ContainsKey(t[i]))
            {
                secondString[t[i]]++;
            }
            else
            {
                secondString[t[i]] = 1;
            }
        }

        foreach(var kvp in firstString)
        {
            if(!secondString.TryGetValue(kvp.Key, out int count) || kvp.Value != count)
            {return false;}
        }
        return true;
    }
}

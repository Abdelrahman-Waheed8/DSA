using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Anagram
{
    public Anagram() { }

    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> firstString = new();
        Dictionary<char, int> secondString = new();

        for(int i = 0; i < s.Length; i++)
        {
            if (firstString.ContainsKey(s[i]))
            {
                firstString[s[i]]++;
            }
            else
            {
                firstString.Add(s[i], 1);
            }

            if (secondString.ContainsKey(t[i]))
            {
                secondString[t[i]]++;
            }
            else
            {
                secondString.Add(t[i], 1);
            }
        }

        foreach(var pair in firstString)
        {
            if(!secondString.TryGetValue(pair.Key, out int count) || pair.Value != count)
            {
                return false;
            }
        }
        return true;


    }

}

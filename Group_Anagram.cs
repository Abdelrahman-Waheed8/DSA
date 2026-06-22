using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

public class GroupAnagram
{
    public GroupAnagram()
    {
        
    }

    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> hashmap = new();
        char[] sorted ;
        List<List<string>> result = [];
        List<string> sortedstrings = [];

        for(int i = 0 ; i< strs.Length; i++)
        {
            sorted = strs[i].ToCharArray();
            Array.Sort(sorted);
            sortedstrings.Add(new string(sorted));
            if(!hashmap.ContainsKey(sortedstrings[i]))
            {
                hashmap.Add(sortedstrings[i], new List<string> {strs[i]}) ;
            }
            else
            {
                hashmap[sortedstrings[i]].Add(strs[i]);
            }
        }

        foreach(var pair in hashmap)
        {
            result.Add(pair.Value);
        }
        return result;
    }
}
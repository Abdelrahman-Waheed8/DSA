using System;
using System.Collections.Generic;

public class DSA
{
    public static void Main(string[] args)
    {
        // CONTAINS DUPLICATE 
        //int[] nums = { 1, 2, 3, 3 };
        //ContainsDuplicate containsDuplicate = new ContainsDuplicate();
        //Console.WriteLine(containsDuplicate.Run(nums));

        // ANAGRAM
        // Anagram anagram = new Anagram();
        // string a = "jar";
        // string b = "jam";
        // Console.WriteLine(anagram.IsAnagram(a, b));

        // GROUP ANAGRAM
        GroupAnagram groupAnagram = new GroupAnagram();
        string[] strs = ["act","pots","tops","cat","stop","hat"];
        List<List<string>> list = groupAnagram.GroupAnagrams(strs);
        foreach (List<string> group in list)
        {
        // Join the words in this group with a space (or a comma) and print
        Console.WriteLine(string.Join(" ", group));
        }
    }
}
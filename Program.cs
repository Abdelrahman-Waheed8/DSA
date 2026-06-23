using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        // GroupAnagram groupAnagram = new GroupAnagram();
        // string[] strs = ["act","pots","tops","cat","stop","hat"];
        // List<List<string>> list = groupAnagram.GroupAnagrams(strs);
        // foreach (List<string> group in list)
        // {
        // // Join the words in this group with a space (or a comma) and print
        // Console.WriteLine(string.Join(" ", group));
        // }

        // TOP K ELEMENTS 
        // topKelements top = new topKelements();
        // int[] nums = [1,2,2,3,3,3];
        // int k = 2;
        // int[] arr = top.TopKFrequent(nums, k);
        // for(int i = 0 ; i <arr.Length; i++)
        // {
        //     Console.Write(arr[i] + " "); 
        // }

        // ENCODE AND DECODE STRINGS
        EncodeAndDecode Func = new EncodeAndDecode();
        List<string> strings = ["str", "hello"];
        Console.WriteLine("Encoded strings: " + Func.Encode(strings));
        List<string> decoded = Func.Decode(Func.Encode(strings));
        foreach(string s in decoded)
        {
            Console.Write(s + " ");
        }
    }
}
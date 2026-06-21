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

        Anagram anagram = new Anagram();
        string a = "jar";
        string b = "jam";
        Console.WriteLine(anagram.IsAnagram(a, b));

    }
}
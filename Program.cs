using System;
using System.Collections.Generic;

public class DSA
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 3 };
        ContainsDuplicate containsDuplicate = new ContainsDuplicate();
        Console.WriteLine(containsDuplicate.Run(nums));
    }
}
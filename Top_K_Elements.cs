using System;
using System.Collections.Generic;

public class topKelements
{
    public topKelements() {}

    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> hashmap = new();
        int[] targeted = new int[k];
        int counter = 0;
        List<int>[] buckets = new List<int>[nums.Length + 1];

        for(int i = 0 ; i< nums.Length; i++)
        {
            if(hashmap.ContainsKey(nums[i]))
            {
                hashmap[nums[i]]++;
            }
            else hashmap.Add(nums[i], 1);                     // [1,2,2,3,3,3] 2 
        }

        for (int i = 0; i < buckets.Length; i++)
        {
            buckets[i] = new List<int>();
        }

        foreach(var kvp in hashmap)
        {
            int number = kvp.Key;
            int frequency = kvp.Value;

            buckets[frequency].Add(number);
        }

        for(int i = buckets.Length - 1; i >= 0 ; i--)
        {
            foreach(int number in buckets[i])
            {
                targeted[counter] = number;
                counter++;

                if (counter == k)
                {
                    return targeted;
                }
            }
        }

        return targeted;
    }
}
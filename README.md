# DSA
Focusing on Solving leetcode problems using the NeetCode.io Roadmap and providing explaination of my approachs and what did i learn

# 1.Contains Duplicate
## Intuition
At first, I thought of a Brute force approach but basically it wouldn't be ideal since we will iterate into the array using a for loop and another for loop to check if there's duplicates which will result in a solution with Time Complexity of O(n^2) 

## Approach
I figured out using a Dictionary or Hash map would be much better since they search for a value by specific key and that key is unique, so at first we need to iterate through the given array using a for loop and using a pre-declared Dictionary we store the values in the array as a key in the dictionary (taking advantage of the key being unique) and store the index in the value which we can use to determine where did the duplication happen. Checks if the dictionary has a key with the array value of it if yes return true and if not we add that value to the dictionary as a key and then return false as an exit of the function

## Analysis
- Time complexity:
We used a single for loop
```
for (int i = 0; i < nums.Length; i++)
```
So the time complexity it O(n)

- Space complexity:
O(n)

}
```

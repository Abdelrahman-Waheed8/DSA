# DSA
Focusing on Solving leetcode problems using the NeetCode.io Roadmap and providing explaination of my approachs and what did i learn

# 1.Contains Duplicate
## Intuition
<!-- Describe your first thoughts on how to solve this problem. -->


# Approach
<!-- Describe your approach to solving the problem. -->

# Complexity
- Time complexity:
<!-- Add your time complexity here, e.g. $$O(n)$$ -->

- Space complexity:
<!-- Add your space complexity here, e.g. $$O(n)$$ -->

# Code
```csharp []
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, int> seen = new();
        for (int i = 0; i < nums.Length; i++) {
            if (seen.ContainsKey(nums[i]))
            {
                return true;
            }

            seen.Add(nums[i], i);
        }
        return false;
    }
}
```

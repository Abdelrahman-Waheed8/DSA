public class Solution {
public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = new();
        int i , j , k ;

        Array.Sort(nums);
        for(i = 0 ; i < nums.Length ; i++)
        {
            j = i+1; k = nums.Length -1;
            if(i > 0 && nums[i] == nums[i - 1]) continue;
            while (j < k)
            {
                if(nums[i] + nums[j] + nums[k] > 0) k--;
                else if(nums[i] + nums[j] + nums[k] < 0) j++;
                else
                {
                    List<int> ints = new();
                    ints.Add(nums[i]);
                    ints.Add(nums[j]);
                    ints.Add(nums[k]);

                    result.Add(ints);
                    j++; k--;
                    while(j < k && nums[j] == nums[j-1]) j++;
                    while(j < k && nums[k] == nums[k+1]) k--;
                }
            }
        }
        return result;
    }
}

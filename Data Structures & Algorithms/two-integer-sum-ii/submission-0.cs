public class Solution {
    public int[] TwoSum(int[] numbers, int target) {

        int left = 0;
        int right = numbers.Length - 1;
        for (int i = 0 ; i < numbers.Length ;i++)
        {
            if(numbers[left] + numbers[right] > target)
            {
                right--;
            }
            else if(numbers[left] + numbers[right] < target)
            {
                left++;
            }
            else
            return [left+1,right+1];
        }
        return [];
    }
}
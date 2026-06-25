public class product1 {
    public int[] ProductExceptSelf(int[] nums) {
        int[] product = new int[nums.Length];
        for(int i = 0 ; i< nums.Length; i++)
        {
            int result = 1;
            for(int j = 0 ; j < nums.Length; j++)
            {
                if(j != i)
                {
                    result *= nums[j];
                }
                else continue;
            }
            product[i] = result;
        }
        return product;
    }
}
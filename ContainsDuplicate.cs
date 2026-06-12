using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ContainsDuplicate
{
    public ContainsDuplicate() { }

    public bool Run(int[] nums)
    {
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
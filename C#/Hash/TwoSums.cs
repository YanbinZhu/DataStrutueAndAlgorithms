/*Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution.

Example:
Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1].
UPDATE (2016/2/13):
The return format had been changed to zero-based indices. Please read the above updated description carefully.*/


public class Solution {
    
    public int[] TwoSum(int[] nums, int target) {
        
        //check null
        
        if(nums==null||nums.Length==0)
        {
            throw new Exception("input error");
        }
        
        //using hash to store the array
        
        var hash=new Dictionary<int, int>();
        
        for(int i=0; i<nums.Length; i++)
        {
            if(hash.ContainsKey(target-nums[i]))
            {
                return new int[2]{hash[target-nums[i]],i};
            }
            
            if(!hash.ContainsKey(nums[i]))
            {
                hash.Add(nums[i],i);
            }
        }
        
        throw new Exception("not found");
        
    }
}
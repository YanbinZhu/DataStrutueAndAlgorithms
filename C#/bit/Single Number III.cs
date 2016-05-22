/*Single Number III
    
    Given an array of numbers nums, in which exactly two elements appear only once and all the other elements appear exactly twice. Find the two elements that appear only once.

For example:

Given nums = [1, 2, 1, 3, 2, 5], return [3, 5].

Note:
The order of the result is not important. So in the above example, [5, 3] is also correct.
Your algorithm should run in linear runtime complexity. Could you implement it using only constant space complexity?*/

// Pass 1 : 
        // Get the XOR of the two numbers we need to find
        int diff = 0;
        for (int i=0; i<nums.Length; i++ ) {
            diff ^= nums[i];
        }
        
        // Get its last set bit
        diff &= -diff;

        // Pass 2 :
        int[] rets = {0, 0}; // this array stores the two numbers we will return
        
        for (int i=0; i < nums.Length; i++)
        {
            if ((nums[i] & diff) == 0) // the bit is not set
            {
                rets[0] ^= nums[i];
            }
            else // the bit is set
            {
                rets[1] ^= nums[i];
            }
        }
        return rets;
    
        
        //hash
        
        var dic=new Dictionary<int,int>();
        
        for(int i=0;i<nums.Length;i++)
        {
            if(dic.ContainsKey(nums[i]))
            {
                dic.Remove(nums[i]);
            }
            else
            {
                dic.Add(nums[i],i);
            }
        }
        
        return dic.Keys.ToArray();
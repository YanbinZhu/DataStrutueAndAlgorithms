/*268. Missing Number
Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.

For example,
Given nums = [0, 1, 3] return 2.

Note:
Your algorithm should run in linear runtime complexity. Could you implement it using only constant extra space complexity?*/

public class Solution {
    public int MissingNumber(int[] nums) {
        
        int xor = 0, i = 0;
    for (i = 0; i < nums.Length; i++) {
        xor = xor ^ i ^ nums[i];
    }

    return xor ^ i;
        
    var numLength=nums.Length;
    
    if(numLength==0)
    {
        throw new Exception();
    }
    
    var min=nums[0];
    var max=nums[0];
    var sum=nums[0];
    
    for(i=1; i<numLength; i++)
    {
        if(nums[i] < min)
        {
            min=nums[i];
        }
        else if(nums[i] > max)
        {
            max = nums[i];
        }
        
        sum += nums[i];
    }
    
    if(max != numLength)
    {
       return numLength;
    }
    
    if(min!=0)
    {
        return 0;
    }
    
    return (int)(((double)numLength/2)*(numLength+1) - sum);
    
    }
}
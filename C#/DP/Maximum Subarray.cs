/*Maximum Subarray
    
    Find the contiguous subarray within an array (containing at least one number) which has the largest sum.

For example, given the array [−2,1,−3,4,−1,2,1,−5,4],
the contiguous subarray [4,−1,2,1] has the largest sum = 6.*/


public class Solution {
    public int MaxSubArray(int[] nums) {
        
        //brutal force Time Limit Exceeded 
        
        /*if(nums.Length==0)
            return 0;
        if(nums.Length==1)
            return 1;
        //brutal force
        int maxLength=nums[0];
        int tempLength;
        for(int i=0; i<nums.Length; i++)
        {
            tempLength = nums[i];
            for(int j=i + 1; j<nums.Length; j++)
            {
                 tempLength += nums[j];
                 if(tempLength>maxLength)
                 {
                     maxLength=tempLength;
                 }
            }
        }
        
        return maxLength;*/
        
        //recrutively
        
        if(nums.Length==0)
        {
            return 0;
        }
        
        return MaxSubArray(nums, 0, nums.Length-1);
        
        //dianamicly 
        
        //dynamically with few space
        
         int n = nums.Length;
        int[] dp = new int[n];//dp[i] means the maximum subarray ending with A[i];
        dp[0] = nums[0];
        int max = dp[0];

        for(int i = 1; i < n; i++){
            dp[i] = nums[i] + (dp[i - 1] > 0 ? dp[i - 1] : 0);
            max = Math.Max(max, dp[i]);
        }

        return max;
        
        //dianamicly with few space
        
    }
    
    
     public int MaxSubArray(int[] nums,int left, int right) {
        
        if(left >= right)
        {
            return nums[left];
        }
        
        int middle = left + (right - left)/2;
        
        //get largest with middle
        int temp = nums[middle];
        int middleMax = nums[middle];
        for(int i=middle-1; i>=left; i--)
        {
            temp+=nums[i];
            middleMax=Math.Max(temp,middleMax);
        }
		temp = middleMax;
        for(int j=middle+1;j<=right;j++)
        {
            temp += nums[j];
            middleMax=Math.Max(temp,middleMax);
        }	

        
        int leftMax=MaxSubArray(nums,left, middle-1);
        int rightMax=MaxSubArray(nums,middle+1, right);
   
        return Math.Max(Math.Max(leftMax,middleMax),rightMax);
    }
 }
 
 
 
 
 
 
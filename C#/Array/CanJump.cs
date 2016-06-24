/*
Jump Game
    
    Given an array of non-negative integers, you are initially positioned at the first index of the array.

Each element in the array represents your maximum jump length at that position.

Determine if you are able to reach the last index.

For example:
A = [2,3,1,1,4], return true.

A = [3,2,1,0,4], return false.*/




   //the main idea is capture all the 0s in the array, then check all the items before, to make sure it cannot cross 0




    public class Solution {
        
        public bool CanJump(int[] nums) {
          
          //check null
          if(nums==null || nums.Length==1)
              return true;
          
          if(nums[0] == 0)
              return false;
          
          
          //find the first 0 in nums
          var zeroIndexs=getZeroIndex(nums);
          
          if(zeroIndexs.Count==0)
                return true;
                
            var ignore = true;
                
            for(int i = 0; i < zeroIndexs.Count - 1; i++)
            {
                for(int j = zeroIndexs[i] - 1; j >= 0; j--)
                {
                    ignore = false;
                    
                    if(nums[j] > zeroIndexs[i] - j)
                    {
                        ignore = true;
                        break;
                    }
                }
                
                if(!ignore)
                    return false;
            }
            
            var zeroIndex = zeroIndexs[zeroIndexs.Count - 1];
            
            for(int i = zeroIndex - 1; i >= 0; i--)
            {
                if(nums[i] > zeroIndex - i || ((zeroIndex == nums.Length - 1) && (nums[i] == zeroIndex - i)))
                        return true;
            }
          
            return false;
        }
        
        public List<int> getZeroIndex(int[] nums)
        {
            var result=new List<int>();
            for(int i=0; i<nums.Length; i++)
            {
                if(nums[i]==0)
                    result.Add(i);
            }
              
            return result;
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
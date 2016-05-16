/*Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You may assume no duplicates in the array.

Here are few examples.
[1,3,5,6], 5 → 2
[1,3,5,6], 2 → 1
[1,3,5,6], 7 → 4
[1,3,5,6], 0 → 0*/

public class Solution {
    
    public int SearchInsert(int[] nums, int target) {
        
        if(nums.Length==0)
        {
            return 0;
        }
        
        int low = 0;
        int high = nums.Length - 1;
        int middle;
        
        while(low < high)
        {
            middle=(low+high)/2;
            if(nums[middle]==target)
            {
                return middle;
            }
            else if(nums[middle]>target)
            {
                high=middle-1;
            }
            else
            {
                low = middle + 1;
            }
        }
        
        if(nums[low] < target)
        {
            return low + 1;
        }
        else
        {
            return low;
        }
        
    }
    
    //Recursively:
    
    public int SearchInsertRecurrence(int[] nums, int low, int high ,int target)
    {
            if(low >= high)
            {
                if(nums[low] < target)
                {
                    return low + 1;
                }
                else
                {
                    return low;
                }
            }
        
            int middle=(low+high)/2;
		 
            if(nums[middle]==target)
            {
                return middle;
            }
            else if(nums[middle] > target)
            {
                return SearchInsertRecurrence(nums, low, middle-1,target);
            }
            else
            {
                return SearchInsertRecurrence(nums, middle + 1, high,target);
            }        
            
    }
}
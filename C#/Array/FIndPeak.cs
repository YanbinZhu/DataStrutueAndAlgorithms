/*Find Peak Element

A peak element is an element that is greater than its neighbors.

Given an input array where num[i] ≠ num[i+1], find a peak element and return its index.

The array may contain multiple peaks, in that case return the index to any one of the peaks is fine.

You may imagine that num[-1] = num[n] = -∞.

For example, in array [1, 2, 3, 1], 3 is a peak element and your function should return the index number 2.*/


public class Solution {
    public int FindPeakElement(int[] nums) {

    return FindPeakElement(nums,0,nums.Length-1);
  }

public int FindPeakElement(int[] nums,int low, int high) {

   if(nums.Length == 1)
    {
        return 0;
    }

    while (low <= high)
    {
        int middle = (low + high)/2;

        if(middle == 0)
        {
           if(nums[middle]>nums[1])
           {
            return middle;
           }
            else
            {
                low = middle+1; continue;
            }
        }

         if(middle == nums.Length-1)
        {
           if(nums[low] > nums[low-1])
           {
            return middle;
           }
            else
            {
                high = middle-1; continue;
            }
        }


        if(nums[middle] > nums[middle-1] && nums[middle] > nums[middle+1])
            return middle;

        if(nums[middle] > nums[middle-1] && nums[middle]<nums[middle+1])
        { low = middle+1; continue;}

        if(nums[middle] < nums[middle-1] && nums[middle] > nums[middle+1])
        { high = middle-1; continue;}

        if(nums[middle] < nums[middle-1] && nums[middle] < nums[middle+1])
        {
            if(FindPeakElement(nums, low, middle-1) == -1)
                return FindPeakElement(nums, middle+1, high);

            return FindPeakElement(nums, low, middle-1);
        }
    }



    return -1;
  }
 }

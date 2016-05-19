/*Find Minimum in Rotated Sorted Array

Suppose a sorted array is rotated at some pivot unknown to you beforehand.

(i.e., 0 1 2 4 5 6 7 might become 4 5 6 7 0 1 2).

Find the minimum element.

You may assume no duplicate exists in the array.*/

public class Solution {
public int FindMin(int[] nums) {


    int length=nums.Length;

    if(length==0)
    {
        return -1;
    }

     if(length==1)
     {
        return nums[0];
     }

    int low=0;
    int high=nums.Length-1;

    if(nums[low] < nums[high])
     {
        return nums[low];
     }

    int middle = 0;      

    while(low < high)
    {
        middle = (low + high) / 2;

        if(middle == 0)
        {
            return nums[middle+1];
        }
        if(middle == nums.Length-1)
        {
            return nums[middle];
        }

         if(nums[middle] < nums[middle-1] && nums[middle]<nums[middle+1])
         {
             return nums[middle];
         }

         if(nums[middle] > nums[middle-1] && nums[middle]>nums[middle+1])
         {
             return nums[middle + 1];
         }

         if(nums[middle] > nums[low])
         {
             low = middle + 1;
             continue;
         }

         if(nums[middle] < nums[high])
         {
             high = middle - 1;
             continue;
         }
    }

    return -1;


}
}
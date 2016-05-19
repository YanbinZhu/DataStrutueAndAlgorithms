/*Kth Largest Element in an Array
    
Find the kth largest element in an unsorted array. Note that it is the kth largest element in the sorted order, not the kth distinct element.

For example,
Given [3,2,1,5,6,4] and k = 2, return 5.

Note: 
You may assume k is always valid, 1 ≤ k ≤ array's length.*/


public class Solution {
  public int FindKthLargest(int[] nums, int k) {

    if(k > nums.Length)
    {
        return -1;
    }

    //quick sort

    quickSort(nums, 0, nums.Length-1);

    //get the kth largest

    return nums[k-1];
}  


public void quickSort(int[] nums, int start, int end)
{
    if(start >= end)
    {
        return;
    }

    var povit = nums[end];

    int i=start, j=start;
    int temp=0;

    for(; j<end; j++)
    {
        if(nums[j] > povit)
        {
            temp=nums[i];
            nums[i] = nums[j];
            nums[j]=temp;
            i += 1;
        }
    }

    nums[end] = nums[i];
    nums[i] = povit;

    quickSort(nums, start, i-1);
    quickSort(nums, i+1, end);
  }
 }


//quick sort improvement with k

public int quickSortK(int[] nums, int start, int end,int k)
 {
    var povit = nums[end];

    if(start >= end)
    {
        return povit;
    }

    int i=start, j=start;
    int temp=0;

    for(; j<end; j++)
    {
        if(nums[j] > povit)
        {
            temp=nums[i];
            nums[i] = nums[j];
            nums[j]=temp;
            i += 1;
        }
    }

    nums[end] = nums[i];
    nums[i] = povit;

    if(i == k-1)
    {
        return povit;
    }
    else if(i > k-1)
    {
       return quickSortK(nums, start, i-1,k);
    }
    else
    {
       return quickSortK(nums, i + 1, end,k);
     }
 }
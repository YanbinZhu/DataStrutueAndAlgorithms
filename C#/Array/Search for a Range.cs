/*34. Search for a Range My Submissions QuestionEditorial Solution
Given a sorted array of integers, find the starting and ending position of a given target value.

Your algorithm's runtime complexity must be in the order of O(log n).

If the target is not found in the array, return [-1, -1].

For example,
Given [5, 7, 7, 8, 8, 10] and target value 8,
return [3, 4].*/

//brain unit testing wiht [1],0 [1],1; [1,1],0; [1,1],1

public class Solution { public int[] SearchRange(int[] nums, int target) { if(nums==null) return new int[2]{-1,-1};

    int low=0;
    int high = nums.Length-1;

    while(low <= high)
    {
        int mid=(low + high)/2;

        if(nums[mid]==target)
        {
            return getScope(nums,target,mid);
        }
        else if(nums[mid] < target)
        {
            while((mid + 1 < nums.Length - 1) && nums[mid+1] == nums[mid])
            {
                mid += 1;
            }

            low = mid + 1;
        }
        else
        {
            while((mid-1 > 0) && nums[mid-1]==nums[mid])
            {
                mid -= 1;
            }

            high = mid-1;
        }
    }


    return new int[2]{-1,-1};
}


//get left, right bound
public int[] getScope(int[] nums, int target, int mid)
{
        int left = mid;

        //find left bound
        while(left > 0 && nums[left-1]==target)
        {
            left -= 1;
        }

        int right=mid;
        //find right bound
        while(right<nums.Length-1 && nums[right + 1]==target)
        {
            right += 1;
        }

        return new int[2]{left,right};
}
}
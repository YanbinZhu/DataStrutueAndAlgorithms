//insert sort

public class Solution {
   public static int[] InsertSort(int[] nums) {

        var numsLength=nums.Length;

        for(int i=1; i<numsLength; i++)
        {
            var key = nums[i];

            int j = i-1;


            while(j >= 0 && nums[j] > key)
            {
                nums[j+1] = nums[j];
                j-=1;
			}

			nums[j+1]=key;

        }

        return nums;

    }
}

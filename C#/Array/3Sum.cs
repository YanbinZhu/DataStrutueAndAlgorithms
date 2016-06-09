
/*3Sum
Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

Note: The solution set must not contain duplicate triplets.

For example, given array S = [-1, 0, 1, 2, -1, -4],

A solution set is:
[
  [-1, 0, 1],
  [-1, -1, 2]
]*/


public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
         //sort array
    Array.Sort(nums);

    //need to be unique

    var resultInHash = new Dictionary<int,Dictionary<int,int>>();

    int low=0, high = nums.Length - 1;

    for(int i=0; i<nums.Length && nums[i]<=0; i++)
    {

        low=i+1; high=nums.Length - 1;

        while(low < high)
        {
            if(nums[low]+nums[high]+nums[i]==0)
            {
                if(resultInHash.ContainsKey(nums[i]))
                {
                    if(!resultInHash[nums[i]].ContainsKey(nums[low]))
                        resultInHash[nums[i]].Add(nums[low],nums[high]);
                }
                else
                {
                    var son=new Dictionary<int,int>();
                    son.Add(nums[low],nums[high]);
                    resultInHash.Add(nums[i],son);
                }
                low+=1;
                high-=1;
            }
            else if(nums[low]+nums[high]+nums[i]<0)
            {
                low+=1;
            }
            else
            {
                high-=1;
            }
        }
    }

    var result=new List<IList<int>>();

    foreach(var item in resultInHash)
    {
        foreach(var subItem in item.Value)
        {
            var sublist=new List<int>();
              sublist.Add(item.Key);
              sublist.Add(subItem.Key);
              sublist.Add(subItem.Value);
              result.Add(sublist);
        }
    }

    return result;
    }
}

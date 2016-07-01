/*78. Subsets
    
    
    Given a set of distinct integers, nums, return all possible subsets.

Note: The solution set must not contain duplicate subsets.

For example,
If nums = [1,2,3], a solution is:

[
  [3],
  [1],
  [2],
  [1,2,3],
  [1,3],
  [2,3],
  [1,2],
  []
]*/


   
    //    DP [i]  = DP [i-1] + each items in  DP [i-1] + nums[i]


    public class Solution {
        public IList<IList<int>> Subsets(int[] nums) {
            
            if(nums.Length==0)
                return new List<IList<int>>();
            
            //sort array
            Array.Sort(nums);
            
           // DP
            var DP = new List<IList<int>>[nums.Length];
            
            DP[0] = new List<IList<int>>(){new List<int>(),new List<int>(){nums[0]}};
            
            for(int i = 1; i<nums.Length; i++)
            {
                DP[i] = new List<IList<int>>();
                
                foreach(var list in DP[i-1])
                {
                    DP[i].Add(list);
                    
                    var newList = new List<int>();
                    
                    foreach(var item in list)
                    {
                        newList.Add(item);
                    }
                    
                    newList.Add(nums[i]);
                    
                    DP[i].Add(newList);
                }
            }
            
            return DP[nums.Length - 1];
        }

    //Recursive

     public IList<IList<int>> Subsets(int[] nums, int index) {
         
             if(index==0)
                return new List<IList<int>>(){new List<int>(),new List<int>(){nums[0]}};
            
            var indexPre=Subsets(nums, index-1);
            
            var result = new List<IList<int>>();
                
                foreach(var list in indexPre)
                {
                    result.Add(list);
                    
                    var newList = new List<int>();
                    
                    foreach(var item in list)
                    {
                        newList.Add(item);
                    }
                    
                    newList.Add(nums[index]);
                    
                    result.Add(newList);
                }
                
                return result;
             
         }
    }

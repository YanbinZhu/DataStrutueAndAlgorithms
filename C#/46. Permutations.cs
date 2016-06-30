/*46. Permutations
    Given a collection of distinct numbers, return all possible permutations.

For example,
[1,2,3] have the following permutations:
[
  [1,2,3],
  [1,3,2],
  [2,1,3],
  [2,3,1],
  [3,1,2],
  [3,2,1]
]*/

    public class Solution {
        public IList<IList<int>> Permute(int[] nums) {            
            return Permute(nums,nums.Length-1);
        }
        
        public IList<IList<int>> Permute(int[] nums, int index) {
            
            if(index==0)
                return new List<IList<int>>(){new List<int>(){nums[0]}};
            
            var result=new List<IList<int>>();
            
            var pre = Permute(nums, index - 1);
            
            foreach(var item in pre)
            {
                for(int i = 0 ; i < index; i++)
                {
                    var newList=new List<int>();
                    
                    foreach(var number in item)
                    {
                        newList.Add(number);
                    }
                    
                    newList.Insert(i,nums[index]);
                    result.Add(newList);
                }
                
                item.Add(nums[index]);
                
                result.Add(item);
            }
            
            return result;            
        }
    }
    
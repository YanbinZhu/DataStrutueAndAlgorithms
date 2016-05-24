/*Top K Frequent Elements
    
    Given a non-empty array of integers, return the k most frequent elements.

For example,
Given [1,1,1,2,2,3] and k = 2, return [1,2].

Note: 
You may assume k is always valid, 1 ≤ k ≤ number of unique elements.
Your algorithm's time complexity must be better than O(n log n), where n is the array's size.*/

public class Solution {
    public IList<int> TopKFrequent(int[] nums, int k) {
        
        //bucket sort 
        
        var frenquecyDict=new Dictionary<int,int>();
        
        int maxFrenquecy = 0;
        
        for(int i=0;i<nums.Length;i++)
        {
            if(frenquecyDict.ContainsKey(nums[i]))
            {
                frenquecyDict[nums[i]]+=1;
            }
            else
            {
                frenquecyDict.Add(nums[i],1);
            }
            
            if(frenquecyDict[nums[i]]>maxFrenquecy)
            {
                maxFrenquecy = frenquecyDict[nums[i]];
            }
        }
        
        var bucket = new List<int>[maxFrenquecy + 1];
        
        foreach(var item in frenquecyDict)
        {
            if (bucket[item.Value] == null) {
            bucket[item.Value] = new List<int>();
            }
            bucket[item.Value].Add(item.Key);
        }
        
        var result = new List<int>();
        
        for(int i=maxFrenquecy; i>0 && result.Count<k; i--)
        {
            if(bucket[i]!=null)
            {
                result.AddRange(bucket[i]);
            }
        }
        
        return result;
        
        
        
    }
}
/*
Largest Number
    
Given a list of non negative integers, arrange them such that they form the largest number.

For example, given [3, 30, 34, 5, 9], the largest formed number is 9534330.

Note: The result may be very large, so you need to return a string instead of an integer.*/

public class Solution {
    public string LargestNumber(int[] nums) {
        
        var resultBuilder = new StringBuilder();
        
        var maxLength= Math.Floor(Math.Log10(nums[0])) + 1;
        
        for(int i=1; i < nums.Length; i++)
        {
            if((Math.Floor(Math.Log10(nums[i])) + 1) > maxLength)
            {
                maxLength=Math.Floor(Math.Log10(nums[i])) + 1;
            }
        }
		
        
        var longDict=new Dictionary<long, List<int>>();
        
        for(int i=0; i < nums.Length; i++)
        {
            if(nums[i]!=0)
			{
				
				long newcur=(long)nums[i];			
            
				var currentLength = Math.Floor(Math.Log10(nums[i])) + 1;            			
			
            if(currentLength < maxLength)
            {
                int last = Math.Max(int.Parse(nums[i].ToString()[0].ToString()),nums[i]%10);
                var addTo=0;
                
                for(var j = 0; j < maxLength - currentLength; j++)
                {
                    newcur *=10;
                    addTo = addTo*10 + last;                    
                }
				
				newcur += addTo;
            }
            
			if(longDict.ContainsKey(newcur))
			{
				longDict[newcur].Add(nums[i]);
			}
			else
			{			
				longDict.Add(newcur, new List<int>(){nums[i]});
			}
			}
			else
			{
    			if(longDict.ContainsKey(0))
    			{
    				longDict[0].Add(nums[i]);
    			}
    			else
    			{			
    				longDict.Add(0, new List<int>(){0});
    			}
			}
        }
        
        if(longDict.ContainsKey(0) && longDict.Keys.Count==1)
        {
            return "0";
        }
        
        foreach (var item in longDict.OrderByDescending(i => i.Key))
	    {
			foreach(var real in item.Value)
			{
	        	resultBuilder.Append(real.ToString());
			}
	    }
	    
	    return resultBuilder.ToString();
        
    }
}
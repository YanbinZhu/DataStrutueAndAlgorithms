/*49. Group Anagrams
    Given an array of strings, group anagrams together.

For example, given: ["eat", "tea", "tan", "ate", "nat", "bat"], 
Return:

[
  ["ate", "eat","tea"],
  ["nat","tan"],
  ["bat"]
]
Note: All inputs will be in lower-case.*/


    public class Solution {
        public IList<IList<string>> GroupAnagrams(string[] strs) {
            
            if (strs == null || strs.Length == 0) return new List<IList<string>>();
            
            var tempDictionary = new Dictionary<string,IList<string>>();
            
            for(int i=0; i < strs.Length; i++)
            {
                var targetArray = strs[i].ToCharArray();
                Array.Sort(targetArray);
                var stringTarget=new string(targetArray);
                
                if(tempDictionary.ContainsKey(stringTarget))
                {
                    tempDictionary[stringTarget].Add(strs[i]);
                    continue;
                }
                
                tempDictionary.Add(stringTarget,new List<string>(){strs[i]});
            }
            
            //return tempDictionary.Values;
                   
            var result=new List<IList<string>>();
             
            foreach(var stringList in tempDictionary.Values)
            {
                result.Add(stringList);
            }
            
            return result;
            
        }
        
    }
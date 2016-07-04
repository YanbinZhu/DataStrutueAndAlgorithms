/*93. Restore IP Addresses
Given a string containing only digits, restore it by returning all possible valid IP address combinations.

For example:
Given "25525511135",

return ["255.255.11.135", "255.255.111.35"]. (Order does not matter)*/

    
    // ask these question:
    // this string will always be valid IP string, ask questions about if the string length is less than 0
    // IP contains for parts, each of thest part will have a int value between 0 and 255
    // any part have more the two chars, but start with '0' is invalid
    // unit test case like "000000100", "0000","100000","25525511135"
    
    
    public class Solution {
        public IList<string> RestoreIpAddresses(string s) {
            
            var result = new List<string>();
            
            DFS(result,s,0,new List<string>());
            
            return result;
            
        }
        
        public void DFS(IList<string> result, string s, int curIndex, IList<string> currList)
        {
            //IP contains for parts, each of thest part will have a int value between 0 and 255
            
            if(currList.Count>4)
                return;
            
            if(currList.Count == 4 && curIndex != s.Length)
                return;
            
            //valid
            if(currList.Count == 4 && curIndex == s.Length)
            {
                result.Add(String.Join(".",currList.ToArray()));
                return;
            }
            
            if(curIndex == s.Length)
                return;
            
            var newList=new List<string>();
            foreach(var str in currList)
            {
                newList.Add(str);
            }
            
            newList.Add(s[curIndex].ToString());
            
            DFS(result, s, curIndex + 1, newList);
            
            // any part have more the two chars, but start with '0' is invalid
            if(curIndex <= s.Length - 2 && s[curIndex] !='0')
            {
                var newTwoList=new List<string>();
                foreach(var str in currList)
                {
                    newTwoList.Add(str);
                }
                newTwoList.Add(s.Substring(curIndex, 2));
                DFS(result, s, curIndex + 2, newTwoList);
            }
            
            // any part have more the two chars, but start with '0' is invalid
            if(curIndex <= s.Length - 3 && int.Parse(s.Substring(curIndex,3))<=255 && s[curIndex] !='0')
            {
                var newThreeList=new List<string>();
                foreach(var str in currList)
                {
                    newThreeList.Add(str);
                }
                newThreeList.Add(s.Substring(curIndex, 3));
                DFS(result, s, curIndex + 3, newThreeList);
            }
            
        }
    }
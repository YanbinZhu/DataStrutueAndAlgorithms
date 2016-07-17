/*76. Minimum Window Substring
    Given a string S and a string T, find the minimum window in S which will contain all the characters in T in complexity O(n).

For example,
S = "ADOBECODEBANC"
T = "ABC"
Minimum window is "BANC".

Note:
If there is no such window in S that covers all characters in T, return the empty string "".

If there are multiple such windows, you are guaranteed that there will always be only one unique minimum window in S.*/


    public class Solution {
        public string MinWindow(string s, string t) {
            
            
            var charList=new int[265];
            
            for(int i=0;i<t.Length;i++)
            {
                charList[t[i]]++;
            }
            
            int start=0, end=0, minLength=int.MaxValue,minStart=0,count=t.Length;
            
            while(end<s.Length)
            {
                if(charList[s[end]]>0)
                    count--;
                
                charList[s[end]]--;
                
                while(count==0)
                {
                    if(minLength > end - start+1)
                    {
                       minLength = end - start+1;
                       minStart = start;
                    }
                    
                    charList[s[start]]++;
                    
                    if(charList[s[start]]>0)
                        count++;
                        
                    start++;
                }
                
                end++;
            }
            
            return minLength==int.MaxValue? "" : s.Substring(minStart,minLength);
            
            
        }
    }
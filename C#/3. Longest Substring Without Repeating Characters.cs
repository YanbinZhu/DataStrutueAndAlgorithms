/*3. Longest Substring Without Repeating Characters
    Given a string, find the length of the longest substring without repeating characters.

Examples:

Given "abcabcbb", the answer is "abc", which the length is 3.

Given "bbbbb", the answer is "b", with the length of 1.

Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.*/

    
    
    public class Solution {
        public int LengthOfLongestSubstring(string s) {
            
            //check null
            
            if(string.IsNullOrEmpty(s))
                return 0;
            
            //unit testing "a","aa"
            var charList=new int[128];
            
            for(int i=0;i<charList.Length;i++)
            {
                charList[i]=-1;
            }
            
            int start=0, max=int.MinValue;
            
            for(int end=0; end<s.Length; end++)
            {
                if(charList[s[end]] > -1)
                {
                    if(start <= charList[s[end]])
                        start = charList[s[end]] + 1;
                }
                
                max=Math.Max(max,end - start + 1);
                
                charList[s[end]]=end;
            }
            
            return max;
        }
    }
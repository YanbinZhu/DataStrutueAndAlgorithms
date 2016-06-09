/*Longest Substring Without Repeating Characters
    
    Given a string, find the length of the longest substring without repeating characters.

Examples:

Given "abcabcbb", the answer is "abc", which the length is 3.

Given "bbbbb", the answer is "b", with the length of 1.

Given "pwwkew", the answer is "wke", with the length of 3. Note that the answer must be a substring, "pwke" is a subsequence and not a substring.

Subscribe to see which companies asked this question*/

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        
        if(string.IsNullOrEmpty(s)) return 0; if(s.Length==1) return 1;
        
        var mainHash=new HashSet<char>();
  //var tempHash=new Dictionary<char,int>();
  var i = 0;
  int stringLength = 1;
  int j = i + 1;

  mainHash.Add(s[i]);

  for(;j<s.Length;j++)
  {
          while(mainHash.Contains(s[j]))
          {
              mainHash.Remove(s[i]);
              i = i+1;
          }

        mainHash.Add(s[j]);
        stringLength = Math.Max(stringLength,mainHash.Count);
  }

  return stringLength;
    }
}
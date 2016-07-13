/*139. Word Break
    Given a string s and a dictionary of words dict, determine if s can be segmented into a space-separated sequence of one or more dictionary words.

For example, given
s = "leetcode",
dict = ["leet", "code"].

Return true because "leetcode" can be segmented as "leet code".*/        
    
    
    public class Solution {
        public bool WordBreak(string s, ISet<string> wordDict) {
            
            
            bool[] DP = new bool[s.Length + 1];
        
            DP[0] = true;
            
            for(int i=1; i <= s.Length; i++){
                for(int j=0; j < i; j++){
                    if(DP[j] && wordDict.Contains(s.Substring(j, i-j))){
                        DP[i] = true;
                        break;
                    }
                }
            }
            
            return DP[s.Length];
            
        }
    }
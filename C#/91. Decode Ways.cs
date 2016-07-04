/*91. Decode Ways
    
A message containing letters from A-Z is being encoded to numbers using the following mapping:

'A' -> 1
'B' -> 2
...
'Z' -> 26
Given an encoded message containing digits, determine the total number of ways to decode it.

For example,
Given encoded message "12", it could be decoded as "AB" (1 2) or "L" (12).

The number of ways decoding "12" is 2.*/

    // discuss about the 
    // anything about string need to ask 
    // 1. enmpty or null
    // 2. need to trim the start and end spaces?
    // 3. is there any char other than 0~9?
    // 4. 0 need to consider carefully, like: 10, 20, 30, 00, 0, 40
    
    
    public class Solution {
        public int NumDecodings(string s) {
            
            if(string.IsNullOrEmpty(s))
                return 0;
            if(s.StartsWith("0"))
                return 0;
                
            var DP = new Dictionary<int,int>[s.Length];
            DP[0]=new Dictionary<int,int>();
            DP[0].Add(1,1);
            DP[0].Add(2,0);
            
            for(int i = 1; i<s.Length; i++)
            {
                DP[i]=new Dictionary<int,int>();
                DP[i].Add(1,0);
                DP[i].Add(2,0);
                
                if(s[i]=='0' && int.Parse(s.Substring(i-1,2)) > 26)
                    continue;
                
                if(int.Parse(s.Substring(i-1,2)) < 27)
                {
                    DP[i][2]=DP[i-1][1];
                }
                
                if(s[i]=='0')
                {
                    DP[i][1] = 0;
                    continue;
                }
                
                DP[i][1] = DP[i-1][1] + DP[i-1][2];
            }
            
            return DP[s.Length-1][1]+DP[s.Length-1][2];
            
        }
        
        
        public void BFS(ref int result,string s,int index)
        {
            if(index > s.Length)
                return;
                
            if(index == s.Length)
            {
                result += 1;
                return;
            }
            
            if(s[index]!='0')
            {
                BFS(ref result, s, index + 1);
            
                if(index + 2 <= s.Length && int.Parse(s.Substring(index,2)) < 27)
                {
                    BFS(ref result, s, index + 2);
                }
            }
        }
    }
    
    
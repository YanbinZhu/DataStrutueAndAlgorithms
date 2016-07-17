/*97. Interleaving String
    Given s1, s2, s3, find whether s3 is formed by the interleaving of s1 and s2.

For example,
Given:
s1 = "aabcc",
s2 = "dbbca",

When s3 = "aadbbcbcac", return true.
When s3 = "aadbbbaccc", return false.*/

    
    
    
    
    
    public class Solution {
        public bool IsInterleave(string s1, string s2, string s3) {
            
            int row = s1.Length;
            int col = s2.Length;
            int length = s3.Length;
            if(row+col!=length)
                return false;
            if(row==0)
                return s2==s3;
            else if(col==0)
                return s1==s3;
    
            bool[,] matrix = new bool[row+1,col+1];
            
            matrix[0,0] = true;
            
            for(int j=1;j<=col;j++)
            {
                matrix[0,j] = s2[j-1]==s3[j-1] && matrix[0,j-1];
            }
            
            for(int i=1;i<=row;i++)
            {
               matrix[i,0] = s1[i-1]==s3[i-1] && matrix[i-1,0];
            }
            
            for(int i = 1; i<=row; i++){
                for(int j = 1;j<=col;j++){
                    
                    matrix[i,j] = (s2[j-1]==s3[i+j-1] && matrix[i,j-1]) || (s1[i-1]==s3[i+j-1] && matrix[i-1,j]);
                }
            }
            
            return matrix[row,col];
            
            if(string.IsNullOrEmpty(s1))
                return s2==s3;
            if(string.IsNullOrEmpty(s2))
                return s1==s3;
                
            if(string.IsNullOrEmpty(s3) || s3.Length != s1.Length+s2.Length)
                return false;
                
            return IsInterleave(s1,s2,s3,0,0,0);
                   
        }
        
        public bool IsInterleave(string s1, string s2, string s3,int s1Index,int s2Index,int s3Index) {
            
            if(s1Index==s1.Length )
            {
                if(s3.Substring(s3Index,s3.Length-s3Index)==s2.Substring(s2Index,s2.Length-s2Index))
                    return true;
                return false;
            }
            
            if(s2Index==s2.Length)
            {
                if(s3.Substring(s3Index,s3.Length-s3Index)==s1.Substring(s1Index,s1.Length-s1Index))
                    return true;
                return false;
            }
            
            if(s3[s3Index]!=s1[s1Index] && s3[s3Index]!=s2[s2Index])
            {
                return false;
            }
            else if(s3[s3Index]!=s2[s2Index])
            {
                return IsInterleave(s1,s2,s3, s1Index + 1, s2Index,s3Index+1);
            }
            else if(s3[s3Index]!=s1[s1Index])
            {
                return IsInterleave(s1,s2,s3,s1Index,s2Index+1,s3Index+1);
            }
            else
            {
                   return IsInterleave(s1,s2,s3,s1Index+1,s2Index,s3Index+1)||IsInterleave(s1,s2,s3,s1Index,s2Index+1,s3Index+1);
            }
        }
    }    
    
    
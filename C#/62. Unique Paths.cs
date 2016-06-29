/*62. Unique Paths
A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).

The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).

How many possible unique paths are there?
    
Above is a 3 x 7 grid. How many possible unique paths are there?

Note: m and n will be at most 100.*/


    public class Solution {
        public int UniquePaths(int m, int n) {
            
            var DP=new int[m,n];
            
            DP[0,0] = 1;
            
            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(i==0 || j==0)
                    {
                        DP[i,j]=1;
                    }
                    else
                    {
                        DP[i,j] = DP[i,j-1] + DP[i-1,j];
                    }
                }
            }
            
            return DP[m-1, n-1];
        }
    }
    
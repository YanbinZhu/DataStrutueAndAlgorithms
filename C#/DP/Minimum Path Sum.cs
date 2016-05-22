/*Minimum Path Sum
    
    Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which minimizes the sum of all numbers along its path.

Note: You can only move either down or right at any point in time.*/

public class Solution {
    public int MinPathSum(int[,] grid) {
        
        // Get upper bounds for the array
	    int bound0 = grid.GetLength(0);
	    int bound1 = grid.GetLength(1);	    
	    
        var dp=new int[bound0,bound1];
        dp[0,0] = grid[0,0];
        //dp solution
        for(int i=0; i<bound0; i++)
        {
            for(int j=0; j<bound1; j++)
            {
                if(i==0 && j==0)
                {
                    dp[0,0] = grid[0,0];
                }
                else if(j == 0)
                {
                    dp[i,j] = dp[i-1,j] + grid[i,j];
                }
                else if(i == 0)
                {
                   dp[i,j] = dp[i,j-1] + grid[i,j];
                }
                else
                {
                   dp[i,j] = Math.Min(dp[i-1,j],dp[i,j-1]) + grid[i,j];
                }
            }
        }
        
        return dp[bound0-1,bound1-1];
        
        
        //less space
        
        // Get upper bounds for the array
	    int bound0 = grid.GetLength(0);
	    int bound1 = grid.GetLength(1);
	    
        var dp=new int[bound0,bound1];
        dp[0,0] = grid[0,0];
        
        var dpLess=new int[bound1];
        dpLess[0]=grid[0,0];
        //dp solution
        for(int i=0; i<bound0; i++)
        {
            for(int j=0; j<bound1; j++)
            {
                if(i==0 && j==0)
                {
                    dpLess[j] = grid[0,0];
                }
                else if(j == 0)
                {
                    dpLess[j] = dpLess[j] + grid[i,j];
                }
                else if(i == 0)
                {
                   dpLess[j] = dpLess[j-1] + grid[i,j];
                }
                else
                {
                   dpLess[j] = Math.Min(dpLess[j],dpLess[j-1]) + grid[i,j];
                }
            }
        }
        
        return  dpLess[bound1-1];
        
        
    }
}
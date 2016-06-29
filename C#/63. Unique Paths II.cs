/*63. Unique Paths II
    
    Follow up for "Unique Paths":

Now consider if some obstacles are added to the grids. How many unique paths would there be?

An obstacle and empty space is marked as 1 and 0 respectively in the grid.

For example,
There is one obstacle in the middle of a 3x3 grid as illustrated below.

[
  [0,0,0],
  [0,1,0],
  [0,0,0]
]
The total number of unique paths is 2.

Note: m and n will be at most 100.*/
   
   
   
   
   
   
   
    public class Solution {
        public int UniquePathsWithObstacles(int[,] obstacleGrid) {
            
            
            //DP
            
            var colums = obstacleGrid.GetLength(0);
            var rows = obstacleGrid.GetLength(1);
            var DP=new int[colums,rows];
            
            for(int i=0; i<colums; i++)
            {
                for(int j = 0; j < rows; j++)
                {
                    if(obstacleGrid[i,j]==1)
                    {
                        DP[i,j]=0;
                    }
                    else
                    {
                        if(i==0 && j==0)
                        {
                            DP[i,j]=1;
                        }
                        else if(i==0)
                        {
                            DP[i,j] = DP[i,j-1];
                        }
                        else if(j==0)
                        {
                            DP[i,j] = DP[i-1,j]; 
                        }
                        else
                        {
                            DP[i,j] = DP[i-1,j] + DP[i,j-1];
                        }
                    }
                }
                
            }
            
            return DP[colums-1,rows-1];
            
            //consider Obstacle
            
        }
    }    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
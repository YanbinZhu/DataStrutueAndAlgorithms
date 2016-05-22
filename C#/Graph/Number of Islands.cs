/*Number of Islands
    
    Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically. You may assume all four edges of the grid are all surrounded by water.

Example 1:

11110
11010
11000
00000
Answer: 1

Example 2:

11000
11000
00100
00011
Answer: 3*/

public class Solution {
    
    public int NumIslands(char[,] grid) {
        
        int width  = grid.GetLength(0);
        int height = grid.GetLength(1);
        int result=0;
        
        for(int i=0; i<width; i++)
        {
            for(int j=0; j<height; j++)
            {
                if(grid[i,j] == '1')
                {
                    DFSMarkingHelper(grid,i,j);
                    ++result;
                }
            }
        }
        
        return result;
    }
    
    
    public void DFSMarkingHelper(char[,] grid,int x, int y)
    {
        if(x<0 || y<0 ||  x>=grid.GetLength(0) || y>=grid.GetLength(1) || grid[x,y]=='0')
            return;
        
        grid[x,y]='0';
        
        DFSMarkingHelper(grid,x-1, y);
        DFSMarkingHelper(grid,x+1, y);
        DFSMarkingHelper(grid,x, y-1);
        DFSMarkingHelper(grid,x, y+1);
        
    }
}
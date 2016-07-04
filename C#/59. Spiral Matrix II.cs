/*59. Spiral Matrix II
    Given an integer n, generate a square matrix filled with elements from 1 to n2 in spiral order.

For example,
Given n = 3,

You should return the following matrix:
[
 [ 1, 2, 3 ],
 [ 8, 9, 4 ],
 [ 7, 6, 5 ]
]*/

    
    
    
    public class Solution {
        public int[,] GenerateMatrix(int n) {
            
            if(n==0)
                return new int[0,0];
            
            var matrix = new int[n,n];
            
            
            right(1, matrix, 0, 0);
            
            return matrix;
        }
        
        public void right(int start, int[,] matrix, int row, int column)
        {
            int j = column;
            
            for(; j < matrix.GetLength(0) && matrix[row,j] == 0; j++)
            {
                matrix[row,j] = start+j-column;
            }
            
            if(row == matrix.GetLength(0) - 1 || matrix[row + 1, j - 1]!=0)
                return;
                
            down(start+j-column,matrix, row + 1, j - 1);
        }
        
        public void left(int start,int[,] matrix, int row, int column)
        {
            int j = column;
            
            for(; j >= 0 && matrix[row,j] == 0; j--)
            {
                matrix[row,j] = start - j + column;
            }
            
            if(row == 0 || matrix[row - 1, j + 1]!=0)
                return;
                
            up(start - j + column,matrix, row - 1, j + 1);
            
        }
        
        public void up(int start,int[,] matrix, int row, int column)
        {
            int i = row;
            
            for(; i >= 0 && matrix[i,column] == 0; i--)
            {
                matrix[i,column] = start-i+row;
            }
            
            if(column == matrix.GetLength(0) - 1 || matrix[column + 1, i + 1] != 0)
                return;
                
            right(start-i+row, matrix, i+1, column + 1);
        }
        
        public void down(int start, int[,] matrix, int row, int column)
        {
            int i = row;
            
            for(; i < matrix.GetLength(0) && matrix[i,column] == 0; i++)
            {
                matrix[i,column] = start + i - row;
            }
            
            if(column == 0 || matrix[ i - 1, column - 1] != 0)
                return;
                
            left( start + i - row,matrix, i-1, column - 1);
            
        }
    }
/*54. Spiral Matrix
    Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.

For example,
Given the following matrix:

[
 [ 1, 2, 3 ],
 [ 4, 5, 6 ],
 [ 7, 8, 9 ]
]
You should return [1,2,3,6,9,8,7,4,5].*/

        public class Solution {
        public IList<int> SpiralOrder(int[,] matrix) {
            
            var rows = matrix.GetLength(0);
            var columns = matrix.GetLength(1);
            
            var result = new List<int>();
            if(rows==0)
                return result;

            right(result,matrix, 0, 0);
            
            return result;
        }
        
        public void right(IList<int> result,int[,] matrix, int row, int column)
        {
            int j = column;
            
            for(; j < matrix.GetLength(1) && matrix[row,j]!= int.MinValue; j++)
            {
                result.Add(matrix[row,j]);
                matrix[row,j]=int.MinValue;
            }
            
            if(row == matrix.GetLength(0) - 1 || matrix[row + 1, j - 1]==int.MinValue)
                return;
                
            down(result,matrix, row + 1, j - 1);
        }
        
        public void left(IList<int> result,int[,] matrix, int row, int column)
        {
            int j = column;
            
            for(; j >= 0 && matrix[row,j] != int.MinValue; j--)
            {
                result.Add(matrix[row,j]);
                matrix[row,j]=int.MinValue;
            }
            
            if(row == 0 || matrix[row - 1, j + 1]==int.MinValue)
                return;
                
            up(result,matrix, row - 1, j + 1);
            
        }
        
        public void up(IList<int> result,int[,] matrix, int row, int column)
        {
            int i = row;
            
            for(; i >= 0 && matrix[i,column]!= int.MinValue; i--)
            {
                result.Add(matrix[i,column]);
                matrix[i,column] = int.MinValue;
            }
            
            if(column == matrix.GetLength(0) - 1 || matrix[column + 1, i + 1] == int.MinValue)
                return;
                
            right(result, matrix, i+1, column + 1);
        }
        
        public void down(IList<int> result,int[,] matrix, int row, int column)
        {
            int i = row;
            
            for(; i < matrix.GetLength(0) && matrix[i,column] != int.MinValue; i++)
            {
                result.Add(matrix[i,column]);
                matrix[i,column] = int.MinValue;
            }
            
            if(column == 0 || matrix[ i - 1, column - 1] == int.MinValue)
                return;
                
            left(result,matrix, i-1, column - 1);
            
        }
    }
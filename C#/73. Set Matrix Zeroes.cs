/*73. Set Matrix Zeroes
    Given a m x n matrix, if an element is 0, set its entire row and column to 0. Do it in place.

click to show follow up. O(M+N)  space

Follow up:
Did you use extra space?
A straight forward solution using O(mn) space is probably a bad idea.
A simple improvement uses O(m + n) space, but still not the best solution.
Could you devise a constant space solution?*/

    
    
    public class Solution {
        public void SetZeroes(int[,] matrix) {
            
            var colums=matrix.GetLength(0);
            var rows=matrix.GetLength(1);
            
            var columsNumber = new HashSet<int>();
            var rowNumbers = new HashSet<int>();
            
            for(int i=0;i<colums;i++)
            {
                for(int j=0; j < rows; j++)
                {
                    if(matrix[i,j]==0)
                    {
                        columsNumber.Add(j);
                        rowNumbers.Add(i);
                    }
                }
            }
            
            foreach(var rowNumber in rowNumbers)
            {
                for(int i=0;i<rows;i++)
                {
                       matrix[rowNumber,i]=0;
                }
            }
            
            foreach(var columNumber in columsNumber)
            {
                for(int i=0;i<colums;i++)
                {
                    matrix[i,columNumber]=0;
                }
            }
        }
    }
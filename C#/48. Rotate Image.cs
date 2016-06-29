public class Solution {
    public void Rotate(int[,] matrix) {
        
        var clolums=matrix.GetLength(0);
        var rows=matrix.GetLength(1);
        
        for(int i = 0; i<clolums; i++){
            for(int j = i; j<rows; j++){
                int temp = 0;
                temp = matrix[i,j];
                matrix[i,j] = matrix[j,i];
                matrix[j,i] = temp;
            }
        }
        for(int i =0 ; i<clolums; i++){
            for(int j = 0; j<rows/2; j++){
                int temp = 0;
                temp = matrix[i,j];
                matrix[i,j] = matrix[i,clolums-1-j];
                matrix[i,clolums-1-j] = temp;
            }
        }
    }
    }

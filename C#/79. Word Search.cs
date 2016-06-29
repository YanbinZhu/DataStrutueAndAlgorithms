/*79. Word Search
    
    Given a 2D board and a word, find if the word exists in the grid.

The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring. The same letter cell may not be used more than once.

For example,
Given board =

[
  ['A','B','C','E'],
  ['S','F','C','S'],
  ['A','D','E','E']
]
word = "ABCCED", -> returns true,
word = "SEE", -> returns true,
word = "ABCB", -> returns false.*/


public class Solution {

    public bool Exist(char[,] board, string word) {

        int width = board.GetLength(0);
        int height = board.GetLength(1);

         for(int i = 0; i < width; i++)
         {
            for(int j = 0; j < height; j++)
            {
                if(exist(board, i, j, word, 0))
                    return true;
            }
         }
         return false;

    }

    private bool exist(char[,] board, int i, int j, string word, int ind){

   //check length found result
    if(ind == word.Length) return true;

    //check whether cross boarder
    if(i > board.GetLength(0)-1 || i <0 || j<0 || j >board.GetLength(1)-1 || board[i,j]!=word[ind])
        return false;

        board[i,j]='*';


    //check all the neighbers    
        bool result =    exist(board, i-1, j, word, ind+1) ||
                            exist(board, i, j-1, word, ind+1) ||
                            exist(board, i, j+1, word, ind+1) ||
                            exist(board, i+1, j, word, ind+1);

        board[i,j] = word[ind];

        return result;
    }
}

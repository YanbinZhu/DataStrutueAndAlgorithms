/*
 Generate Parentheses
Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

For example, given n = 3, a solution set is:

"((()))", "(()())", "(())()", "()(())", "()()()"*/

public class Solution {
    
    public void backtrack(List<String> list, String str, int open, int close, int max){

        if(str.Length == max*2){
            list.Add(str);
            return;
        }

        if(open < max)
            backtrack(list, str+"(", open+1, close, max);
        if(close < open)
            backtrack(list, str+")", open, close+1, max);
    }
    
    
    public IList<string> GenerateParenthesis(int n) {
        
        var result=new List<string>();
        
        backtrack(result,"",0,0,n);
        
        return result;
    }
    
    
    
}
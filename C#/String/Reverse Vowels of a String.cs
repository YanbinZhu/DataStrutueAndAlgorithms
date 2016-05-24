/*Reverse Vowels of a String
    Write a function that takes a string as input and reverse only the vowels of a string.

Example 1:
Given s = "hello", return "holle".

Example 2:
Given s = "leetcode", return "leotcede".*/

public class Solution {
    public string ReverseVowels(string s) {
        
        var vowels=new HashSet<char>();
        
        vowels.Add('a');
        vowels.Add('A');
        vowels.Add('o');
        vowels.Add('O');
        vowels.Add('e');
        vowels.Add('E');
        vowels.Add('i');
        vowels.Add('I');
        vowels.Add('u');
        vowels.Add('U');
        
        //use string builder wil excell 
        var aStringBuilder = new StringBuilder(s);
        var charArray=s.ToCharArray();
        
        int low = 0;
        int high = s.Length-1;
        while(low < high)
        {
            while((!vowels.Contains(charArray[low])) && (low < high))
            {
                low  += 1;
            }
            
            while((!vowels.Contains(charArray[high]))  && (low < high))
            {
                high -= 1;
            }
            
            if(low < high)
            {
                var temp = charArray[low];
                charArray[low] = charArray[high];
                charArray[high] = temp;
                
                low += 1;
                high -= 1;
            }
        }
        
        return  new string(charArray);
    }
}
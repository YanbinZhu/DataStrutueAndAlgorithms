/* Excel Sheet Column Title
Given a positive integer, return its corresponding column title as appear in an Excel sheet.

For example:

    1 -> A
    2 -> B
    3 -> C
    ...
    26 -> Z
    27 -> AA
    28 -> AB */


public class Solution {
    public string ConvertToTitle(int n) {
        
        var charDictionary=new Dictionary<int, Char>();
        
        charDictionary.Add(1,'A');
        charDictionary.Add(2,'B');
        charDictionary.Add(3,'C');
        charDictionary.Add(4,'D');
        charDictionary.Add(5,'E');
        charDictionary.Add(6,'F');
        charDictionary.Add(7,'G');
        charDictionary.Add(8,'H');
        charDictionary.Add(9,'I');
        charDictionary.Add(10,'J');
        charDictionary.Add(11,'K');
        charDictionary.Add(12,'L');
        charDictionary.Add(13,'M');
        charDictionary.Add(14,'N');
        charDictionary.Add(15,'O');
        charDictionary.Add(16,'P');
        charDictionary.Add(17,'Q');
        charDictionary.Add(18,'R');
        charDictionary.Add(19,'S');
        charDictionary.Add(20,'T');
        charDictionary.Add(21,'U');
        charDictionary.Add(22,'V');
        charDictionary.Add(23,'W');
        charDictionary.Add(24,'X');
        charDictionary.Add(25,'Y');
        charDictionary.Add(0,'Z');
        
        var strBuilder=new StringBuilder();
        
        while(n > 0)
        {
            strBuilder.Insert(0, charDictionary[n % 26]);
            
            //n -= 26;
            if(n % 26 == 0)
            {
                n -= 1;
            }
                
            n = n / 26;
        }
        
        return strBuilder.ToString();
    }
}
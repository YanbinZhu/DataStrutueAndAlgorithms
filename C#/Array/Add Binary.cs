/*Add Binary
    Given two binary strings, return their sum (also a binary string).

For example,
a = "11"
b = "1"
Return "100".*/

public class Solution {
    public string AddBinary(string a, string b) {
        
        int aLength = a.Length;
        int bLength = b.Length;
        
        if(aLength==0)
        {
            return b;
        }
        
        if(bLength==0)
        {
            return a;
        }
        
        int shortLeng=0;
        int longLeng=0;
        string shortString;
        string longString;
        
        if(aLength > bLength)
        {
            shortLeng= bLength;
            longLeng = aLength;
            shortString = b;
            longString = a;
        }
        else
        {
            shortLeng = aLength;
            longLeng = bLength;
            shortString = a;
            longString = b;
        }
        
        int addTrue = 0;
        
        StringBuilder sb=new StringBuilder();
        
        for(int i = shortLeng - 1; i >= 0; i--)
        {
            int current = (shortString[i] == '1'? 1 : 0) + (longString[longLeng - shortLeng + i] == '1' ? 1: 0);
            
            current += addTrue;
            
            if(current==3)
            {
                sb.Insert(0,'1');
                addTrue=1;
            }
            else if(current==2)
            {
                sb.Insert(0,'0');
                addTrue=1;
            }
            else if(current==1)
            {
                sb.Insert(0,'1');
                addTrue=0;
            }
            else
            {
                sb.Insert(0,'0');
                addTrue=0;
            }
        }
        
        for(int i = longLeng - shortLeng - 1; i >= 0; i--)
        {
            
            int current = (longString[i] == '1' ? 1 : 0) + addTrue;
            
            if(current == 2)
            {
                sb.Insert(0,'0');
                addTrue=1;
            }
            else if(current==1)
            {
                sb.Insert(0,'1');
                addTrue=0;
            }
            else
            {
                sb.Insert(0,'0');
                addTrue=0;
            }
        }
        
        if(addTrue==1)
        {
            sb.Insert(0,'1');
        }
        
        return sb.ToString();
        
    }
}
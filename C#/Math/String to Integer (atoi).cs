/*String to Integer (atoi)
    Implement atoi to convert a string to an integer.

Hint: Carefully consider all possible input cases. If you want a challenge, please do not see below and ask yourself what are the possible input cases.

Notes: It is intended for this problem to be specified vaguely (ie, no given input specs). You are responsible to gather all the input requirements up front.

Update (2015-02-10):
The signature of the C++ function had been updated. If you still see your function signature accepts a const char * argument, please click the reload button  to reset your code definition.*/

public class Solution {
    public int MyAtoi(string str) {
          //check null
    if(string.IsNullOrEmpty(str))
        return 0;

    //trim
    str=str.Trim();

    //consider all the senarioes
    var dictionary=new Dictionary<char,int>();

    dictionary.Add('1', 1);
    dictionary.Add('2', 2);
    dictionary.Add('3', 3);
    dictionary.Add('4', 4);
    dictionary.Add('5', 5);
    dictionary.Add('6', 6);
    dictionary.Add('7', 7);
    dictionary.Add('8', 8);
    dictionary.Add('9', 9);
    dictionary.Add('0', 0);

    //check minus and 
    int i = str.StartsWith("-") || str.StartsWith("+") ? 1 : 0;

    long result=0;

    for(; i<str.Length; i++)
    {
        if(!dictionary.ContainsKey(str[i]))
            break;

        if(result > int.MaxValue/10)
        {
            if(str.StartsWith("-"))
            {return int.MinValue;}
            else
            {
                return int.MaxValue;
            }

        }

        result = result*10 + dictionary[str[i]];
    }

    if(str.StartsWith("-"))
        result=0-result;

    if(result>int.MaxValue)
        return int.MaxValue;

    if(result<int.MinValue)
        return int.MinValue;

    return (int)result;
    }
}
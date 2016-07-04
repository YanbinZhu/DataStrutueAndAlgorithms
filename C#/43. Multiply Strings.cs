/*43. Multiply Strings
    Given two numbers represented as strings, return multiplication of the numbers as a string.

Note:
The numbers can be arbitrarily large and are non-negative.
Converting the input string to integer is NOT allowed.
You should NOT use internal library such as BigInteger.
    
    */

    public class Solution {
        public string Multiply(string num1, string num2) {
            
            int m = num1.Length, n = num2.Length;
            int[] pos = new int[m + n];
           
            for(int i = m - 1; i >= 0; i--) {
                for(int j = n - 1; j >= 0; j--) {
                    int mul = (num1[i] - '0') * (num2[j] - '0'); 
                    int p1 = i + j, p2 = i + j + 1;
                    int sum = mul + pos[p2];
        
                    pos[p1] += sum / 10;
                    pos[p2] = (sum) % 10;
                }
            }  
            
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<pos.Length;i++)
            {
                if(!(sb.Length == 0 && pos[i] == 0))
                    sb.Append(pos[i]);
            }
            
            return sb.Length == 0 ? "0" : sb.ToString();
            
        }
    }
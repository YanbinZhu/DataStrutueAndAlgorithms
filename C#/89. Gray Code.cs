/*89. Gray Code
    
    The gray code is a binary numeral system where two successive values differ in only one bit.

Given a non-negative integer n representing the total number of bits in the code, print the sequence of gray code. A gray code sequence must begin with 0.

For example, given n = 2, return [0,1,3,2]. Its gray code sequence is:

00 - 0
01 - 1
11 - 3
10 - 2
Note:
For a given n, a gray code sequence is not uniquely defined.

For example, [0,2,3,1] is also a valid gray code sequence according to the above definition.

For now, the judge is able to judge based on one instance of gray code sequence. Sorry about that.*/    
    
       
    
    public class Solution {
        public IList<int> GrayCode(int n) {
            var DP= new List<int>[n + 1];
            DP[0]=new List<int>(){0};
            for(int i=1; i<=n; i++)
            {
                DP[i]=new List<int>();
                bool reverse = false;
                foreach(var num in DP[i-1])
                {
                    DP[i].Add(!reverse ? num << 1 : (num << 1) + 1);
                    DP[i].Add(!reverse ? (num << 1) + 1 : num << 1);
                    reverse=!reverse;
                }
            }
            return DP[n];
        }
    }
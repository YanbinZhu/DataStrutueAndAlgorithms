/*Count Primes
    Description:

Count the number of prime numbers less than a non-negative number, n.*/

public class Solution {
    public int CountPrimes(int n) {
        
        //using bool array
        
        var m = new bool[n];
        //var noPrimare=new HashSet<int>();
        int count = 0;
        for (int i=2; i<n; i++) {
            if (m[i])
                continue;

            count++;
            for (int j=i; j<n; j=j+i)
            {
                m[j]=true;
            }
        }
        
        return count;
        
        //using hash set, but it will take too many memory.
        
        var noPrimare = new HashSet<int>();
        
        int i = 2;
        int result = 1;
        
        while(i <= n)
        {
            if(!noPrimare.Contains(i))
            {
                result += 1;
                int j = 2;
                while(i * j<=n)
                {
                    if(!noPrimare.Contains(i * j))
                    {
                        noPrimare.Add(i*j);
                    }
                    j++;
                }
            }
            i += 1;
        }
        
        return result;
    }
}


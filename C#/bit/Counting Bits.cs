/*Counting Bits
    
    Given a non negative integer number num. For every numbers i in the range 0 ≤ i ≤ num calculate the number of 1's in their binary representation and return them as an array.

Example:
For num = 5 you should return [0,1,1,2,1,2].

Follow up:

It is very easy to come up with a solution with run time O(n*sizeof(integer)). But can you do it in linear time O(n) /possibly in a single pass?
Space complexity should be O(n).
Can you do it like a boss? Do it without using any builtin function like __builtin_popcount in c++ or in any other language.*/


public class Solution {
    public int[] CountBits(int num) {
        
        //DP better solution: An easy recurrence for this problem is f[i] = f[i / 2] + i % 2. 
        
         int[] answer = new int[num+1];
        int offset = 1;
        for(int i = 1; i < answer.length; i++){
            if(offset * 2 == i) offset *= 2;
            answer[i] = 1 + answer[i - offset];
        }
        return answer;
        
        //bit operation:
        
        int[] f = new int[num + 1];
        for (int i=1; i<=num; i++) f[i] = f[i >> 1] + (i & 1);
        return f;
        
        var result=new int[num + 1];
        
        //naive solution
        
        for(int i=0;i<=num;i++)
        {
            result[i] = CountOneFromInt(i);
        }
        
        return result;
        
    }
    
    //naive solution
    
    public int CountOneFromInt(int num)
    {
        int result = 0;
        
        while(num != 0)
        {
            if(num % 2 == 1)
            {
                result += 1;
            }
            
            num = num/2;
        }
        
        return result;
    }
}
/*Power of Four
    
Given an integer (signed 32 bits), write a function to check whether it is a power of 4.

Example:
Given num = 16, return true. Given num = 5, return false.

Follow up: Could you solve it without loops/recursion?*/

public class Solution {
    public bool IsPowerOfFour(int num) {
        
        return 
            //this num should be nagetive interge 
            num > 0 &&             
            //this nus should have only 1 at the begin like 10 or 10000
            (num&(num-1)) == 0 && 
            //the only 1 should be at the odd positon 
            //0x55555555 = 01010101010101010101010101010101
            (num & 0x55555555) != 0;
        
    }
}
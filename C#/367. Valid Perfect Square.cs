/*367. Valid Perfect Square
    
    Given a positive integer num, write a function which returns True if num is a perfect square else False.

Note: Do not use any built-in library function such as sqrt.

Example 1:

Input: 16
Returns: True
Example 2:

Input: 14
Returns: False*/

    
    
    
    public class Solution {
        public bool IsPerfectSquare(int num) {
            
            if(num==0)
                return false;
            
            int squ=Squ(num);
            
            return squ*squ==num;
            
        }
        
        //unit testing 0,1,3,4
        public int Squ(int num)
        {
            if(num<2)
                return num;
            
            int left=0,right=num;
            
            while(left<=right)
            {
                int mid=left+(right-left)/2;
                if(num==mid*mid)
                    return mid; 
                if(num/mid < mid)
                {
                    right=mid-1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            
            return right;
        }
    }
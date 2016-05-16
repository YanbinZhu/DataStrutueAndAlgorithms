/*First Bad Version*/
/*You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of your product fails the quality check. Since each version is developed based on the previous version, all the versions after a bad version are also bad.

Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.

You are given an API bool isBadVersion(version) which will return whether version is bad. Implement a function to find the first bad version. You should minimize the number of calls to the API.*/


/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        if(n==0)
        {
            throw new Exception("");
        }

        if(n==1)
        {
            if(IsBadVersion(1))
            return 1;
        }

        int left = 1;
        int right = n;
        int middle = 0;
    
        while(left <= right)
        {
            middle =left + ( right-left) / 2;   //here we could not use middle =(left + right) / 2, it will overflow if left is larger than int.Max/2
			
            if(IsBadVersion(middle))
            {
                if(!IsBadVersion(middle-1))
                {
                    return middle;
                }
                else
                {
                    right = middle - 1;
                }
            }
            else
            {
                left = middle + 1;
            }
        }
    
        throw new Exception("");;
    }
}
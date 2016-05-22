/*Compare two version numbers version1 and version2.
If version1 > version2 return 1, if version1 < version2 return -1, otherwise return 0.

You may assume that the version strings are non-empty and contain only digits and the . character.
The . character does not represent a decimal point and is used to separate number sequences.
For instance, 2.5 is not "two and a half" or "half way to version three", it is the fifth second-level revision of the second first-level revision.

Here is an example of version numbers ordering:

0.1 < 1.1 < 1.2 < 13.37*/

public class Solution {
    public int CompareVersion(string version1, string version2) {
        
        var v1List = version1.Split('.');
        var v2List = version2.Split('.');
        
        //trim end 0
        
        var v1Length=v1List.Length;
        var v2Length=v2List.Length;
        
        if(v1Length <= v2Length)
        {
            int i;
            for(i=0; i < v1Length; i++)
            {
                if(int.Parse(v1List[i]) > int.Parse(v2List[i]))
                {
                    return 1;
                }
                
                if(int.Parse(v1List[i]) < int.Parse(v2List[i]))
                {
                    return -1;
                }
            }
            
            if(v1Length == v2Length)
            {
                return 0;
            }
            
           for(int j=i;j<v2List.Length;j++)
            {
                if(int.Parse(v2List[j])!=0)
                {
                    return -1;
                }
            }
            
            return 0;
        }
        
        
        
        if(v1Length > v2Length)
        {
            int i;
            for(i=0; i<v2Length; i++)
            {
                if(int.Parse(v1List[i]) > int.Parse(v2List[i]))
                {
                    return 1;
                }
                
                if(int.Parse(v1List[i]) < int.Parse(v2List[i]))
                {
                    return -1;
                }
            }
            
            for(int j=i;j<v1List.Length;j++)
            {
                if(int.Parse(v1List[j])!=0)
                {
                    return 1;
                }
                
            }
            
            return 0;
            
        }
        
         return 1;
        
        
    }
}
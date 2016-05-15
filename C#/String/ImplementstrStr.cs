//brutal force

public class Solution {
    
    public int StrStr(string haystack, string needle) {
        
    var hayStackLength = haystack.Length;
    var needleLength = needle.Length;

    if(haystack == needle)
    {
        return 0;
    }

    if(needleLength == 0)
    {
        return 0;
    }

    if(hayStackLength == 0)
    {
        return -1;
    }

    for(int i = 0; i < hayStackLength; i++)
    {
        if(needleLength > hayStackLength - i)
        {
            return -1;
        }

        if(haystack[i] == needle[0])
        {
            int j = 0;
            for(; j < needleLength; j++)
            {
                if(needle[j] != haystack[i + j])
                {
                    break;
                }
            }

            if(j == needleLength)
            {
                return i;
            }
        }
    }

    return -1;
    }
}
/*71. Simplify Path
    Given an absolute path for a file (Unix-style), simplify it.

For example,
path = "/home/", => "/home"
path = "/a/./b/../../c/", => "/c"*/


    public class Solution {
        public string SimplifyPath(string path) {
 
        var stack = new Stack<string>();
        
        var skip = new HashSet<string>(){"..",".",""};
        
        var pathArray=path.Split('/');
        
        for(int i=0;i<pathArray.Length;i++)
        {
            if (pathArray[i]==".." && stack.Count>0) 
                {stack.Pop();}
            else if (!skip.Contains(pathArray[i])) 
            {
                stack.Push(pathArray[i]);
            }
        }
        
        String res = "";
        
        while(stack.Count>0)
        {
            var dir=stack.Pop();
            res ="/" + dir + res;
        }
        
        return string.IsNullOrEmpty(res) ? "/" : res;
            
        }
    }
public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        
        var result=new List<IList<int>>();
        
        for(int i=0; i<numRows; i++)
        {
            result.Add(GetRow(i));
        }
        
        return result;
    }
    
    
    public IList<int> GetRow(int rowIndex) {
        
        IList<int> temp=new List<int>();
        
        if(rowIndex == 0)
        {
            temp.Add(1);
            return temp;
        }
        
        if(rowIndex==1)
        {
            
             temp.Add(1);
             temp.Add(1);
            return temp;
        }
        
        temp.Add(1);
        
        var pre = GetRow(rowIndex - 1);
        
        for(int i = 1; i < rowIndex;  i++)
        {
            temp.Add(pre[i-1] + pre[i]);
        }
        
        temp.Add(1);
        
        return temp;
        
    }
}
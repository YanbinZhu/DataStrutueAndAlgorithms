public class Solution {
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
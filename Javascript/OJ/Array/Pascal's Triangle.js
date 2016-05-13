/**
 * @param {number} numRows
 * @return {number[][]}
 */
var generate = function(numRows) {
    var result = [];
    for(var i=0;i<numRows;i++)
    {
        result.push(GetRow(i));
    }
    
    return result;
};

 var GetRow =function(rowIndex) {
        
        var temp=[];
        
        if(rowIndex === 0)
        {
            temp.push(1);
            return temp;
        }
        
        if(rowIndex===1)
        {
            
            temp.push(1);
            temp.push(1);
            return temp;
        }
        
        temp.push(1);
        
        var pre = GetRow(rowIndex - 1);
        
        for(var i = 1; i < rowIndex;  i++)
        {
            temp.push(pre[i-1] + pre[i]);
        }
        
        temp.push(1);
        
        return temp;
        
    }
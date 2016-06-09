/*Valid Parentheses
    Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

The brackets must close in the correct order, "()" and "()[]{}" are all valid but "(]" and "([)]" are not.*/

/**
 * @param {string} s
 * @return {boolean}
 */
var isValid = function(s) {
    
    var strLength=s.length;
    
    if(strLength===0)
    {
        return true;
    }
    
    if(strLength===1)
    {
        return false;
    }
    
    parentssList = {
        ')': '(',
        '}': '{',
        ']': '['
    };
    
    var charList=[s.charAt(0)];
    
    for(var i = 1; i < strLength; i++)
    {
        if(charList.length>0 && (parentssList[s.charAt(i)] === charList[charList.length-1]))
        {
            charList.pop();
        }
        else
        {
            charList.push(s.charAt(i));
        }
    }
    
    return charList.length===0;
    
};
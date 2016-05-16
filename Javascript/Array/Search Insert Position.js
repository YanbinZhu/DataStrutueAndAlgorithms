//Search Insert Position

/*Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You may assume no duplicates in the array.

Here are few examples.
[1,3,5,6], 5 → 2
[1,3,5,6], 2 → 1
[1,3,5,6], 7 → 4
[1,3,5,6], 0 → 0*/

/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */

var searchInsert = function (nums, target) {

    if (nums.length === 0) {
        return 0;
    }

    var low = 0
        , high = nums.length - 1
        , middle;

    while (low < high) {
        middle = Math.floor((low + high) / 2);
        if (nums[middle] === target) {
            return middle;
        } else if (nums[middle] > target) {
            high = middle - 1;
        } else {
            low = middle + 1;
        }
    }

    if (nums[low] < target) {
        return low + 1;
    } else {
        return low;
    }

};


//recrecive way

var SearchInsertRecurrence = function(nums, low, high ,target)
    {
            if(low >= high)
            {
                if(nums[low] < target)
                {
                    return low + 1;
                }
                else
                {
                    return low;
                }
            }
        
            var middle=Math.floor((low+high)/2);
		 
            if(nums[middle]===target)
            {
                return middle;
            }
            else if(nums[middle] > target)
            {
                return SearchInsertRecurrence(nums, low, middle-1,target);
            }
            else
            {
                return SearchInsertRecurrence(nums, middle + 1, high,target);
            }        
            
    }
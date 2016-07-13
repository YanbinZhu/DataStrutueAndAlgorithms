/*42. Trapping Rain Water
    Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it is able to trap after raining.

For example, 
Given [0,1,0,2,1,0,1,3,2,1,2,1], return 6.*/

    public class Solution {
        public int Trap(int[] height) {
            
            if(height == null || height.Length == 0) return 0;
            int leftMax = 0, rightMax = 0, waterTrapped = 0, left = 0, right = height.Length-1;
            while(left < right) {
                leftMax = leftMax > height[left] ? leftMax : height[left];
                rightMax = rightMax > height[right] ? rightMax : height[right];
                if(leftMax < rightMax)
                {
                    waterTrapped += leftMax - height[left];
                    left+=1;
                }
                else
                {
                    waterTrapped += rightMax - height[right];
                    right-=1;
                }
            }
            
            return waterTrapped;
        }
    }
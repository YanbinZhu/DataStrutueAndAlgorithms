
/*Intersection of Two Arrays

Given two arrays, write a function to compute their intersection.

Example:
Given nums1 = [1, 2, 2, 1], nums2 = [2, 2], return [2].

Note:
Each element in the result must be unique.
The result can be in any order.*/

public class Solution {
     public int[] Intersection(int[] nums1, int[] nums2) {

        var hashInt = new Dictionary<int, int>();
        var hashResultInt = new Dictionary<int, int>();

        int minLength = Math.Min(nums1.Length, nums2.Length);

        if(minLength == 0)
        {
            return new int[0];
        }

        var result=new List<int>();

        if(nums1.Length < nums2.Length)
        {
            for(int i = 0; i < nums1.Length; i++)
            {
                if(!hashInt.ContainsKey(nums1[i]))
                {
                    hashInt.Add(nums1[i],nums1[i]);
                }
            }

            for(int i = 0; i < nums2.Length; i++)
            {
                if(hashInt.ContainsKey(nums2[i]))
                {
                    if(!hashResultInt.ContainsKey(nums2[i]))
                    {
                        hashResultInt.Add(nums2[i],nums2[i]);
                    }
                }
            }
        }
        else
        {
            for(int i = 0; i < nums2.Length; i++)
            {
                if(!hashInt.ContainsKey(nums2[i]))
                {
                    hashInt.Add(nums2[i],nums2[i]);
                }
            }

            for(int i = 0; i < nums1.Length; i++)
            {
                if(hashInt.ContainsKey(nums1[i]))
                {
                    if(!hashResultInt.ContainsKey(nums1[i]))
                    {
                        hashResultInt.Add(nums1[i],nums1[i]);
                    }
                }
            }
        }

        return hashResultInt.Keys.ToArray();
    }
  }

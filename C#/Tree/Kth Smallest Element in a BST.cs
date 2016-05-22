/*Kth Smallest Element in a BST
    
    Given a binary search tree, write a function kthSmallest to find the kth smallest element in it.

Note: 
You may assume k is always valid, 1 ≤ k ≤ BST's total elements.*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public int KthSmallest(TreeNode root, int k) {
        
        List<int> result =new List<int>();
        travelsList(root,k,result);
        
         return result[result.Count-1];
    }
    
    
     public static void travelsList(TreeNode root, int k, List<int> result)
{

    if(root.left != null)
    {
        travelsList(root.left, k, result);
    }
    
    if(result.Count == k)
    {
        return;
    }

    result.Add(root.val);
 

    if(root.right != null)
    {
        travelsList(root.right, k, result);
    }

    return;
  }
}
/*
Validate Binary Search Tree

    Given a binary tree, determine if it is a valid binary search tree (BST).

Assume a BST is defined as follows:

The left subtree of a node contains only nodes with keys less than the node's key.
The right subtree of a node contains only nodes with keys greater than the node's key.
Both the left and right subtrees must also be binary search trees.
*/

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
    public bool IsValidBST(TreeNode root) {
        if(root == null || (root.left == null && root.right==null))
        {
            return true;
        }

        return IsValidBST(root, long.MaxValue, long.MinValue);
    }

    public bool IsValidBST(TreeNode root, long maxValue, long minValue)
    {
        if(root == null)
        {
            return true;
        }

        if(root.val >= maxValue || root.val <= minValue)
        {
            return false;
        }

        return IsValidBST(root.left, (long)root.val, minValue) && IsValidBST(root.right, maxValue,    (long)root.val);

    }
    }

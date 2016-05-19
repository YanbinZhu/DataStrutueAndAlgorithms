
/*Binary Tree Inorder Traversal
    
Given a binary tree, return the inorder traversal of its nodes' values.

For example:
Given binary tree {1,#,2,3},
   1
    \
     2
    /
   3
return [1,3,2].

Note: Recursive solution is trivial, could you do it iteratively?
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

    /*Recursive solution*/

    public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        
        var result = new List<int>();
        
        if(root==null)
        {
            return result;
        }
        
        if(root.left!=null)
        {
            result.AddRange(InorderTraversal(root.left));
        }
        
        result.Add(root.val);
        
        if(root.right!=null)
        {
            result.AddRange(InorderTraversal(root.right));
        }
        
        return result;
    }
}

    //    iteratively solution

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
    public IList<int> InorderTraversal(TreeNode root) {

      List<int> list = new List<int>();

        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode cur = root;

    while(cur!=null || !(stack.Count == 0)){
        while(cur!=null){
            stack.Push(cur);
            cur = cur.left;
        }
        cur = stack.Pop();
        list.Add(cur.val);
        cur = cur.right;
    }

    return list;
        
        }
}






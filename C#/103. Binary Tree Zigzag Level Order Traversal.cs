/*103. Binary Tree Zigzag Level Order Traversal
    Given a binary tree, return the zigzag level order traversal of its nodes' values. (ie, from left to right, then right to left for the next level and alternate between).

For example:
Given binary tree [3,9,20,null,null,15,7],
    3
   / \
  9  20
    /  \
   15   7
return its zigzag level order traversal as:
[
  [3],
  [20,9],
  [15,7]
]*/


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
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
          
          var result=new List<IList<int>>();
          
          //check null
          if(root==null)
            return result;
          
          //use stack
          
          var nodeStack=new Stack<TreeNode>();
          nodeStack.Push(root);
            
        zagzip(result,nodeStack,true);
            
        return result;
        }
        
        public void zagzip(IList<IList<int>> result,Stack<TreeNode> nodeStack,bool fromLeft)
        {
            
            if(nodeStack.Count==0)
                return;
                
                var currList=new List<int>();
                var nextLevel=new Stack<TreeNode>();
                
              while(nodeStack.Count!=0)
              {
                var curNode=nodeStack.Pop();
                currList.Add(curNode.val);
                if(!fromLeft)
                {
                    if(curNode.right!=null)
                    {
                        nextLevel.Push(curNode.right);
                    }
                    
                    if(curNode.left!=null)
                    {
                        nextLevel.Push(curNode.left);
                    }
                }
                else
                {
                    if(curNode.left!=null)
                    {
                        nextLevel.Push(curNode.left);
                    }
                    if(curNode.right!=null)
                    {
                        nextLevel.Push(curNode.right);
                    }
                    
                }
              }
          
          result.Add(currList);
          
          zagzip(result,nextLevel,!fromLeft);
        }
    }
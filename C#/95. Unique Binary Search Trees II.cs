/*95. Unique Binary Search Trees II
Given an integer n, generate all structurally unique BST's (binary search trees) that store values 1...n.

For example,
Given n = 3, your program should return all 5 unique BST's shown below.

   1         3     3      2      1
    \       /     /      / \      \
     3     2     1      1   3      2
    /     /       \                 \
   2     1         2                 3*/

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
        public IList<TreeNode> GenerateTrees(int n) {
            if(n==0)
                return new List<TreeNode>();
            
            return generateSubtrees(1, n);
        }
        
        private List<TreeNode> generateSubtrees(int s, int e) {
        	var res = new List<TreeNode>();
        	if (s > e) {
        		res.Add(null); // empty tree
        		return res;
        	}
        
        	for (int i = s; i <= e; ++i) {
        		var leftSubtrees = generateSubtrees(s, i - 1);
        		var rightSubtrees = generateSubtrees(i + 1, e);
        
        		foreach (var left in leftSubtrees) {
        			foreach (var right in rightSubtrees) {
        				TreeNode root = new TreeNode(i);
        				root.left = left;
        				root.right = right;
        				res.Add(root);
        			}
        		}
        	}
        	return res;
        }
    }
/*86. Partition List
    Given a linked list and a value x, partition it such that all nodes less than x come before nodes greater than or equal to x.

You should preserve the original relative order of the nodes in each of the two partitions.

For example,
Given 1->4->3->2->5->2 and x = 3,
return 1->2->2->4->3->5.*/    
    
    
    
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) { val = x; }
     * }
     */
    public class Solution {
        public ListNode Partition(ListNode head, int x) {
            
            //create two new nodelist for larger and smaller nodes
            ListNode smallHead = new ListNode(0);
            ListNode bigHead = new ListNode(0);
            var tempSmallHead=smallHead;
            var tempBigHead=bigHead;
            
            var curr=head;
            while(curr!=null)
            {
                var nextTemp = curr.next;
                curr.next = null;
                if(curr.val < x)
                {
                    smallHead.next = curr;
                    smallHead = smallHead.next;
                }
                else
                {
                    bigHead.next = curr;
                    bigHead = bigHead.next;
                }
                
                curr = nextTemp;
            }
            
            smallHead.next = tempBigHead.next;
            
            
            return tempSmallHead.next;
            
        }
        
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

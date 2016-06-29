/*147. Insertion Sort List
    
Sort a linked list using insertion sort.*/
    
    
    
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) { val = x; }
     * }
     */
    public class Solution {
        public ListNode InsertionSortList(ListNode head) {
            if(head==null||head.next==null)
                return head;
            
            //two list one for the ordered, and one for the remaing
            var newHead=new ListNode(0);
            newHead.next=head;
            var resultPre=newHead;
            var next = head.next;
            head.next=null;
            
            while(next != null)
            {
                newHead = resultPre;
                var nextnextTemp=next.next;
                
                while(newHead !=null)
                {
                    if(newHead.next==null || next.val < newHead.next.val)
                    {
                        next.next = null;
                        next.next = newHead.next;
                        newHead.next = next;
                        
                        break;
                    }
                    newHead=newHead.next;
                }
                next = nextnextTemp;
            }
            return resultPre.next;
        }
    }    
    
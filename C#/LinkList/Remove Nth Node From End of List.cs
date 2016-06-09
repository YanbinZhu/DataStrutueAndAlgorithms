/*Given a linked list, remove the nth node from the end of list and return its head.

For example,

   Given linked list: 1->2->3->4->5, and n = 2.

   After removing the second node from the end, the linked list becomes 1->2->3->5.
Note:
Given n will always be valid.
Try to do this in one pass.*/



/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        var newHeader=new ListNode(0);
    newHeader.next=head;
    var pre=newHeader;
    var runner=head;
    int counter = 0;

    var slowruner=head;

    while(runner != null)
    {
        runner=runner.next;
        counter += 1;
        pre=pre.next;
        slowruner=slowruner.next;

        if(counter == n)
        {
            pre = newHeader;
            slowruner = head;
        }
    }

    pre.next=slowruner.next;

    return newHeader.next;

}
    }

/*
You are given two linked lists representing two non-negative numbers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8

*/


/**
  * Definition for singly-linked list.
  * public class ListNode {
  *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */


public class Solution {
   public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

    //check null
    if(l1 == null)
    {
        return l2;
    }

    if(l2 == null)
    {
        return l1;
    }

    var newHeader=new ListNode(0);
    var markNewHeader = newHeader;
    var add=0;
    var curSum=0;

    while(l1!=null || l2 != null)
    {
        curSum = (l1==null ? 0 : l1.val) + (l2==null ? 0 : l2.val) + add;
        if(curSum > 9)
        {
            curSum = curSum-10;
            add = 1;
        }
        else
        {
            add = 0;
        }

        newHeader.next = new ListNode(curSum);
        newHeader=newHeader.next;

        if(l1!=null) 
            l1=l1.next;
        if(l2!=null) 
            l2=l2.next;
    }

    if(add==1)
    {
        newHeader.next=new ListNode(1);
    }

    return markNewHeader.next;
   }
}
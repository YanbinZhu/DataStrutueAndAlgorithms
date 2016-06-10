/** * Definition for singly-linked list. * public class ListNode { * public int val; * public ListNode next; * public ListNode(int x) { val = x; } * } */ //brain unit testing [1],[], [1,2], [1,2,3]


public class Solution { public ListNode ReverseList(ListNode head) {

    //check null
    if(head==null)
        return head;

    var cur=head;
    var nex=head.next;

    //set the head.next=null to avoid dead lock
    head.next = null;

    return ReverseListI(cur,nex);

    while(nex != null)
    {
        var temp=nex.next;
        nex.next=cur;
        cur=nex;
        nex=temp;
    }

    return cur;
}

public ListNode ReverseListI(ListNode cur,ListNode nex) {

 if(nex==null)
    return cur;

    var temp=nex.next;
    nex.next=cur;
    cur=nex;
    nex=temp;

    return ReverseListI(cur,nex);
}


                       /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */

{
    public ListNode ReverseList(ListNode head) {

        ListNode newHeader=null;
        var cur=newHeader;
        var next=head;

        while(next!=null)
        {
            var temp=next.next;
            next.next=cur;
            cur=next;
            next=temp;
        }

        return cur;

}
}

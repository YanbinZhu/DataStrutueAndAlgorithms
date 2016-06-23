/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
*     public ListNode next;
*     public ListNode(int x) { val = x; }
* }
*/
/*
3 steps:
1. divide linked list into k length group;
2. reverse k length group;
3. Link  the reversed k length group;
4. the very last one will be tricky, need to check whether its length is less or larger than k.

*/

public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {

        var KlengthList=new List<ListNode>();

        //divide the list into group

        KlengthList.Add(head);

        var runner = head;
        var newHeader=head;
        int length = 1;

        while(runner!=null)
        {
            if(length == k)
            {
                KlengthList.Add(runner.next);
                length = 1;
                var temp=runner.next;
                runner.next=null;
                runner=temp;
                continue;
            }

            length += 1;
            runner = runner.next;
        }

        var KlengthListEnd=new List<ListNode>();

        //reverse k length list

        for(int i = 0; i < KlengthList.Count - 1;i++)
        {
            KlengthListEnd.Add(ReverseList(KlengthList[i]));
        }

        if(length == k + 1)
        {
           KlengthListEnd.Add(ReverseList(KlengthList[KlengthList.Count - 1]));
        }
        else
        {
            KlengthListEnd.Add(KlengthList[KlengthList.Count - 1]);
        }

        //link reversed list together

        for(int i = 0; i < KlengthList.Count - 1;i++)
        {
            KlengthList[i].next = KlengthListEnd[i + 1];
        }

        return KlengthListEnd[0];
    }

    public ListNode ReverseList(ListNode head)
    {
        ListNode newHead=null;

        var next=head;

        while(next!=null)
        {
            var temp=next.next;
            next.next=newHead;
            newHead=next;
            next=temp;
        }

        return newHead;
    }
}

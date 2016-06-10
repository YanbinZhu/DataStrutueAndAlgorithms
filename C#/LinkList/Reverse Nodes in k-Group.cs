/* Reverse Nodes in k-Group
     Given a linked list, reverse the nodes of a linked list k at a time and return its modified list.

If the number of nodes is not a multiple of k then left-out nodes in the end should remain as it is.

You may not alter the values in the nodes, only nodes itself may be changed.

Only constant memory is allowed.

For example,
Given this linked list: 1->2->3->4->5

For k = 2, you should return: 2->1->4->3->5

For k = 3, you should return: 3->2->1->4->5*/
    
    
    
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class SmallList{
    
    public ListNode head;
    
    public ListNode tail;
    
    public SmallList(ListNode head, ListNode tail)
    {
        head=head;
        tail=tail;
    }
}



public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        //check null and single node
        if(head==null||head.next==null)
            return head;
        
        var runner=head;
        var counter=1;
        var smallList=new List<ListNode>();
        smallList.Add(head);
        //split list node into separated list
        while(runner!=null)
        {
            if(counter==k)
            {
                var temp=runner.next;
                runner.next = null;
                runner = temp;
                smallList.Add(temp);
                counter = 1;
                continue;
            }
            
            counter += 1;
            runner = runner.next;
        }
        
        smallList.Add(runner);
        
        if(smallList.Count==1 && counter < k)
        {
            return head;
        }
        
        var reversedSmalllist=new List<SmallList>();
        //reverse small list
        
        for(int i =0; i < smallList.Count-1; i++)
        {
            reversedSmalllist.Add(ReverseSmallList(smallList[i]));
        }
        
        for(int i =1; i < smallList.Count - 2; i++)
        {
            reversedSmalllist[i].tail.next = reversedSmalllist[i+1].head;
        }
        
        if(counter == 2)
        {
            reversedSmalllist[smallList.Count - 1].tail.next = reversedSmalllist[smallList.Count-1].head;
        }
        else
        {
            
            reversedSmalllist[smallList.Count - 1].tail.next = reversedSmalllist[smallList.Count-1].head;
        }
        
        //return 
        
        return reversedSmalllist[0].head;
    }
    
    public SmallList ReverseSmallList(ListNode head)
    {
        ListNode newHeader=null;
        var pre=newHeader;
        var cur=head;
        var next=head.next;
        while(next!=null)
        {
            var temp=next.next;
            next.next=cur;
            cur.next=pre;
            pre=cur;
            cur=next;
            next=temp;
        }
        
        return new SmallList(cur, head);
    }
    
}
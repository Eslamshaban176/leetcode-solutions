// Problem: https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/?envType=problem-list-v2&envId=two-pointers
// Language: C#

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode temp = new ListNode(0);
         temp.next = head;
         ListNode first = temp;
         ListNode second = temp;

         for(int i = 0; i <= n; i++)
            first = first.next;

        while( first != null){
            first = first.next;
            second = second.next;
        }

        second.next = second.next.next;

        return temp.next;
    }
}
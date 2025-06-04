// Problem: https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/?envType=problem-list-v2&envId=two-pointers
// Language: C#

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode temp = head;
        int count = 0;

        while (temp != null) {
            count++;
            temp = temp.next;
        }

        int length = count - n;

        if (length == 0) {
            return head.next;
        }

        temp = head;
        for (int i = 1; i < length; i++) {
            temp = temp.next;
        }

        if (temp.next != null)
            temp.next = temp.next.next;

        return head;
    }
}



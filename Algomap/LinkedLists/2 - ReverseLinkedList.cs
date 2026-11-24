#pragma warning disable CS8321 // local function declared but never used (no driver calls in the Python original)
// (The Python original has no driver calls, so this file prints nothing.)

// head: Optional[ListNode] -> Optional[ListNode]
//
// prev    head
// None     1       2        3        4           5
//
//         curr
// prev
//                 next
//         prev
//                 curr
static ListNode? ReverseList(ListNode? head)
{
    ListNode? prev = null;
    ListNode? curr = head;

    while (curr != null)
    {
        ListNode? next = curr.next;
        curr.next = prev;
        prev = curr;
        curr = next;
    }

    return prev;
}

// Definition for singly-linked list.
class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}

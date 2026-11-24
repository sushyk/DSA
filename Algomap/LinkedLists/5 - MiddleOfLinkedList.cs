#pragma warning disable CS8321 // local function declared but never used (no driver calls in the Python original)
// (The Python original has no driver calls, so this file prints nothing.)

// head: Optional[ListNode] -> Optional[ListNode]
static ListNode? MiddleNode(ListNode? head)
{
    ListNode? fast = head;
    ListNode? slow = head;

    while (fast is not null && fast.next != null)
    {
        fast = fast.next.next;
        slow = slow!.next;
    }

    return slow;
}

// Definition for singly-linked list.
class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}

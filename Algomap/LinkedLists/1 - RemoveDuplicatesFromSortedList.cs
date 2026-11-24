#pragma warning disable CS8321 // local function declared but never used (no driver calls in the Python original)
// (The Python original has no driver calls, so this file prints nothing.)

// head: Optional[ListNode] -> Optional[ListNode]
static ListNode? DeleteDuplicates(ListNode? head)
{
    ListNode? left = head;
    ListNode? right = head;

    while (left != null && left.next != null)
    {
        right = left.next;
        if (left.val == right.val)
        {
            left.next = left.next.next;
        }
        else
        {
            left = left.next;
        }
    }

    return head;
}

// Definition for singly-linked list.
class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}

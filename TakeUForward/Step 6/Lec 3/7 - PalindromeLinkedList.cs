var head = new ListNode(1);
head.next = new ListNode(0);
head.next.next = new ListNode(0);

Console.WriteLine(IsPalindrome(head));                // False
Console.WriteLine(IsPalindrome(Build(1, 2, 1)));       // True
Console.WriteLine(IsPalindrome(Build(1, 2, 3, 2, 1))); // True
Console.WriteLine(IsPalindrome(Build(1, 2, 2, 1)));    // True
Console.WriteLine(IsPalindrome(Build(1, 2, 3, 1)));    // False

// :type head: Optional[ListNode]
// :rtype: bool
static bool IsPalindrome(ListNode? head)
{
    if (head == null || head.next == null)
        return true;

    if (head.next.next == null)
        return head.val == head.next.val;

    ListNode? fast = head;
    ListNode slow = head;

    while (fast != null && fast.next != null)
    {
        slow = slow.next!;
        fast = fast.next.next;
    }

    ListNode middle = slow;

    ListNode? curr = head;
    ListNode? prev = null;

    while (curr != middle)
    {
        ListNode? next = curr!.next;
        curr.next = prev;

        prev = curr;
        curr = next;
    }

    ListNode? curr1 = prev;
    // fixed: for odd length (fast != null) skip the middle node, which has no pair
    ListNode? curr2 = fast != null ? middle.next : middle;

    while (curr1 != null && curr2 != null)
    {
        if (curr1.val != curr2.val)
            return false;

        curr1 = curr1.next;
        curr2 = curr2.next;
    }

    return true;
}

static ListNode? Build(params int[] vals)
{
    ListNode? h = null;
    for (int i = vals.Length - 1; i >= 0; i--)
        h = new ListNode(vals[i], h);
    return h;
}

// Definition for singly-linked list.
class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

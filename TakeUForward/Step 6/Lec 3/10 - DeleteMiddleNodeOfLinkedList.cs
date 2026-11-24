var one = new ListNode(1);
var two = new ListNode(2);
var three = new ListNode(3);

one.next = two;
two.next = three;

Console.WriteLine(ToStr(DeleteMiddle(one)));                             // [1, 3]
Console.WriteLine(ToStr(DeleteMiddle(new ListNode(1, new ListNode(2))))); // [1]
Console.WriteLine(ToStr(DeleteMiddle(Build(1, 3, 4, 7, 1, 2, 6))));       // [1, 3, 4, 1, 2, 6]
Console.WriteLine(ToStr(DeleteMiddle(Build(1, 2, 3, 4))));                // [1, 2, 4]

// :type head: Optional[ListNode]
// :rtype: Optional[ListNode]
static ListNode? DeleteMiddle(ListNode? head)
{
    // 0 or 1 elements
    if (head is null || head.next is null)
        return null;

    // 2 elements: middle is the 2nd node (fixed: Python returned head.next, dropping the head)
    if (head.next.next is null)
    {
        head.next = null;
        return head;
    }

    var dummy = new ListNode();
    dummy.next = head;

    ListNode slow = dummy;
    ListNode? fast = head;

    while (fast != null && fast.next != null)
    {
        slow = slow.next!;
        fast = fast.next.next;
    }

    slow.next = slow.next!.next;

    return head;
}

static ListNode? Build(params int[] vals)
{
    ListNode? head = null;
    for (int i = vals.Length - 1; i >= 0; i--)
        head = new ListNode(vals[i], head);
    return head;
}

static string ToStr(ListNode? head)
{
    var vals = new List<int>();
    for (var n = head; n != null; n = n.next)
        vals.Add(n.val);
    return "[" + string.Join(", ", vals) + "]";
}

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

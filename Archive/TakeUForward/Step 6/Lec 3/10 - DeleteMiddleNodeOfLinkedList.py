
class ListNode(object):
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

def deleteMiddle(head):
    """
    :type head: Optional[ListNode]
    :rtype: Optional[ListNode]
    """
    # 0 or 1 elements
    if head is None or head.next is None:
        return None

    # 2 elements
    if head.next.next is None:
        return head.next

    dummy = ListNode()
    dummy.next = head

    length = 0
    slow = dummy
    fast = head

    while fast and fast.next:
        slow = slow.next
        fast = fast.next.next
        length += 1

    slow.next = slow.next.next

    return head

one = ListNode(1)
two = ListNode(2)
three = ListNode(3)

one.next = two
two.next = three

deleteMiddle(one)
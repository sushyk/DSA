# Definition for singly-linked list.
class ListNode(object):
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

def isPalindrome(head):
    """
    :type head: Optional[ListNode]
    :rtype: bool
    """
    
    if head == None or head.next == None:
        return True

    if head.next.next == None:
        return head.val == head.next.val

    fast = head
    slow = head

    while fast and fast.next:
        slow = slow.next
        fast = fast.next.next

    middle = slow

    curr = head
    prev = None

    while curr != middle:
        next = curr.next
        curr.next = prev

        prev = curr
        curr = next

    curr1 = prev
    curr2 = middle

    while curr1 and curr2:
        if curr1.val != curr2.val:
            return False

        curr1 = curr1.next
        curr2 = curr2.next

    return True


head = ListNode(1)
head.next = ListNode(0)
head.next.next = ListNode(0)

print(isPalindrome(head))


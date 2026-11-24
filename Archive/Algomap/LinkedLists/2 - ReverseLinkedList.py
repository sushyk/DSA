# Definition for singly-linked list.
# class ListNode(object):
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution(object):
    def reverseList(self, head):
        """
        :type head: Optional[ListNode]
        :rtype: Optional[ListNode]

        prev    head
        None     1       2        3        4           5

                curr
        prev
                        next
                prev    
                        curr
        """

        prev = None
        curr = head
        
        while curr:
            next = curr.next
            curr.next = prev
            prev = curr
            curr = next

        return prev


        
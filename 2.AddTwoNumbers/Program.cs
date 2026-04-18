using System;

class Node
{
    private int data;
    private Node next;

    public Node(int value)
    {
        data = value;
        next = null;
    }

    public int Data
    {
        get { return data; }
        set { data = value; }
    }

    public Node Next
    {
        get { return next; }
        set { next = value; }
    }
}

class AddTwoNumbers
{
    static Node Add(Node l1, Node l2)
    {
        Node dummy = new Node(0);
        Node current = dummy;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0)
        {
            int sum = carry;

            if (l1 != null)
            {
                sum += l1.Data;
                l1 = l1.Next;
            }

            if (l2 != null)
            {
                sum += l2.Data;
                l2 = l2.Next;
            }

            carry = sum / 10;
            current.Next = new Node(sum % 10);
            current = current.Next;
        }

        return dummy.Next;
    }

    static void Print(Node head)
    {
        while (head != null)
        {
            Console.Write(head.Data + " ");
            head = head.Next;
        }
    }

    static void Main(string[] args)
    {
        Node first = new Node(2);
        first.Next = new Node(4);
        first.Next.Next = new Node(3);

        Node second = new Node(5);
        second.Next = new Node(6);
        second.Next.Next = new Node(4);

        Node result = Add(first, second);

        Print(result); // Output: 7 0 8
    }
}
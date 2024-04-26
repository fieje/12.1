using System;

public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}

public class LinkedList
{
    private Node head;
    private Node tail;

    public object Tail { get; set; }
    public object Head { get; set; }

    public LinkedList()
    {
        head = null;
        tail = null;
    }

    public void Append(int value)
    {
        Node newNode = new Node(value);
        if (tail != null)
        {
            tail.Next = newNode;
        }
        tail = newNode;
        if (head == null)
        {
            head = newNode;
        }
    }

    public void Print()
    {
        Node temp = head;
        while (temp != null)
        {
            Console.Write(temp.Value + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }

    public bool HasAdjacentDuplicates()
    {
        Node temp = head;
        while (temp != null && temp.Next != null)
        {
            if (temp.Value == temp.Next.Value)
            {
                return true;
            }
            temp = temp.Next;
        }
        return false;
    }

    public void Destroy()
    {
        head = null;
        tail = null;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();

        linkedList.Append(1);
        linkedList.Append(2);
        linkedList.Append(3);
        linkedList.Append(4);

        Console.WriteLine("List:");
        linkedList.Print();

        Console.WriteLine("Presence of adjacent duplicates: " + linkedList.HasAdjacentDuplicates());

        linkedList.Destroy();

        Console.WriteLine("List after destruction:");
        linkedList.Print();

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}

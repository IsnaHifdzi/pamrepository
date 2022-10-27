using System;

namespace StackUsingLinkedList_CSharp
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class StacksLinked
    {
        Node top;
        public StacksLinked()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }
        public void push(int element)
        {
            Node fresh;
            fresh = new Node(element, null);
            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + " Pushed.");
        }
        public void pop()
        {
            Console.WriteLine("\n The popped element is: " + top.info);
            top = top.next; //make top point to the next node iin sequence
        }
        public void display()
        {
            Node tmp;
            if (empty())
                Console.WriteLine("\n Stack empty");
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            StacksLinked Stk = new StacksLinked();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("\n1. Push.");
                Console.WriteLine("\n2. Pop");
                Console.WriteLine("\n3. Display");
                Console.WriteLine("\n4. Exit");
                Console.Write("\nEnter your choise: ");
                string stkInput = Console.ReadLine();
                char ch = Convert.ToChar(stkInput == "" ? "0" : stkInput);
                switch (ch)
                {
                    case '1':
                        Console.Write("\n Masukkan Nomor");
                        int num = Convert.ToInt32(Console.ReadLine());
                        Stk.push(num);
                        break;
                    case '2':
                        if (Stk.empty())
                        {
                            Console.WriteLine("\nStack Kosong");
                            break;
                        }
                        Stk.pop();
                        break;
                    case '3':
                        Stk.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nPilihan tidak tersedia");
                        break;
                }
            }
        }
    }
}

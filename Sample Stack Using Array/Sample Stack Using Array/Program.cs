using System;

namespace StackUsingArrays_CSharp
{
    class StacksArray
    {
        int[] stack_arr = new int[5];
        int top;

        StacksArray()
        {
            top = -1;
        }

        public bool full()
        {
            if (top == 4)
                return (true);
            else
                return (false);
        }

        public bool empty()
        {
            if (top == -1)
                return (true);
            else
                return (false);
        }
        public void push(int item)
        {
            top = top + 1;
            stack_arr[top] = item;
            Console.WriteLine();
            Console.WriteLine(item + " pushed");
        }

        public void pop()
        {
            Console.WriteLine("\nThe popped is: " + stack_arr[top]);
            top = top - 1;
        }
        public void display()
        {
            int i;
            if (empty())
                Console.WriteLine("\n Stack empty");
            else
            {
                Console.WriteLine("\nThe contents of the stack are:\n ");
                for (i = top; i >= 0; i--)
                    Console.WriteLine(stack_arr[i]);
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            StacksArray Stk = new StacksArray();
            char choice;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\nMenu");
                Console.WriteLine("\n1. Push.");
                Console.WriteLine("\n2. Pop");
                Console.WriteLine("\n3. Display");
                Console.WriteLine("\n4. Exit");

                Console.Write("\nEnter your choise: ");

                choice = Convert.ToChar(Console.ReadLine());
                switch (choice)
                {
                    case '1':
                        int item;
                        if (Stk.full())
                        {
                            Console.WriteLine("\n Stack full");
                            break;
                        }
                        Console.Write("\nEnter a number:");
                        item = Convert.ToInt32(Console.ReadLine());
                        Stk.push(item);
                        break;
                    case '2':
                        if (Stk.empty())
                        {
                            Console.WriteLine("\nStack empty");
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
                        Console.WriteLine("\nInvalid choise");
                        break;
                }
            }
        }
    }
}

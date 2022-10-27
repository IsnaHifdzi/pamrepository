using System;

namespace Singly_Linked_List
{
    /*Each node consist of the information part and a lik to the next node*/
    class node
    {
        public int rollNumber;
        public string name;
        public node next;
    }

    class list
    {
        node START;
        public list()
        {
            START = null;
        }

        public void addNode()/*Adds a Node in the list*/
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            node newnode = new node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            /*If the node to be inserted is the first node*/
            if (START == null || rollNo >= START.rollNumber)
            {
                if ((START != null) && (rollNo == START.rollNumber))
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }
            /*Locate the position of the new node in the list */
            node previous, current;
            previous = START;
            current = START;
            while ((current != null) && (rollNo >= current.rollNumber))
            {
                if (rollNo == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed\n");
                    return;
                }
                previous = current;
                current = current.next;
            }
            /*Once the above for loop is executed, prev and current are 
             positioned in such
             a manner that the position for the new node is in between them.*/

            newnode.next = current;
            previous.next = newnode;
        }

        public bool delNode(int rollNo) /*Deletes the specified node from the list*/
        {
            node previous, current;
            previous = current = null;
            /*checks if the specified node is present in the list or not*/
            if (Search(rollNo, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == START)
                START = START.next;
            return true;
        }

        /*Checks wheter th specified node is present in the list or not*/
        public bool Search(int rollNo, ref node previous, ref node current)
        {
            previous = START;
            current = START;

            while ((current != null) && (rollNo != current.rollNumber))
            {
                previous = current;
                current = current.next;
            }

            if (current == null)
                return (false);
            else
                return (true);
        }

        public void traverse()/*Traverses the list*/
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty.\n");
            else
            {
                Console.WriteLine("\nThe records in the list are :\n");
                node currentnode;
                for (currentnode = START; currentnode != null;
                currentnode = currentnode.next)
                    Console.WriteLine(currentnode.rollNumber + " " + currentnode.name + "\n");
                Console.WriteLine();
            }
        }

        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            list obj = new list();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Add a record to the list");
                    Console.WriteLine("2. Delete a record from the list");
                    Console.WriteLine("3. View all the records in the list");
                    Console.WriteLine("4. Search for a record in the list");
                    Console.WriteLine("5. Exit");
                    Console.Write("\nEnter your choice (1-5): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                            case '1':
                            {
                                obj.addNode();
                            }
                            break;
                            case '2':
                            {
                                if (obj.listEmpty())
                                {
                                    Console.WriteLine("\nList is empty");
                                    break;
                                }
                                Console.Write("\nEnter the roll number of" + "The student whose record is to be deleted:");
                                int rollNo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                if (obj.delNode(rollNo) == false)
                                    Console.WriteLine("\nRecord not found.");
                                else
                                    Console.WriteLine("Record with roll number" + rollNo + " Deleted ");
                            }
                            break;
                            case '3':
                            {
                                obj.traverse();
                            }
                            break;
                            case '4':
                            {
                                if (obj.listEmpty() == true)
                                {
                                    Console.WriteLine("\nList is empty");
                                    break;
                                }
                                node previous, current;
                                previous = current = null;
                                Console.Write("\nEnter the roll number of the" +
                                    "Student whose record is to be searched: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (obj.Search(num, ref previous, ref current) == false)
                                    Console.WriteLine("\nRecord not found.");
                                else
                                {
                                    Console.WriteLine("\nRecord found");
                                    Console.WriteLine("\nRoll nymber :" + current.rollNumber);
                                    Console.WriteLine("\nName: " + current.name);
                                }

                            }
                            break;
                            case '5':
                            return;
                            default:
                            {
                                Console.WriteLine("\nInvalid option");
                                break;
                            }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("\nCheck for the value entered.");
                }
            }
        }
    }
}
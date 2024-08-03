using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SingleLinkedList
{
    public class SingleLinkedList
    {
        public Node head;

        public SingleLinkedList()
        {
            head = null;
        }


        public void DisplayList()
        {
            Node p;
            if(head == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            Console.Write("LinkedList is: ");

            p = head;

            while(p != null)
            {
                Console.Write(p.data + " ");
                p = p.next;
            }
        }

        public void CountNodes()
        {
            int i = 0;

            Node p = head;
            while(p != null)
            {
                i++;
                p = p.next;
            }

            Console.WriteLine("No. of Nodes: " + i);
        }

        public bool Search(int x)
        {
            Node p = head;
            int position = 1;

            while(p.next != null)
            {
                if (p.data == x)
                    break;
                position++;
                p = p.next;
            }

            if(p == null)
            {
                Console.WriteLine(x + " not found in the list");
                return false;
            }
            else
            {
                Console.WriteLine(x + " found at position " + position);
                return true;
            }
        }

        public void CreateList()
        {
            int n, data;
            Console.Write("Enter the Number of Nodes: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            for(int i=0; i < n; i++)
            {
                Console.Write("Enter the node: ");
                data = Convert.ToInt32(Console.ReadLine());
                InsertAtEnd(data);
            }
        }

        public void InsertAtEnd(int data)
        {
            Node p;
            Node temp = new Node(data);

            if(head == null)
            {
                head = temp;
                return;
            }

            p = head;

            while(p.next != null)
            {
                p = p.next;
            }

            p.next = temp;
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);

            if (head == null)
            {
                head = temp;
                return;
            }

            temp.next = head;
            head = temp;
        }

        //public void InsertAtEnd(int data)
        //{
        //    Node p;
        //    Node temp = new Node(data);

        //    if (head == null)
        //    {
        //        head = temp;
        //        return;
        //    }

        //    p = head;

        //    while (p.next != null)
        //    {
        //        p = p.next;
        //    }

        //    p.next = temp;
        //}

        public void InsertAfter(int data, int x)
        {
            Node p;
            Node temp = new Node(data);

            if (head == null)
                return;

            p = head;

            while(p != null)
            {
                if(p.data == x)
                {
                    temp.next = p.next;
                    p.next = temp;
                    break;
                }

                p = p.next;
            }
            if(p == null)
                Console.WriteLine(x + " not present in the list");
        }

        public void InsertBefore(int data, int x)
        {
            Node p;
            Node temp = new Node(data);

            p = head;

            if(x == head.data)
            {
                temp.next = head;
                head = temp;
                return;
            }

            while(p.next != null)
            {
                if(p.next.data == x)
                {
                    temp.next = p.next;
                    p.next = temp;
                    break;
                }

                p = p.next;
            }

            if (p == null)
                Console.WriteLine(x + " not present in the list");
        }

        public void InsertAtPosition(int data, int k)
        {
            Node p;
            Node temp = new Node(data);
            int i;
            p = head;

            if (k == 1)
            {
                temp.next = head;
                head = temp;
                return;
            }

            for (i = 1; i < k-1 && p!=null; i++)
            {
                p = p.next;
            }

            if(p == null)
            {
                Console.WriteLine("You can insert only upto " + i + "th position");
            }
            else
            {
                temp.next = p.next;
                p.next = temp;
            }
        }
    }
}

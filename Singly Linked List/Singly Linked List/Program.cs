using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_Linked_List
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int i)
        {
            Data = i;
            Next = null;
        }
        public void print()
        {
            Console.Write("|" + Data + "|->");
            if (Next != null)
            {
                Next.print();
            }

        }

        public void AddToEnd(int i)
        {
            if (Next == null)
            {
                Next = new Node(i);
            }
            else
            {
                Next.AddToEnd(i);
            }
        }

        public void AddSorted(int i)
        {
            if (Next == null)
            {
                Next = new Node(i);
            }
            else if (i < Next.Data)
            {
                Node temp = new Node(i);
                temp.Next = this.Next;
                this.Next = temp;
            }
            else
            {
                Next.AddSorted(i);
            }
        }


    }
    public class MyList
    {
        public Node HeadNode;

        public MyList()
        {
            HeadNode = null;
        }

        public void AddToEnd(int i)
        {
            if (HeadNode == null)
            {
                HeadNode = new Node(i);
            }
            else
            {
                HeadNode.AddToEnd(i);
            }

        }
        public void AddToBeginning(int i)
        {
            if (HeadNode == null)
            {
                HeadNode = new Node(i);
            }
            else
            {
                Node temp = new Node(i);
                temp.Next = HeadNode;
                HeadNode = temp;
            }
        }

        public void AddSorted(int i)
        {
            if (HeadNode == null)
            {
                HeadNode = new Node(i);
            }
            else if (HeadNode.Data > i)
            {
                AddToBeginning(i);
            }
            else
            {
                HeadNode.AddSorted(i);
            }

        }

        public void print()
        {
            if (HeadNode != null)
            {
                HeadNode.print();
            }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList List = new MyList();

            List.AddToBeginning(4);
            List.AddToEnd(6);
            List.AddSorted(5);

            List.print();

            Console.ReadLine();

        }
    }
}

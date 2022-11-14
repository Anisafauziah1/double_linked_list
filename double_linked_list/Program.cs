using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace double_linked_list
{
    class Node
    {
        /* Node class represents the node of doubly linked list
         * it consists of the information part and links to
         * its suceeding and preceeding
         * in terms of the next and previous */
        public int noMhs;
        public string name;
        //point to the suceeding node
        public Node next;
        //point to the preceeding node
        public Node prev;
    }
    class DoubleLinkedList
    {
        Node START;

        //constructor
        public DoubleLinkedList() 
        {
            START = null;
        }
        public void addNode() 
        {
            int nim;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;
        }


    }
    class program 
    {
        static void Main(string[] args)
        {
        }
    }
       
        
    
}

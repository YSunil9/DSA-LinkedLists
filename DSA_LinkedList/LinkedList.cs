using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA_LinkedList
{
    internal class LinkedList
    {
        internal Node head;
        public void add(int id)
        {
            Node node = new Node(id);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} is inserted in to linked list", node.id);
        }
        public void add2(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                this.head = node;
            }
            else
            {
                node.next = head;
                head = node;
            }
            Console.WriteLine(node.id + " Added\n");
        }
        public void Display()
        {
            Node currentNode = this.head;
            if (currentNode == null)
            {
                Console.WriteLine("Linked List Is Empty");
            }
            else
            {
                Console.WriteLine("LinkedList Sequence:");
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.id + " ");
                    currentNode = currentNode.next;
                }
            }

        }
    }
}

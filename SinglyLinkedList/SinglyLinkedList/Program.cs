using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList myList = new SinglyLinkedList();
            myList.insertFist(100);
            myList.insertFist(50);
            myList.insertFist(99);
            myList.insertFist(88);
            myList.insertLast(999000);
            myList.displayList();
            myList.deleteFirst();
            myList.displayList();
                

            // Console.WriteLine("Hello World!");
        }
    }
    public class SinglyLinkedList
    {
        private Node first;
        public bool isEmpty()
        {
            return (first == null);
        }
        public void insertFist(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;

        }
        public Node deleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }
        public void displayList()
        {
            Console.WriteLine("List (first----last)");
            Node current = first;
            while (current != null)
            {
                current.displayNode();
                current = current.next;

            }
            Console.WriteLine();

        }
        public void insertLast(int data)
        {
            Node current = first;
            while (current.next!= null)
            {
                current = current.next;
            }
            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
    }
        public class Node
        {
            public int data;
            public Node next;
            public void displayNode()
            {
                Console.WriteLine("<" + data+">");


            }
        }
    
}

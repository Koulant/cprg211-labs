using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_Using_a_Singly_Linked_List
{
    public class SinglyLinkedList<T>
    {
        //Properties
        public Node<T> First; //Head
        public Node<T> Last; //Tail
        public int Count; //Address/Index/Pointer

        //Constructor
        public SinglyLinkedList() 
        {
            this.First = null; //Head
            this.Last = null; //Tail
        }

        //Methods
        //InsertFront: inserts a node at the beginning of an SLL
        public void InsertFirst(SinglyLinkedList<T> singlyLinkedList, T data) //Object or data required as a parameter?
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = singlyLinkedList.First;
            singlyLinkedList.First = newNode;
        }

        //InsertLast: inserts a node at the end of an SLL
        public void InsertLast(SinglyLinkedList<T> singlyLinkedList, T data)
        {
            Node<T> newNode = new Node<T>(data);
            if(singlyLinkedList.First != null)
            {
                singlyLinkedList.First = newNode;
                return;
            }
            Node<T> lastNode = GetLastNode(singlyLinkedList);
            lastNode.Next = newNode;
        }
        //GetLastNode: gets the last item of an SLL
        public Node<T> GetLastNode(SinglyLinkedList<T> singlyLinkedList)
        {
            Node<T> tempNode = singlyLinkedList.First;
            while(tempNode.Next != null) 
            {
                tempNode = tempNode.Next;
            }
            return tempNode;
        }

        //InsertAfter: inserts a specific item
        public void InsertAfter(Node<T> prevNode, T data)
        {
            if(prevNode == null)
            {
                Console.WriteLine("The previous node cannot be null.");
            }
            Node<T> newNode = new Node<T>(data) ;
            newNode.Next = prevNode.Next;
            prevNode.Next = newNode;
        }

        //DeleteNodeByKey: deletes a specific node using its key
        public void DeleteNodeByKey(SinglyLinkedList<T> singlyLinkedList, int key)
        {
            Node<T> tempNode = singlyLinkedList.First;
            Node<T> prevNode = null;
            if (tempNode != null && tempNode.data == key)
            {
                singlyLinkedList.First = tempNode.Next;
                return;
            }
            while (tempNode != null && tempNode.data != key)
            {
                prevNode = tempNode;
                tempNode = tempNode.Next;
            }
            if (tempNode == null)
            {
                return;
            }
            prevNode.Next = tempNode.Next;
        }

        //ReverseLinkedList: reverses the SLL (completed using iterative method)

        public void ReverseLinkedList(SinglyLinkedList<T> singlyLinkedList)
        {
            Node<T> prevNode = null;
            Node<T> currentNode = singlyLinkedList.First;
            Node<T> tempNode = null;
            while (currentNode != null)
            {
                tempNode = currentNode.Next;
                currentNode.Next = prevNode;
                prevNode = currentNode;
                currentNode = tempNode;
            }
            singlyLinkedList.First = prevNode;
        }
    }
}

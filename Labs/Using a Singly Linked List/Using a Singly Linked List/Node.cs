using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Using_a_Singly_Linked_List
{
    public class Node<T>
    {
        public T Data { get; set; } //Data inside the node //Something wrong with the data here?!

        public Node<T> Next; //Next node

        //public int data { get; internal set; } //Corrects error but idk why???

        public Node(T data) //Connecting all the nodes with one another
        {
            Data = data;
            Next = null; //Required line
        }
    }
}

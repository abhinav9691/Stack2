using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack1
    {
        Node top;
        public Stack1()
        {
            top = null;
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.WriteLine("|" + temp.Data + "|");
                    Console.WriteLine("__________");
                    temp = temp.Next;
                }
            }
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                top = top.Next;
            }
        }
        public void Peek()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                Node temp = top;
                Console.WriteLine(temp.Data + "is top Element");
            }
        }

    }
}

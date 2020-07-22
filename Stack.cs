using System;
using static System.Console;
namespace Stack1
{
    public class Stack
    {
        private int maxSize;
        private string[] stackArray;
        private int top;
        public Stack()
        {

        }
        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1;
        }
        public void push(string m)
        {
            if (isFull())
            {
                WriteLine("This stack is full");
            }
            else
            {
                top++;
                stackArray[top] = m;
            }
        }
        private bool isFull()
        {
            return (maxSize - 1 == top);
        }
        public string pop()
        {
            if (isEmpty())
            {
                WriteLine("The stack is empty.");
                return "--";
            }
            else
            {
                int oldTop = top;
                top--;
                return stackArray[oldTop];
            }
        }
        public string peek()
        {
            return stackArray[top];
        }
        public bool isEmpty()
        {
            return (top == -1);
        }
    }
}
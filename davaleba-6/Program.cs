using System;
using System.Collections;

namespace Davaleba_6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack s = new MyStack();
            s.Add(3);
            s.Add(5);
            s.Min();
            s.Add(2);
            s.Add(1);
            s.Min();
            s.Remove();
            s.Min();
            s.Remove();
            s.Peek();
        }
    }
    public class MyStack
    {
        public Stack s;
        public int min;

        public MyStack()
        {
            s = new Stack();
        }

        public void Min()
        {
            if (s.Count == 0)
            {
                Console.WriteLine("Stack is empty");
            }
            else 
            {
                Console.WriteLine("Minimum element in the " + " stack is: " + min);
            }
                
        }

        public void Peek()
        {
            if (s.Count == 0)
            {
                Console.WriteLine("Stack is empty ");
                return;
            }

            int t = (int)s.Peek();
            Console.Write("Top element is: ");

            if (t < min) 
            { 
                Console.WriteLine(min);
            }
            else 
            {
                Console.WriteLine(t);
            }
        }

        public void Add(int x)
        {
            if (s.Count == 0)
            {
                min = x;
                s.Push(x);
                Console.WriteLine("Number added: " + x);
                return;
            }

            if (x < min)
            {
                s.Push(2 * x - min);
                min = x;
            }

            else
                s.Push(x);

            Console.WriteLine("Number added: " + x);
        }

        public void Remove()
        {
            if (s.Count == 0)
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.Write("Element removed: ");
            int t = (int)s.Pop();

            if (t < min)
            {
                Console.WriteLine(min);
                min = 2 * min - t;
            }
            else 
            {
                Console.WriteLine(t);
            }
        }
    }
}

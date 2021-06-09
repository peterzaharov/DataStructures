using LinkedList.Model;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var circularLinkedList = new CircularLinkedList<int>();
            circularLinkedList.Add(1);
            circularLinkedList.Add(2);
            circularLinkedList.Add(3);
            circularLinkedList.Add(4);
            circularLinkedList.Add(5);
            foreach(var item in circularLinkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            circularLinkedList.Delete(3);
            foreach (var item in circularLinkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var duplexLinkedList = new DuplexLinkedList<int>();
            duplexLinkedList.Add(1);
            duplexLinkedList.Add(2);
            duplexLinkedList.Add(3);
            duplexLinkedList.Add(4);
            duplexLinkedList.Add(5);

            foreach(var item in duplexLinkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            duplexLinkedList.Delete(3);
            foreach (var item in duplexLinkedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var reverse = duplexLinkedList.Reverse();
            foreach (var item in reverse)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}

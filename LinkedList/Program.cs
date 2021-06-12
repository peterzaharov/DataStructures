using LinkedList.Model;
using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var duplexLinkedDeque = new DuplexLinkedDeque<int>();
                duplexLinkedDeque.PushFront(1);
                duplexLinkedDeque.PushFront(2);
                duplexLinkedDeque.PushFront(3);
                duplexLinkedDeque.PushBack(4);
                duplexLinkedDeque.PushBack(5);
                
                Console.WriteLine(duplexLinkedDeque.PopFront());
                Console.WriteLine(duplexLinkedDeque.PopFront());
                Console.WriteLine(duplexLinkedDeque.PopBack());
                Console.WriteLine(duplexLinkedDeque.PopBack());
                Console.WriteLine(duplexLinkedDeque.PopFront());
            }

            Console.WriteLine();

            {
                var easyDeque = new EasyDeque<int>();
                easyDeque.PushFront(1);
                easyDeque.PushFront(2);
                easyDeque.PushFront(3);
                easyDeque.PushBack(40);
                easyDeque.PushBack(50);
                easyDeque.PushFront(600);
                easyDeque.PushBack(700);



                Console.WriteLine(easyDeque.PopFront());
                Console.WriteLine(easyDeque.PopBack());
                Console.WriteLine(easyDeque.PopFront());
                Console.WriteLine(easyDeque.PopBack());
            }

            Console.WriteLine();

            {
                var linkedQueue = new LinkedQueue<int>();
                linkedQueue.Enqueue(1);
                linkedQueue.Enqueue(2);
                linkedQueue.Enqueue(3);
                linkedQueue.Enqueue(4);
                linkedQueue.Enqueue(5);

                Console.WriteLine(linkedQueue.Dequeue());
                Console.WriteLine(linkedQueue.Peek());
                Console.WriteLine(linkedQueue.Dequeue());
                Console.WriteLine(linkedQueue.Dequeue());
                Console.WriteLine(linkedQueue.Dequeue());
            }

            Console.WriteLine();
            
            var easyQueue = new EasyQueue<int>();
            easyQueue.Enqueue(1);
            easyQueue.Enqueue(2);
            easyQueue.Enqueue(3);
            easyQueue.Enqueue(4);
            easyQueue.Enqueue(5);

            Console.WriteLine(easyQueue.Dequeue());
            Console.WriteLine(easyQueue.Peek());
            Console.WriteLine(easyQueue.Dequeue());

            Console.WriteLine();

            var arrayQueue = new ArrayQueue<int>(5);
            arrayQueue.Enqueue(1);
            arrayQueue.Enqueue(2);
            arrayQueue.Enqueue(3);
            arrayQueue.Enqueue(4);
            arrayQueue.Enqueue(5);

            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Peek());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());
            Console.WriteLine(arrayQueue.Dequeue());

            Console.ReadLine();
        }
    }
}

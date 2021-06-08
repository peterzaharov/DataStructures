using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    public class LinkedStack<T>
    {
        public ItemStack<T> Head { get; set; }
        public int Count { get; set; }
        public LinkedStack()
        {
            Head = null;
            Count = 0;
        }
        public LinkedStack(T data)
        {
            var item = new ItemStack<T>(data);
            Head = item;
            Count = 1;
        }
        public void Push (T data)
        {
            var item = new ItemStack<T>(data);
            item.Previous = Head;
            Head = item;
            Count++;
        }
        public T Pop()
        {
            if(Count > 0)
            {
                var item = Head;
                Head = Head?.Previous;
                Count--;
                return item.Data;
            }
            else
            {
                throw new NullReferenceException("Стек пуст");
            }
        }
        public T Peek()
        {
            if (Count > 0)
                return Head.Data;
            else
                throw new NullReferenceException("Стек пуст");
        }
    }
}

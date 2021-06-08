﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Model
{
    public class EasyStack<T>
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;
        public bool IsEmpty => items.Count == 0;
        public void Push(T item)
        {
            items.Add(item);
        }
        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else
                throw new NullReferenceException("Стек пуст");
        }
        public T Peek()
        {
            if (!IsEmpty)
                return items.LastOrDefault();
            else
                throw new NullReferenceException("Стек пуст");
        }
        public override string ToString()
        {
            return $"Стек с {Count} элементами";
        }
    }
}

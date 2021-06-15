using System;
using System.Collections.Generic;
using System.Linq;
namespace LinkedList.Model.HashTable
{
    public class SuperHashTable<T>
    {
        private HashTableItem<T>[] items;
        public SuperHashTable(int size)
        {
            items = new HashTableItem<T>[size];

            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new HashTableItem<T>(i);
            }
        }
        public void Add(T item)
        {
            var key = GetHash(item);
            items[key].Nodes.Add(item);
        }
        public bool Search(T item)
        {
            var key = GetHash(item);
            return items[key].Nodes.Contains(item);
        }
        private int GetHash(T item)
        {
            return item.GetHashCode() % items.Length;
        }
    }
}

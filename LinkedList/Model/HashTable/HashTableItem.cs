using System.Collections.Generic;

namespace LinkedList.Model.HashTable
{
    public class HashTableItem<T>
    {
        public int Key { get; set; }
        public List<T> Nodes { get; set; }
        public HashTableItem(int key)
        {
            Key = key;
            Nodes = new List<T>();
        }
    }
}

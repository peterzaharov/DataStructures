using System;

namespace LinkedList.Model.BinarySearchTree
{
    class Node<T> : IComparable
        where T : IComparable
    {
        public T Data { get; private set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node(T data)
        {
            Data = data;
        }
        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }
        public void Add(T data)
        {
            var node = new Node<T>(data);
            if (node.Data.CompareTo(Data) == -1)
            {
                if (Left == null)
                    Left = node;
                else
                    Left.Add(data);
            }
            else
            {
                if(Right == null)
                {
                    Right = node;
                }
                else
                {
                    Right.Add(data);
                }
            }
        }

        public int CompareTo(object obj)
        {
            //return Data.CompareTo(obj);

            if (obj is Node<T> item)
            {
                return Data.CompareTo(item);
            }
            else
                throw new ArgumentException("Несовпадение типов.");
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

using System.Collections.Generic;

namespace LinkedList.Model.Trie
{
    class TrieNode<T>
    {
        public char Symbol { get; set; }
        public T Data { get; set; }
        public bool IsWord { get; set; }
        public string Prefix { get; set; }
        public Dictionary<char, TrieNode<T>> SubNodes { get; set; }
        public TrieNode(char symbol, T data, string prefix)
        {
            Symbol = symbol;
            Data = data;
            Prefix = prefix;
            SubNodes = new Dictionary<char, TrieNode<T>>();
        }
        public override string ToString()
        {
            return $"{Data} [{SubNodes.Count}] ({Prefix})";
        }
        public TrieNode<T> TryFind(char symbol)
        {
            if (SubNodes.TryGetValue(symbol, out TrieNode<T> value))
                return value;
            else
                return null;
        }
        public override bool Equals(object obj)
        {
            if (obj is TrieNode<T> item)
                return Data.Equals(item);
            else
                return false;
        }
    }
}

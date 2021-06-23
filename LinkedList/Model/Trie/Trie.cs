﻿namespace LinkedList.Model.Trie
{
    class Trie<T>
    {
        private TrieNode<T> root;
        public int Count { get; set; }
        public Trie()
        {
            root = new TrieNode<T>('\0', default(T), "");
            Count = 1;
        }
        public void Add(string key, T data)
        {
            AddNode(key, data, root);
        }
        private void AddNode(string key, T data, TrieNode<T> node)
        {
            if (string.IsNullOrEmpty(key))
            {
                if (!node.IsWord)
                {
                    node.Data = data;
                    node.IsWord = true;
                }
            }
            else
            {
                var symbol = key[0];
                var subnode = node.TryFind(symbol);
                if (subnode != null)
                {
                    AddNode(key.Substring(1), data, subnode);
                }
                else
                {
                    var newNode = new TrieNode<T>(key[0], data, node.Prefix + key[0]);
                    node.SubNodes.Add(key[0], newNode);
                    AddNode(key.Substring(1), data, newNode);
                }
            }
        }
        public void Remove(string key)
        {
            RemoveNode(key, root);
        }
        private void RemoveNode(string key, TrieNode<T> node)
        {
            if (string.IsNullOrEmpty(key))
            {
                if (node.IsWord)
                {
                    node.IsWord = false;
                }
                else
                {
                    var subnode = node.TryFind(key[0]);
                    if(subnode != null)
                    {
                        RemoveNode(key.Substring(1), subnode);
                    }
                }
            }
        }
        public bool TrySearch(string key, out T value)
        {
            return SearchNode(key, root, out value);
        }
        private bool SearchNode(string key, TrieNode<T> node, out T value)
        {
            value = default(T);
            var result = false;
            if (string.IsNullOrEmpty(key))
            {
                if (node.IsWord)
                {
                    value = node.Data;
                    result = true;
                }
            }
            else
            {
                var subnode = node.TryFind(key[0]);
                if (subnode != null)
                {
                    result = SearchNode(key.Substring(1), subnode, out value);
                }
            }
            return result;
        }
    }
}

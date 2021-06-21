using System;
using System.Collections;

namespace LinkedList.Model.Map
{
    public class Dict<TKey, TValue> : IEnumerable
    {
        private int size = 100;
        private MapItem<TKey, TValue>[] Items;
        public Dict()
        {
            Items = new MapItem<TKey, TValue>[size];
        }
        public void Add(MapItem<TKey, TValue> item)
        {
            var hash = GetHash(item.Key);

            if (Items[hash] == null)
            {
                Items[hash] = item;
            }
            else
            {
                var placed = false;
                for (int i = hash; i < size; i++)
                {
                    if (Items[i] == null)
                    {
                        Items[i] = item;
                        placed = true;
                        break;
                    }

                    if (Items[i].Key.Equals(item.Key))
                    {
                        return;
                    }
                }

                if (!placed)
                {
                    for (int i = 0; i < hash; i++)
                    {
                        if (Items[i] == null)
                        {
                            Items[i] = item;
                            placed = true;
                            break;
                        }

                        if (Items[i].Key.Equals(item.Key))
                        {
                            return;
                        }
                    }
                }

                if (!placed)
                {
                    throw new Exception("Словарь заполнен");
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in Items)
            {
                if (item != null)
                {
                    yield return item;
                }
            }
        }

        public void Remove(TKey key)
        {
            var hash = GetHash(key);
            
            if (Items[hash] == null)
            {
                return;
            }

            if (Items[hash].Key.Equals(key))
            {
                Items[hash] = null;
            }
            else
            {
                var placed = false;
                for (int i = hash; i < size; i++)
                {
                    if (Items[i] == null)
                    {
                        return;
                    }

                    if (Items[i].Key.Equals(key))
                    {
                        Items[i] = null;
                        return;
                    }
                }

                if (!placed)
                {
                    for (int i = 0; i < hash; i++)
                    {
                        if (Items[i] == null)
                        {
                            return;
                        }

                        if (Items[i].Key.Equals(key))
                        {
                            Items[i] = null;
                            return;
                        }
                    }
                }
            }
        }
        public TValue Search (TKey key)
        {
            var hash = GetHash(key);

            if (Items[hash] == null)
            {
                return default(TValue);
            }

            if (Items[hash].Key.Equals(key))
            {
                return Items[hash].Value;
            }
            else
            {
                var placed = false;
                for (int i = hash; i < size; i++)
                {
                    if (Items[i] == null)
                    {
                        return default(TValue);
                    }

                    if (Items[i].Key.Equals(key))
                    {
                        return Items[i].Value;
                    }

                    
                }

                if (!placed)
                {
                    for (int i = 0; i < hash; i++)
                    {
                        if (Items[i] == null)
                        {
                            return default(TValue);
                        }

                        if (Items[i].Key.Equals(key))
                        {
                            return Items[i].Value;
                        }
                    }
                }
            }
            return default(TValue);
        }
        private int GetHash(TKey key)
        {
            return key.GetHashCode() % size;
        }
    }
}

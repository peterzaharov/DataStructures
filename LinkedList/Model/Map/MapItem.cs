namespace LinkedList.Model.Map
{
    public class MapItem<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public MapItem(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
    }
}

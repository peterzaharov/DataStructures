namespace LinkedList.Model
{
    public class QueueDuplexItem<T>
    {
        public T Data { get; set; }
        public QueueDuplexItem<T> Next { get; set; }
        public QueueDuplexItem<T> Privious { get; set; }
        public QueueDuplexItem(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

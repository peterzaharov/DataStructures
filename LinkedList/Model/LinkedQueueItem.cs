namespace LinkedList.Model
{
    public class LinkedQueueItem<T>
    {
        public T Data { get; set; }
        public LinkedQueueItem<T> Next { get; set; }
        public LinkedQueueItem(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}

namespace LinkedList.Model
{
    public class DuplexLinkedDeque<T>
    {
        private QueueDuplexItem<T> Head;
        private QueueDuplexItem<T> Tail;
        public int Count { get; private set; }
        public DuplexLinkedDeque() { }
        public DuplexLinkedDeque(T data)
        {
            SetHeadItem(data);
        }

        private void SetHeadItem(T data)
        {
            var item = new QueueDuplexItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public void PushBack(T data)
        {
            if(Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new QueueDuplexItem<T>(data);
            item.Next = Tail;
            Tail.Privious = item;
            Tail = item;
            Count++; 
        }
        public void PushFront(T data)
        {
            if (Count == 0)
            {
                SetHeadItem(data);
                return;
            }

            var item = new QueueDuplexItem<T>(data);
            item.Privious = Head;
            Head.Next = item;
            Head = item;
            Count++;
        }
        public T PopBack()
        {
            if (Count > 0)
            {
                var result = Tail.Data;
                var current = Tail.Next;
                current.Privious = null;
                Tail = current;
                Count--;
                return result;
            }
            else
                return default(T);
        }
        public T PopFront()
        {
            if (Count > 0)
            {
                var result = Head.Data;
                var current = Head.Privious;
                current.Next = null;
                Head = current;
                Count--;
                return result;
            }
            else
                return default(T);
        }
        public T PeekBack()
        {
            return Tail.Data;
        }
        public T Peek()
        {
            return Head.Data;
        }
    }
}

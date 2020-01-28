namespace HashTable_implimentation
{
    class HList<T>
    {
        private Link<T> head;
        public HList()
        {
            head = null;
        }

        public void Push(T value)
        {
            if (head == null) head = new Link<T>(value);
            else head.Push(value);
        }

        public T Pop()
        {

        }
    }
}

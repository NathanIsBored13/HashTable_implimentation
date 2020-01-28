using System;

namespace HashTable_implimentation
{
    class Link<T>
    {
        T value;
        Link<T> child;
        public Link(T value)
        {
            this.value = value;
        }

        public void Push (T value)
        {
            if (child == null) child = new Link<T>(value);
            else child.Push(value);
        }

        public Tuple<T, bool> Remove(Func<T, bool> check)
        {
            Tuple<T, bool> ret;
            if (check(value)) ret = Tuple.Create(value, true);
            else if (child == null) ret = Tuple.Create<T, bool>(default, false);
            else
            {
                ret = child.Remove(check);
                if (ret.Item2) child = child.GetChild();
            }
            return ret;
        }

        public Link<T> GetChild() => child;
    }
}

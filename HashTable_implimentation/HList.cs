using System;

namespace HashTable_implimentation
{
    class HList<X>
    {
        private Link<X> head;
        public HList()
        {
            head = null;
        }

        public bool Append(X value, string key)
        {
            bool ret = true;
            if (head == null) head = new Link<X>(value, key);
            else ret = head.Append(value, key);
            return ret;
        }

        public X Get(string key) => head == null ? default : head.Get(key);

        public X Remove(string key)
        {
            Tuple<X, bool, Link<X>> ret = Tuple.Create<X, bool, Link<X>>(default, false, null);
            if (head != null)
            {
                ret = head.Remove(key);
                if (ret.Item2) head = ret.Item3;
            }
            return ret.Item1;
        }

        public void Print(int index)
        {
            if (head != null) Console.WriteLine($"{index}: {head.Print("")}");
        }
    }
}

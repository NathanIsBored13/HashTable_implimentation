using System;

namespace HashTable_implimentation
{
    internal class Link<X>
    {
        X value;
        string key;
        Link<X> child;
        public Link(X value, string key)
        {
            this.value = value;
            this.key = key;
            child = null;
        }

        public bool Append (X value, string key)
        {
            bool ret;
            if (key == this.key) ret = false;
            else if (child == null)
            {
                child = new Link<X>(value, key);
                ret = true;
            }
            else ret = child.Append(value, key);
            return ret;
        }

        public X Get(string key) => key == this.key ? value : child == null ? default : child.Get(key);

        public Tuple<X, bool, Link<X>> Remove(string key)
        {
            Tuple<X, bool, Link<X>> ret;
            if (key == this.key) ret = Tuple.Create(value, true, child);
            else if (child == null) ret = Tuple.Create<X, bool, Link<X>>(default, true, null);
            else
            {
                ret = child.Remove(key);
                if (ret.Item2)
                {
                    child = ret.Item3;
                    ret = Tuple.Create<X, bool, Link<X>>(ret.Item1, false,  null);
                }
            }
            return ret;
        }

        public string Print(string value)
        {
            value += string.Format("{0}{1}", value.Length == 0 ? "" : ", ", this.value);
            if (child != null) value = child.Print(value);
            return value;
        }
    }
}

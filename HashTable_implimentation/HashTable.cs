using System;

namespace HashTable_implimentation
{
    class HashTable<X, Y>
    {
        public HList<X>[] table;
        Func<X, Y> index;
        Func<Y, int> hash;
        public HashTable(Func<X, Y> index, Func<Y, int> hash, int range)
        {
            this.index = index;
            this.hash = hash;
            table = new HList<X>[range];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new HList<X>();
            }
        }

        public bool Add(X value) => table[hash(index(value)) % table.Length].Append(value, index(value).ToString());

        public bool Remove(Y key) => table[hash(key) % table.Length].Remove(key.ToString());

        public X Get(Y key) => table[hash(key) % table.Length].Get(key.ToString());

        public void Print()
        {
            for (int i = 0; i < table.Length; i++)
            {
                table[i].Print(i);
            }
        }

    }
}

using System;

namespace HashTable_implimentation
{
    class HashTable<T>
    {
        public HList<T>[] table;
        Func<int, int> hash;
        public HashTable(Func<int, int> hash, int range)
        {
            this.hash = hash;
            table = new HList<T>[range];
        }
    }
}

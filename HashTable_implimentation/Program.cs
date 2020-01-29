using System;

namespace HashTable_implimentation
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable<Tuple<string, int>, string> table = new HashTable<Tuple<string, int>, string>(x => x.Item1, x => char.ToUpper(x[0]) - 65, 26);
            bool exit = false;
            do
            {
                Console.Write("> ");
                string[] input = Console.ReadLine().Split(" ");
                Tuple<string, int> ret;
                switch (input[0].ToLower())
                {
                    case "print":
                        table.Print();
                        break;
                    case "add":
                        if (table.Add(Tuple.Create(input[1], int.Parse(input[2])))) Console.WriteLine("item added sucsesfuly");
                        else Console.WriteLine("item could not be added");
                        break;
                    case "remove":
                        if (table.Remove(input[1])) Console.WriteLine("item removed sucsesfuly");
                        else Console.WriteLine("item could not be removed");
                        break;
                    case "get":
                        ret = table.Get(input[1]);
                        if (ret == default) Console.WriteLine("item does not exist");
                        else Console.WriteLine(ret);
                        break;
                    case "q":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("invalid comand");
                        break;
                }
                Console.WriteLine();
            } while (!exit);
        }
    }
}

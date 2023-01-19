using System.Collections.Generic;

namespace DSA_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To DataStructure\n");
            LinkedList list = new LinkedList();
            //list.add(56);
            //list.add(30);
            //list.add(70);

            //list.add2(70);
            //list.add2(30);
            //list.add2(56);
            //list.Display();
            //Console.ReadLine();

            //list.Append(56);
            //list.Append(30);
            //list.Append(70);
            //list.Display();

            //list.add(56);
            //list.add(70);
            //Console.WriteLine("Before insert");
            //list.Display();
            //Console.WriteLine("After insert");
            //list.Insert(2,30);
            //list.Display();

            list.add(56);
            list.add(30);
            list.add(70);
            Console.WriteLine("--------------------");
            Console.WriteLine("Values Present in The List");
            list.Display();
            list.RemoveFirst();
            Console.WriteLine("After Deleting The First Value");
            list.Display();
        }
    }
}
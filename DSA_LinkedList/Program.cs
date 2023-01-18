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
    
            list.add2(70);
            list.add2(30);
            list.add2(56);
            list.Display();
            Console.ReadLine();
        }
    }
}
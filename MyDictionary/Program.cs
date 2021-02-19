using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> name1 = new MyDictionary<int, string>();
            name1.Add(1, "Bengisu");
            name1.Add(2, "Nursu");
            name1.Add(3, "Ahmet");
            name1.Add(4, "Mehmet");
            name1.Add(5, "Fatma");
            name1.Add(6, "Mustafa");
            Console.WriteLine("MyDictionary : "+name1.count );

            

            MyDictionary<int, string> name2 = new MyDictionary<int, string>();
            name2.Add(1, "Kerem");
            name2.Add(2, "Ayşe");
            name2.Add(3, "Dicle");
            name2.Add(4, "Mahmut");
            name2.Add(5, "Efe");
            name2.Add(6, "Mert");
            Console.WriteLine("MyDictionary : " + name2.count);
           
            



        }
    }
}

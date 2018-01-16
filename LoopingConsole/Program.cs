using System;
using System.Collections.Generic;

namespace LoopingConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var children = new List<Child>
            {
                new Child { Name = "Suzy", Sick = false },
                new Child { Name = "Ralph", Sick = true }
            };

            //for (var i = 0; i < children.Count - 1; i++)
            //{
            //    var child = children[i];
            //    Console.WriteLine($"{child.Name} is {(child.Sick ? "sick" : "healthy")}");
            //    Console.WriteLine(child.ForgeASickNote());
            //}

            foreach (var child in children)
            {
                Console.WriteLine($"{child.Name} is {(child.Sick ? "sick" : "healthy")}");
                Console.WriteLine(child.ForgeASickNote());
            }

            Console.WriteLine("This is our second time talking about the same thing.");

            var lineIRead = Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var originalInstanceResourceListWrapper = ClientResourceListWrapper.GetInstance();
            originalInstanceResourceListWrapper.AddResources(new List<Resource>
            {
                new Resource { SomeBoolProp = true, SomeIntProp = 123, SomeStringProp = "some string prop 1" },
                new Resource { SomeBoolProp = false, SomeIntProp = 321, SomeStringProp = "some string prop 2" },
                new Resource { SomeBoolProp = true, SomeIntProp = 213, SomeStringProp = "some string prop 3" },
                new Resource { SomeBoolProp = false, SomeIntProp = 312, SomeStringProp = "some string prop 4" }
            });

           
            var anotherInstanceResourceListWrapper = ClientResourceListWrapper.GetInstance();

            Console.WriteLine("Before Changes/Updates\n");
            Console.WriteLine("originalInstanceResourceListWrapper");
            originalInstanceResourceListWrapper.EnumerateResources();

            Console.WriteLine("\n");
            Console.WriteLine("anotherInstanceResourceListWrapper");
            anotherInstanceResourceListWrapper.EnumerateResources();

            
            originalInstanceResourceListWrapper.AddResources(new List<Resource>
            {
                new Resource { SomeBoolProp = false, SomeIntProp = 456, SomeStringProp = "some string prop 5" },
                new Resource { SomeBoolProp = true, SomeIntProp = 546, SomeStringProp = "some string prop 6" },
                new Resource { SomeBoolProp = false, SomeIntProp = 654, SomeStringProp = "some string prop 7" },
                new Resource { SomeBoolProp = true, SomeIntProp = 645, SomeStringProp = "some string prop 8" }
            });

            Console.WriteLine("\nAfter Changes/Updates\n");
            Console.WriteLine("originalInstanceResourceListWrapper");
            originalInstanceResourceListWrapper.EnumerateResources();

            Console.WriteLine("\n");
            Console.WriteLine("anotherInstanceResourceListWrapper");
            anotherInstanceResourceListWrapper.EnumerateResources();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program : ProgramBase
    {
        class products
        {
            public string name;
            public float id;
            public string cat;
            public string country;
            public string brand_name;
            public decimal price;
        }
        static char menu()
        {
            char choice;
            Console.WriteLine("Press 1. Add Products:");
            Console.WriteLine("Press 2. Show data");
            Console.WriteLine("Press 3. Exit");
            choice = char.Parse(Console.ReadLine());
            return choice;
        }

        static products addProducts()
        {
            products p1 = new products();
            Console.WriteLine("Enter product name:");
            p1.name = Console.ReadLine();
            Console.WriteLine("Enter product id:");
            p1.id = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter product category:");
            p1.cat = Console.ReadLine();
            Console.WriteLine("Enter product country:");
            p1.country = Console.ReadLine();
            Console.WriteLine("Enter product brand name:");
            p1.brand_name = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            p1.price = decimal.Parse(Console.ReadLine());
            float add = p1.id + (float)p1.price;
            Console.WriteLine(add);
            Console.Read();
            return p1;
        }


        static void viewProducts(products[] p, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Product Name: {p[i].name}, ID: {p[i].id}, Category: {p[i].cat}, Country: {p[i].country}, Brand: {p[i].brand_name}, Price: {p[i].price}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            products[] p = new products[10];
            char op;
            int count = 0;
            do
            {
                op = menu();
                if (op == '1')
                {
                    p[count] = addProducts();
                    count = count + 1;
                }
                else if (op == '2')
                {
                    viewProducts(p, count);
                }
            } while (op != '3');
            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}

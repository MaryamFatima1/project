using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selftask2
{
    class Program
    {
        static void Main(string[] args)
        {
           //  float Total_money;
            //float Total_toys;
          //  float Total_saved;
          //  float Lilly_brother;
            //float age=0F;
             //float washing_machine_price=0F;
            // float toy_price=0F;
            // Console.WriteLine("enter lillys age: ");
           // age= float.Parse(Console.ReadLine());
            // Console.WriteLine("enter washing machine price:");
          //  washing_machine_price= float.Parse(Console.ReadLine());
            //Console.WriteLine("enter toy_price: ");
            //toy_price= float.Parse(Console.ReadLine());
            //float num = 1.00F;
            //  Lilly_brother = age * num;
           // Console.WriteLine(" lillys brother: ");
            // Console.Write(Lilly_brother);
          
           // Total_saved = (age + 1) - Lilly_brother;
            //Console.WriteLine(" total saved is: ");
            // Console.Write(Total_saved);
           
           // Total_toys = age * toy_price;
            // Console.WriteLine(" total toy is: ");
           // Console.Write(Total_toys);
           
            //Total_money = Total_toys + Total_saved;
             //Console.WriteLine(" total money is: ");
            // Console.Write(Total_money);
             //if (Total_money >= washing_machine_price)
         // {
             // Console.WriteLine("yes! ");
            // }
            // else
             // {
             //Console.WriteLine(" no! ");
             //}
            // Console.ReadKey();


            //3manual
          float min_order=0F;
           float min_order_prize=0F;
          Console.WriteLine("minimum order: ");
          min_order= float.Parse (Console.ReadLine());
           
            Console.WriteLine("minimum order prize: ");
          min_order_prize=float.Parse (Console.ReadLine());
            
          float sum;
           
           sum = ( min_order + min_order_prize);
            Console.WriteLine("the sum is: ");
            Console.Write(sum);
           if (sum <= 600)
            {
                 Console.WriteLine("they get free pizza");
             }
        else
         {
               Console.WriteLine("they pay bill");
           
           }
         Console.ReadKey();
            int option;
            Console.WriteLine("1.signIn");
            Console.WriteLine("2.signUp");
            Console.WriteLine("Enter Option ");
            option = int.Parse(Console.ReadLine());
            return option;

        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        static void readData(string path, string[] names, string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                streamReader fileVariable = new streamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    names[x] = parseData(record, 1);
                    password[x] = parseData(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                fileVariable.close();
            }
            else
            {
                Console.WriteLine("not exit");
            }
        }
        static void signIn(string n, string p, string[] names, string[] password)
        {
            bool flag = false;
            for (int x = 0; x < 5; x++)
            {
                if (n == names[x] && p == password[x])
                {
                    Console.WriteLine("invalid user");
                }
                Console.ReadKey();
            }
            static void signUp(string path, string n, string p)
            {
                streamWriter file = new streamWriter(path, true);
                file.WriteLine(n + " ," + p);
                file.Flush();
                file.Close();
            }
        }
    }
}


        
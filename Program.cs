using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3
{
    class Program
    {
        static int Main()
        {
            //task3
            //string variable = "iam girl";
            // Console.WriteLine("string: ");
            //Console.WriteLine(variable);
            //Console.ReadKey();
            // task4
            // char variable = 'A';
            //Console.WriteLine("Character: ");
            // Console.Write(variable);
            //Console.ReadKey();

            //task5
            //float variable = 2.2F;
            //Console.WriteLine("string: ");
            // Console.Write(variable);
            // Console.ReadKey();

            //task6
            //string str;
            // str = Console.ReadLine();
            // Console.WriteLine("You have inputted: ");
            // Console.WriteLine(str);
            // Console.ReadKey();

            //task7
            // string str;
            //str = Console.ReadLine();
            // Console.WriteLine("you have inputted");
            // int num = int.Parse(str);
            // Console.WriteLine("string: ");
            // Console.WriteLine("the number is: ");
            // Console.Write(num);
            // Console.ReadKey();


            //task8
            // string str;
            //Console.WriteLine("enter Floating point values");
            //str = Console.ReadLine();
            //float num = float.Parse(str);
            //Console.WriteLine("the floating value is: ");
            //Console.Write(num);
            // Console.ReadKey();


            //task 9

            //float length;
            //float area;
            //string str;
            //Console.WriteLine("enter length: ");
            //str = Console.ReadLine();
            //length = float.Parse(str);
            //area = length * length;
            //Console.WriteLine("the area is: ");
            // Console.Write(area);
            // Console.ReadKey();



            // selftask
            //task1
            // Console.Write("  ");
            // Console.ReadLine();


            //task2
            //float area;
            //float length;
            //string str;
            //Console.WriteLine("enter length:");
            //str = Console.ReadLine();
            // length = float.Parse(str);
            // area = length * length;
            // Console.WriteLine("the area is:   ");
            // Console.Write(area);
            // Console.ReadKey();

            //task3
            //float variable;
            //string str;
            // Console.WriteLine("enter the value:");
            // str = Console.ReadLine();
            //variable = float.Parse(str);
            //Console.ReadKey();

            //task4

            // string str;
            // Console.WriteLine("the value is:");
            // str = Console.ReadLine();
            //float value= float.Parse(str);
            //Console.ReadKey();

            //task5
            //float area;
            //float length;
            // string str;
            // Console.WriteLine("the area is: ");
            // str = Console.ReadLine();
            //length = float.Parse(str);
            //area = length * length;
            //Console.WriteLine("the area is:");
            // Console.Write(area);
            // Console.ReadKey();

            //labmnaual2
            //task1
            //string input;
            // float marks;
            //Console.Write("write the mars:");
            //input = Console.ReadLine();
            //marks = float.Parse(input);
            //if (marks >=50)
            //{
            //    Console.WriteLine("you are passed");
            //}
            //else
            //{
            //    Console.WriteLine("you are failed");
            // }
            // Console.Read();

            //task2
            // for(int x = 0; x < 5; x++)
            //{
            //    Console.WriteLine("welcome jack");
            //}
            //Console.Read();

            //task3
            //int num;
            //int sum = 0;
            //Console.WriteLine("ener number: ");
            //num = int.Parse(Console.ReadLine());
            //while (num != -1)
            //{
            // sum = sum + num;
            //// Console.Write("enter number:");
            //num = int.Parse(Console.ReadLine());

            // }
            //Console.WriteLine("the total sum  is {0}", sum);
            //Console.Read();

            //labmanual3

            int option;
            Console.WriteLine("1.signIn");
            Console.WriteLine("2.signUp");
            Console.WriteLine("Enter Option ");
            option = int.Parse(Console.ReadLine());
            return option;

        }
        static string parseData(string record,int field)
        {
            int comma = 1;
            string item = "";
            for(int x = 0; x < record.Length; x++)
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
        static void readData(string path,string[] names, string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                streamReader fileVariable = new streamReader(path);
                string record;
                while((record=fileVariable.ReadLine()) != null)
                {
                    names[x] = parseData(record, 1);
                    password[x] = parseData(record, 2);
                    x++;
                    if(x>=5)
                    {
                        break;
                    }
                }
                fileVariable.close();
                            }
            else{
                Console.WriteLine("not exit");
            }
        }
        static void signIn(string n,string p,string[] names,string[] password)
        {
            bool flag = false;
            for(int x=0;x<5;x++)
            {
                if (n == names[x] && p == password[x])
                {
                    Console.WriteLine("invalid user");
                                    }
                Console.ReadKey();
            }
            static void signUp(string path,string n,string p)
            {
                streamWriter file = new streamWriter(path, true);
                file.WriteLine(n + " ," + p);
                file.Flush();
                file.Close();
            }
        }
    }
}

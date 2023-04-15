using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Task1();
            Task2();
            Task3();
            Task4();
            Task5();
            Task6();
            Task7();
            Task8();*/
            //Task9();
            //Task10();
            //Task11();
            //Task12();
            //Task13();
            //Task14();
            //Task15();
            //Task16();
            //Task17();
            //Task18();
            // Task19();
            //Task20Main();
            Task21();
        }
        static void Task1()
        {
            Console.Write("HELLO WORLD!!");
            Console.Write("HELLO WORLD!!");
            Console.ReadKey();
        }
        static void Task2()
        {
            Console.WriteLine("HELLO WORLD!!");
            Console.Write("HELLO WORLD!!");
            Console.ReadKey();
        }
        static void Task3()
        {
            int variable = 7;
            Console.WriteLine("Value: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void Task4()
        {
            string variable = "I am string";
            Console.WriteLine("String: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void Task5()
        {
            char variable = 'A';
            Console.WriteLine("Character: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void Task6()
        {
            float variable = 2.2F;
            Console.WriteLine("Decimal: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void Task7()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("you have entered: ");
            Console.Write(str);
            Console.ReadKey();
        }
        static void Task8()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("you have entered: ");
            int num = int.Parse(str);
            Console.WriteLine("The number is: ");
            Console.Write(num);
            Console.ReadKey();
        }
        static void Task9()
        {
            string str;
            Console.WriteLine("Enter a floating point value: ");
            str = Console.ReadLine();
            float num = float.Parse(str);
            Console.WriteLine("The floating value is: ");
            Console.Write(num);
            Console.ReadKey();
        }
        static void Task10()
        {

            float length;
            float area;
            Console.WriteLine("Enter The length of a square: ");
            length = float.Parse(Console.ReadLine());
            area = length * length;
            Console.WriteLine("The Area is ");
            Console.Write(area);
            Console.ReadKey();
        }
        static void Task11()
        {
            int number;
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number > 50)
            {
                Console.WriteLine("You are Pass");
            }
            else
            {
                Console.WriteLine("You are fail");
            }
            Console.ReadKey();
        }
        static void Task12()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Welcome Jack");
            }
            Console.ReadKey();

        }
        static void Task13()
        {
            int sum = 0;
            int num = 0;
            while (num != -1)
            {
                Console.WriteLine("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;

            }
            Console.Write("Sum is: ");
            Console.Write(sum);
            Console.ReadKey();
        }
        static void Task14()
        {
            int sum = 0;
            int num;
            do
            {
                Console.WriteLine("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                sum = sum + num;

            } while (num != -1);
            sum = sum + 1;
            Console.Write("Sum is: ");
            Console.Write(sum);
            Console.ReadKey();
        }
        static void Task15()
        {
            int[] number = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number: ");
                number[i] = int.Parse(Console.ReadLine());
            }
            
            if (number[0] > number[1] && number[0] > number[2])
            {
                Console.Write("Largest number is {0}", number[0]);
            }
            if (number[1] > number[2] && number[1] > number[0])
            {
                Console.Write("Largest number is {0}", number[1]);
            }
            else
            {
                Console.Write("Largest number is {0}", number[2]);
            }
            Console.ReadKey();
        }
        static int Add(int num1, int num2)
        {
            int sum;
            sum = num1 + num2;
            return sum;
        }
        static void Task17()
        {
            int num1;
            int num2;
            int result;
            Console.WriteLine("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number: ");
            num2 = int.Parse(Console.ReadLine());
            result = Add(num1, num2);
            Console.WriteLine("The sum is: " + result);
            Console.ReadKey();

        }
        static void Task16()
        {
            int toyPrice;
            float machinePrice;
            int age;
            int toys = 0;
            float price = 0, totalToyPrice = 0, total;
            float moneyLeft;
            Console.WriteLine("Enter the age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Machine Price: ");
            machinePrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Toy Price: ");
            toyPrice = int.Parse(Console.ReadLine());
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    price = price + (((i / 2) * 10) - 1);
                }
                else
                {
                    toys = toys + 1;
                }
            }
            totalToyPrice = toyPrice * toys;
            total = totalToyPrice + price;
            if (total >= machinePrice)
            {
                moneyLeft = total - machinePrice;
                Console.WriteLine("YES! {0}", moneyLeft);
            }
            else
            {
                moneyLeft = machinePrice - total;
                Console.WriteLine("No! {0}", moneyLeft);
            }
            Console.ReadKey();
        }
        static void Task18()
        {
            string path = "C:\\OOP\\Lab1\\task1.txt";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                file.Close();


            }
            else
            {
                Console.WriteLine("not exist");
            }
            Console.ReadKey();
        }
        static void Task19()
        {
            string path = "C:\\OOP\\Lab1\\task1.txt";
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine("hello");
            file.Flush();
            file.Close();

        }
        static int menu()
        {
            int option;
            Console.WriteLine("1- SignIn");
            Console.WriteLine("2- SignUp");
            Console.WriteLine("Enter Option: ");
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
        static void readData(string path, string[] names, string[] passwords)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    names[x] = parseData(record, 1);
                    passwords[x] = parseData(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                file.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }
        static void signUp(string path, string n, string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();
        }
        static void signIn(string n, string p, string[] names, string[] passwords)
        {
            bool flag = false;
            for (int i = 0; i < 5; i++)
            {
                if (n == names[i] && p == passwords[i])
                {
                    flag = true;
                    Console.WriteLine("Valid user");

                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }
        static void Task20Main()
        {
            string path = "C:\\OOP\\Lab1\\Records.txt";
            string[] names = new string[5];
            string[] password = new string[5];
            int option;
            do
            {
                readData(path, names, password);
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter your name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter your password: ");
                    string p = Console.ReadLine();
                    signIn(n, p, names, password);

                }
                else if (option == 2)
                {
                    Console.WriteLine("Enter new name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter new password: ");
                    string p = Console.ReadLine();
                    signUp(path, n, p);

                }

            } while (option < 3);
            Console.Read();
        }


            static void Task21()
            {
                string path = "C:\\OOP\\Lab1\\Customers.txt";
                string record, name, orderNumstr, number;
                int count = 0;
                int orderNum = 0, minOrderNum, price;

                Console.Write("Enter the minimum number of orders: ");
                minOrderNum = int.Parse(Console.ReadLine());
                Console.Write("Enter the minimum price: ");
                price = int.Parse(Console.ReadLine());
                StreamReader file = new StreamReader(path);
                int i;
                while ((record = file.ReadLine()) != null)
                {
                    i = 0;
                    name = "";
                    orderNumstr = "";
                    number = "";
                    while (record[i] != ' ')
                    {

                        name = name + record[i];
                        i++;

                    }
                    i++;
                    // Console.WriteLine(name);
                    while (record[i] != ' ')
                    {
                        orderNumstr = orderNumstr + record[i];
                        i++;
                    }
                    //Console.WriteLine(orderNumstr);

                    orderNum = int.Parse(orderNumstr);
                    //Console.WriteLine(orderNum);
                    if (minOrderNum <= orderNum)
                    {
                        int[] arr = new int[orderNum];
                        i = i + 2;

                        for (int z = 0; z < orderNum - 1; z++)
                        {

                            while (record[i] != ',')
                            {
                                number = number + record[i];
                                i++;
                            }
                            i++;
                            //Console.WriteLine(number);
                            arr[z] = int.Parse(number);
                            number = "";


                        }
                        i = i + 1;
                        number = "";
                        while (record[i] != ']')
                        {
                            number = number + record[i];
                            i++;
                        }
                        arr[orderNum - 1] = int.Parse(number);
                        for (int r = 0; r < orderNum; r++)
                        {
                            if (arr[r] >= price)
                            {
                                count = count + 1;
                            }

                        }
                        if (count >= minOrderNum)
                        {
                            Console.WriteLine(name);

                        }
                    }
                }
                file.Close();
                Console.ReadKey();

            }
        }
    } 

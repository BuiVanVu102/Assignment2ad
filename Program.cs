using System;

namespace Kieudulieu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*char alphabet, alphabet1, alphabet2;
            Console.WriteLine("chu cai thu nhat :");
            alphabet = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(" chu cai thu hai :");
            alphabet1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("nhap chu cai thu 3:");
            alphabet2 = Convert.ToChar(Console.ReadLine());

            Console.Write("hien 3 chu so theo chieeu nguoc lai la:");
            Console.WriteLine("{0} {1} {2}"  , alphabet2, alphabet1, alphabet);
            Console.ReadKey();*/

            //Chuong trinh c# de ve tam giac so
            /* Console.WriteLine("nhap 1 so bat ki");
             int num = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("nhap chieu rong");
             int rong = Convert.ToInt32(Console.ReadLine());
             int dai = rong;
             for (int i = 0; i < dai; i++)
             {
                 for (int j = 0; j < rong; j++)
                 {
                     Console.Write(num);
                 }
                 Console.WriteLine();
                 rong--;
             }
             Console.ReadKey();*/

            //bai toan nhap tk mk C# va kiem tra 
            /*int i = 1;
            while(i <=10)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
            int a = 1;
            int num = 0;
            do
            {
                num += a;
                a++;
            }
            while (a <= 5);
            Console.WriteLine("tong 5 do dau tien la:" + num);

            //bai toan nhap tk mk C# va kiem tra 

            string user, password;
            Console.WriteLine("Kiem tra ten tai khoan va pass");
            Console.WriteLine("Gia tri mac dinh la user va pass");
            do
            {
                Console.Write("nhap username");
                user = Console.ReadLine();
                Console.WriteLine("nhap password");
                password = Console.ReadLine();
            }
            while (user != "user" && password != "password");
            Console.WriteLine("Ten dang nhap va mat khau sai");
            Console.ReadKey(); */
            //nhap tk mk neu sai 3 lan thi bao loi
            /* string user, password;
             int count = 0;
             Console.Write("Kiem tra nhap tai khoan va pass:");
             Console.Write("Gia tri mac dinh la user va password\n");

             do
             {
                 Console.Write("Nhap tai khoan:\n");
                 user = Console.ReadLine();

                 Console.Write("Nhap pass:\n");
                 password = Console.ReadLine();

                 count++;

             }
             while (((user != "user") || (password != "password")) && (count != 3));

             if (count == 3)
                 Console.Write("Dang nhap that bai!");
             else
                 Console.Write("Mat khau chinh xac. Ban da dang nhap thanh cong!");

             Console.ReadKey();*/
            //nhap 2 so v phep tinh in ra ket qua
            /*int a, b;
            char pheptoan;
            Console.WriteLine("nhap so dau tien:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap phep toan:");
            pheptoan = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("nhap so thu hai:");
            b = Convert.ToInt32(Console.ReadLine());

            if (pheptoan == '+')
            {
                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            }
            else if (pheptoan == '-')
            {
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            }
            else if (pheptoan == '*')
            {
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            }
            else if (pheptoan == '/')
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            }
            else
            {
                Console.WriteLine("nhap sai phep toan");
            }*/
            //tim chu vi dien tich hinh tron S = R^2*3.14, P = 2*3.14.r
            /*double r, P, S;
            double Pi = 3.14;
            Console.WriteLine("Nhap ban kinh duong tron:");
            r = Convert.ToDouble(Console.ReadLine());
            P = 2 * Pi * r;
            Console.WriteLine("Chu vi hinh tron:" + P);
            S = r * r * Pi;
            Console.WriteLine("Dien tich hinh tron:" + S);
            Console.ReadKey();*/
            //tim gia tri cua ham x = y^2 - 2*Y + 1 voi y [-5;5]
            /*int x, y;
            Console.WriteLine(" y² - 2y +1");
            Console.WriteLine();
            for (y = -5; y <= 5; y++)
            {
                x = y * y - 2 * y + 1;
                Console.WriteLine("y={0};x=({0})² - 2*({0}) + 1 = {1}", y, x);
              
            }
            Console.ReadKey();*/
            //kiem tra chan le
            
            /*int a, b;
            Console.WriteLine("kiem tra chan le cua hai so:");
            bool c;
            Console.WriteLine("nhap so thu nhat:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so thu hai:");
            b = Convert.ToInt32(Console.ReadLine());
            c = ((a % 2 == 0) && (b % 2 == 0)) ? true : false;
            Console.WriteLine(c ? @"Ca hai so deu la so chan" :
                                    @"Ca hai so ko pai");
            Console.ReadKey();*/
            //
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_1_basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //viet tat cw
            Console.WriteLine();

            double x = Convert.ToDouble(Console.ReadLine());
            string a = x > 10 ? "lon hon 10" : "nho hon hoac bang 10";
            Console.WriteLine(a);

            Console.WriteLine(x);
            //{0:0.00}: doc phan tu thu 0 sau dau , ; phan tu thu 0 co dinh dang: giu nguyen phan so nguyen, 2 chu so thap phan
            Console.WriteLine(string.Format("{0:0.00}", x));

            //"c" dinh dang kieu tien, lay 2 chu so phan thap phan
            Console.WriteLine(x.ToString("C"));

            //co gang chuyen kieu sang double, neu chuyen duoc thi x nhan gia tri moi, neu khong thi x giu gia tri cu
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine(x);
            */

            //ex1:
            Console.Write("enter a int number: ");
            int a = 0;
            if (int.TryParse(Console.ReadLine(), out a))
            {
                for(int i = 0; i < a; i++)
                {
                    Console.WriteLine(a);
                }
            }
            else
            {

            }


        }
    }
}

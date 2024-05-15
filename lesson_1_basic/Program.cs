using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

            /*
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
            */

            /*
            //ex2
            Console.Write("enter a string: ");
            string s = Console.ReadLine();
            string[] t = {"apple", "banana", "cherry"};
            Console.WriteLine(string.Join(".", t));
            
            if(!string.IsNullOrEmpty(s) )
            {
                if (s.Equals(t[0]))
                {
                    Console.WriteLine(t);
                }
            }

            */

            /*
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();  

            Random rand = new Random();
            for(int i = 0; i < 20; i++)
            {
                list.Add(rand.Next(1, 10));
            }

            foreach(int i in list)
            {
                if(i%2 == 0)
                {
                    list2.Add(i);
                }
                else
                {
                    list3.Add(i);
                }
            }
            */

        }
    }
}

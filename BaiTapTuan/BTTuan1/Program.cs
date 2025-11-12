using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTuan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap he so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap he so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap he so c: ");
            int c = int.Parse(Console.ReadLine());

            PhuongTrinhBac2 ptb2 = new PhuongTrinhBac2();
            ptb2.GiaiPT(a, b, c);  
        }
    }

    internal class PhuongTrinhBac1
    {
        public void GiaiPT(int a, int b)
        {
            if (a != 0)
            {
                double x = (double)(-b) / a;
                Console.WriteLine($"Phuong trinh bac 1 co nghiem: x = {x}");
            }
            else if (b == 0)
                Console.WriteLine("Phuong trinh bac 1 co vo so nghiem");
            else
                Console.WriteLine("Phuong trinh bac 1 vo nghiem");
        }
    }

    internal class PhuongTrinhBac2 : PhuongTrinhBac1
    {
        public void GiaiPT(int a, int b, int c)
        {
            if (a == 0)
            {
                Console.WriteLine("Vi a = 0, day la phuong trinh bac 1");
                GiaiPT(b, c); 
                return;
            }

            int delta = b * b - 4 * a * c;

            if (delta < 0)
                Console.WriteLine("Phuong trinh vo nghiem.");
            else if (delta == 0)
            {
                double x = (double)(-b) / (2 * a);
                Console.WriteLine($"Phuong trinh co nghiem kep: x = {x}");
            }
            else
            {
                double sqrtDelta = Math.Sqrt(delta);
                double x1 = (-b + sqrtDelta) / (2.0 * a);
                double x2 = (-b - sqrtDelta) / (2.0 * a);
                Console.WriteLine($"Phuong trinh co hai nghiem phan biet: x1 = {x1} va x2 = {x2}");
            }
        }
    }
}

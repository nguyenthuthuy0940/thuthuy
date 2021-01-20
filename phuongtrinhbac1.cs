using System;

namespace phuongtrinh_bac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhập a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("nhập b");
            int b = int.Parse(Console.ReadLine());

                if (a == 0)
                if (b == 0)
                        Console.WriteLine("phương trình vô số nghiệm");
                    else
                        Console.WriteLine("phuương trình vô nghiệm");
                    else
                    {
                        int nghiem = -b / a;
                        Console.WriteLine("phương trình có nghiệm là x={0}", nghiem.ToString());
                    }
            Console.ReadKey();
        }
    }
}

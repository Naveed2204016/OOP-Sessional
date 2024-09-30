using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{

    class threed
    {
        int i;
        int j;
        int k;
        public threed()
        {
            i = j = k = 0;
        }

        public threed(int i,int j,int k)
        {
            this.i = i;
            this.j = j;
            this.k = k;
        }

        public static bool operator>(threed a,threed b)
        {
            if (Math.Sqrt(a.i * a.i + a.j * a.j + a.k * a.k) > Math.Sqrt(b.i * b.i + b.j * b.j + b.k * b.k))
                return true;
            else
                return false;
        }


        public static bool operator <(threed a, threed b)
        {
            if (Math.Sqrt(a.i * a.i + a.j * a.j + a.k * a.k) <Math.Sqrt(b.i * b.i + b.j * b.j + b.k * b.k))
                return true;
            else
                return false;
        }
        public static bool operator==(threed a,threed b)
        {
            if (Math.Sqrt(a.i * a.i + a.j * a.j + a.k * a.k) == Math.Sqrt(b.i*b.i+b.j*b.j+b.k*b.k))
                return true;
            else
                return false;
        }

        public static bool operator!=(threed a,threed b)
        {
            if (Math.Sqrt(a.i * a.i + a.j * a.j + a.k * a.k) != Math.Sqrt(b.i*b.i+b.j*b.j+b.k*b.k))
                return true;
            else
                return false;
        }

        public static bool operator true(threed a)
        {
            if (a.i != 0 || a.j != 0 || a.k != 0)
                return true;
            else
                return false;
        }

        public static bool operator false(threed a)
        {
            if (a.i == 0 && a.j == 0 && a.k == 0)
                return true;
            else
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            threed a = new threed(1, 2, 3);
            threed b = new threed(4, 5, 6);
            threed c = new threed(0, 0, 0);

            if(a>b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if(a<b)
            {
                Console.WriteLine("b is greater than a");
            }


            if (a == b)
            {
                Console.WriteLine("a is equal to b");
            }
            else if(a!=b)
            {
                Console.WriteLine("a is not equal to b");
            }

            if(c)
            {
                Console.WriteLine("c is not a center");
            }
            else
            {
                Console.WriteLine("c is a center");
            }

            Console.ReadLine();
        }
    }
}

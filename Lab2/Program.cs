using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
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

        public static threed operator+(threed a,threed b)
        {
            threed tem = new threed();
            tem.i = a.i + b.i;
            tem.j = a.j + b.j;
            tem.k = a.k + b.k;
            return tem;
        }

        public static threed operator -(threed a, threed b)
        {
            threed tem = new threed();
            tem.i = a.i - b.i;
            tem.j = a.j - b.j;
            tem.k = a.k - b.k;
            return tem;
        }

        public static threed operator *(threed a, threed b)
        {
            threed tem = new threed();
            tem.i = a.i * b.i;
            tem.j = a.j * b.j;
            tem.k = a.k * b.k;
            return tem;
        }

        public static threed operator /(threed a, threed b)
        {
            threed tem = new threed();
            tem.i = a.i / b.i;
            tem.j = a.j / b.j;
            tem.k = a.k / b.k;
            return tem;
        }

        public static threed operator ++(threed a)
        {
            threed tem = new threed();
            tem.i = a.i + 1;
            tem.j = a.j + 1;
            tem.k = a.k + 1;
            return tem;
        }

        public static threed operator --(threed a)
        {
            threed tem = new threed();
            tem.i = a.i - 1;
            tem.j = a.j - 1;
            tem.k = a.k - 1;
            return tem;
        }

        public static threed operator +(int b,threed a)
        {
            threed tem = new threed();
            tem.i = a.i + b;
            tem.j = a.j + b;
            tem.k = a.k + b;
            return tem;
        }

       public static threed operator+(threed a,int b)
        {
            threed tem = new threed();
            tem.i = a.i + b;
            tem.j = a.j + b;
            tem.k = a.k + b;
            return tem;
        }

        public static threed operator -(threed a)
        {
            threed tem = new threed();
            tem.i = -1*a.i;
            tem.j = -1*a.j;
            tem.k = -1*a.k;
            return tem;
        }

        public static threed operator %(threed a,threed b)
        {
            threed tem = new threed();
            tem.i = a.i % b.i;
            tem.j = a.j % b.j;
            tem.k = a.k % b.k;
            return tem;
        }

        public void show()
        {
            Console.WriteLine(i + " " + j+" " + k);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            threed a = new threed(4, 6, 8);
            threed b = new threed(2, 3, 4);
            threed c = new threed();
            c = a + b;
            c.show();
            c = a - b;
            c.show();
            c = a * b;
            c.show();
            c = a / b;
            c.show();
            c = a % b;
            c.show();
            c = ++a;
            c.show();
            a--;
            c = --a;
            c.show();
            a++;
            c = a + 5;
            c.show();
            c = -a;
            c.show();
            Console.ReadLine();
        }
    }
}

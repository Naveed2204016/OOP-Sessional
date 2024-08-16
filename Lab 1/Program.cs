using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geomatric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shapes[] s = new Shapes[100];
            int tot = 0;
            int cir = 0;
            int rec = 0;
            int cub = 0;
            double totarea = 0;
            double cirarea = 0;
            double recarea = 0;
            double cubarea = 0;
            while(true)
            {
                int a;
                Console.WriteLine("1.Add a circle");
                Console.WriteLine("2.Add a rectangle");
                Console.WriteLine("3.Add a cube");
                Console.WriteLine("4.List items");
                Console.WriteLine("5.Get statistics");
                Console.WriteLine("6.Exit");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine("Enter diameter:");
                    double d = Convert.ToDouble(Console.ReadLine());
                    s[tot] = new circle(d);
                    s[tot].id = tot + 1;
                    totarea += s[tot].area();
                    cirarea += s[tot].area();
                    tot++;
                    cir++;
                }
                else if (a == 2)
                {
                    double w, h;
                    Console.WriteLine("Enter width:");
                    w = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter height:");
                    h = Convert.ToDouble(Console.ReadLine());
                    s[tot] = new rectangle(w, h);
                    s[tot].id = tot + 1;
                    totarea += s[tot].area();
                    recarea += s[tot].area();
                    tot++;
                    rec++;
                }
                else if(a==3)
                {
                    double w, h, d;
                    Console.WriteLine("What is the height:");
                    h = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("What is the width:");
                    w = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("What is the depth:");
                    d= Convert.ToDouble(Console.ReadLine());

                    s[tot] = new cube(h, w, d);
                    s[tot].id = tot + 1;
                    totarea += s[tot].area();
                    cubarea += s[tot].area();
                    tot++;
                    cub++;
                }
                else if (a == 4)
                {
                    Console.WriteLine("===================");
                    Console.WriteLine("ID  Type  Dimension");
                    foreach (Shapes i in s)
                    {
                        if (i is circle)
                        {
                            circle c = (circle)i;
                            Console.WriteLine("{0} circle {1}", c.id, c.dia);
                        }
                        else if(i is rectangle)
                        {
                            rectangle rs = (rectangle)i;
                            Console.WriteLine("{0} rectangle {1}X{2}", rs.id, rs.width, rs.height);
                        }
                        else
                        {
                            cube cu = (cube)i;
                            Console.WriteLine("{0} cube {1}X{2}X{3}", cu.id, cu.height, cu.width, cu.depth);

                        }
                    }
                }
                else if (a == 5)
                {
                    Console.WriteLine("Total number of shapes {0}", tot);
                    Console.WriteLine("Total number of circles {0}", cir);
                    Console.WriteLine("Total number of rectangle {0}", rec);
                    Console.WriteLine("Total number of cubes {0}", cub);
                    Console.WriteLine($"Total area {totarea:F1}");
                    Console.WriteLine($"Total area occupied by circles {cirarea:F1} ({(cirarea/totarea)*100:F1})%");
                    Console.WriteLine($"Total area occupied by rectangles {recarea:F1} ({(recarea/totarea)*100:F1})%");
                    Console.WriteLine($"Total area occupied by cubes {cubarea:F1} ({(cubarea / totarea) * 100:F1})%");
                }
                else
                    break;
            }
        }
    }
}

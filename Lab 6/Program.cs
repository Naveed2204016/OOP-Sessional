using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuetStudents
{
    class student
    {
        public string studentid;
        private string name;
        protected string contactno;
        public student()
        {

        }
        public student(string studentid, string name, string contactno)
        {
            this.studentid = studentid;
            this.name = name;
            this.contactno = contactno;
        }

        public string Name { get { return name; } set { name = value; } }


    }

    class Admin : student
    {
        public int batch;
        public string dept;
        public Admin() { }
        public Admin(string studentid, string name, string contactno, int batch, string dept) : base(studentid, name, contactno)
        {
            this.batch = batch;
            this.dept = dept;
        }

        List<Admin> admins = new List<Admin>();
        public void addstudent(Admin admin)
        {
            admins.Add(admin);
        }

        public void Studentsummary()
        {
            foreach(Admin admin in admins)
            {
                Console.WriteLine(admin.studentid + " " + admin.Name + " " + admin.contactno);
            }
        }

        public void searchstudent(string id)
        {
            var a=from i in admins where i.studentid == id select i;
            int num = a.Count();
            if (num == 0)
                Console.WriteLine("No such students found");
            else
            {
                foreach(Admin admin in a)
                {
                    Console.WriteLine(admin.studentid + " " + admin.Name + " " + admin.contactno);
                }
            }
        }

        public void updatecontactno(string id,string newcontactno)
        {
            foreach(Admin admin in admins)
            {
                if(admin.studentid==id)
                {
                    admin.contactno = newcontactno;
                }
            }
        }

        public void deletestudent(string id)
        {
            Admin toremove = admins.FirstOrDefault(a => a.studentid == id);
            if(toremove!=null)
            admins.Remove(toremove);
            else
            {
                Console.WriteLine("No such student found");
            }
        }

        public void studentsummary()
        {
            var a = from i in admins where i.batch == 19 select i;
            var b= from i in admins where i.batch == 20 select i;
            var c=from i in admins where i.batch == 21 select i;
            var d= from i in admins where i.batch == 22 select i;

            var ce= from i in admins where i.dept == "CE" select i;
            var eee= from i in admins where i.dept == "EEE" select i;
            var me= from i in admins where i.dept == "ME" select i;
            var cse=from i in admins where i.dept == "CSE" select i;
            Console.WriteLine("Total students:(Batch wise)");
            Console.WriteLine("19: " + a.Count() + " 20: " + b.Count() + " 21: " + c.Count() + " 22: " + d.Count());
            Console.WriteLine("Total students:(Department wise)");
            Console.WriteLine("CE(01): " + ce.Count() + " EEE(02): " + eee.Count() + " ME(03): " + me.Count() + " CSE(04): " + cse.Count());
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Admin a = new Admin();
            while(true)
            {
                int opt;
                Console.WriteLine();
                Console.WriteLine("Select one");
                Console.WriteLine("1:Add student");
                Console.WriteLine("2:Student Summary");
                Console.WriteLine("3:Search student by id");
                Console.WriteLine("4:Update contact no");
                Console.WriteLine("5:Exit");
                Console.WriteLine("6:Delete student by id");
                Console.WriteLine("7:student summary");
                opt = int.Parse(Console.ReadLine());
                if(opt==1)
                {
                    string id = Console.ReadLine();
                    string name = Console.ReadLine();
                    string con = Console.ReadLine();
                    int batch = int.Parse(Console.ReadLine());
                    string dept = Console.ReadLine();
                    Admin ob = new Admin(id, name, con, batch, dept);
                    a.addstudent(ob);
                }
                else if(opt==2)
                {
                    a.Studentsummary();
                }
                else if(opt==3)
                {
                    string id = Console.ReadLine();
                    a.searchstudent(id);
                }
                else if(opt==4)
                {
                    string id = Console.ReadLine();
                    string contactno = Console.ReadLine();
                    a.updatecontactno(id, contactno);
                }
                else if (opt == 5)
                {
                    break;
                }
                else if(opt==6)
                {
                    string id = Console.ReadLine();
                    a.deletestudent(id);
                }
                else if(opt==7)
                {
                    a.studentsummary();
                }
            }
            Console.ReadLine();
        }
    }
}

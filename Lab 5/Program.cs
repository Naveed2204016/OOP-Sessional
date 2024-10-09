using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public interface IMachine
    {
        void start();
        void stop();
    }

    public interface IMaintainable
    {
        void PerformMaintenance();
    }

    abstract class Machine:IMachine
    {
        public abstract void start();
        public abstract void stop();
        public string manufacturer;
        public string model;
        public int year;
        public void getinfo()
        {
            Console.WriteLine("Manufacturer: " + manufacturer + " Model: " + model + " Year: " + year);
        }
    }

    class Robot : Machine
    {
        public override void start()
        {
            Console.WriteLine("The robot is starting");
        }

        public override void stop()
        {
            Console.WriteLine("Stopping..");
        }
    }

    class vehicle : Machine,IMaintainable
    {
        public void PerformMaintenance()
        {
            Console.WriteLine("The vehicle is under maintenance");
        }

        public override void start()
        {
            Console.WriteLine("The car is starting");
        }

        public override void stop()
        {
            Console.WriteLine("The car is stopping..");
        }
    }

    public interface IRechargeable
    {
        void RechargeBattery();
        int CheckBatteryLevel();
    }
    class Drone : Machine,IMaintainable,IRechargeable
    {
        public int batterylevel;
        public override void start()
        {
            Console.WriteLine("The drone is starting");
        }

        public override void stop()
        {
            Console.WriteLine("Drone is stopping..");
        }

        public void PerformMaintenance()
        {
            Console.WriteLine("The drone is under maintenance");
        }

        public void RechargeBattery()
        {
            Console.WriteLine("Drone is charging..");
            batterylevel += 10;
        }
        public int CheckBatteryLevel()
        {
            return batterylevel;
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            Robot r = new Robot();
            vehicle v = new vehicle();
            Drone d = new Drone();

            r.start();
            r.stop();
            v.start();
            v.stop();
            v.PerformMaintenance();
            d.start();
            d.stop();
            d.PerformMaintenance();
            d.RechargeBattery();
            Console.WriteLine(d.CheckBatteryLevel());
            IMachine[] machine = new IMachine[3];
            machine[0] = r;
            machine[1] = v;
            machine[2] = d;
            machine[1].start();
            machine[2].stop();
            Console.ReadLine();
        }
    }
}

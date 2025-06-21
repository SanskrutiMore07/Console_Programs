using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Car MyCar = new Car("Blue",100);
            Car MyCar2 = new Car("Red",90);

            Console.WriteLine(MyCar.Color);
            Console.WriteLine(MyCar2.Color);
            Console.ReadLine();
            MyCar.Run();
            MyCar2.Run();
        }
    }
    class Car
    {
        public Car(string Color1,int MaxSpeed1)
        {
        Color = Color1;
            MaxSpeed = MaxSpeed1;
        }
        public string Color;
        public int MaxSpeed;

        public void Run()
        {
            Console.WriteLine("Running At:" + MaxSpeed );
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        public string Name
        {
            get;
            set;
        }
        public float Kalibr
        {
            get;
            set;
        }
        public double Dlina
        {
            get;
            set;
        }
        public Class1()
        {
            Name = null;
            Kalibr = 0;
            Dlina = 0;
        }
        public void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("-----Класс-----");
            Console.WriteLine("Название: {0}", Name);
            Console.WriteLine("Калибр: {0}", Kalibr);
            Console.WriteLine("Дальность: {0}", Dlina);
        }

        public void SetInfo()
        {
            Console.Write("Название: ");
            Name = Console.ReadLine();

            Console.Write("Калибр: ");
            Kalibr = Convert.ToInt32(Console.ReadLine());

            Console.Write("Дальность: ");
            Dlina = Convert.ToDouble(Console.ReadLine());

        }
    }
}

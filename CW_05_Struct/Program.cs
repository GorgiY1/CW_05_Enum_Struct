using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_05_Struct
{
    struct Dimension
    {
        public double height;
        private double _width;

        public Dimension(double h, double w)
        {
            height = h;
            _width = w;
        }

        public void SetWidth(double w)
        {
            _width = w;
        }
        public double GetWidth()
        {
            return _width;
        }

        public void Print()
        {
            Console.WriteLine($"Height: {height} Width: {_width}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Dimension dimension = new Dimension();
            //Console.WriteLine($"Height: {dimension.height} Width: {dimension.GetWidth()}");

            //Dimension dimension1 = new Dimension(5.67, 6.45);
            //Console.WriteLine($"Height: {dimension.height} Width: {dimension.GetWidth()}");

            //int ch = Console.Read();
            //Console.WriteLine(ch);
            //Console.WriteLine((char)ch);

            //ConsoleKeyInfo keyInfo = Console.ReadKey();
            //Console.WriteLine($"KeyChar: {keyInfo.KeyChar} Key: {keyInfo.Key} Modifiers: {keyInfo.Modifiers}");


            Console.WriteLine($"MinValue: {DateTime.MinValue} MaxValue: {DateTime.MaxValue}");

            Console.WriteLine($"DateTime.Now: {DateTime.Now}");
            Console.WriteLine($"DateTime.Now: {DateTime.Now.ToLongDateString()}");
            Console.WriteLine($"DateTime.Now: {DateTime.Now.ToShortDateString()}");
            Console.WriteLine($"DateTime.Now: {DateTime.Now.ToLongTimeString()}");
            Console.WriteLine($"DateTime.Now: {DateTime.Now.ToShortTimeString()}");

            DateTime today = DateTime.Today;
            Console.WriteLine($"Today: {today}");

            Console.WriteLine($"Day of yesr: {today.DayOfYear}");

            DateTime dateTime = new DateTime(2022, 12, 31);
            Console.WriteLine(today > dateTime);

            TimeSpan timeSpan = dateTime - today;
            Console.WriteLine(timeSpan);
            Console.WriteLine(timeSpan.Days);

            timeSpan = new TimeSpan(4, 3, 17);
            Console.WriteLine(timeSpan.ToString(""));
            Console.WriteLine(timeSpan.ToString(@"d\.hh\:mm\:ss"));

            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}

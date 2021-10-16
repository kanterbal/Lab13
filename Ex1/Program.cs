using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    class Building
    {
        public string Address { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public Building(string a, double l, double w, double h)
        {
            Address = a;
            Length = l;
            Width = w;
            Height = h;
        }
        public void Print()
        {
            Console.WriteLine("Adres zdanija: {0}", Address);
            Console.WriteLine("Dlina zdanija: {0}", Length);
            Console.WriteLine("Sirina zdanija: {0}", Width);
            Console.WriteLine("Vjisota zdanija: {0}", Height);
        }
    }
    sealed class MultiBuilding : Building
    {
        public int Number { get; set; }
        public MultiBuilding(string a, double l, double w, double h, int n)
            : base(a, l, w, h)
        {
            Number = n;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("Jetaznost zdanija: {0}", Number);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List ls = new List();
            ls.Add("геометрические фигуры");
            ls.Add("Круг");
            ls.AddRange(ls);
            ls.Insert(0, "Прямоугольник");
            ls.RemoveAt(3);
            ls.Reverse();

            Spisk(ls);
            Console.WriteLine($"Кол-во элементов {ls.Count()}");



            Console.Read();

        }

        static void Spisk(Listx)
        {
            for (int i = 0; i < x.Count; i++)
            {
                x[i] = x[i].ToUpper();
            }
            foreach (string ls in x)
            {
                Console.WriteLine(ls);
            }


        }
    }
}

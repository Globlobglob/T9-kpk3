using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void F(List<string> goods)

        {

            foreach (var elem in goods)

            {


                Console.WriteLine(elem);



            }

            Console.WriteLine();

        }

        static void Main(string[] args)

        {

            var goods = new List<string> { "Pencil", "books", "copybook", "bags", "pen", "hihgitler" };

            F(goods);

            goods.Add("mouse");

            F(goods);

            goods.Insert(0, "Opka");

            F(goods);

            goods.RemoveAt(3);

            F(goods);

            //goods[0] = goods[0].ToUpper();

            for (int i = 0; i <= 6; i++)

            {

                goods.Reverse();

                goods[i] = goods[i].ToUpper();

            }


            F(goods);






            WriteLine("Количесвто элементов = " + goods.Count());

            ReadKey();



        }
    }
}

// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int tree_Age;
            double tree_account;
            string tree_LITERA;
            string tree_hello_world;
            bool tree_isLive100years = true;
            bool tree_isnotlive100years = false;
            double tree_temperature;
            double tree_temperatureofEarth;
            int tree_people_of_earth;

            Console.WriteLine("vvedite temperature");
            Console.WriteLine("vvedite litera");   
            Console.WriteLine(tree_isnotlive100years);
            Console.WriteLine("vvod rzchunka ");
            Console.WriteLine("vvod goda ");
            Console.WriteLine("hello world");
            tree_Age = Convert.ToInt32(Console.ReadLine());
            tree_account = Convert.ToInt32(Console.ReadLine());
            if (tree_Age < 2018 && tree_Age > 0)
            {
                Console.Write("{0}", tree_Age);
            }
            else
            {
                Console.Write("{1}", tree_Age);
            }
            if (tree_account < 2018 && tree_account > 0)
            {
                Console.Write("{0}", tree_account);
            }
            else
            {
                Console.Write("{1}", tree_account);
            }
            if (tree_isLive100years)
            {
                Console.WriteLine("Old enough to vote!");
            }
            else
            {
                Console.WriteLine("Not old enough to vote.");
            }

        }
    }
}


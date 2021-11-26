using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4._2
{
    class Program
    {
        private static string result;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите Месяц");
            string grade = Console.ReadLine();
            switch (grade)
            {
                case "январь":
                    result = "30 руз";
                    break;
                case "февраль":
                    result = "28 руз";
                    break;
                case "март":
                    result = "30 руз";
                    break;
                case "апрел":
                    result = "31 руз";
                    break;
                case "май":
                    result = "30 руз";
                    break;
                case "июнь":
                    result = "31 руз";
                    break;
                case "июль":
                    result = "30 руз";
                    break;
                case "август":
                    result = "31 руз";
                    break;
                case "сентябрь":
                    result = "30 руз";
                    break;
                case "октябрь":
                    result = "31 руз";
                    break;
                case "ноябрь":
                    result = "30 руз";
                    break;
                case "декабрь":
                    result = "31 руз";
                    break;
                default:
                    result = "you failed!";
                    break;
            }
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}

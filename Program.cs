using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во часов от 0 до 220");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine(@"Выберите должность по первой букве:
m=Manager,
d=Developer,
a=Accountant,
s=Secretary,
j=Junior,
c=Cleaner");
            char ch = Convert.ToChar(Console.ReadLine());

            int tmp=0;
            switch (ch)
            {
                case'm': tmp = (int)Manager.Manager;
                    break;
                case 'd':tmp = (int)Manager.Developer;
                    break;
                case 'a':tmp = (int)Manager.Accountant;
                    break;
                case 's':tmp = (int)Manager.Secretary;
                    break;
                case 'j':tmp = (int)Manager.Junior;
                    break;
                case 'c':tmp = (int)Manager.Cleaner;
                    break;
                default: Console.WriteLine("Неверный параметр");
                break;

            }
            Console.WriteLine("Необходимо было отработать: {0} часов , отработано по факту: {1} часов",tmp,hours);

            BonusCheck m = new BonusCheck();

            if (m.Bonus((Manager)tmp, hours))
            {
                Console.WriteLine("Дать премию");
            }
            else
            {
                Console.WriteLine("Не давать премию");
            }
           

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Cocktail : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Смешиваем ингредиенты в шейкере");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Украшаем коктейль");
        }

        protected override bool CustomerWantsCondiments()
        {
            Console.Write("Хотите украшение для коктейля? (y/n): ");
            string answer = Console.ReadLine();
            return answer.ToLower() == "y";
        }
    }
}

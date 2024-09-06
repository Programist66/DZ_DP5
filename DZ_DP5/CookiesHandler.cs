using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP5
{
    internal class CookiesHandler : BaseHandler
    {
        public CookiesHandler(IHandler next) : base(next)
        {
        }
        public override bool Check()
        {
            Console.Write("Приянть куки?\n[Y] - да \n[N] - нет\n: ");
            string choise = Console.ReadLine();

            if (choise != "Y")
            {
                Console.WriteLine("Без куки фильм не работает!!!");
                return false;
            }
            return true;
        }
        
    }
}

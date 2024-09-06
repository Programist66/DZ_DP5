using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP5
{
    internal class CaptchaHandler : BaseHandler
    {
        public CaptchaHandler(IHandler next) : base(next)
        {
        }

        public override bool Check()
        {
            Console.Write("Введите текст `AFD`: ");
            string choise = Console.ReadLine();

            if (choise != "AFD") 
            {
                Console.WriteLine("Вы не прошли проверку!!!");
                return false;
            }
            return true;
        }
    }
}

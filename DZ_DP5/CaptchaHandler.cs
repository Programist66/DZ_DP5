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

        public override bool Handle()
        {
            Console.Write("Вы человек?[Y] - да \n[N] - нет\n: ");
            string choise = Console.ReadLine();
            if (choise == "Y")
            {
                return next.Handle();
            }
        }
    }
}

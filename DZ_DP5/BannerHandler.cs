using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP5
{
    internal class BannerHandler : BaseHandler
    {
        public BannerHandler(IHandler next) : base(next)
        {
        }

        public override bool Check()
        {
            Console.WriteLine("Нажмите любую клавишу чтобы закрыть баннер");
            Console.ReadKey();
            return true;
        }
    }
}

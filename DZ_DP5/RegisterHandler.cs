using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP5
{
    internal class RegisterHandler : BaseHandler
    {
        public RegisterHandler(IHandler next) : base(next)
        {
        }

        public override bool Check()
        {
            Console.Write("Введите ваш ник: ");
            string nick = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            Int32.TryParse(Console.ReadLine(), out int age);
            if(nick == "") 
            {
                Console.WriteLine("Без вашего ника мы вас не зарегистрируем!!");
                return false;
            }
            if (age > 200 || age < 1)
            {
                Console.WriteLine("вы либо умерли, либо еще не родились");
                return false;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP5
{
    public class Movie : IMovie
    {
        public void Play()
        {
            Console.WriteLine("фильм пошел!!");
        }
    }
}

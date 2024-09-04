using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP5
{
    internal class Stub : IMovie
    {
        private IHandler handler;
        private IMovie movie;

        Stub (IHandler handler, IMovie movie)
        {
            this.handler = handler;
            this.movie = movie;
        }

        public void Play()
        {
            if (handler.Handle())
            {
                movie.Play();
            }
        }
    }
}

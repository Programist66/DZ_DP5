using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP5
{
    public class Stub : IMovie
    {
        private IHandler handler;
        private Movie movie;

        public Stub (IHandler handler, Movie movie)
        {
            this.handler = handler;
            this.movie = movie;
        }

        public void Play()
        {
            handler.Handle(movie);
        }
    }
}

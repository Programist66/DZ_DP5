using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_DP5
{
    internal abstract class BaseHandler : IHandler
    {
        protected readonly IHandler next;

        public BaseHandler(IHandler next)
        {
            this.next = next;
        }

        public virtual void Handle(Movie movie) 
        {
            if (Check())
            {
                if (next == null)
                {
                    movie.Play();
                }
                else
                {
                    next.Handle(movie);
                }
            }
        }
        public abstract bool Check();
    }
    
}

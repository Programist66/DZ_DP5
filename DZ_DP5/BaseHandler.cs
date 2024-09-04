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

        public abstract bool Handle();
    }
    
}

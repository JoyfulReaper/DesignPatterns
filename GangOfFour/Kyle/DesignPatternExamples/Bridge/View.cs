using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class View
    {
        protected readonly IResource _resource;

        public View(IResource resource)
        {
            _resource = resource;
        }
        public abstract string Show();
    }
}

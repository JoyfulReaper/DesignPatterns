using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IResource
    {
        string Snippet();
        string Image();
        string Title();
        string Url();
    }
}

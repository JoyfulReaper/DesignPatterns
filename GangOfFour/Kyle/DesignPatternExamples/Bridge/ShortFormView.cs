using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ShortFormView : View
    {
        public ShortFormView(IResource resource) : base(resource)
        {
        }

        public IResource Resource { get; }

        public override string Show()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Title: {_resource.Title()}");
            output.AppendLine($"Image: {_resource.Image()}");
            output.AppendLine($"Url: {_resource.Url()}");

            return output.ToString();
        }
    }
}

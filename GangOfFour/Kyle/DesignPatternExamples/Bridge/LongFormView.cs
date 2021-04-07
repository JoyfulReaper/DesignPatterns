using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class LongFormView : View
    {
        public LongFormView(IResource resource) : base(resource)
        {

        }

        public override string Show()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Title: {_resource.Title()}");
            output.AppendLine($"Image: {_resource.Image()}");
            output.AppendLine($"Information: {_resource.Snippet()}");
            output.AppendLine($"Url: {_resource.Url()}");

            return output.ToString();
        }
    }
}

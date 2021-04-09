using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeGOF
{
    public class Equipment
    {
        public string Name { get; set; }

        public virtual Watt Power()
        {
            return new Watt(0);
        }

        public virtual Currency NetPrice()
        {
            return new Currency()
            {
                Amount = 0
            };
        }

        public virtual Currency DiscountPrice()
        {
            return NetPrice();
        }

        public virtual void Add(Equipment equipment)
        {

        }

        public virtual void Remove(Equipment equipment)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CatFactory : IAnimalFactory
    {
        public IAnimal MakeAnimal()
        {
            return new Cat();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class PeanutButterAndStrawberryJelly : ISandwhich
    {
        public List<IIngredient> Ingredients { get; } = new List<IIngredient>();

        public PeanutButterAndStrawberryJelly()
        {
            CreateIngredients();
        }

        public void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new PeanutButter());
            Ingredients.Add(new StrawberryJelly());
            Ingredients.Add(new Bread());
        }
    }
}

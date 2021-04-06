using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PeanutButterAndGrapeJelly : ISandwhich
    {
        public List<IIngredient> Ingredients { get; } = new List<IIngredient>();

        public PeanutButterAndGrapeJelly()
        {
            CreateIngredients();
        }

        public void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new PeanutButter());
            Ingredients.Add(new GrapeJelly());
            Ingredients.Add(new Bread());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class SonHamburgerBuilder : IBuilder
    {
        private Hamburger _hamburger;
        public void AddIngredients()
        {
            _hamburger.Ingredients = new string[] { "Bread", "Meat", "Sausage", "Salad", "Mayonnaise" };
        }

        public void AddShape()
        {
            _hamburger.Shape = "Cuboid";
        }

        public void AddSize()
        {
            _hamburger.Size = 10;
        }

        public Hamburger Build()
        {
            return _hamburger;
        }

        public void Reset()
        {
            _hamburger = new Hamburger();
        }
    }
}

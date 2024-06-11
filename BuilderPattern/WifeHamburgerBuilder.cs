using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class WifeHamburgerBuilder : IBuilder
    {
        private Hamburger _hamburger;
        public void AddIngredients()
        {
            _hamburger.Ingredients = new string[] { "Bread", "Salad" };
        }

        public void AddShape()
        {
            _hamburger.Shape = "Cuboid";
        }

        public void AddSize()
        {
            _hamburger.Size = 6; //inches
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

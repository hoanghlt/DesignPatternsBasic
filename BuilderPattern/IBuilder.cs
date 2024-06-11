using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IBuilder
    {

        void AddIngredients();
        void AddShape();
        void AddSize();
        void Reset();
        Hamburger Build();
    }
}

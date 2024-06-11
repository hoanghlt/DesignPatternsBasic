using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Cook
    {
        private IBuilder _builder;

        public Cook(IBuilder builder)
        {
            AcceptBuilder(builder);
        }

        public void ChangeBuilder(IBuilder builder)
        {
            AcceptBuilder(builder);
        }

        public Hamburger Build()
        {
            _builder.AddIngredients();
            _builder.AddShape();
            _builder.AddSize();
            return _builder.Build();
        }

        public void AcceptBuilder(IBuilder builder)
        {
            _builder = builder;
            _builder.Reset();
        }
    }
}

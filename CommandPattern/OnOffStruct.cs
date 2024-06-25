using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal struct OnOffStruct
    {
        public ICommand On;
        public ICommand Off;
    }
}

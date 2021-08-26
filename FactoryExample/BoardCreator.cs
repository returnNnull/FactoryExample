using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class BoardCreator : Creator
    {
        public override Transpor create()
        {
            return new Board();
        }
    }
}

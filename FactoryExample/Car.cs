using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class Car : Transpor
    {
        private string bodyType;

        public string BodyType { get => bodyType; set => bodyType = value; }
    }
}

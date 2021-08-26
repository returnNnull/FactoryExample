using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    abstract class Transpor
    {
        private String name;

        public string Name { get => name; set => name = value; }

        public String start()
        {
            return "Машина работает!";
        }
    }
}

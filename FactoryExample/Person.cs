using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class Person
    {
        private String name;

        public string Name { get => name; set => name = value; }


        public void actionWithCar(Transpor transpor)
        {

            Console.WriteLine ("Персонаж сел в " + transpor.Name);
        }
    }
}

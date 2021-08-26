using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    class CarCreator : Creator
    {
        public override Transpor create()
        {
            return new Car();
        }

        public Transpor createWithBodyType(String type)
        {
            Car car = new Car();
            car.BodyType = type;

            return car;
        
        }
    }
}

using System;

namespace FactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            Transpor transport1 = new CarCreator().create();
            Transpor transport = new BoardCreator().create();
            person.Name = "Joe";
            transport1.Name = "Opel";
            transport.Name = "Pobeda";

            person.actionWithCar(transport);
            person.actionWithCar(transport1);
        }
    }
}

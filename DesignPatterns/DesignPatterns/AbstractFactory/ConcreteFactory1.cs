using System;

namespace DesignPatterns.AbstractFactory
{
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            throw new NotImplementedException();
        }

        public override AbstractProductB CreateProductB()
        {
            throw new NotImplementedException();
        }
    }
}

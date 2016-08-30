using System;

namespace DesignPatterns.AbstractFactory
{
    class ConcreteFactory2 : AbstractFactory
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

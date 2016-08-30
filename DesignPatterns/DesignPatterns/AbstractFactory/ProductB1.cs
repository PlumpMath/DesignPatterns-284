using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    class ProductB1 : AbstractProductB
    {
        public override string Interact(AbstractProductA a)
        {
            throw new NotImplementedException();
        }
    }
}

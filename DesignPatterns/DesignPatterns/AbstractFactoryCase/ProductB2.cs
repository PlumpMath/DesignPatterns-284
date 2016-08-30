namespace DesignPatterns.AbstractFactoryCase
{
    class ProductB2 : AbstractProductB
    {
        public override string Interact(AbstractProductA abstractProductA)
        {
            return $"{GetType().Name} efetuando interações com {abstractProductA.GetType().Name}";
        }
    }
}

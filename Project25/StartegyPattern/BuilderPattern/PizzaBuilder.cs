namespace StartegyPattern.BuilderPattern
{
    public class PizzaBuilder
    {
        private BuilderPizza _pizza = new BuilderPizza();
        
        public PizzaBuilder SetSize(string size)
        {
            _pizza.Size = size;
            return this;
        }

        public PizzaBuilder AddCheese(string cheese)
        {
            _pizza.Cheese = cheese;
            return this;
        }

        public PizzaBuilder AddTopping(string topping)
        {
            _pizza.Topping = topping;
            return this;
        }

        public BuilderPizza Build()
        {
            return _pizza;
        }
    }
}
namespace StartegyPattern.BuilderPattern
{
    public class CoffeeBuilder
    {
        private Coffee _coffee = new Coffee();
        
        public CoffeeBuilder SetType(string type)
        {
            _coffee.Type = type;
            return this;
        }

        public CoffeeBuilder AddSugar()
        {
            _coffee.Sugar = true;
            return this;
        }

        public CoffeeBuilder AddMilk()
        {
            _coffee.Milk = true;
            return this;
        }

        public Coffee Build()
        {
            return _coffee;
        }
    }
}
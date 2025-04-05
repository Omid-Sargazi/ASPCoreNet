namespace StartegyPattern.BuilderPattern
{
    public class Pizza
    {
        public string Size { get; set; }
        public string Cheese { get; set; }
        public string Topping { get; set; }

    public Pizza(string size, string cheese, string topping)
        {
            Size = size;
            Cheese = cheese;
            Topping = topping;
        }
    }
}
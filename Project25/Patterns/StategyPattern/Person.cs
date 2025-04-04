namespace Patterns.StrategyPattern
{
    public class Person
    {
        private object _travelMethod;
        public Person(object method)
        {
            _travelMethod = method;
        }

        public string SetTravelMethod()
        {
            if(_travelMethod is Walking walking)
            {
                return walking.Move();
            }
            else if(_travelMethod is Biking biking)
            {
                return biking.Move();
            }
            else if(_travelMethod is Driving driving)
            {
                return driving.Move();
            }
            else
            {
                return "Unknown travel method";
            }
        }
    }
}
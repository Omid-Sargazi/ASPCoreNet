namespace StartegyPattern.AdapterPattern
{
    public class SensoreHelper
    {
        private OldSensor _oldSensor;
        public SensoreHelper(OldSensor oldsensore)
        {
            _oldSensor = oldsensore;
        }
        public int Read()
        {
           return _oldSensor.GetValue();
        }
    }
}
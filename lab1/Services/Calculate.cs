namespace lab1.Services
{
    public class Calculate
    {

        private int Value { get; set; }

        public int Add(int value)
        {
            return Value += value;
        }

        public int Subtract(int value)
        {
            return Value -= value;
        }

        // make 1 parametr constructor
        public Calculate(int value)
        {
            Value = value;
        }

        // make getters and setters for Value
        public int GetValue()
        {
            return Value;
        }

        public void SetValue(int value)
        {
            Value = value;
        }
    }
}

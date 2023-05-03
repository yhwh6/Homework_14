namespace Homework_12.Model
{
    public class Balance<T>
    {
        public decimal Value;
        public Balance(T value)
        {
            decimal.TryParse(value.ToString(), out Value);
        }
    }
}

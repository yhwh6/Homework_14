namespace Homework_13.Model
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

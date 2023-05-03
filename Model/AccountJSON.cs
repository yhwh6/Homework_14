namespace Homework_12.Model
{
    /// <summary>
    /// Account deserealization class
    /// </summary>
    public class AccountJSON
    {
        /// <summary>
        /// Account number
        /// </summary>
        public object? Number { get; set; }

        /// <summary>
        /// Balance
        /// </summary>
        public object? Balance { get; set; }

        /// <summary>
        /// Account type
        /// </summary>
        public object? AccountType { get; set; }
    }
}

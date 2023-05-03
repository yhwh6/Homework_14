using Homework_12.Model;

namespace Homework_12.Interface
{
    /// <summary>
    /// Account interface
    /// </summary>
    /// <typeparam name="T">Account type</typeparam>
    public interface IAccount<out T> where T : Account
    {
        /// <summary>
        /// Account number
        /// </summary>
        object Number { get; set; }

        /// <summary>
        /// Balance
        /// </summary>
        object Balance { get; set; }

        /// <summary>
        /// Account type
        /// </summary>
        object AccountType { get; set; }

        /// <summary>
        /// Transfer funds
        /// </summary>
        /// <param name="sum">Transfer summ</param>
        public virtual void TransferFunds(decimal sum)
        {
            ;
        }
    }
}

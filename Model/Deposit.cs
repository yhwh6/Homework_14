using Homework_12.Interface;


namespace Homework_12.Model
{
    /// <summary>
    /// Deposit account
    /// </summary>
    public class Deposit : Account, IAccount<Account>
    {
        #region Constructors

        public Deposit(object number, object balance) : base(number, balance)
        {
        }

        #endregion

        #region Methods

        public override void TransferFunds(decimal sum)
        {
            sum += 12;
            this.Balance = (decimal)this.Balance + sum;
        }

        #endregion
    }
}

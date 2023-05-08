using Homework_13.Interface;

namespace Homework_13.Model
{
    /// <summary>
    /// Nin deposit account
    /// </summary>
    public class NonDeposit : Account, IAccount<Account>
    {
        #region Constructors

        public NonDeposit(object number, object balance) : base(number, balance)
        {
        }

        #endregion

        #region Methods

        public override void TransferFunds(decimal sum)
        {
            this.Balance = (decimal)this.Balance + sum;
        }

        #endregion
    }
}

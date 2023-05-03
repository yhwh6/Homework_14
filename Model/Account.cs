using Homework_12.Interface;


namespace Homework_12.Model
{
    /// <summary>
    /// Account class
    /// </summary>
    public class Account : ViewModelBase, IAccount<Account>
    {
        #region Properties

        /// <summary>
        /// Account number
        /// </summary>
        public object Number
        {
            get
            {
                return number;
            }
            set
            {
                if (number != value)
                {
                    number = value;
                    RaisePropertyChanged(nameof(Number));
                }
            }
        }
        private object? number;

        /// <summary>
        /// Account balance
        /// </summary>
        public object Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (balance != value)
                {
                    balance = value;
                    RaisePropertyChanged(nameof(Balance));
                }
            }
        }
        private object? balance;

        /// <summary>
        /// Account type
        /// </summary>
        public object AccountType
        {
            get
            {
                return accountType.ToString() == "Deposit" ? "Deposit" : "Non deposit";
            }
            set
            {
                if (accountType != value)
                {
                    RaisePropertyChanged(nameof(AccountType));
                }
            }
        }
        private object accountType => this.GetType().Name;

        #endregion

        #region Constructors

        public Account() { }
        public Account(object number, object balance)
        {
            Number = number;
            Balance = new Balance<object>(balance).Value;
        }

        #endregion

        #region Methods

        public virtual void TransferFunds(decimal sum)
        {
            ;
        }

        #endregion
    }
}

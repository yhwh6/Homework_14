using Homework_13.Interface;
using System.Collections.ObjectModel;


namespace Homework_13.Model
{
    /// <summary>
    /// Client class
    /// </summary>
    public class Client : ViewModelBase
    {
        #region Properties

        /// <summary>
        /// Full Name
        /// </summary>
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                if (fullName != value)
                {
                    fullName = value;
                    RaisePropertyChanged(nameof(FullName));
                }
            }
        }
        private string? fullName;

        /// <summary>
        /// Clients unique tax id
        /// </summary>
        public string TaxId
        {
            get
            {
                return taxId;
            }
            set
            {
                if (taxId != value)
                {
                    taxId = value;
                    RaisePropertyChanged(nameof(TaxId));
                }
            }
        }
        private string? taxId;

        /// <summary>
        /// Phone number
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                if (phoneNumber != value)
                {
                    phoneNumber = value;
                    RaisePropertyChanged(nameof(PhoneNumber));
                }
            }
        }
        private string? phoneNumber;
        /// <summary>
        /// List of accounts
        /// </summary>
        public ObservableCollection<IAccount<Account>> Accounts { get; set; }

        #endregion

        #region Constructors

        public Client(string FullName, string TaxId, string PhoneNumber)
        {
            this.FullName = FullName;
            this.TaxId = TaxId;
            this.PhoneNumber = PhoneNumber;
        }

        public Client(string FullName, string TaxId, string PhoneNumber, ObservableCollection<AccountJSON> accounts)
        {
            this.FullName = FullName;
            this.TaxId = TaxId;
            this.PhoneNumber = PhoneNumber;
            this.Accounts = new ObservableCollection<IAccount<Account>>();

            if (accounts != null)
            {
                foreach (var acc in accounts)
                {
                    if (acc.AccountType.ToString() == "Deposit")
                    {
                        this.Accounts.Add(new Deposit(acc.Number, acc.Balance));
                    }
                    else
                    {
                        this.Accounts.Add(new NonDeposit(acc.Number, acc.Balance));
                    }
                }
            }
        }

        #endregion

        /// <summary>
        /// Creating account
        /// </summary>
        /// <typeparam name="T">Account type</typeparam>
        /// <param name="account">Account infos</param>
        public void AddAccount<T>(T account) where T : Account
        {
            if (this.Accounts == null)
            {
                this.Accounts = new ObservableCollection<IAccount<Account>>();
            }
            this.Accounts.Add((IAccount<Account>)account);
        }
    }
}

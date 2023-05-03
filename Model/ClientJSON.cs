using System.Collections.ObjectModel;

namespace Homework_12.Model
{
    /// <summary>
    /// Client deserealization class
    /// </summary>
    public class ClientJSON
    {
        #region Properties
        
        /// <summary>
        /// Full name
        /// </summary>
        public string? FullName { get; set; }

        /// <summary>
        /// Unique tax id
        /// </summary>
        public string? TaxId { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// List of accounts
        /// </summary>
        public ObservableCollection<AccountJSON>? Accounts { get; set; }

        #endregion
    }
}

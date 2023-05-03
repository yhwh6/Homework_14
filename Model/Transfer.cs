using Homework_12.Interface;


namespace Homework_12.Model
{
    /// <summary>
    ///Transfer funds class
    /// </summary>
    public class Transfer : ITransfer<Account, Account>
    {
        /// <summary>
        /// Transfering funds
        /// </summary>
        /// <param name="sender">Sender account</param>
        /// <param name="recepient">Recepint account</param>
        /// <param name="sum">Transfer summ</param>
        public void Post(Account sender, Account recepient, decimal sum)
        {
            sender.Balance = (decimal)sender.Balance - sum;
            recepient.Balance = (decimal)recepient.Balance + sum;
        }
    }
}

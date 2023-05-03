using Homework_12.Model;

namespace Homework_12.Interface
{
    /// <summary>
    /// Contravariant interface
    /// </summary>
    /// <typeparam name="T1">Account type</typeparam>
    /// <typeparam name="T2">Account type</typeparam>
    public interface ITransfer<in T1, in T2> where T1 : Account where T2 : Account
    {
        public void Post(Account acc_out, Account acc_in, decimal sum);
    }
}

using Homework_13.Model;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Homework_13
{
    /// <summary>
    /// Логика взаимодействия для pTransferFunds.xaml
    /// </summary>
    public partial class pTransferFunds : Page
    {
        public pTransferFunds()
        {
            InitializeComponent();
        }

        private void ButtonReplenish(object sender, RoutedEventArgs e)
        {
            decimal sum;
            if (decimal.TryParse(TextBoxSum.Text, out sum))
            {
                MainWindow.clients.First(x => x.TaxId == MainWindow.CurrentClientTaxId).Accounts
                    .First(x => x.Number == MainWindow.CurrentAccountNumber)
                    .TransferFunds(decimal.Parse(TextBoxSum.Text));

                MessageBox.Show($"Сlient's account {MainWindow.CurrentAccountNumber} has been funded with {sum} YEN.");
                HistoryLog.SaveLogFile($"Сlient's account {MainWindow.CurrentAccountNumber} has been funded with {sum} YEN.");

            }
            else
            {
                MessageBox.Show("Enter sum: ");
            }
        }
    }
}
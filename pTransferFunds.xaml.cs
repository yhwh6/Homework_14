using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Homework_12
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
            }
            else
            {
                MessageBox.Show("Enter sum: ");
            }
        }
    }
}
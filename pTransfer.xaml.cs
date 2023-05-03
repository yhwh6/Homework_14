using Homework_12.Model;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Homework_12.View
{
    /// <summary>
    /// Interaction logic for pTransfer.xaml
    /// </summary>
    public partial class pTransfer : Page
    {
        public ClientList clients => MainWindow.clients;

        public pTransfer()
        {
            InitializeComponent();
        }

        private void ButtonTransfer(object sender, RoutedEventArgs e)
        {
            if (ComboBoxAcc1.SelectedValue.ToString() != ComboBoxAcc2.SelectedValue.ToString() ||
                ComboBoxCl1.SelectedItem != ComboBoxCl2.SelectedItem)
            {
                MainWindow.transfer.Post(
                    (Account)clients.First(x => x == (Client)ComboBoxCl1.SelectedItem).Accounts.First(x => x.Number.ToString() == ComboBoxAcc1.Text),
                    (Account)clients.First(x => x == (Client)ComboBoxCl2.SelectedItem).Accounts.First(x => x.Number.ToString() == ComboBoxAcc2.Text),
                    decimal.Parse(TextBoxSum.Text)
                    );
            }
            else
            {
                MessageBox.Show("Select different accounts");
            }
        }

        private void ComboBoxCl1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxAcc1.ItemsSource = GetAccounts((Client)ComboBoxCl1.SelectedItem);
        }

        private void ComboBoxCl2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxAcc2.ItemsSource = GetAccounts((Client)ComboBoxCl2.SelectedItem);
        }

        private ObservableCollection<string> GetAccounts(Client client)
        {
            try
            {
                return new ObservableCollection<string>(
                    clients
                        .First(x => x == client).Accounts
                            .Select(x => x.Number.ToString())
                );
            }
            catch
            {
                return new ObservableCollection<string>();
            }
        }
    }
}
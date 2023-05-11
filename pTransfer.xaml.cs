using Homework_13.Model;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace Homework_13.View
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
            try
            {
                var acc1 = (Account)clients.First(x => x == (Client)ComboBoxCl1.SelectedItem).Accounts.First(x => x.Number.ToString() == ComboBoxAcc1.Text);
                var acc2 = (Account)clients.First(x => x == (Client)ComboBoxCl2.SelectedItem).Accounts.First(x => x.Number.ToString() == ComboBoxAcc2.Text);
                var amount = decimal.Parse(TextBoxSum.Text);

                if (ComboBoxAcc1.SelectedValue.ToString() == ComboBoxAcc2.SelectedValue.ToString() ||
                    ComboBoxCl1.SelectedItem == ComboBoxCl2.SelectedItem)
                {
                    throw new ArgumentException("Select different accounts");
                }

                if ((decimal)acc1.Balance < amount)
                {
                    throw new InsufficientFundsException("Insufficient funds at the source account.");
                }

                MainWindow.transfer.Post(acc1, acc2, amount);

                MessageBox.Show($"{amount} YEN was transferred!");
                HistoryLog.SaveLogFile($"From account: {ComboBoxAcc1.SelectedValue.ToString()} to account: {ComboBoxAcc2.SelectedValue.ToString()} was transferred {amount} YEN.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number in the amount field.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InsufficientFundsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (WrongAmountException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("An unexpected error occurred.");
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
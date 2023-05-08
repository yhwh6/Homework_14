using Homework_13.Model;
using System;
using System.Windows;
using System.Windows.Controls;


namespace Homework_13
{
    /// <summary>
    /// Interaction logic for pAddAccount.xaml
    /// </summary>
    public partial class pAddAccount : Page
    {
        public pAddAccount()
        {
            InitializeComponent();
        }

        private void ButtonGeneration(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int cm = random.Next(0, 2);
            ComboBoxType.SelectedIndex = cm;
            string acc = cm == 0 ? "32345670" : "62346570";
            long accNum = random.NextInt64(100_000_000_000, 1_000_000_000_000);
            TextBoxNumber.Text = $"{acc}{accNum}";
        }

        private void ButtonCreate(object sender, RoutedEventArgs e)
        {
            if (ComboBoxType.Text != "" && TextBoxNumber.Text != "")
            {
                Account account;
                if (ComboBoxType.SelectedIndex == 0)
                {
                    account = new NonDeposit(TextBoxNumber.Text, 0);
                }
                else
                {
                    account = new Deposit(TextBoxNumber.Text, 0);
                }
                MainWindow.clients.AddAccount(MainWindow.CurrentClientTaxId, account);

                MessageBox.Show($"Account has been created for client {MainWindow.CurrentClientTaxId}.");
                HistoryLog.SaveLogFile($"Account has been created for client {MainWindow.CurrentClientTaxId}.");
            }
            else
            {
                MessageBox.Show("All fields must be filled in!");
            }
        }
    }
}

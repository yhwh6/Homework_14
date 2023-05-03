using System.Collections.Generic;
using System.Windows;
using System;
using System.Windows.Controls;

namespace Homework_12
{
    /// <summary>
    /// Interaction logic for pAddClient.xaml
    /// </summary>
    public partial class pAddClient : Page
    {
        private List<string> FullName = new List<string>()
        {
            "Johnny Depp",
            "Emma Watson",
            "Leonardo DiCaprio",
            "Matt Damon",
            "Angelina Jolie",
            "Brad Pitt",
            "Nicole Kidman",
            "Robert Downey Jr.",
            "Jennifer Lawrence",
            "Will Smith",
            "Amy Adams",
            "James McAvoy",
            "Emma Stone",
            "Michael Fassbender",
            "Scarlett Johansson",
            "Keanu Reeves",
            "Cate Blanchett",
            "Lady Gaga",
            "Hugh Jackman",
            "Ryan Reynolds",
            "Anna Kendrick",
            "Benedict Cumberbatch",
            "Jennifer Aniston",
            "Bruce Willis",
            "Tom Hiddleston",
            "Stephen Colbert",
            "Charlize Theron",
            "Ryan Gosling",
            "Michael B. Jordan",
            "Anne Hathaway",
        };
        public pAddClient()
        {
            InitializeComponent();
        }

        private void ButtonGeneration(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            TextBoxFullName.Text = FullName[random.Next(0, FullName.Count - 1)];
            TextBoxTaxId.Text = random.NextInt64(100_000_000, 999_999_999).ToString();
            TextBoxPhoneNumber.Text = "+38" + random.NextInt64(1_000_000_000, 9_999_999_999).ToString();
        }

        private void ButtonCreate(object sender, RoutedEventArgs e)
        {
            string FullName = TextBoxFullName.Text;
            string TaxId = TextBoxTaxId.Text;
            string PhoneNumber = TextBoxPhoneNumber.Text;

            if (String.IsNullOrEmpty(FullName) || String.IsNullOrEmpty(TaxId) || String.IsNullOrEmpty(PhoneNumber))
            {
                MessageBox.Show("All fields must be filled in!");
            }
            else
            {
                MainWindow.clients.Add(FullName, TaxId, PhoneNumber);
                MainWindow.CurrentClientTaxId = TaxId;
            }
        }
    }
}

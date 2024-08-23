using System;
using System.Windows;
using System.Windows.Controls;

namespace RecipeCookbook.Dashboard.BookMenu
{
    public partial class KhmerNodle : UserControl
    {
        public KhmerNodle()
        {
            InitializeComponent();
        }

        // Define an event
        public event EventHandler BackButtonClicked;

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            // Raise the event
            BackButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

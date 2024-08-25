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

        public event EventHandler CloseUserControlRequested;

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            // Raise the event to notify the parent that the control has been closed
            CloseUserControlRequested?.Invoke(this, EventArgs.Empty);
        }

    }
}

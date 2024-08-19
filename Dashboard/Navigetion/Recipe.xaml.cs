// Recipe.xaml.cs
using RecipeCookbook.Dashboard.BookMenu;
using System.Windows;
using System.Windows.Controls;

namespace RecipeCookbook
{
    public partial class Recipe : UserControl
    {
        public Recipe()
        {
            InitializeComponent();
        }

        private void KhmerNodle_Click(object sender, RoutedEventArgs e)
        {
            var khmernodle = new KhmerNodle();
            var parentWindow = Window.GetWindow(this) as DashboardWindow;

            if (parentWindow != null)
            {
                parentWindow.MainContentArea.Content = khmernodle;
            }
        }
    }
}

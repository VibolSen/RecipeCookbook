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

        private void KhmerNoodle_Click(object sender, RoutedEventArgs e)
        {
            var khmernoodle = new KhmerNodle();
            var parentWindow = Window.GetWindow(this) as DashboardWindow;

            if (parentWindow != null)
            {
                parentWindow.MainContentArea.Content = khmernoodle;
            }
        }

        private void Somlorkorkor_Click(object sender, RoutedEventArgs e)
        {
            var somlorkorkor = new Somlorkorkor();
            var parentWindow = Window.GetWindow(this) as DashboardWindow;

            if (parentWindow != null)
            {
                parentWindow.MainContentArea.Content = somlorkorkor;
            }
        }
    }
}

// DashboardMain.xaml.cs
using RecipeCookbook.Dashboard.BookMenu;
using System.Windows;
using System.Windows.Controls;

namespace RecipeCookbook
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void MjuKroung_Click(object sender, RoutedEventArgs e)
        {
            var mjuKroung = new MjuKroung();
            var parentWindow = Window.GetWindow(this) as DashboardWindow;

            if (parentWindow != null)
            {
                parentWindow.MainContentArea.Content = mjuKroung;
            }
        }

        private void Somlorkorkor_Click(object sender, RoutedEventArgs e)
        {
            var somlorkorkor = new Somlorkorkor();
            var parentWindow = Window.GetWindow(this) as DashboardWindow;

            if (parentWindow == null)
            {
                MessageBox.Show("DashboardWindow not found.");
                return;
            }

            parentWindow.MainContentArea.Content = somlorkorkor;
        }
    }
}

using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace RecipeCookbook
{
    public partial class DashboardWindow : Window
    {
        public DashboardWindow()
        {
            InitializeComponent();
            MainContentArea.Content = new Dashboard1();
        }

        private void DashboardButton_Click(object sender, RoutedEventArgs e)
        {
            // Load DashboardMain UserControl into the MainContentArea
            MainContentArea.Content = new Dashboard1();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            // Load DashboardMain UserControl into the MainContentArea
            MainContentArea.Content = new Home();
        }

        private void CountryButton_Click(object sender, RoutedEventArgs e)
        {
            // Load DashboardMain UserControl into the MainContentArea
            MainContentArea.Content = new Country();
        }

        private void RecipeButton_Click(object sender, RoutedEventArgs e)
        {
            // Load DashboardMain UserControl into the MainContentArea
            MainContentArea.Content = new Recipe();
        }

        private void AboutUsButton_Click(object sender, RoutedEventArgs e)
        {
            // Load DashboardMain UserControl into the MainContentArea
            MainContentArea.Content = new AboutUs();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the current window
            this.Close();
        }
    }
}

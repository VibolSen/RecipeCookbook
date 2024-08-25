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

            if (parentWindow == null)
            {
                MessageBox.Show("DashboardWindow not found.");
                return;
            }

            parentWindow.MainContentArea.Content = somlorkorkor;
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

        private void AmokFish_Click(object sender, RoutedEventArgs e)
        {
            var amokFish = new AmokFish();
            var parentWindow = Window.GetWindow(this) as DashboardWindow;

            if (parentWindow != null)
            {
                parentWindow.MainContentArea.Content = amokFish;
            }
        }

        private void BanhMi_Click(object sender, RoutedEventArgs e)
        {
            var banhMi = new BanhMi();
            var parentWindow = Window.GetWindow(this) as DashboardWindow;

            if (parentWindow != null)
            {
                parentWindow.MainContentArea.Content = banhMi;
            }
        }

        private void BurmsesTofu_Click(object sender, RoutedEventArgs e)
        {
            var burmesetofu = new BurmsesTofu();
            var parentWindow = Window.GetWindow(this) as DashboardWindow;

            if (parentWindow != null)
            {
                parentWindow.MainContentArea.Content = burmesetofu;
            }
        }

        private void GreenCurry_Click(object sender, RoutedEventArgs e)
        {
            var greenCurry = new Green_Cury();
            var parentWindow = Window.GetWindow(this) as DashboardWindow;

            if (parentWindow != null)
            {
                parentWindow.MainContentArea.Content = greenCurry;
            }
        }

        private void CaoLau_Click(object sender, RoutedEventArgs e)
        {
            var cuoLau = new Cao_Lau();
            var parentWindow = Window.GetWindow(this) as DashboardWindow;

            if (parentWindow != null)
            {
                parentWindow.MainContentArea.Content = cuoLau;
            }
        }

        private void BakSo_Click(object sender, RoutedEventArgs e)
        {
            var bakSo = new Bakso();
            var parentWindow = Window.GetWindow(this) as DashboardWindow;

            if (parentWindow != null)
            {
                parentWindow.MainContentArea.Content = bakSo;
            }
        }

        private void BayCha_Click(object sender, RoutedEventArgs e)
        {
            var bayCha = new BayCha();
            var parentWindow = Window.GetWindow(this) as DashboardWindow;

            if (parentWindow != null)
            {
                parentWindow.MainContentArea.Content = bayCha;
            }
        }

        private void Brahok_Click(object sender, RoutedEventArgs e)
        {
            var braHok = new BrahouKhteah();
            var parentWindow = Window.GetWindow(this) as DashboardWindow;

            if (parentWindow != null)
            {
                parentWindow.MainContentArea.Content = braHok;
            }
        }

        private void BanhKhot_Click(object sender, RoutedEventArgs e)
        {
            var banhKhot = new BanhKhot();
            var parentWindow = Window.GetWindow(this) as DashboardWindow;

            if (parentWindow != null)
            {
                parentWindow.MainContentArea.Content = banhKhot;
            }
        }

    }
}

﻿using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace RecipeCookbook
{
    public partial class DashboardWindow : Window
    {
        public DashboardWindow()
        {
            InitializeComponent();
            MainContentArea.Content = new Dashboard();
        }

        private void DashboardButton_Click(object sender, RoutedEventArgs e)
        {
            // Load DashboardMain UserControl into the MainContentArea
            MainContentArea.Content = new Dashboard();
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
    }
}

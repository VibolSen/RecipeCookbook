using Microsoft.Win32;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using System.IO;
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

        private void OpenFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Documents (*.doc;*.docx)|*.doc;*.docx";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                // Create a WebBrowser control to display the document
                WebBrowser webBrowser = new WebBrowser();

                try
                {
                    // Load the document in the WebBrowser
                    webBrowser.Navigate(new Uri(filePath));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while trying to open the file: " + ex.Message);
                }

                // Assuming 'MainContentArea' is your ContentControl in DashboardWindow
                MainContentArea.Content = webBrowser;
            }
        }

        private void OpenTextFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Read the content of the text file
                    string fileContent = File.ReadAllText(filePath);

                    // Create a TextBlock to display the text content
                    TextBlock textBlock = new TextBlock
                    {
                        Text = fileContent,
                        TextWrapping = TextWrapping.Wrap,
                        Margin = new Thickness(10)
                    };

                    // Display the TextBlock in the MainContentArea
                    MainContentArea.Content = textBlock;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while trying to open the file: " + ex.Message);
                }
            }
        }

        private void DropdownButton_Click(object sender, RoutedEventArgs e)
        {
            dropdownButton.ContextMenu.IsOpen = true;
        }


        private void SaveAsTextFile_Click(object sender, RoutedEventArgs e)
        {
            string content = GetContentFromMainContentArea();
            SaveFile("Text Files|*.txt", "Save as Text File", content);
        }

        private void SaveAsWordFile_Click(object sender, RoutedEventArgs e)
        {
            string content = GetContentFromMainContentArea();
            SaveFile("Word Documents|*.docx", "Save as Word File", content);
        }

        private void SaveAsExcelFile_Click(object sender, RoutedEventArgs e)
        {
            string content = GetContentFromMainContentArea();
            SaveFile("Excel Files|*.xlsx", "Save as Excel File", content);
        }

        private string GetContentFromMainContentArea()
        {
            if (MainContentArea.Content is TextBox textBox)
            {
                return textBox.Text;
            }
            else if (MainContentArea.Content is TextBlock textBlock)
            {
                return textBlock.Text;
            }
            else
            {
                // Handle other content types as needed
                return string.Empty;
            }
        }

        private void SaveFile(string filter, string title, string content)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = filter,
                Title = title
            };

            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, content);
                MessageBox.Show($"File saved as {saveFileDialog.FileName}", "File Saved", MessageBoxButton.OK, MessageBoxImage.Information);
            }
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

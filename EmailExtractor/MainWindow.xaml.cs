using System.Windows;
using System.Windows.Controls;

namespace EmailExtractor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();

            richtext.AppendText(dialog.SelectedPath);
            var emailExtractorObject = new EmailExtractorObject {RichText = richtext};
            emailExtractorObject.ProcessDirectory(dialog.SelectedPath);
        }
    }
}

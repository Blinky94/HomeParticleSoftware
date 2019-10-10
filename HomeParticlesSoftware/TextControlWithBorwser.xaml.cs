using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace HomeParticlesSoftware
{
    /// <summary>
    /// Logique d'interaction pour TextControlWithBorwser.xaml
    /// </summary>
    public partial class TextControlWithBorwser : UserControl
    {
        private string imagesFolder = @"E:\GameDevelop\ParticlesEngineMine\WpfApp1\WpfApp1\Textures\";
        public string FullPathTexture { get; internal set; }

        private string GetFileNameOnly(string fullImagePath)
        {
            if (fullImagePath.Contains("/"))
                return fullImagePath.Substring(fullImagePath.LastIndexOf('/') + 1);
            else if (fullImagePath.Contains("\\"))
                return fullImagePath.Substring(fullImagePath.LastIndexOf('\\') + 1);

            return fullImagePath;
        }

        public TextControlWithBorwser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var directoryExplore = new Microsoft.Win32.OpenFileDialog() { Filter = "JPG Files (*.jpg} | *.jpg | JPEG Files (*.jpeg} | *.jpeg | BMP Files (*.bmp} | *.bmp | PNG Files (*.png} | *.png" };
            directoryExplore.InitialDirectory = imagesFolder;
            var result = directoryExplore.ShowDialog();
            if (result == false) return;

            string fileName = directoryExplore.FileName;
            FullPathTexture = fileName;
            TextBox.Text = GetFileNameOnly(fileName);
            TextBox.Background = Brushes.GhostWhite;
            TextBox.IsEnabled = true;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TextBox.Background = Brushes.GhostWhite;
            TextBox.IsEnabled = true;
            Button.IsEnabled = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            TextBox.Background = Brushes.LightGray;
            TextBox.IsEnabled = false;
            TextBox.Text = string.Empty;
            Button.IsEnabled = false;
        }     
    }
}

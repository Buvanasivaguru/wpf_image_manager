using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WPF_ImageManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //Load the xaml file
            InitializeComponent();
        }

        /// <summary>
        /// Opens the dialog window to load an image 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="routedEventArgs"></param>
        private void onClickBrowseButton(object sender, RoutedEventArgs routedEventArgs)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.InitialDirectory = "c:\\";
            dlg.Filter = "Image files (*.jpg)|*.jpg|PNG (*.png)|*.png|All Files (*.*)|*.*";
            dlg.RestoreDirectory = true;

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                string selectedFileName = dlg.FileName;
               // FileNameLabel.Content = selectedFileName;
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(selectedFileName);
                bitmap.EndInit();
                ImageViewer.Source = bitmap;

            }
        }

        private void onClickExitButton(object sender, RoutedEventArgs routedEventArgs)
        {
            Console.Write("Closing the application. bye !");
            Environment.Exit(0);
        }
    }
}

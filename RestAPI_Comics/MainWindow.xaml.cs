using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using RestAPI_Library;

namespace RestAPI_Comics
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            APIHelper.Init();
        }

        private async Task LoadImage(int num = 0)
        {
            // API
            var comic = await WorkProcess.Load(num);

            // comic.Img

            imageComic.Source = new BitmapImage(new Uri(comic.Image));

        }

        private void btnPrev_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void btnNext_Click(object sender, RoutedEventArgs e)
        {
            await LoadImage();
        }
    }
}

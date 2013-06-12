using System.Windows;
using System.Windows.Media.Animation;

namespace SpinnyTest
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

        private void Spin_Click(object sender, RoutedEventArgs e)
        {
            spinnyBar.Visibility = System.Windows.Visibility.Visible;
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            spinnyBar.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}

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

namespace DoUWantToPlay
{
    public partial class MainWindow
    {

        private void MediaElement_MediaEnded(object sender, RoutedEventArgs e)
        {
            Noice.Position = TimeSpan.FromMilliseconds(1);
        }
        public MainWindow()
        {
            InitializeComponent();

            MessageBox.Show("Virus is installed on your computer ../System32/Windows/Defender/RandomViruse.exe", "", MessageBoxButton.OK, MessageBoxImage.Warning);
            MessageBox.Show("To deactivate of virus, answer one question honestly.", "", MessageBoxButton.OK, MessageBoxImage.Warning);
            if (MessageBox.Show("Do you want to play?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                while (MessageBox.Show("BITCH you want to play!!! >:D", "Command", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No);
            }
            MessageBox.Show("Virsu now is deactivated.", "Virus", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}

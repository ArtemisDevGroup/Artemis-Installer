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

namespace Artemis_Installer
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

        private void OnClick_Install(object sender, RoutedEventArgs e)
        {

        }

        private void OnClick_Minimize(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void OnClick_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void OnEnter_ChangeRed(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Background = Brushes.Red;
        }

        private void OnEnter_ChangeGray(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Background = new BrushConverter().ConvertFromString("#2A2A2A") as Brush;
        }

        private void OnLeave_Reset(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Background = Brushes.Transparent;
        }

        private void OnLeave_ChangeDarkGray(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Background = new BrushConverter().ConvertFromString("#1A1A1A") as Brush;
        }

        private void TopBorder_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}

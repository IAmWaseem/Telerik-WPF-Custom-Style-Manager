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
using Telerik.Windows.Controls;

namespace TelerikThemeTesting
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            StyleManagerHelper.Initialize();
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            themesList.Items.Add("Office Black");
            themesList.Items.Add("Windows 7");
            themesList.Items.Add("Windows 8");
        }

        private void themesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch ((String)themesList.SelectedItem)
            {
                case "Office Black":
                    StyleManagerHelper.SetTheme(TelerikTheme.OfficeBlack);
                    break;
                case "Windows 7":
                    StyleManagerHelper.SetTheme(TelerikTheme.Windows7);
                    break;
                case "Windows 8":
                    StyleManagerHelper.SetTheme(TelerikTheme.Windows8);
                    break;
                default:
                    break;
            }
        }

        private void GetThemeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Current Theme: " + StyleManagerHelper.GetTheme());
        }
    }
}

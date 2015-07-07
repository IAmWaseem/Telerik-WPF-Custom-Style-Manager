using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Telerik.Windows.Controls;

namespace TelerikThemeTesting
{
    public static class StyleManagerHelper
    {
        private static TelerikTheme DefaultTheme = TelerikTheme.Windows7;
        private static TelerikTheme CurrentTheme = DefaultTheme;

        public static void Initialize()
        {
            SetTheme(DefaultTheme);
        }

        public static String GetTheme()
        {
            return CurrentTheme.GetDescription();
        }

        public static void SetTheme(TelerikTheme theme)
        {
            switch (theme)
            {
                case TelerikTheme.OfficeBlack:
                    Application.Current.Resources.MergedDictionaries.Clear();
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
                    });
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
                    });
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Navigation.xaml", UriKind.RelativeOrAbsolute)
                    });
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("/Telerik.Windows.Themes.Office_Black;component/Themes/Telerik.Windows.Controls.Docking.xaml", UriKind.RelativeOrAbsolute)
                    });
                    CurrentTheme = TelerikTheme.OfficeBlack;
                    break;
                case TelerikTheme.Windows8:
                    Application.Current.Resources.MergedDictionaries.Clear();
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("/Telerik.Windows.Themes.Windows8;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
                    });
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
                    });
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Navigation.xaml", UriKind.RelativeOrAbsolute)
                    });
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("/Telerik.Windows.Themes.Windows8;component/Themes/Telerik.Windows.Controls.Docking.xaml", UriKind.RelativeOrAbsolute)
                    });
                    CurrentTheme = TelerikTheme.Windows8;
                    break;
                case TelerikTheme.Windows7:
                    Application.Current.Resources.MergedDictionaries.Clear();
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("/Telerik.Windows.Themes.Windows7;component/Themes/System.Windows.xaml", UriKind.RelativeOrAbsolute)
                    });
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("/Telerik.Windows.Themes.Windows7;component/Themes/Telerik.Windows.Controls.xaml", UriKind.RelativeOrAbsolute)
                    });
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("/Telerik.Windows.Themes.Windows7;component/Themes/Telerik.Windows.Controls.Navigation.xaml", UriKind.RelativeOrAbsolute)
                    });
                    Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary
                    {
                        Source = new Uri("/Telerik.Windows.Themes.Windows7;component/Themes/Telerik.Windows.Controls.Docking.xaml", UriKind.RelativeOrAbsolute)
                    });
                    CurrentTheme = TelerikTheme.Windows7;
                    break;
                default:
                    break;
            }
        }
    }
}

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

namespace Work1811
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        //private void ButtonSkin1_Click(object sender, RoutedEventArgs e)
        //{
        //    ResourceDictionary newResourceDictionary = new ResourceDictionary();
        //    newResourceDictionary.Source = new Uri("Skin1.xaml", UriKind.Relative);
        //    Resources.MergedDictionaries[0] = newResourceDictionary;
        //    LabelSkins.Content = "Skin1";
        //}

        //private void ButtonSkin2_Click(object sender, RoutedEventArgs e)
        //{
        //    ResourceDictionary newResourceDictionary = new ResourceDictionary();
        //    newResourceDictionary.Source = new Uri("Skin2.xaml", UriKind.Relative);
        //    Resources.MergedDictionaries[0] = newResourceDictionary;
        //    LabelSkins.Content = "Skin2";
        //}

        //private void ButtonDefault_Click(object sender, RoutedEventArgs e)
        //{
        //    ResourceDictionary newResourceDictionary = new ResourceDictionary();
        //    newResourceDictionary.Source = new Uri("DefaultDictionary.xaml", UriKind.Relative);
        //    Resources.MergedDictionaries[0] = newResourceDictionary;
        //    LabelSkins.Content = "Default Skin";
        //}
    }
}

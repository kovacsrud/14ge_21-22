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

namespace WpfIsmetles
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

        private void buttonNovel_Click(object sender, RoutedEventArgs e)
        {
            var ertek = Convert.ToInt32(labelSzam.Content);
            ertek += 1;
            labelSzam.Content = ertek;
        }

        private void buttonCsokkent_Click(object sender, RoutedEventArgs e)
        {
            var ertek = Convert.ToInt32(labelSzam.Content);
            if (ertek>0)
            {
                ertek -= 1;
                labelSzam.Content = ertek;
            }


            
        }
    }
}

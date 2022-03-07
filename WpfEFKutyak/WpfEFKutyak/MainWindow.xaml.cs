using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WpfEFKutyak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Kutyamodel kutyamodel;
        public MainWindow()
        {
            InitializeComponent();
            kutyamodel = new Kutyamodel();
            kutyamodel.Kutyafajtak.Load();
            kutyamodel.Kutyak.Load();
            kutyamodel.Kutyanevek.Load();
            DataContext = kutyamodel;
            
        }



        private void DbUpdate()
        {
            var muvelet = kutyamodel.SaveChanges();
            if (muvelet>0)
            {
                MessageBox.Show("Adatbázis módosítva!");
            }
            else
            {
                MessageBox.Show("Nem történt változás.");
            }

        }

        private void buttonKutyanevekUpdate_Click(object sender, RoutedEventArgs e)
        {
            DbUpdate();
        }

        private void buttonKutyafajtakUpdate_Click(object sender, RoutedEventArgs e)
        {
            DbUpdate();
        }

        private void buttonKutyakUpdate_Click(object sender, RoutedEventArgs e)
        {
            DbUpdate();
        }
    }
}

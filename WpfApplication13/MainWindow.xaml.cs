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

namespace WpfApplication13
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

        private void btnTong_Click(object sender, RoutedEventArgs e)
        {
            Double a = double.Parse(txta.Text);
            Double b = double.Parse(txtb.Text);
            txtdapan.Text = Tong(a, b).ToString();
        }
            public double Tong(Double a, Double b)
            {
                return a + b;
            }

        private void btnHieu_Click(object sender, RoutedEventArgs e)
        {
             Double a = double.Parse(txta.Text);
            Double b = double.Parse(txtb.Text);
            txtdapan.Text = Hieu(a, b).ToString();
        }
            public double Hieu(Double a, Double b)
            {
                return a - b;
            }

        private void btnTich_Click(object sender, RoutedEventArgs e)
        {
            
             Double a = double.Parse(txta.Text);
            Double b = double.Parse(txtb.Text);
            txtdapan.Text = Tich(a, b).ToString();
        }
            public double Tich(Double a, Double b)
            {
                return a * b;
            }

        private void btnThuong_Click(object sender, RoutedEventArgs e)
        {
             Double a = double.Parse(txta.Text);
            Double b = double.Parse(txtb.Text);
            txtdapan.Text = Thuong(a, b).ToString();
         }
            public double Thuong(Double a, Double b)
            {
                return a / b;
            }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

            
        }
        }


        
    

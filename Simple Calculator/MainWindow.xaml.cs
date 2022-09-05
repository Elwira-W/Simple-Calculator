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

namespace Simple_Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + 0;
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + 1;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + 2;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + 3;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + 4;
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + 5;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + 6;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + 7;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + 8;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + 9;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Result.Clear();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = Result.Text + "+";
        }

        private void EqualSign_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}

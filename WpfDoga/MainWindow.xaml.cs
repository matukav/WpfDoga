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

namespace WpfDoga
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

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Task1View_Click(object sender, RoutedEventArgs e)
        {
            Tasks.Task1 taskObj = new Tasks.Task1();
            showPage1.Children.Add(taskObj);
        }

        private void Task2View_Click(object sender, RoutedEventArgs e)
        {
            Tasks.Task2 taskObj = new Tasks.Task2();
            showPage2.Children.Add(taskObj);
        }
    }
}

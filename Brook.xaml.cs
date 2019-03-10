using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assertion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Brook : Window,IView
    {
        View v;
        public Brook()
        {
            InitializeComponent();
        }

        private void ClassA_Click(object sender, RoutedEventArgs e)
        {
            //clm = new ClassA();
            v = new View(new Assertion.ClassA());
            v.ShowDialog();
        }


        private void ClassB_Click(object sender, RoutedEventArgs e)
        {
            v = new View(new Assertion.ClassB());
            v.ShowDialog(); 
        }
    }
}

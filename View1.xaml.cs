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
using System.Windows.Shapes;

namespace Assertion
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : Window
    {
        
        ViewModel vm;
        List<Student> stList = new List<Student>();
        public List<Student> StList{get {return stList;}}
        public View()
        {
            InitializeComponent();
        }

        public View(ClassModel clM):this()
        {
            vm = new ViewModel(clM); 
        }

        private void SortName_Click(object sender, RoutedEventArgs e)
        {
            stList = vm.GetViewStudentList(SortBy.ByName);

            
            rtBox.Document.Blocks.Clear();
            
            foreach (Student stu in stList)
            {

                rtBox.AppendText(stu.Name + "\t" + stu.Mark);

                rtBox.AppendText( Environment.NewLine);

                //+Environment.NewLine;

            }
        }

        
        private void SortMark_Click(object sender, RoutedEventArgs e)
        {
            stList =  vm.GetViewStudentList(SortBy.ByMark);

            
            rtBox.Document.Blocks.Clear();

            foreach (Student stu in stList)
            {

                rtBox.AppendText( stu.Name + "\t" + stu.Mark);
                //+Environment.NewLine;
                rtBox.AppendText(Environment.NewLine);

            }
        }
    }
}

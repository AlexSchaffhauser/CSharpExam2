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
using System.Windows.Shapes;

namespace Exam2
{
    /// <summary>
    /// Interaction logic for StudentList.xaml
    /// </summary>
    public partial class StudentList : Window
    {
        List<Student> students = new List<Student>();
        public StudentList()
        {
            InitializeComponent();

            Student std1 = new Student(1, "John");
            Student std2 = new Student(2, "Christopher");
            Student std3 = new Student(3, "Patricia");
            Student std4 = new Student(4, "Marley");
            Student std5 = new Student(5, "Ron");

            
            students.Add(std1);
            students.Add(std2);
            students.Add(std3);
            students.Add(std4);
            students.Add(std5);
        }

        private void submitId_Click(object sender, RoutedEventArgs e)
        {
            foreach (Student std in students())
            {

            }
        }
    }
}

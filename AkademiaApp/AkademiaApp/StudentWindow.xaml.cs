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


namespace AkademiaApp
{
   
    public partial class StudentWindow : Window
    {
        public StudentWindow()
        {
            InitializeComponent();
            StudentDaoImpl sdi = new StudentDaoImpl();
            List<Student> studentList = new List<Student>();
            studentList = sdi.getAllStudents();
            dgStudent.ItemsSource = studentList;
            cbKierunek.ItemsSource = Enum.GetValues(typeof(MainWindow.branchOfStudy));
        }
        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            Student classObj = dgStudent.SelectedItem as Student;
            int id = classObj.Id;
            MarksWindow w = new MarksWindow(id);
            w.ShowDialog();
        }
        private void DG1_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            switch (e.Column.Header.ToString())
            {
                case "Id":
                    e.Column.DisplayIndex = 0;
                    break;
                case "Name":
                    e.Column.DisplayIndex = 1;
                    break;
                case "Surname":
                    e.Column.DisplayIndex = 2;
                    break;
                case "PhoneNumber":
                    e.Column.DisplayIndex = 3;
                    break;
                case "BranchOfStudy":
                    e.Column.DisplayIndex = 4;
                    break;
                case "NrIdx":
                    e.Column.DisplayIndex = 5;
                    break;
                default:
                    e.Column.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        private void bDelete_Click(object sender, RoutedEventArgs e)
        {
            StudentDaoImpl sdi = new StudentDaoImpl();
            Student s = sdi.getStudentById(int.Parse(tbId.Text.ToString()));
            
            MarkDaoImpl mdi = new MarkDaoImpl();
            
            sdi.deleteStudent(s);
            List<Mark> markList = new List<Mark>();
            markList = mdi.getMarksStudent(s.Id);
            foreach(Mark m in markList)
            {
               mdi.deleteMark(m);
            }
        }

        private void bShow_Click(object sender, RoutedEventArgs e)
        {
            BranchStudents b = new BranchStudents(cbKierunek.Text.ToString());
            b.ShowDialog();
        }

        private void bAverage_Click(object sender, RoutedEventArgs e)
        {
            MarkDaoImpl mdi = new MarkDaoImpl();
            MessageBox.Show("Student Average : "+mdi.getStudentAverage(int.Parse(tbId.Text.ToString())));
        }
    }
}

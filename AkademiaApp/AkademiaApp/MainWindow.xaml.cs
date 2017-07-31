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
using System.Diagnostics;


namespace AkademiaApp
{
    public partial class MainWindow : Window
    {
        public enum branchOfStudy { Philosophy, Maths, Architektura, Mechanics }
        public enum academicDegree { Engineer, Master, Doctor, Professor }
        public List<int> lo = new List<int>() { 2, 3, 4, 5 };

        public MainWindow()
        {
            InitializeComponent();
            DbConnection db = DbConnection.getInstance();
            db.OpenConection();
        }

        private void rbStudents_Checked(object sender, RoutedEventArgs e)
        {
            lNrIdx.Visibility = Visibility.Visible;
            lBranchOfStudy.Visibility = Visibility.Visible;
            lMaths.Visibility = Visibility.Visible;
            lPhysics.Visibility = Visibility.Visible;
            lEnglish.Visibility = Visibility.Visible;
            lProgramming.Visibility = Visibility.Visible;
            cbMaths.Visibility = Visibility.Visible;
            cbPhysics.Visibility = Visibility.Visible;
            cbEnglish.Visibility = Visibility.Visible;
            cbProgramming.Visibility = Visibility.Visible;
            tbNrIdx.Visibility = Visibility.Visible;
            cbBranchOfStudy.Visibility = Visibility.Visible;

            lAcademicDegree.Visibility = Visibility.Hidden;
            lSalary.Visibility = Visibility.Hidden;
            cbAcademicDegree.Visibility = Visibility.Hidden;
            tbSalary.Visibility = Visibility.Hidden;
            cbBranchOfStudy.ItemsSource= Enum.GetValues(typeof(branchOfStudy));
            cbEnglish.ItemsSource = lo;
            cbPhysics.ItemsSource = lo;
            cbMaths.ItemsSource = lo;
            cbProgramming.ItemsSource = lo;
        }

        private void rbTeachers_Checked(object sender, RoutedEventArgs e)
        {
            lNrIdx.Visibility = Visibility.Hidden;
            lBranchOfStudy.Visibility = Visibility.Hidden;
            lMaths.Visibility = Visibility.Hidden;
            lPhysics.Visibility = Visibility.Hidden;
            lEnglish.Visibility = Visibility.Hidden;
            lProgramming.Visibility = Visibility.Hidden;
            cbMaths.Visibility = Visibility.Hidden;
            cbPhysics.Visibility = Visibility.Hidden;
            cbEnglish.Visibility = Visibility.Hidden;
            cbProgramming.Visibility = Visibility.Hidden;
            tbNrIdx.Visibility = Visibility.Hidden;
            cbBranchOfStudy.Visibility = Visibility.Hidden;

            lAcademicDegree.Visibility = Visibility.Visible;
            lSalary.Visibility = Visibility.Visible;
            cbAcademicDegree.Visibility = Visibility.Visible;
            cbAcademicDegree.ItemsSource= Enum.GetValues(typeof(academicDegree));
            tbSalary.Visibility = Visibility.Visible;

        }

        private void bExit_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
      
        private void bClear_Click(object sender, RoutedEventArgs e)
        {
            tbName.Text = "";
            tbSurname.Text = "";
            tbPhoneNumber.Text = "";
            cbBranchOfStudy.Text = "";
            tbNrIdx.Text = "";
            tbSalary.Text = "";


            lAcademicDegree.Visibility = Visibility.Hidden;
            lSalary.Visibility = Visibility.Hidden;
            cbAcademicDegree.Visibility = Visibility.Hidden;
            tbSalary.Visibility = Visibility.Hidden;

            rbStudent.IsChecked = false;
            rbTeacher.IsChecked = false;

            lNrIdx.Visibility = Visibility.Hidden;
            lBranchOfStudy.Visibility = Visibility.Hidden;
            lMaths.Visibility = Visibility.Hidden;
            lPhysics.Visibility = Visibility.Hidden;
            lEnglish.Visibility = Visibility.Hidden;
            lProgramming.Visibility = Visibility.Hidden;
            cbMaths.Visibility = Visibility.Hidden;
            cbPhysics.Visibility = Visibility.Hidden;
            cbEnglish.Visibility = Visibility.Hidden;
            cbProgramming.Visibility = Visibility.Hidden;
            cbBranchOfStudy.Visibility = Visibility.Hidden;
            tbNrIdx.Visibility = Visibility.Hidden;
        }

        private void bAdd_Click(object sender, RoutedEventArgs e)
        {
            if (rbStudent.IsChecked == true)
            {
                StudentDaoImpl sdi = new StudentDaoImpl();
                Student s = new Student(tbName.Text.ToString(), tbSurname.Text.ToString(), tbPhoneNumber.Text.ToString(), int.Parse(tbNrIdx.Text), (MainWindow.branchOfStudy)Enum.Parse(typeof(MainWindow.branchOfStudy), cbBranchOfStudy.Text));
                sdi.addStudent(s);
                int idxLastStudent = sdi.getLastStudent();
                DbConnection.getInstance().CloseConnection();
                Mark m1 = new Mark(int.Parse(cbMaths.Text.ToString()), idxLastStudent, 1);
                Mark m2 = new Mark(int.Parse(cbPhysics.Text.ToString()), idxLastStudent, 2);
                Mark m3 = new Mark(int.Parse(cbEnglish.Text.ToString()), idxLastStudent, 3);
                Mark m4 = new Mark(int.Parse(cbProgramming.Text.ToString()),idxLastStudent, 4);
                MarkDaoImpl mdi = new MarkDaoImpl();
                mdi.addMark(m1);
                mdi.addMark(m2);
                mdi.addMark(m3);
                mdi.addMark(m4);
            }
           
            if (rbTeacher.IsChecked==true)
            {
                TeacherDaoImpl tdi = new TeacherDaoImpl();
                Teacher t = new Teacher(tbName.Text.ToString(), tbSurname.Text.ToString(),tbPhoneNumber.Text.ToString(), (MainWindow.academicDegree)Enum.Parse(typeof(MainWindow.academicDegree), cbAcademicDegree.Text),Double.Parse(tbSalary.Text.ToString()));
                tdi.addTeacher(t);
            }
        }

        private void bStudents_Click(object sender, RoutedEventArgs e)
        {
            StudentWindow w = new StudentWindow();
            w.ShowDialog();

        }

        private void bTeachers_Click(object sender, RoutedEventArgs e)
        {
            TeacherWindow w = new TeacherWindow();
            w.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SubjectDaoImpl sdi = new SubjectDaoImpl();
            Subject s = new Subject("Maths");
            Subject s2 = new Subject("Phyics");
            Subject s3 = new Subject("English");
            Subject s4 = new Subject("Programming");
            sdi.addSubject(s);
            sdi.addSubject(s2);
            sdi.addSubject(s3);
            sdi.addSubject(s4);
        }
    }
}

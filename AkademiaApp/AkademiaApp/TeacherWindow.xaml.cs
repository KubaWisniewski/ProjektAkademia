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
    public partial class TeacherWindow : Window
    {
        public TeacherWindow()
        {
            InitializeComponent();
            TeacherDaoImpl sdi = new TeacherDaoImpl();
            List<Teacher> teacherList = new List<Teacher>();
            teacherList = sdi.getAllTeachers();
            dgTeacher.ItemsSource = teacherList;
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
                case "AcademicDegree":
                    e.Column.DisplayIndex = 4;
                    break;
                case "Salary":
                    e.Column.DisplayIndex = 5;
                    break;
                default:
                    e.Column.Visibility = Visibility.Collapsed;
                    break;
            }
        }
    }
}

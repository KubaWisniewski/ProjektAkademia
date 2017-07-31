using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaApp
{
    interface StudentDao
    {
        void addStudent(Student student);
        void modifyStudent(Student student);
        void deleteStudent(Student student);
        List<Student> getAllStudents();
        Student getStudentById(int id);
        int getLastStudent();
    }
}

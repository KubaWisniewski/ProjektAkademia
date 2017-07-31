using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiaApp
{
    interface TeacherDao
    {
        void addTeacher(Teacher teacher);
        void modifyTeacher(Teacher teacher);
        void deleteTeacher(Teacher teacher);
        List<Teacher> getAllTeachers();
        Teacher getTeacherById(int id);
    }
}

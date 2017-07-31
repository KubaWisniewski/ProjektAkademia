using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AkademiaApp
{
    class TeacherDaoImpl : TeacherDao
    {
        public void addTeacher(Teacher teacher)
        {
            string sql = "INSERT INTO Teacher(name,surname,phoneNumber,academicDegree,salary) VALUES ('" + teacher.Name + "','" + teacher.Surname + "','" + teacher.PhoneNumber + "','" + teacher.AcademicDegree.ToString() + "','" + teacher.Salary + "');";
            DbConnection.getInstance().OpenConection();
            DbConnection.getInstance().ExecuteQueries(sql);
            DbConnection.getInstance().CloseConnection();
        }
        public void modifyTeacher(Teacher teacher)
        {
            string sql = "UPDATE Teacher SET name='" + teacher.Name + "', surname='" +teacher.Surname + "',phoneNumber='" + teacher.PhoneNumber + "',academicDegree='" + teacher.AcademicDegree.ToString() + "',salary='" + teacher.Salary + "' where id=" + teacher.Id + ";";
            DbConnection.getInstance().OpenConection();
            DbConnection.getInstance().ExecuteQueries(sql);
            DbConnection.getInstance().CloseConnection();
        }
        public void deleteTeacher(Teacher teacher)
        {
            string sql = "DELETE FROM Teacher where id=" + teacher.Id + ";";
            DbConnection.getInstance().OpenConection();
            DbConnection.getInstance().ExecuteQueries(sql);
            DbConnection.getInstance().CloseConnection();
        }
        public List<Teacher> getAllTeachers()
        {
            string sql = "SELECT * FROM Teacher;";
            DbConnection.getInstance().OpenConection();
            SQLiteDataReader reader = DbConnection.getInstance().ExecuteReader(sql);
            
            List<Teacher> teacherList = new List<Teacher>();
            while (reader.Read())
            {
               Teacher s = new Teacher(
                    reader["name"].ToString(), reader["surname"].ToString(), reader["phoneNumber"].ToString(), (MainWindow.academicDegree)Enum.Parse(typeof(MainWindow.academicDegree), reader["academicDegree"].ToString()),Double.Parse(reader["salary"].ToString()) );
                s.Id = int.Parse(reader["id"].ToString());
                teacherList.Add(s);
            }
            reader.Close();
            DbConnection.getInstance().CloseConnection();
            return teacherList;
        }
        public Teacher getTeacherById(int id)
        {
            string sql = "SELECT * FROM Teacher where id=" + id + ";";
            DbConnection.getInstance().OpenConection();
            SQLiteDataReader reader = DbConnection.getInstance().ExecuteReader(sql);
            if (reader.Read())
            {
                Teacher s = new Teacher(
                    reader["name"].ToString(), reader["surname"].ToString(), reader["phoneNumber"].ToString(), (MainWindow.academicDegree)Enum.Parse(typeof(MainWindow.academicDegree), reader["academicDegree"].ToString()), Double.Parse(reader["salary"].ToString()));
                s.Id = int.Parse(reader["id"].ToString());
                reader.Close();
                DbConnection.getInstance().CloseConnection();

                return s;
            }
            reader.Close();
            DbConnection.getInstance().CloseConnection();
            return null;
        }
    }
}

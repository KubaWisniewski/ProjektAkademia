using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace AkademiaApp
{
    class StudentDaoImpl : StudentDao
    {
        public void addStudent(Student student)
        {
            string sql = "INSERT INTO Student(name,surname,phoneNumber,nrIdx,branchOfStudy) VALUES ('" + student.Name + "','" + student.Surname + "','" + student.PhoneNumber + "','" + student.NrIdx + "','" + student.BranchOfStudy.ToString() + "');";
            DbConnection.getInstance().OpenConection();

            DbConnection.getInstance().ExecuteQueries(sql);
                
            DbConnection.getInstance().CloseConnection();
        }

        public void modifyStudent(Student student)
        {
            string sql = "UPDATE Student SET name='" + student.Name + "', surname='" + student.Surname + "',phoneNumber='" + student.PhoneNumber + "',nrIdx='" + student.NrIdx + "',branchOfStudy='" + student.BranchOfStudy.ToString() + "' where id=" + student.Id + ";";
            DbConnection.getInstance().OpenConection();
            DbConnection.getInstance().ExecuteQueries(sql);
            DbConnection.getInstance().CloseConnection();
        }

        public void deleteStudent(Student student)
        {
            string sql = "DELETE FROM Student where id='" + student.Id + "';";
            DbConnection.getInstance().OpenConection();
            DbConnection.getInstance().ExecuteQueries(sql);
            DbConnection.getInstance().CloseConnection();
        }
        public List<Student> getAllStudents()
        {
            string sql = "SELECT * FROM Student;";
            DbConnection.getInstance().OpenConection();
            SQLiteDataReader reader = DbConnection.getInstance().ExecuteReader(sql);
           
            List<Student> studentList = new List<Student>();
            while (reader.Read())
            {
                Student s = new Student(
                    reader["name"].ToString(), reader["surname"].ToString(), reader["phoneNumber"].ToString(), int.Parse(reader["nrIdx"].ToString()), (MainWindow.branchOfStudy)Enum.Parse(typeof(MainWindow.branchOfStudy),reader["branchOfStudy"].ToString()));
                s.Id = int.Parse(reader["id"].ToString());
                studentList.Add(s);
            }
            reader.Close();
            DbConnection.getInstance().CloseConnection();
            return studentList;
        }
        public Student getStudentById(int id)
        {
            string sql = "SELECT * FROM Student where id="+id+";";
            DbConnection.getInstance().OpenConection();
            SQLiteDataReader reader = DbConnection.getInstance().ExecuteReader(sql);
            
            if (reader.Read())
            {
                Student s = new Student(
                    reader["name"].ToString(), reader["surname"].ToString(), reader["phoneNumber"].ToString(), int.Parse(reader["nrIdx"].ToString()), (MainWindow.branchOfStudy)Enum.Parse(typeof(MainWindow.branchOfStudy), reader["branchOfStudy"].ToString()));
                s.Id = int.Parse(reader["id"].ToString());
                reader.Close();
                DbConnection.getInstance().CloseConnection();
                return s;
            }
            reader.Close();
            DbConnection.getInstance().CloseConnection();
            return null;
        }
        public int getLastStudent()
        {
            string sql = "SELECT max(id) FROM Student;";
            DbConnection.getInstance().OpenConection();
            SQLiteDataReader reader = DbConnection.getInstance().ExecuteReader(sql);

            if (reader.Read())
            {
                int idx = int.Parse(reader[0].ToString());
                reader.Close();
                DbConnection.getInstance().CloseConnection();
               
                return idx;
            }
            else
            {
                reader.Close();
                DbConnection.getInstance().CloseConnection();
                return 0;
            }
        }
        public List<Student> getStudentsWithBranch(string branch)
        {
            string sql = "SELECT * FROM Student where branchOfStudy='"+branch+"';";
            DbConnection.getInstance().OpenConection();
            SQLiteDataReader reader = DbConnection.getInstance().ExecuteReader(sql);

            List<Student> studentList = new List<Student>();
            while (reader.Read())
            {
                Student s = new Student(
                    reader["name"].ToString(), reader["surname"].ToString(), reader["phoneNumber"].ToString(), int.Parse(reader["nrIdx"].ToString()), (MainWindow.branchOfStudy)Enum.Parse(typeof(MainWindow.branchOfStudy), reader["branchOfStudy"].ToString()));
                s.Id = int.Parse(reader["id"].ToString());
                studentList.Add(s);
            }
            reader.Close();
            DbConnection.getInstance().CloseConnection();
            return studentList;
        }
    }
}

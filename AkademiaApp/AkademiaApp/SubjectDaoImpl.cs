using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace AkademiaApp
{
    class SubjectDaoImpl
    {
        public void addSubject(Subject subject)
        {
            string sql = "INSERT INTO Subject(name) VALUES ('" + subject.Name+ "');";
            DbConnection.getInstance().OpenConection();
            DbConnection.getInstance().ExecuteQueries(sql);
            DbConnection.getInstance().CloseConnection();
        }
        public void modifySubject(Subject subject)
        {
            string sql = "UPDATE Subject SET value='" +subject.Name+ "' where id=" + subject.Id + ";";
            DbConnection.getInstance().OpenConection();
            DbConnection.getInstance().ExecuteQueries(sql);
            DbConnection.getInstance().CloseConnection();
        }
        public void deleteSubject(Subject subject)
        {
            string sql = "DELETE FROM Subject where id=" + subject.Id + ";";
            DbConnection.getInstance().OpenConection();
            DbConnection.getInstance().ExecuteQueries(sql);
            DbConnection.getInstance().CloseConnection();
        }
        public List<Subject> getAllSubject()
        {
            string sql = "SELECT * FROM Subject;";
            DbConnection.getInstance().OpenConection();
            SQLiteDataReader reader = DbConnection.getInstance().ExecuteReader(sql);

            List<Subject> subjectList = new List<Subject>();
            while (reader.Read())
            {
                Subject s = new Subject(reader["name"].ToString());
                s.Id = int.Parse(reader["id"].ToString());
              
                subjectList.Add(s);
            }
            reader.Close();
            DbConnection.getInstance().CloseConnection();
            return subjectList;

        }
        public Subject getSubjectById(int id)
        {
            string sql = "SELECT * FROM Subject where id=" + id + ";";
            DbConnection.getInstance().OpenConection();
            SQLiteDataReader reader = DbConnection.getInstance().ExecuteReader(sql);
            if (reader.Read())
            {
                Subject s = new Subject(reader["name"].ToString());
                s.Id = int.Parse(reader["id"].ToString());
                reader.Close();
                DbConnection.getInstance().CloseConnection();
                return s;
            }
            reader.Close();
            DbConnection.getInstance().CloseConnection();
            return null;
        }
        public List<SubjectMark> getSubjectWithMark(int id)
        {
            string sql = "SELECT s.name,m.val FROM Subject s inner join Mark m on s.id=m.idSubject where idStudent=" + id + ";";
            DbConnection.getInstance().OpenConection();
            SQLiteDataReader reader = DbConnection.getInstance().ExecuteReader(sql);
            
            List<SubjectMark> subjectList = new List<SubjectMark>();
            while (reader.Read())
            {
                SubjectMark s = new SubjectMark(reader["name"].ToString(),int.Parse(reader["val"].ToString()));
                subjectList.Add(s);
            }
            reader.Close();
            DbConnection.getInstance().CloseConnection();
            return subjectList;
        }
    }
}

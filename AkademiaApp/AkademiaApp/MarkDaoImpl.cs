using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace AkademiaApp
{
    class MarkDaoImpl : MarkDao
    {
         public void addMark(Mark mark)
        {
            string sql = "INSERT INTO Mark(val,idStudent,idSubject) VALUES ('" + mark.Value + "','" + mark.IdStudent+ "','" + mark.IdSubject + "');";
            DbConnection.getInstance().OpenConection();
            DbConnection.getInstance().ExecuteQueries(sql);
            DbConnection.getInstance().CloseConnection();
         }
        public void modifyMark(Mark mark)
        {
            string sql = "UPDATE Mark SET val='" + mark.Value + "', idStudent='" + mark.IdStudent + "',idSubject='" + mark.IdSubject + "' where id=" + mark.Id + ";";
            DbConnection.getInstance().OpenConection();
            DbConnection.getInstance().ExecuteQueries(sql);
            DbConnection.getInstance().CloseConnection();
        }
        public void deleteMark(Mark mark)
        {
            string sql = "DELETE FROM Mark where id=" + mark.Id + ";";
            DbConnection.getInstance().OpenConection();
            DbConnection.getInstance().ExecuteQueries(sql);
            DbConnection.getInstance().CloseConnection();
        }
        public List<Mark> getAllMarks()
        {
            string sql = "SELECT * FROM Mark;";
            DbConnection.getInstance().OpenConection();
            SQLiteDataReader reader = DbConnection.getInstance().ExecuteReader(sql);

            List<Mark> markList = new List<Mark>();
            while (reader.Read())
            {
                Mark m = new Mark(
                  int.Parse(reader["val"].ToString()), int.Parse(reader["idStudent"].ToString()), int.Parse(reader["idSubject"].ToString())

                  );
                m.Id = int.Parse(reader["id"].ToString());
              
                markList.Add(m);
            }
            reader.Close();
            DbConnection.getInstance().CloseConnection();
            return markList;
        }
        public Mark getMarkById(int id)
        {
            string sql = "SELECT * FROM Mark where id=" + id + ";";
            DbConnection.getInstance().OpenConection();
            SQLiteDataReader reader = DbConnection.getInstance().ExecuteReader(sql);
           
            if (reader.Read())
            {
                Mark m = new Mark(
                   int.Parse(reader["val"].ToString()),int.Parse(reader["idStudent"].ToString()),int.Parse(reader["idSubject"].ToString())

                   );
                m.Id = int.Parse(reader["id"].ToString());
                reader.Close();
                DbConnection.getInstance().CloseConnection();
                return m;
            }
            reader.Close();
            DbConnection.getInstance().CloseConnection();
            return null;
        }
        public List<Mark> getMarksStudent(int id)
        {
            string sql = "SELECT * FROM Mark where idStudent='"+id+"';";
            DbConnection.getInstance().OpenConection();
            SQLiteDataReader reader = DbConnection.getInstance().ExecuteReader(sql);

            List<Mark> markList = new List<Mark>();
            while (reader.Read())
            {
                Mark m = new Mark(
                  int.Parse(reader["val"].ToString()), int.Parse(reader["idStudent"].ToString()), int.Parse(reader["idSubject"].ToString())

                  );
                m.Id = int.Parse(reader["id"].ToString());

                markList.Add(m);
            }
            reader.Close();
            DbConnection.getInstance().CloseConnection();
            return markList;
        }
        public double getStudentAverage(int id)
        {
            string sql = "Select avg(m.val) from Mark as m where idStudent=" + id + ";";
            DbConnection.getInstance().OpenConection();
            SQLiteDataReader reader = DbConnection.getInstance().ExecuteReader(sql);

            if (reader.Read())
            {
                double avg= double.Parse(reader[0].ToString());
                reader.Close();
                DbConnection.getInstance().CloseConnection();

                return avg;
            }
            else
            {
                reader.Close();
                DbConnection.getInstance().CloseConnection();
                return 0;
            }
        }
    }
}

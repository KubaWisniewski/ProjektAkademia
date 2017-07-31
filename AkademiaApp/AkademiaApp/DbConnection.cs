using System.Data.SQLite;

namespace AkademiaApp
{
    class DbConnection
    {
        private static DbConnection instance = null;
        private string ConnectionString = "data source=C: \\Users\\Kuba\\Documents\\Visual Studio 2015\\Projects\\AkademiaApp\\AkademiaApp\\DBTest.db;Version=3;";
        private SQLiteConnection connection;
        
        public static DbConnection getInstance()
        {
            if(instance==null)
            {
                instance = new DbConnection();
            }
            return instance;
        }

        public void createDbFile()
        {
            if (!System.IO.File.Exists("C: \\Users\\Kuba\\Documents\\Visual Studio 2015\\Projects\\AkademiaApp\\AkademiaApp\\DBTest.db"))
            {
                SQLiteConnection.CreateFile("C: \\Users\\Kuba\\Documents\\Visual Studio 2015\\Projects\\AkademiaApp\\AkademiaApp\\DBTest.db");
            }
        }

        private DbConnection()
        {
            CreateTables();
            createDbFile();
        }

        public void OpenConection()
        {
            connection = new SQLiteConnection(ConnectionString);
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void CreateTables()
        {
            string studentTable = "CREATE TABLE IF NOT EXISTS Student(" +
                "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                "name VARCHAR(30) NOT NULL," +
                "surname VARCHAR(30) NOT NULL," +
                "phoneNumber VARCHAR(30) NOT NULL," +
                "nrIdx INTEGER NOT NULL," +
                "branchOfStudy VARCHAR(30) NOT NULL" +
                "); ";
            string teacherTable = "CREATE TABLE IF NOT EXISTS Teacher(" +
                 "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                 "name VARCHAR(30) NOT NULL," +
                 "surname VARCHAR(30) NOT NULL," +
                 "phoneNumber VARCHAR(30) NOT NULL," +
                 "academicDegree VARCHAR(30) NOT NULL," +
                 "salary DOUBLE NOT NULL" +
                 ");";
            string markTable = "CREATE TABLE IF NOT EXISTS Mark(" +
                 "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                 "val INTEGER NOT NULL," +
                 "idStudent INTEGER NOT NULL," +
                 "idSubject INTEGER NOT NULL," +
                 "FOREIGN KEY(idStudent) REFERENCES Student(id)ON DELETE CASCADE ON UPDATE CASCADE," +
                 "FOREIGN KEY(idSubject) REFERENCES Subject(id) ON DELETE CASCADE ON UPDATE CASCADE" +
                 ");";
            string subjectTable = "CREATE TABLE IF NOT EXISTS Subject(" +
                 "id INTEGER PRIMARY KEY AUTOINCREMENT," +
                 "name VARCHAR(30) NOT NULL" +
                ");";
            OpenConection();
            ExecuteQueries(studentTable);
            ExecuteQueries(teacherTable);
            ExecuteQueries(subjectTable);
            ExecuteQueries(markTable);
            CloseConnection();
        }

        public void ExecuteQueries(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        public SQLiteDataReader ExecuteReader(string query)
        {
            SQLiteCommand cmd = new SQLiteCommand(query, connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void Dispose ()
        {
            connection.Dispose();
        }
    }
}

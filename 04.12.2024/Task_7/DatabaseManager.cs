using System;
using System.Data.SQLite;1
using System.IO;

namespace Task_7
{
    public class DatabaseManager
    {
        private const string DatabaseFileName = "audio_recordings.db";
        private const string TableName = "Recordings";

        public void InitializeDatabase()
        {
            if (!File.Exists(DatabaseFileName))
            {
                SQLiteConnection.CreateFile(DatabaseFileName);
            }

            using (var connection = new SQLiteConnection($"Data Source={DatabaseFileName};Version=3;"))
            {
                connection.Open();

                string createTableQuery = $"CREATE TABLE IF NOT EXISTS {TableName} (Id INTEGER PRIMARY KEY, FilePath TEXT)";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void InsertRecording(string filePath)
        {
            using (var connection = new SQLiteConnection($"Data Source={DatabaseFileName};Version=3;"))
            {
                connection.Open();

                string insertQuery = $"INSERT INTO {TableName} (FilePath) VALUES (@FilePath)";
                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@FilePath", filePath);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ViewRecordings()
        {
            using (var connection = new SQLiteConnection($"Data Source={DatabaseFileName};Version=3;"))
            {
                connection.Open();

                string selectQuery = $"SELECT * FROM {TableName}";
                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["Id"]);
                            string filePath = Convert.ToString(reader["FilePath"]);
                            Console.WriteLine($"Id: {id}, FilePath: {filePath}");
                        }
                    }
                }
            }
        }
    }
}

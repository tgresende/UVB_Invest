using System.Data.SQLite;

namespace Database
{
    public class DBcon
    {

        public static SQLiteConnection DbConnection()
        {
            SQLiteConnection DbConnection = new SQLiteConnection("DataSource = database.db; Version=3;");
            DbConnection.Open();
            return DbConnection;
        }
    }
}

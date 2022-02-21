using System;
using System.Data.SQLite;

namespace SQLiteCountries
{
    class Database
    {
        public SQLiteConnection myConnetion;

        public Database()
        {
            myConnetion = new SQLiteConnection("Data Source=Countries.db");

        }

        public void OpenConnection()
        {
            if(myConnetion.State != System.Data.ConnectionState.Open)
            {
                myConnetion.Open();
            }
        }
        public void CloseConnection()
        {
            if (myConnetion.State != System.Data.ConnectionState.Closed)
            {
                myConnetion.Close();
            }
        }
    }
}

using MySql.Data.MySqlClient;

namespace CompressFile
{
    public class DATA_BASE
    {
        //Server=localhost;Database=reg_utilite_compress;port=3306;User Id=root;password=root
        private MySqlConnection dataBase;
        private const string connstr = "server=localhost;port=3306;username=root;password=;database=users_of_compressfile";        
        public DATA_BASE()
        {
            dataBase = new MySqlConnection(connstr);
        }

        public void OpenConnection()
        {
            if(dataBase.State == System.Data.ConnectionState.Closed)
            {
                dataBase.Open();
            }           
        }

        public void CloseConnection()
        {
            if(dataBase.State == System.Data.ConnectionState.Open)
            {
                dataBase.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return dataBase;
        }
    }
}

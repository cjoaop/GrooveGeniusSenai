using GrooveGenius.Model;
using SQLite;

namespace GrooveGenius.Data
{
    public class SQLiteData
    {
        readonly SQLiteAsyncConnection _conexaoDB;

        public UserData UserDataTable { get; set; }

        public SQLiteData(string path)
        {
            _conexaoDB = new SQLiteAsyncConnection(path);
            _conexaoDB.CreateTableAsync<UserModel>().Wait();

            UserDataTable = new UserData(_conexaoDB);
        }
    }
}

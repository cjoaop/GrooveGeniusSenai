using GrooveGenius.Model;
using SQLite;

namespace GrooveGenius.Data
{
    public class UserData
    {
        private SQLiteAsyncConnection _conexaoDB;

        public UserData(SQLiteAsyncConnection conexaoDB)
        {
            _conexaoDB = conexaoDB;
        }

        public Task<List<UserModel>> GetUsers()
        {
            return _conexaoDB.Table<UserModel>().ToListAsync();
        }

        public Task<UserModel> GetItenUser(string email, string password)
        {
            return _conexaoDB.Table<UserModel>()
                             .Where(u => u.Email == email && u.Password == password)
                             .FirstOrDefaultAsync();
        }

        public Task<UserModel> GetIdUser(int id)
        {
            return _conexaoDB.Table<UserModel>()
                             .Where(u => u.Id == id)
                             .FirstOrDefaultAsync();
        }

        public async Task<int> SaveUser(UserModel user)
        {
            if (user.Id == 0)
            {
                return await _conexaoDB.InsertAsync(user);
            }
            else
            {
                var existingUser = await GetIdUser(user.Id);
                if (existingUser != null)
                {
                    return await _conexaoDB.UpdateAsync(user);
                }
                else
                {
                    return await _conexaoDB.InsertAsync(user);
                }
            }
        }

        public Task<int> DeletarUsuario(UserModel user)
        {
            return _conexaoDB.DeleteAsync(user);
        }
    }
}

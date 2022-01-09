using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mobile_app.Data
{
    public class ProgramareClientiDatabase
    {
        readonly SQLiteAsyncConnection _database;
        public ProgramareClientiDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Programare>().Wait();
        }
        public Task<List<Programare>> GetProduseAsync()
        {
            return _database.Table<Programare>().ToListAsync();
        }
        public Task<Programare> GetProduseAsync(int id)
        {
            return _database.Table<Programare>()
            .Where(i => i.ID == id)
            .FirstOrDefaultAsync();
        }
        public Task<int> SaveProgrameAsync(Programare plist)
        {
            if (plist.ID != 0)
            {
                return _database.UpdateAsync(plist);
            }
            else
            {
                return _database.InsertAsync(plist);
            }
        }
        public Task<int> DeleteProgramareAsync(Programare plist)
        {
            return _database.DeleteAsync(plist);
        }
    }
}

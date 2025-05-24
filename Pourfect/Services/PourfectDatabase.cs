using SQLite;
using Pourfect.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;

namespace Pourfect.Services
{
    public class PourfectDatabase
    {
        private readonly SQLiteAsyncConnection _database;

        public PourfectDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Brew>().Wait();
            _database.CreateTableAsync<Bean>().Wait();
            _database.CreateTableAsync<Recipe>().Wait();
        }

        // BREW
        public Task<List<Brew>> GetBrewsAsync() => _database.Table<Brew>().ToListAsync();
        public Task<int> SaveBrewAsync(Brew brew) => _database.InsertOrReplaceAsync(brew);
        public Task<int> DeleteBrewAsync(Brew brew) => _database.DeleteAsync(brew);

        // Add similar methods for Bean and Recipe as needed
    }
}
using Biseccion.Modelos;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Biseccion
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            //Establishing the conection
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<UsuariosModelos>().Wait();
        }

        // Show the registers
        public Task<List<UsuariosModelos>> GetPeopleAsync()
        {
            return _database.Table<UsuariosModelos>().ToListAsync();
        }

        public Task<UsuariosModelos> GetAlumnoByAsync(int idalumno)
        {
            return _database.Table<UsuariosModelos>().Where(a => a.ID == idalumno).FirstOrDefaultAsync();
        }

        // Save registers
        public Task<int> SavePersonAsync(UsuariosModelos user)
        {
            return _database.InsertAsync(user);
        }
        // Delete registers
        public Task<int> DeletePersonAsync(UsuariosModelos user)
        {
            return _database.DeleteAsync(user);
        }

        // Save registers
        public Task<int> UpdatePersonAsync(UsuariosModelos user)
        {
            return _database.UpdateAsync(user);
        }
        public Task<List<UsuariosModelos>> validacion(string correo, string password)
        {
            return _database.QueryAsync<UsuariosModelos>("SELECT * FROM UsuariosModelos Where Correo=? AND Pasword =?", correo, password);
            
        }

    }
}

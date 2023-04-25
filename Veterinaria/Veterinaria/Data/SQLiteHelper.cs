using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Veterinaria.Models;
using Xamarin.Essentials;
using System.Threading.Tasks;
using System.Linq;

namespace Veterinaria.Data
{
    public class SQLiteHelper
    {
        SQLiteAsyncConnection db;
        public SQLiteHelper(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Persona>().Wait();
        }

        public Task<int> saveRegistroAsync(Persona registro)
        {
            if (registro.Id != 0)
            {
                return db.UpdateAsync(registro);
            }
            else
            {
                return db.InsertAsync(registro);
            }
        }
        /// <summary>
        /// Recuperar datos de registro
        /// </summary>
        /// <returns></returns>
        public Task<List<Persona>> GetRegistroAsync()
        {
            return db.Table<Persona>().ToListAsync();
        }
        /// <summary>
        /// Recupera registro por ID
        /// </summary>
        /// <param name="Id">Id del usuario que se requiere</param>
        /// <returns></returns>
        public Task<Persona> GetRegistroByIdAsync(int Id)
        {
            return db.Table<Persona>().Where(a => a.Id == Id).FirstOrDefaultAsync();
        }

        public void conseguirID()
        {
            var user = db.Table<Persona>().FirstAsync();
        }

        public Task<Persona> validarLogin(string username, string password)
        {
            var user = db.Table<Persona>().FirstOrDefaultAsync(u => u.Usuario == username && u.Password == password);
            return user;
        }

        public Task ActualizarUsuario(string username)
        {
            return db.Table<Persona>().Where(a => a.Usuario == username).FirstOrDefaultAsync();
        }
        public Task EliminarRegistro(string username)
        {
            return db.Table<Persona>().DeleteAsync(u => u.Usuario == username);
        }
        

    }
}
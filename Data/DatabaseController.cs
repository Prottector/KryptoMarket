using SQLite;
using Xamarin.Forms;
using Krryp.Modelss;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Krryp.Data
{
   public class DatabaseController
    {
        static object locker = new object();
        SQLiteConnection database;

    

        public DatabaseController()
        {
            this.database = DependencyService.Get<ISQLite>().GetConnection();

            this.database.CreateTable<User>();
            database.Query<User>("INSERT INTO User (Id,Username,Password)values (01,'admin','admin')");
            database.Query<User>("INSERT INTO User (Id,Username,Password)values (02,'Jakub12','Hasło123')");
            database.Query<User>("INSERT INTO User (Id,Username,Password)values (03,'Szymon','Krypto_Szymon')");
            database.Query<User>("INSERT INTO User (Id,Username,Password)values (04,'Daniel','Jedendwatrzy3')");
            
        }

        public IEnumerator<User> GetUser()
        {
            lock (locker)
            {
                if (database.Table<User>().Count() == 0)
                {
                    return null;
                }
                else
                {
                    return this.database.Table<User>().GetEnumerator();
                }
            }
        }
        public int SaveUser( User user)
        {
            lock (locker)
            {
                if (user.Id !=0)
                {
                    database.Update(user);
                    return user.Id;
                }
                else
                {
                    return database.Insert(user);
                }
            }
        }
        public int DeleteUser(int id)
        {
            lock (locker)
            {
                return database.Delete<User>(id);
            }
        }
       
  

    }
}

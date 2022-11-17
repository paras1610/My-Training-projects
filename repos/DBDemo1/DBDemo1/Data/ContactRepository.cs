using DBDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDemo1.Data
{
    public class ContactRepository : IContactRepository
    {
        public void Save(Contact ContactToSave)
        {
            //open the connection
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ContactsDb;Integrated Security=True;Pooling=False";
            conn.Open();

            //prepare the sql insert statement
            string sqlinsert=$"insert into Contacts values('{ContactToSave.Name}','{ContactToSave.Mobile}','{ContactToSave.Email}','{ContactToSave.Location}')";
         
      
            //send the sql command to db
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sqlinsert;
            cmd.ExecuteNonQuery();

            //close the db connection
            conn.Close();
        }
        
    }
}

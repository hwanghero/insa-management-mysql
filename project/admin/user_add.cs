using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.admin
{
    class user_add : database
    {
        public int admin_user_add(String id, String pw, String level)
        {
            int check = 0;
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = connection;
                comm.CommandText = "INSERT INTO user values(@id, @pw, 0, 'new', @level);";
                comm.Parameters.AddWithValue("@id", id);
                comm.Parameters.AddWithValue("@pw", pw);
                comm.Parameters.AddWithValue("@level", level);

                if (idcheck(id) == 0)
                {
                    comm.ExecuteNonQuery();
                    check = 1;
                }
                comm.Cancel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return check;
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.server
{
    class password_changecs : database
    {
        public int user_pw_change(String id, String pw, String c_pw)
        {
            int check = 0;
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = connection;
                comm.CommandText = "UPDATE user SET pw=@changepw where id=@id and pw=@pw";
                comm.Parameters.AddWithValue("@id", id);
                comm.Parameters.AddWithValue("@pw", pw);
                comm.Parameters.AddWithValue("@changepw", c_pw);

                if(logincheck(id, pw) == 1)
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

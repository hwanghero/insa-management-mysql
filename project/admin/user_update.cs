using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.admin
{
    class user_update : database
    {
        public void User_update(List<String[]> get_user_list)
        {
            try
            {
                foreach (String[] user_ in get_user_list)
                {
                    String id = user_[0];
                    String pw = user_[1];
                    String pw_miss = user_[2];
                    String joinday = user_[3];
                    String level = user_[4];

                    MySqlCommand comm = new MySqlCommand();
                    comm.Connection = connection;
                    comm.CommandText = "update user set pw=@pw, password_miss=@pw_miss, joinday=@joinday, level=@level where id=@id;";
                    comm.Parameters.AddWithValue("@id", id);
                    comm.Parameters.AddWithValue("@pw", pw);
                    comm.Parameters.AddWithValue("@pw_miss", pw_miss);
                    comm.Parameters.AddWithValue("@joinday", joinday);
                    comm.Parameters.AddWithValue("@level", level);
                    comm.ExecuteNonQuery();
                    comm.Cancel();

                    Console.WriteLine("db:"+id + pw + pw_miss + joinday + level);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

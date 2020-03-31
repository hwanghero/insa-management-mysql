using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.admin
{
    class user_list : database
    {
        public String[,] User_list()
        {
            int user_count = User_list_count();
            String[,] user_ = new String[user_count, 5];
            string selectQuery = "Select * from user";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Prepare();

                    using (var reader = cmd.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            user_[i, 0] = reader.GetString(0);
                            user_[i, 1] = reader.GetString(1);
                            user_[i, 2] = reader.GetString(2);
                            user_[i, 3] = reader.GetString(3);
                            user_[i, 4] = reader.GetString(4);
                            i++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return user_;
        }

        public int User_list_count()
        {
            int user_count = 0;
            string selectQuery = "Select count(*) from user";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Prepare();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user_count = reader.GetInt16(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            return user_count;
        }
    }
}

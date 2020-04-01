using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace project.admin
{
    class user_list : database
    {
        public List<String[]> User_list()
        {
            int user_count = User_list_count();
            List<String[]> user_data = new List<String[]>();
            string selectQuery = "Select * from user";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Prepare();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //reader.GetString(0)
                            user_data.Add(new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4)});
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return user_data;
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

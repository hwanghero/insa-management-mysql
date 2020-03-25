
using MySql.Data.MySqlClient;
using System;

namespace project
{
    class database
    {
        // 장기간 미사용자 몇일?
        int dayCheck = 7;
        // 쿼리 접속
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=insa;Uid=root;Pwd=1234;");

        public void connectionOpen()
        {
            connection.Open();
        }

        public int idcheck(String id)
        {
            int check = 0;
            string selectQuery;
            selectQuery = "Select * from user where id=@id";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Prepare();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            check = 1;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return check;
        }

        public int logincheck(String id, String pw)
        {
            int check = 0;
            string selectQuery;
            selectQuery = "Select * from user where id=@id and pw=@pw";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@pw", pw);
                    cmd.Prepare();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            check = 1;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return check;
        }

        public void misscheck(String id)
        {
            try
            {
                int getresult = get_pwmiss(id);
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = connection;
                comm.CommandText = "UPDATE user SET password_miss=@password_miss where id=@id";
                comm.Parameters.AddWithValue("@id", id);
                comm.Parameters.AddWithValue("@password_miss", (getresult + 1));
                comm.ExecuteNonQuery();
                comm.Cancel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public int get_pwmiss(String id)
        {
            int miss = 0;
            string selectQuery = "Select password_miss from user where id=@id";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Prepare();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            miss = int.Parse(reader.GetString(0));

                        }
                        if (reader != null) reader.Close();
                    }
                    cmd.Cancel();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return miss;
        }

        public int day_check(String id)
        {
            int datacheck = 0;
            string selectQuery = "Select joinday from user where id=@id";
            try
            {

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Prepare();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime T1 = DateTime.Parse(reader.GetString(0));
                            DateTime T2 = DateTime.Parse(DateTime.Now.ToString("2020-03-24"));
                            TimeSpan TS = T1 - T2;
                            int diffDay = TS.Days;
                            if (diffDay > dayCheck)
                            {
                                datacheck = 1;
                            }
                        }
                        if (reader != null) reader.Close();
                    }
                    cmd.Cancel();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return datacheck;
        }

        public void day_update(String id)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = connection;
                comm.CommandText = "UPDATE user SET joinday=@joinday where id=@id";
                comm.Parameters.AddWithValue("@id", id);
                comm.Parameters.AddWithValue("@joinday", DateTime.Now.ToString("yyyy-MM-dd"));
                comm.ExecuteNonQuery();
                comm.Cancel();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}

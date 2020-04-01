
using MySql.Data.MySqlClient;
using System;

namespace project
{
    class database
    {
        /*
         * 여기에 포함된 DB
         * 1. 날짜 수정, 업데이트
         * 2. 아이디 체크
         * 3. 비밀번호 5회 틀릴시 체크
         */
         
        // 장기간 미사용자 몇일?
        int dayCheck = 30;

        static String db_server = "localhost";
        static String db_database = "insa";
        static String db_id = "root";
        static String db_pw = "root";
        static String db_format = String.Format($"Server={db_server};Database={db_database};Uid={db_id};Pwd={db_pw};");

        // 쿼리 접속
        public MySqlConnection connection = new MySqlConnection(db_format);

        public void connectionOpen()
        {
            connection.Open();
        }

        public int idcheck(String id)
        {
            int check = 0;
            string selectQuery = "Select * from user where id=@id";

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

        // 관리자일경우 전환값이 2임
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
                            if (reader.GetString(4).Equals("관리자"))
                            {
                                check = 2;
                            }
                            else
                            {
                                check = 1;
                            }
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
                            if (reader.GetString(0).Equals("new")){
                                Console.WriteLine("new");
                            }
                            else
                            {
                                DateTime T1 = DateTime.Parse(reader.GetString(0));
                                DateTime T2 = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                                TimeSpan TS = T1 - T2;
                                int diffDay = TS.Days;
                                if (diffDay > dayCheck)
                                {
                                    datacheck = 1;
                                }
                                Console.WriteLine("old");
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

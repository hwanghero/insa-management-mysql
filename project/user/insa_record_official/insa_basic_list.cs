using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.user.insa_record_official
{
    class insa_basic_list : database
    {
        public List<String[]> empno_list()
        {
            int user_count = empno_list_count();
            List<String[]> user_data = new List<String[]>();
            string selectQuery = "Select * from thrm_bas";
            string result = "";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Prepare();

                    using (var reader = cmd.ExecuteReader())
                    {
                        // 매우 비효율적인거같음
                        // reader.getstring 을 변수로 i로 줘도 안되고
                        // list방식을 쓰면안됐나?
                        while (reader.Read())
                        {
                            Console.WriteLine(result);
                            user_data.Add(new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) , reader.GetString(4) , reader.GetString(5),
                            reader.GetString(6),reader.GetString(7),reader.GetString(8),reader.GetString(9),reader.GetString(10),reader.GetString(11),reader.GetString(12),reader.GetString(13),
                            reader.GetString(14),reader.GetString(15),reader.GetString(16),reader.GetString(17),reader.GetString(18),reader.GetString(19),reader.GetString(20),reader.GetString(21),
                            reader.GetString(22),reader.GetString(23),reader.GetString(24),reader.GetString(25),reader.GetString(26),reader.GetString(27),reader.GetString(28),reader.GetString(29),
                            reader.GetString(30),reader.GetString(31),reader.GetString(32),reader.GetString(33),reader.GetString(34),reader.GetString(35),reader.GetString(36),reader.GetString(37),reader.GetString(38),
                            reader.GetString(39),reader.GetString(40)});
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

        public int empno_list_count()
        {
            int user_count = 0;
            string selectQuery = "Select count(*) from thrm_bas";

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

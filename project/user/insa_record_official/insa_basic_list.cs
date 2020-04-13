using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.user.insa_record_official
{
    class insa_basic_list : database
    {
        public List<string[]> empno_list()
        {
            int user_count = empno_list_count();
            List<string[]> user_data = new List<string[]>();
            string selectquery = "select bas_empno, bas_name from thrm_bas";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(selectquery, connection))
                {
                    cmd.Prepare();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user_data.Add(new string[] { reader.GetString(0), reader.GetString(1)});
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
            string selectquery = "select count(*) from thrm_bas";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(selectquery, connection))
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

        // 이건 통계에서 사용할거같음 전체 목록 불러오기.
        // 그리드뷰 이름 바꾸는거 있으니까 그거 사용하면되긴함 
        // 콤보박스였나 불러와서 했음

        //private MySqlDataAdapter da;

        //public BindingSource empno_get(CheckedListBox load)
        //{
        //    BindingSource bindingSource1 = new BindingSource();
        //    da = new MySqlDataAdapter("SELECT * FROM thrm_bas", connection);
        //    DataTable table = new DataTable { Locale = CultureInfo.InvariantCulture };
        //    da.Fill(table);
        //    bindingSource1.DataSource = table;
        //    return bindingSource1;
        //}

        // 전체리스트 뽑기 개노가다로 한거

        //public List<String[]> empno_list()
        //{
        //    int user_count = empno_list_count();
        //    List<String[]> user_data = new List<String[]>();
        //    string selectQuery = "Select * from thrm_bas";
        //    string result = "";
        //    try
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
        //        {
        //            cmd.Prepare();

        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                // 매우 비효율적인거같음
        //                // reader.getstring 을 변수로 i로 줘도 안되고
        //                // list방식을 쓰면안됐나?
        //                while (reader.Read())
        //                {
        //                    Console.WriteLine(result);
        //                    user_data.Add(new string[] { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) , reader.GetString(4) , reader.GetString(5),
        //                    reader.GetString(6),reader.GetString(7),reader.GetString(8),reader.GetString(9),reader.GetString(10),reader.GetString(11),reader.GetString(12),reader.GetString(13),
        //                    reader.GetString(14),reader.GetString(15),reader.GetString(16),reader.GetString(17),reader.GetString(18),reader.GetString(19),reader.GetString(20),reader.GetString(21),
        //                    reader.GetString(22),reader.GetString(23),reader.GetString(24),reader.GetString(25),reader.GetString(26),reader.GetString(27),reader.GetString(28),reader.GetString(29),
        //                    reader.GetString(30),reader.GetString(31),reader.GetString(32),reader.GetString(33),reader.GetString(34),reader.GetString(35),reader.GetString(36),reader.GetString(37),reader.GetString(38),
        //                    reader.GetString(39),reader.GetString(40)});
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }
        //    return user_data;
        //}

        //public int empno_list_count()
        //{
        //    int user_count = 0;
        //    string selectQuery = "Select count(*) from thrm_bas";

        //    try
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
        //        {
        //            cmd.Prepare();

        //            using (var reader = cmd.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    user_count = reader.GetInt16(0);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex);
        //    }

        //    return user_count;
        //}
    }
}

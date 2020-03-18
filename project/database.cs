using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace project
{
    class database
    {
        // 쿼리 접속
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=insa;Uid=root;Pwd=root;");

        // 쿼리 연결
        public void connectionDB()
        {
            connection.Open();
        }

        public int logincheck(String id, String pw)
        {
            int check = 0;

            if(id.Equals("") && pw.Equals(""))
            {
                check = 0;
            }

            try //예외 처리
            {
                string sql = "SELECT * FROM user where id='"+id+"' and pw='"+pw+"'";

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                MySqlCommand cmd = new MySqlCommand(sql, connection);
                MySqlDataReader table = cmd.ExecuteReader();

                if (table.Read())
                {
                    Console.WriteLine("login success");
                    check = 1;
                }
                table.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("실패");
                Console.WriteLine(ex.ToString());
            }
            return check;
        }
    }
}

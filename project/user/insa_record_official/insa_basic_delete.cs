using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.user.insa_record_official
{
    class insa_basic_delete : database
    {
        public int insa_delete(String empno)
        {
            int check = 1;
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = connection;
                comm.CommandText = "DELETE FROM thrm_bas WHERE IFNULL(bas_empno, 0) = @empno";
                comm.Parameters.AddWithValue("@empno", empno);

                check = 0;
                comm.ExecuteNonQuery();
                comm.Cancel();
            }
            catch (Exception ex)
            {
                check = 1;
                Console.WriteLine(ex);
            }
            return check;
        }
    }
}

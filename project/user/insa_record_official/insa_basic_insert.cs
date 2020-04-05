using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.user.insa_record_official
{
    class insa_basic_insert : database
    {
        // 따로따로 인설트하는게 더 효율적인거같음.. 매우 비효율적인거같음
        user.insa_record_official.insa_basic_main main = new user.insa_record_official.insa_basic_main();
        public int thrm_bas_add(String empno, String resno, String name, String cname, String ename, String fix, String zip, String addr, String residence, String hdpno, String telno, String email, String mil_sta, String mil_mil, String mil_rnk, String mar,
            String acc_bank1, String acc_name1, String acc_no1, String acc_bank2, String acc_name2, String acc_no2, String cont, String intern, int intern_no, String emp_sdate, String emp_edate, String entdate,
            String resdate, String levdate, String reidate, String wsta, String sts, String pos, String dut, String dept, String rmk, String pos_dt, String dut_dt, String dept_dt, String intern_dt, String datasys1, String datasys2, String datasys3)
        {
            int check = 0;
            try
            {
                main.connectionOpen();
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = connection;
                comm.CommandText = "INSERT INTO thrm_bas values(@empno, @resno, @name, @cname, @ename, @fix, @zip, @addr, @residence, @hdpno, @telno, @email, @mil_sta, @mil_mil, @mil_rnk, @mar," + // 15
                    "@acc_bank1, @acc_name1, @acc_no1, @acc_bank2, @acc_name2, @acc_no2, @cont, @intern, @intern_no, @emp_sdate, @emp_edate, @entdate," + // 12
                    "@resdate, @levdate, @reidate, @wsta, @sts, @pos, @dut, @dept, @rmk, @pos_dt, @dut_dt, @dept_dt, @intern_dt, @datasys1, @datasys2, @datasys3);"; // 16
                comm.Parameters.AddWithValue("@empno", empno);
                comm.Parameters.AddWithValue("@resno", resno);
                comm.Parameters.AddWithValue("@name", name);
                comm.Parameters.AddWithValue("@cname", cname);
                comm.Parameters.AddWithValue("@ename", ename);
                comm.Parameters.AddWithValue("@fix", fix);
                comm.Parameters.AddWithValue("@zip", zip);
                comm.Parameters.AddWithValue("@addr", addr);
                comm.Parameters.AddWithValue("@residence", residence);
                comm.Parameters.AddWithValue("@hdpno", hdpno);
                comm.Parameters.AddWithValue("@telno", telno);
                comm.Parameters.AddWithValue("@email", email);
                comm.Parameters.AddWithValue("@mil_sta", mil_sta);
                comm.Parameters.AddWithValue("@mil_mil", mil_mil);
                comm.Parameters.AddWithValue("@mil_rnk", mil_rnk);
                comm.Parameters.AddWithValue("@mar", mar);
                comm.Parameters.AddWithValue("@acc_bank1", acc_bank1);
                comm.Parameters.AddWithValue("@acc_name1", acc_name1);
                comm.Parameters.AddWithValue("@acc_no1", acc_no1);
                comm.Parameters.AddWithValue("@acc_bank2", acc_bank2);
                comm.Parameters.AddWithValue("@acc_name2", acc_name2);
                comm.Parameters.AddWithValue("@acc_no2", acc_no2);
                comm.Parameters.AddWithValue("@cont", cont);
                comm.Parameters.AddWithValue("@intern", intern);
                comm.Parameters.AddWithValue("@intern_no", intern_no);
                comm.Parameters.AddWithValue("@emp_sdate", emp_sdate);
                comm.Parameters.AddWithValue("@emp_edate", emp_edate);
                comm.Parameters.AddWithValue("@entdate", entdate);
                comm.Parameters.AddWithValue("@resdate", resdate);
                comm.Parameters.AddWithValue("@levdate", levdate);
                comm.Parameters.AddWithValue("@reidate", reidate);
                comm.Parameters.AddWithValue("@wsta", wsta);
                comm.Parameters.AddWithValue("@sts", sts);
                comm.Parameters.AddWithValue("@pos", pos);
                comm.Parameters.AddWithValue("@dut", dut);
                comm.Parameters.AddWithValue("@dept", dept);
                comm.Parameters.AddWithValue("@rmk", rmk);
                comm.Parameters.AddWithValue("@pos_dt", pos_dt);
                comm.Parameters.AddWithValue("@dut_dt", dut_dt);
                comm.Parameters.AddWithValue("@dept_dt", dept_dt);
                comm.Parameters.AddWithValue("@intern_dt", intern_dt);
                comm.Parameters.AddWithValue("@datasys1", datasys1);
                comm.Parameters.AddWithValue("@datasys2", datasys2);
                comm.Parameters.AddWithValue("@datasys3", datasys3);

                if (main.empno_check(empno) == 0)
                {
                    comm.ExecuteNonQuery();
                    check = 1;
                }
                comm.Cancel();
                main.connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return check;
        }
    }
}

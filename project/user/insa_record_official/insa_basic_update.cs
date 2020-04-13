using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.user.insa_record_official
{
    class insa_basic_update : database
    {
        public int thrm_bas_update(String empno, String resno, String name, String cname, String ename, String fix, String zip, String addr, String residence, String hdpno, String telno, String email, String mil_sta, String mil_mil, String mil_rnk, String mar,
            String acc_bank1, String acc_name1, String acc_no1, String acc_bank2, String acc_name2, String acc_no2, String cont, String intern, int intern_no, String emp_sdate, String emp_edate, String entdate,
            String resdate, String levdate, String reidate, String wsta, String sts, String pos, String dut, String dept, String rmk, String pos_dt, String dut_dt, String dept_dt, String intern_dt, String datasys1, String datasys2, String datasys3)
        {
            int check = 1;
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = connection;
                comm.CommandText = "UPDATE thrm_bas SET bas_resno=@resno, bas_name=@name, bas_cname=@cname, bas_ename=@ename, bas_fix=@fix, bas_zip=@zip, bas_addr=@addr, bas_residence=@residence, bas_hdpno=@hdpno, bas_telno=@telno, bas_email=@email, bas_mil_sta=@mil_sta, bas_mil_mil=@mil_mil, bas_mil_rnk=@mil_rnk, bas_mar=@mar," + // 15
                    "bas_acc_bank1=@acc_bank1, bas_acc_name1=@acc_name1, bas_acc_no1=@acc_no1, bas_acc_bank2=@acc_bank2, bas_acc_name2=@acc_name2, bas_acc_no2=@acc_no2, bas_cont=@cont, bas_intern=@intern, bas_intern_no=@intern_no, bas_emp_sdate=@emp_sdate, bas_emp_edate=@emp_edate, bas_entdate=@entdate," + // 12
                    "bas_resdate=@resdate, bas_levdate=@levdate, bas_reidate=@reidate, bas_wsta=@wsta, bas_sts=@sts, bas_pos=@pos, bas_dut=@dut, bas_dept=@dept, bas_rmk=@rmk, bas_pos_dt=@pos_dt, bas_dut_dt=@dut_dt, bas_dept_dt=@dept_dt, bas_intern_dt=@intern_dt, datasys1=@datasys1, datasys2=@datasys2, datasys3=@datasys3 where IFNULL(bas_empno, 0) = @empno"; // 16
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

        public List<string> insa_basic_getdata(String bas_empno)
        {
            List<string> user_data = new List<string>();
            string selectquery = "select * from thrm_bas where bas_empno='"+bas_empno+"'";
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(selectquery, connection))
                {
                    cmd.Prepare();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for(int i=0; i<41; i++)
                            {
                                user_data.Add(reader.GetString(i));
                            }
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
    }
}

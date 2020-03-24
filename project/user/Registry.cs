using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Registry
    {
        RegistryKey reg;

        // 키 생성
        public void Set_ID_Registry(string id)
        {
            //키 생성하기
            reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("insa-management");
            reg.SetValue("regID", id);
        }

        public void Set_Savecheck_Registry(Boolean savecheck)
        {
            //키 생성하기
            reg = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("insa-management");
            reg.SetValue("regSave", savecheck);
        }

        // 키 값 불러오기
        public String Get_ID_Registry()
        {
            reg = Microsoft.Win32.Registry.CurrentUser;
            reg = reg.OpenSubKey("insa-management", true);
            return reg.GetValue("regID", "").ToString();
        }

        public String Get_Save_Registry()
        {
            reg = Microsoft.Win32.Registry.CurrentUser;
            reg = reg.OpenSubKey("insa-management", true);
            return reg.GetValue("regSave", "").ToString();
        }
    }
}

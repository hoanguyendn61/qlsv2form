using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_QLSV2FORM
{
    public class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public bool Gender { get; set; }
        public DateTime NgaySinh { get; set; }
        public int ID_Lop { get; set; }
        public SV(){}
        public SV(string ms, string n, bool gender, DateTime ns, int id) 
        {
            MSSV = ms;
            NameSV = n;
            Gender = gender;
            NgaySinh = ns;
            ID_Lop = id;
        }
        public static bool Compare_MSSVDescending(object o1, object o2)
        {
            return Convert.ToInt32(((SV)o1).MSSV) < Convert.ToInt32(((SV)o2).MSSV);
        }
        public static bool Compare_MSSVAscending(object o1, object o2)
        {
            return Convert.ToInt32(((SV)o1).MSSV) > Convert.ToInt32(((SV)o2).MSSV);
        }
        public static bool Compare_NameZA(object o1, object o2)
        {
            if (string.Compare(((SV)o1).NameSV, ((SV)o2).NameSV) < 0)
                return true;
            else
                return false;
        }
        public static bool Compare_NameAZ(object o1, object o2)
        {
            if (string.Compare(((SV)o1).NameSV, ((SV)o2).NameSV) > 0)
                return true;
            else
                return false;
        }
    }
}

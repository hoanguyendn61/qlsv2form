using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_QLSV2FORM
{
    class CSDL_OOP
    {
        public delegate bool MyCompare(object o1, object o2);
        private static CSDL_OOP _Instance;
        public static CSDL_OOP Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL_OOP();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private CSDL_OOP() { }
        public List<SV> GetAllSV()
        {
            List<SV> data = new List<SV>();
            foreach(DataRow i in CSDL.Instance.DTSV.Rows)
            {
                data.Add(GetSV(i));
            }
            return data;
        }
        public SV GetSV(DataRow i)
        {
            return new SV
            {
                MSSV = i["MSSV"].ToString(),
                NameSV = i["NameSV"].ToString(),
                Gender = Convert.ToBoolean(i["Gender"]),
                ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString()),
                NgaySinh = Convert.ToDateTime(i["NgaySinh"])
            };
        }
        public List<LSH> GetAllLSH()
        {
            List<LSH> data = new List<LSH>();
            foreach(DataRow i in CSDL.Instance.DTLSH.Rows)
            {
                data.Add(GetLSH(i));
            }
            return data;
        }
        public LSH GetLSH(DataRow i)
        {
            return new LSH
            {
                ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString()),
                NameLop = i["TenLop"].ToString()
            };
        }
        public List<SV> GetListSV(int ID_Lop, string Name)
        {
            List<SV> data = new List<SV>();
            if (ID_Lop == 0 && Name == "")
            {
                data = GetAllSV();
            } else
            {
                foreach (SV i in GetAllSV())
                {
                    if (Name != "")
                    {
                        if (i.NameSV.Contains(Name))
                        {
                            data.Add(new SV
                            {
                                NameSV = i.NameSV,
                                MSSV = i.MSSV,
                                Gender = i.Gender,
                                NgaySinh = i.NgaySinh,
                                ID_Lop = i.ID_Lop
                            });
                        }
                    }
                    else
                    {
                        if (i.ID_Lop == ID_Lop)
                        {
                            data.Add(new SV
                            {
                                NameSV = i.NameSV,
                                MSSV = i.MSSV,
                                Gender = i.Gender,
                                NgaySinh = i.NgaySinh,
                                ID_Lop = i.ID_Lop
                            });
                        }
                    }
                }
                
            }
            return data;
        }
        public void ExecuteDB(SV s)
        {
            bool check = false;
            foreach(SV i in GetAllSV())
            {
                if (i.MSSV == s.MSSV)
                {
                    check = true;
                }
            }
            if (check == true)
            {
                // Edit, Done
                CSDL.Instance.EditDataRow(s);
            } else
            {
                // Add, Done
                CSDL.Instance.AddDataRow(s);
            }
        }
        public List<SV> Sort(int idLop, string Name, MyCompare cmp)
        {
            List<SV> data = GetListSV(idLop, Name);
            for (int i = 0; i < data.Count - 1; ++i)
            {
                for (int j = i + 1; j < data.Count; ++j)
                {
                    if (cmp(data[i], data[j]))
                    {
                        SV temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            }
            return data;
        }
        public void DeleteSV(SV s)
        {
            CSDL.Instance.DeleteDataRow(s);
        }
        public SV GetSVByMSSV(string ms)
        {
            SV s = new SV();
            foreach(SV i in GetAllSV())
            {
                if(i.MSSV == ms)
                {
                    s =  i;
                }
            }
            return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_QLSV2FORM
{
    public class CSDL
    {
        public DataTable DTSV { get; set; }
        public DataTable DTLSH { get; set; }
        private static CSDL _Instance;
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        private CSDL()
        {
            //CSDL DataTable Sinh Vien
            DTSV = new DataTable();
            DTSV.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(string)),
                new DataColumn("NameSV", typeof(string)),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("NgaySinh", typeof(DateTime)),
                new DataColumn("ID_Lop", typeof(string)),
            });
            DataRow dr = DTSV.NewRow();
            dr["MSSV"] = "101"; dr["NameSV"] = "Nguyễn Văn An";
            dr["Gender"] = true; dr["ID_Lop"] = 1;
            dr["NgaySinh"] = DateTime.Now;
            DTSV.Rows.Add(dr);
            DataRow dr1 = DTSV.NewRow();
            dr1["MSSV"] = "102"; dr1["NameSV"] = "Nguyễn Văn Bê";
            dr1["Gender"] = true; dr1["ID_Lop"] = 1;
            dr1["NgaySinh"] = DateTime.Now;
            DTSV.Rows.Add(dr1);
            DataRow dr2 = DTSV.NewRow();
            dr2["MSSV"] = "103"; dr2["NameSV"] = "Nguyễn Thị Xê";
            dr2["Gender"] = false; dr2["ID_Lop"] = 2;
            dr2["NgaySinh"] = DateTime.Now;
            DTSV.Rows.Add(dr2);
            //CSDL Lop Sinh Hoat
            DTLSH = new DataTable();
            DTLSH.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Lop", typeof(string)),
                new DataColumn("TenLop", typeof(string))
            });
            DataRow dr3 = DTLSH.NewRow();
            dr3["ID_Lop"] = 1; dr3["TenLop"] = "LSH1";
            DTLSH.Rows.Add(dr3);
            DataRow dr4 = DTLSH.NewRow();
            dr4["ID_Lop"] = 2; dr4["TenLop"] = "LSH2";
            DTLSH.Rows.Add(dr4);
        }
        /*
        // Trả về DataTable có SV trùng với ID_Lop
        public DataTable GetSVByIDLop(int id)
        {
            DataTable dt  = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(string)),
                new DataColumn("NameSV", typeof(string)),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("NgaySinh", typeof(DateTime)),
                new DataColumn("ID_Lop", typeof(string)),
            });
            if (id != 0)
            {
                foreach (DataRow i in DTSV.Rows)
                {
                    DataRow dr = dt.NewRow();
                    if (Convert.ToInt32(i["ID_Lop"]) == id)
                    {
                        dr["MSSV"] = i["MSSV"]; dr["NameSV"] = i["NameSV"];
                        dr["Gender"] = i["Gender"]; dr["ID_Lop"] = id;
                        dr["NgaySinh"] = i["NgaySinh"];
                        dt.Rows.Add(dr);
                    }
                }
            } else
            {
                dt = DTSV;
            }
            return dt;
        }
        // Trả về DataTable có SV trùng với ms
        public DataTable GetDTSVByMSSV(int ms)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(string)),
                new DataColumn("NameSV", typeof(string)),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("NgaySinh", typeof(DateTime)),
                new DataColumn("ID_Lop", typeof(string)),
            });
            if (ms != 0)
            {
                foreach (DataRow i in DTSV.Rows)
                {
                    DataRow dr = dt.NewRow();
                    if (Convert.ToInt32(i["MSSV"]) == ms)
                    {
                        dr["MSSV"] = i["MSSV"]; dr["NameSV"] = i["NameSV"];
                        dr["Gender"] = i["Gender"]; dr["ID_Lop"] = i["ID_Lop"] ;
                        dr["NgaySinh"] = i["NgaySinh"];
                        dt.Rows.Add(dr);
                    }
                }
            }
            else
            {
                dt = DTSV;
            }
            return dt;
        }
        // Trả về DataTable có SV trùng với name
        public DataTable GetDTSVByNameSV(string name)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MSSV", typeof(string)),
                new DataColumn("NameSV", typeof(string)),
                new DataColumn("Gender", typeof(bool)),
                new DataColumn("NgaySinh", typeof(DateTime)),
                new DataColumn("ID_Lop", typeof(string)),
            });
            if (name != "")
            {
                foreach (DataRow i in DTSV.Rows)
                {
                    DataRow dr = dt.NewRow();
                    if (i["NameSV"].ToString() == name)
                    {
                        dr["MSSV"] = i["MSSV"]; dr["NameSV"] = i["NameSV"];
                        dr["Gender"] = i["Gender"]; dr["ID_Lop"] = i["ID_Lop"];
                        dr["NgaySinh"] = i["NgaySinh"];
                        dt.Rows.Add(dr);
                    }
                }
            }
            else
            {
                dt = DTSV;
            }
            return dt;
        }
        // Trả về hàng có SV trùng với MSSV
        public DataRow GetSVByMSSV(string ms)
        {
            DataRow dr = DTSV.NewRow();
            try
            {
                foreach (DataRow i in DTSV.Rows)
                {
                    if (i["MSSV"].ToString() == ms)
                    {
                        dr = i;
                    }
                }
                return dr;
            }
            catch (Exception)
            {
                return null;
            }
        }
        private bool CheckMSSV(string ms)
        {
            foreach(DataRow i in DTSV.Rows)
            {
                if (i["MSSV"].ToString() == ms)
                {
                    return true;
                }
            }
            return false;
        }
        public bool Add(params object[] data)
        {
            try
            {
                if (CheckMSSV(data[0].ToString()))
                {
                    return false;
                } else
                {
                    DTSV.Rows.Add(new object[]
                    {
                      data[0], data[1], data[2], data[3], data[4]
                    });
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Edit(params object[] data)
        {
            bool check = false;
            try
            {
                foreach (DataRow i in DTSV.Rows)
                {
                    if (i["MSSV"].ToString() == data[0].ToString())
                    {
                        i["NameSV"] = data[1].ToString();
                        i["Gender"] = Convert.ToBoolean(data[2].ToString());
                        i["NgaySinh"] = Convert.ToDateTime(data[3].ToString());
                        i["ID_Lop"] = data[4].ToString();
                        check = true;
                    }
                }
                return check;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Del(List<string> data)
        {
            try
            {
                foreach (string j in data)
                {
                    foreach (DataRow i in DTSV.Select())
                    {
                        if (i["MSSV"].ToString() == j)
                        {
                            DTSV.Rows.Remove(i);
                        }
                    }
                    DTSV.AcceptChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        } 
        */
        /// KIEU MOI
        public void AddDataRow(SV s) 
        {
            DataRow dr = DTSV.NewRow();
            dr["MSSV"] = s.MSSV; dr["NameSV"] = s.NameSV;
            dr["Gender"] = s.Gender; dr["ID_Lop"] = s.ID_Lop;
            dr["NgaySinh"] = s.NgaySinh;
            DTSV.Rows.Add(dr);
        }
        public void EditDataRow(SV s) 
        {
            try
            {
                foreach (DataRow i in DTSV.Rows)
                {
                    if (i["MSSV"].ToString() == s.MSSV)
                    {
                        i["NameSV"] = s.NameSV;
                        i["Gender"] = s.Gender;
                        i["NgaySinh"] = s.NgaySinh;
                        i["ID_Lop"] = s.ID_Lop;
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        public void DeleteDataRow(SV s)
        {
            try
            {
                foreach (DataRow i in DTSV.Rows)
                {
                    if (i["MSSV"].ToString() == s.MSSV)
                    {
                        DTSV.Rows.Remove(i);
                    }
                }
                DTSV.AcceptChanges();
            }
            catch (Exception)
            {
            }
        }
    }

}

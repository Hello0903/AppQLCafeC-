using QuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaFe.DAO
{
    public class DanhMucDAO
    {
        private static DanhMucDAO instance;

        public static DanhMucDAO Instance {
            get { if (instance == null) instance = new DanhMucDAO(); return DanhMucDAO.instance; }
            private set { DanhMucDAO.instance = value; }
        }

        private DanhMucDAO() { }



        public List<DanhMuc> ListDanhMuc() {

            List<DanhMuc> DanhMucList = new List<DanhMuc>();
            DataTable data = ProcessDataBase.Instance.LoadData("select * from danhmuc");

            foreach (DataRow item in data.Rows) {
                DanhMuc danhMuc = new DanhMuc(item);
                DanhMucList.Add(danhMuc);
            }


            return DanhMucList;

        }

        public int GetIddanhmuc(String name) {

            string sql = "select * from danhmuc where ten like N'" + name + "'";

            DataTable data = ProcessDataBase.Instance.LoadData(sql);

            if (data.Rows.Count > 0) {

                DanhMuc danhMuc = new DanhMuc(data.Rows[0]);
                return danhMuc.ID;

            }




            return -1;
        }

        public void themDM(String name) {

            String sql = "insert danhmuc (ten) values (N'"+name+"')";
            ProcessDataBase.Instance.UpdateData(sql);
            
        }
        public void suaDM(int id, String name) {
            String sql = "update danhmuc set ten = N'"+name+"' where id = "+id+"";
            ProcessDataBase.Instance.UpdateData(sql);
        }

        public void xoaDM(int id) { 
        
        
        }
        
    }

}

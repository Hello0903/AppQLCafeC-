using QuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaFe.DAO
{
    public class TableDAO
    {
        public static int TableWidth = 80;
        public static int TableHeight = 80;

        private static TableDAO instance;



        public static TableDAO Instance {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance;
            }
            private set { TableDAO.instance = value; } }
        private TableDAO() { }


        public List<Table> LoadTableDAO() {

            List<Table> TableList = new List<Table>();
            DataTable data = ProcessDataBase.Instance.LoadData("select * from ban");

            foreach (DataRow item in data.Rows) {
                Table datatb = new Table(item);
                TableList.Add(datatb);
            }

            return TableList;

        }
        public void ChuyenBan(int idban1, int idban2)
        {

            if (idban1 > 0 && idban2 != null)
            {
                string sql = "exec chuyenban " + idban1 + "," + idban2;

                ProcessDataBase.Instance.UpdateData(sql);
            }


        }
        public int getidbanbyname(String name){

            string sql = "select * from ban where name like N'"+name+"'";
            DataTable data = ProcessDataBase.Instance.LoadData(sql);
            if (data.Rows.Count > 0) {
                Table table = new Table(data.Rows[0]);
                return table.Id;
            }


            return -1;
        
        }
        public void themban(String name) {

            String sql = "insert ban (name,status) values(N'" + name + "',1)";
            ProcessDataBase.Instance.UpdateData(sql);


        }
        public void suaban(int id, String name) {
            String sql = "update ban set name = N'"+name+"' where id = " + id + "";
            ProcessDataBase.Instance.UpdateData(sql);
        }
        public void xoaban(int id){
        
        
        }

    }
}

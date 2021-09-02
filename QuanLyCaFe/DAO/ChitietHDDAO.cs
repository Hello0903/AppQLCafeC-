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
    public class ChitietHDDAO
    {
        private static ChitietHDDAO instance;

        public static ChitietHDDAO Instance {
            get { if (instance == null) instance = new ChitietHDDAO(); return ChitietHDDAO.instance;  }

            private set { ChitietHDDAO.instance = value; }
        }
        private ChitietHDDAO() { }

        public List<ChitietHD> CTHDList(int ID) {
            List<ChitietHD> ListCTHD = new List<ChitietHD>();
            DataTable data = ProcessDataBase.Instance.LoadData("select * from ChiTietHoaDon where IdHoaDon = "+ID);
            
            foreach (DataRow item in data.Rows) {
                ChitietHD chitietHD = new ChitietHD(item);
                ListCTHD.Add(chitietHD);
            
            }

            return ListCTHD;
        
        
        }
        public DataTable testCTHDDAO(int ID){
            DataTable table = new DataTable();
            table = ProcessDataBase.Instance.LoadData("select * from ChiTietHoaDon where IdHoaDon = " + ID);
            return table;
        
        
        }
        public void ThemCTHD(int IDHoaDon,int IDFood, int SoLuong) {

            ProcessDataBase.Instance.UpdateData("exec ThemCTHD '"+IDHoaDon+"','"+IDFood+"','"+SoLuong+"'");
        
        
        }
    }
}

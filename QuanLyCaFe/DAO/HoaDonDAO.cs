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
   public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance {
            get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
           private set {HoaDonDAO.instance = value; } }

        private HoaDonDAO() { }


        public int GetIDHoaDon(int id) {
            DataTable data = ProcessDataBase.Instance.LoadData("select * from hoadon where idban =" + id + " and status = 0 ");
            
            if (data.Rows.Count > 0) {

                HoaDon hoadon = new HoaDon(data.Rows[0]);
                return hoadon.ID;
            
            }
            return -1;



        }
        public void ThemHD(int idTable) {

            ProcessDataBase.Instance.UpdateData("exec themHoaDon '"+idTable+"'");
        
        }
        public int getMaxHD() {
            try
            {
                return (int)ProcessDataBase.Instance.LoadCount("select max(id) where hoadon");
            }
            catch
            { return 1; }
        }

        public void ThanhToan(int ID) {

            string query = "update hoadon set status = 1 ,ngayra= getdate() where id = "+ID;
            ProcessDataBase.Instance.UpdateData(query);
        
        } 
        public void KhuyenMai(int KM,int idtable,int idbill,int thanhtien) {
            if (idbill != null || idtable != null)
            {
                String sql = "update hoadon set khuyenmai = " + KM +", thanhtien = "+thanhtien+"  where idban = " + idtable + " and id =" + idbill + " ";
                ProcessDataBase.Instance.UpdateData(sql);
                
            }
    
         }

    }
   
}

using QuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QuanLyCaFe.DTO.Menu;

namespace QuanLyCaFe.DAO
{
   public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance {
            get { if (instance == null) instance = new MenuDAO();return MenuDAO.instance; }
            private set { MenuDAO.instance = value; } }

        private MenuDAO() { }

        public List<DTO.Menu> ListMenu(int ID) {

            List<DTO.Menu> MenuList = new List<DTO.Menu>();
            String sql ="select food.Ten, SoLuong, giaban, SoLuong* giaban as thanhtien from ChiTietHoaDon, Food where ChiTietHoaDon.IdFood = Food.Id and IdHoaDon = "+ID;
            DataTable data = ProcessDataBase.Instance.LoadData(sql);
            
            foreach (DataRow item in data.Rows) {
                DTO.Menu menu = new Menu(item);
                MenuList.Add(menu);
            
            }


            return MenuList;
        
        
        }
    
    
    }

    

}

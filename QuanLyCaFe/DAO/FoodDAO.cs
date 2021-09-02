using QuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance {
            get { if (instance == null) instance = new FoodDAO(); return FoodDAO.instance; }
            private set { FoodDAO.instance = value; }
        }
        private FoodDAO() { }


        public List<Food> LoadFoodById(int ID) {
            List<Food> list = new List<Food>();
            DataTable data = ProcessDataBase.Instance.LoadData("select * from food where iddanhmuc = " + ID);

            foreach (DataRow item in data.Rows) {
                Food food = new Food(item);
                list.Add(food);

            }

            return list;

        }
        public void ThemFood(String name, int iddannhmuc, int giaban) {

            string sql = "insert food (ten,iddanhmuc,giaban) values (N'" + name + "'," + iddannhmuc + "," + giaban + ")";
            ProcessDataBase.Instance.UpdateData(sql);


        }
        public void suafood(int idfood,String name, int iddannhmuc, int giaban) {
            string sql = "update food set ten = N'"+name+"' , iddanhmuc = "+iddannhmuc+" , giaban = "+giaban+" " +
                " where id = "+idfood+"";
            ProcessDataBase.Instance.UpdateData(sql);

        }
        public void xoafood() { 
        
        
        
        }
    }
}

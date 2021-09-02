using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe.DTO
{
    public class ChitietHD
    {   public ChitietHD(int id, int idhoadon, int idfood, int soluong) {

            this.ID = id;
            this.IdHoaDon = idhoadon;
            this.IdFood = idfood;
            this.Soluong = soluong;
        
        }

        private int iD;
        private int idHoaDon;
        private int idFood;
        private int soluong;

        public ChitietHD(DataRow row) {

            this.ID = (int)row["id"];
            this.IdHoaDon  = (int)row["idHoaDon"];
            this.IdFood = (int)row["idFood"];
            this.Soluong = (int)row["SoLuong"];

        }


        public int Soluong { get { return soluong; } set { soluong = value; } }
        public int IdFood { get { return idFood; } set { idFood = value; } }
        public int IdHoaDon { get { return idHoaDon; } set { idHoaDon = value; } }
        public int ID { get { return iD; } set { iD = value; } }
    }
}

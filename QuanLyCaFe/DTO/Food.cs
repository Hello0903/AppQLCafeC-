using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe.DTO
{
    public class Food
    {
        public Food(int id, string name, int iddanhmuc, float giaban) {
            this.ID = id;
            this.Name = name;
            this.IdDanhMuc = iddanhmuc;
            this.giaban = giaban;
        }

        public Food(DataRow row) {
            this.ID = (int)row["id"];
            this.Name = row["ten"].ToString();
            this.IdDanhMuc = (int)(row["iddanhmuc"]);
            this.giaban = (float)Convert.ToDouble(row["giaban"]);
        }

        private int iD;
        private String name;
        private int idDanhMuc;
        private float giaban;
        private float gianhap;

        public int ID { get { return iD; } set { iD = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int IdDanhMuc { get { return idDanhMuc; } set { idDanhMuc = value; } }
        public float Giaban { get { return giaban; } set { giaban = value; } }
        public float Gianhap { get { return gianhap; } set { gianhap = value; } }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe.DTO
{
 public    class Menu
    {
        public Menu(String name, int soluong, float dongia, float thanhtien) {
            this.Name = name;
            this.Soluong = soluong;
            this.Dongia = dongia;
            this.Thanhtien = thanhtien; 
        
        
        }

        public Menu(DataRow row) {
            this.Name =row["ten"].ToString();
            this.Soluong = (int)row["soluong"];
            this.Dongia = (float)Convert.ToDouble(row["giaban"].ToString());
            this.Thanhtien = (float)Convert.ToDouble(row["thanhtien"].ToString());

        }

        private String name;
        private int soluong;
        private float dongia;
        private float thanhtien;

        public string Name { get { return name; } set { name = value; } }
        public int Soluong { get { return soluong; } set { soluong = value; } }
        public float Dongia { get { return dongia; } set { dongia = value; } }
        public float Thanhtien { get { return thanhtien; } set { thanhtien = value; } }
    }
}

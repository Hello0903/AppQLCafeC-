using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe.DTO
{
  public  class DanhMuc
    {   public DanhMuc(int id, String name) {
            this.ID = iD;
            this.Name = name;
        
        }

        private int iD;
        private String name;

        public int ID { get { return iD; } set { iD = value; } }
        public string Name { get { return name; } set { name = value; } }

        public DanhMuc(DataRow row) {
            this.ID = (int)row["id"];
            this.Name = row["ten"].ToString(); 
        }
    }
}

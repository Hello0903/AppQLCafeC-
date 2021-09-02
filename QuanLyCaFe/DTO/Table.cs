using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe.DTO
{
    public class Table
    {
          public Table(int id, String name, String status) {
            this.Id = id;
            this.Name = name;
            this.Status = status;
        
        }
        
        private int id;
        private String name;
        private String status;
      
        public Table(DataRow row) {
            this.Id = (int)row["Id"];
            this.Name = row["name"].ToString();
            this.Status = row["status"].ToString();
        }
        
        public int Id { get { return id; }
            set { id = value; } }
        public String Name { 
        get { return name; }
            set { name = value; }
        }

        public string Status { get { return status; }
            set { status = value; } }
       
    }
    
}

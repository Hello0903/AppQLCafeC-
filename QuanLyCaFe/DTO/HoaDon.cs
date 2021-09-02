using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe.DTO
{
   public  class HoaDon
    {
        private HoaDon(int id, DateTime? ngayvao, DateTime? ngayra, int idban, int status) {
            this.ID = id;
            this.Ngayvao = ngayvao;
            this.Ngayra = ngayra;
            this.IdBan = idBan;
            this.Status = status;

        }
        public HoaDon(DataRow row) {

            this.ID = (int)row["id"];
            this.Ngayvao = (DateTime?)row["ngayvao"];
            var checktime = row["ngayra"];
            if (checktime.ToString() != "") 
            this.Ngayra = (DateTime?)checktime;
            this.IdBan = (int)row["idBan"];
            this.Status = (int)row["status"];


        }

        private DateTime? ngayvao;
        private int iD;
        private DateTime? ngayra;
        private int idBan;
        private int status;
        public int ID { get { return iD; } set { iD = value; } }
        public DateTime? Ngayvao { get { return ngayvao; } set { ngayvao = value; } }
        public DateTime? Ngayra { get { return ngayra; } set { ngayra = value; } }
        public int IdBan { get { return idBan; } set { idBan = value; } }
        public int Status { get { return status; } set { status = value; } }
    }
}

using QuanLyCaFe.DAO;
using QuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaFe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

            String sql = "select ban.name'Bàn',ngayvao'Ngày vào',ngayra'Ngày ra',khuyenmai'Khuyến mại',thanhtien'Thành tiền' from hoadon , ban where hoadon.idban = ban.id " +
                "and month(ngayvao) = month(getdate()) and year(ngayvao)= year(getdate())";

            dgvDoanhThu.DataSource = ProcessDataBase.Instance.LoadData(sql);
            loadall();
           
        }

        void loadall() { 
            
            cbbtestdm.DataSource = DanhMucDAO.Instance.ListDanhMuc();
            cbbtestdm.ValueMember = "name";


        }
        
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            int ngay;
            int thang;
            int nam;

            DateTime date = dtpkToDate.Value;
            ngay = date.Day;
            thang = date.Month;
            nam = date.Year;

            

                String sql = "select ban.name'Bàn',ngayvao'Ngày vào',ngayra'Ngày ra',khuyenmai'Khuyến mại',thanhtien'Thành tiền' from hoadon , ban where hoadon.idban = ban.id " +
                    "and day(ngayra) = '"+ngay+"' and month(ngayra) = " + thang + " and year(ngayra)= " + nam + "";

                dgvDoanhThu.DataSource = ProcessDataBase.Instance.LoadData(sql);

            
            
        }
        //---------------------------------------------------- datagridview--------------
        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvFood.CurrentRow.Index;
            txtidfood.Text = dgvFood.Rows[i].Cells[0].Value.ToString();
            txttenfood.Text = dgvFood.Rows[i].Cells[1].Value.ToString();
            txtdanhmucfood.Text = dgvFood.Rows[i].Cells[2].Value.ToString();
            numgiafood.Value = Convert.ToInt32(dgvFood.Rows[i].Cells[3].Value);
            cbbtestdm.Text = dgvFood.Rows[i].Cells[2].Value.ToString();


        } 
        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDanhMuc.CurrentRow.Index;
            txtiddanhmuc.Text = dgvDanhMuc.Rows[i].Cells[0].Value.ToString();
            tendanhmuc.Text = dgvDanhMuc.Rows[i].Cells[1].Value.ToString();

        }
        private void dgvBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvBan.CurrentRow.Index;
            txtban.Text = dgvBan.Rows[i].Cells[0].Value.ToString();
            txttenban.Text = dgvBan.Rows[i].Cells[1].Value.ToString();
            txttrangthaiban.Text = dgvBan.Rows[i].Cells[2].Value.ToString();



        }

        //-------------------------------------------------------------
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "select food.id'Mã Món',food.ten'Món',danhmuc.ten'Danh Mục',giaban'Giá Bán' " +
                " from food ,danhmuc where food.ten like N'%" + txtSearchfood.Text+ "%' and food.iddanhmuc = danhmuc.id";

            dgvFood.DataSource = ProcessDataBase.Instance.LoadData(sql);
          

        }

    }
}

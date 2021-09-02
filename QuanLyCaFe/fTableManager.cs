using QuanLyCaFe.DAO;
using QuanLyCaFe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaFe
{
    public partial class fTableManager : Form
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadDanhMuc();
            loadchuyenban(cbChuyenBan);

        }
       

        public void LoadTableList() {
            flpTable.Controls.Clear();
            List<Table> TableList = new List<Table>();
                TableList  =   TableDAO.Instance.LoadTableDAO();
                 foreach (Table item in TableList) {

                  Button btn = new Button() {Width = TableDAO.TableWidth , Height = TableDAO.TableHeight };
                btn.Click += btn_Click;
                btn.Tag = item;
                btn.Text = item.Name;
                if (item.Status.ToString() != "0") btn.BackColor = Color.Yellow;
                  flpTable.Controls.Add(btn);


              }
        }

        void ShowBill(int ID) {

            lsvBill.Items.Clear();
            List<DTO.Menu> ListCTHD = MenuDAO.Instance.ListMenu(HoaDonDAO.Instance.GetIDHoaDon(ID));
            float tien = 0;
            foreach (DTO.Menu item in ListCTHD) {

                ListViewItem listViewItem = new ListViewItem(item.Name.ToString());
                listViewItem.SubItems.Add(item.Soluong.ToString());
                listViewItem.SubItems.Add(item.Dongia.ToString());
                listViewItem.SubItems.Add(item.Thanhtien.ToString());
                tien += item.Thanhtien;
                lsvBill.Items.Add(listViewItem);
            
            }
            txttien.Text = tien.ToString();
            
        }

        public void LoadDanhMuc() {

            List<DanhMuc> table = DanhMucDAO.Instance.ListDanhMuc();
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "name";

        }
        void LoadFoodById1(int ID) { 
        
        List<Food> table = FoodDAO.Instance.LoadFoodById(ID);
            comboBox2.DataSource = table;
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "name";


        }
        void loadchuyenban(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableDAO();
            cb.ValueMember = "name";

        }
        private void btn_Click(object sender, EventArgs e)
        {
            int TableID = ((sender as Button).Tag as Table).Id ;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(TableID);
            
        }

        private void thongtincanhanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile();
            f.ShowDialog();

        }

        private void đangxuatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
             
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();

        }

        private void fTableManager_Load(object sender, EventArgs e)
        {
            

            if (ProcessDataBase.Instance.ChucVu != 0)
                adminToolStripMenuItem.Enabled = false;

         
          
            LoadTableList();
        

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            
            if (cb.SelectedItem == null)
                return;
             DanhMuc select = cb.SelectedItem as DanhMuc;
             id = select.ID;
            LoadFoodById1(id);

        }

        private void btnthemmon_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int IdBill = HoaDonDAO.Instance.GetIDHoaDon(table.Id);
            int idFood = (comboBox2.SelectedItem as Food).ID;
            int soluong = Convert.ToInt32(nudThemmon.Value);
            if (IdBill == -1)
            {
                HoaDonDAO.Instance.ThemHD(table.Id);
                 btnthemmon_Click(sender,  e);
               

            }
            else {

                ChitietHDDAO.Instance.ThemCTHD(IdBill, idFood, soluong);
            
            }
            ShowBill(table.Id);
            LoadTableList();
        }
        
        private void btnthanhtoan_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int IdBill = HoaDonDAO.Instance.GetIDHoaDon(table.Id);
            int tien= 0;
            tien = Convert.ToInt32(txttien.Text);
            tien = (tien * (100 - Convert.ToInt32(nudkhuyenmai.Value)))/100;
          
            if (IdBill != -1) {
                if (MessageBox.Show("ban muon thanh toan ban"
                    + table.Name + " gia sau km " + tien, "Thong Bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
     
                    khuyenMai(table.Id,IdBill,tien);
                    HoaDonDAO.Instance.ThanhToan(IdBill);
                }
                ShowBill(table.Id);
                LoadTableList();
            
            }
        }
        void khuyenMai(int idtable,int idbill,int thanhtien) {

            int KM = (int)nudkhuyenmai.Value;

            HoaDonDAO.Instance.KhuyenMai(KM, idtable, idbill,thanhtien);
        }

        private void btnkhuyenmai_Click(object sender, EventArgs e)
        {
           /* int idTable = (lsvBill.Tag as Table).Id;
            int idBill = HoaDonDAO.Instance.GetIDHoaDon(idTable);
            int KM = (int)nudkhuyenmai.Value;

            HoaDonDAO.Instance.KhuyenMai(KM, idTable, idBill);*/
        }

        private void btnchuyenban_Click(object sender, EventArgs e)
        {
            try
            {
                int idTable1 = (lsvBill.Tag as Table).Id;
                int idTable2 = (cbChuyenBan.SelectedItem as Table).Id;
                if(MessageBox.Show("chuyen tu ban " + idTable1 + " ssang " 
                    + idTable2 , "thong bao",MessageBoxButtons.OKCancel) == DialogResult.OK);
                TableDAO.Instance.ChuyenBan(idTable1, idTable2);
                LoadTableList();
            }
            catch { }

        }
    }
}

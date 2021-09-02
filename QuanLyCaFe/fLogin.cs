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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            String sql = "Select UserName ,PassWorld,DisplayName,Type from Account where UserName = '";

           /* if (txtUsername.Text != "" && txtPassW.Text != "")
            {
                sql = sql + txtUsername.Text.Trim() + "' and PassWorld = '" + txtPassW.Text.Trim() + "'";
                if (ProcessDataBase.Instance.LoadData(sql).Rows.Count > 0)
                { DataTable table1 = new DataTable();
                   
                    table1 = ProcessDataBase.Instance.LoadData(sql);

                   
                    ProcessDataBase.Instance.UserName = Convert.ToString(table1.Rows[0][0].ToString());
                    ProcessDataBase.Instance.PassWorld = Convert.ToString(table1.Rows[0][1].ToString());
                    ProcessDataBase.Instance.Name = Convert.ToString(table1.Rows[0][2].ToString());
                    ProcessDataBase.Instance.ChucVu = Convert.ToInt32(table1.Rows[0][3].ToString());
           */
                    MessageBox.Show("login oke :");
                    fTableManager f = new fTableManager();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();


               // }

              //  else MessageBox.Show("login fail");




            // }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình không?","Thông Báo",MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
           
            
            }

        }
    }


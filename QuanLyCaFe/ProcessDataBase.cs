using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe
{
    public class ProcessDataBase
    {
        private static ProcessDataBase instance;

        public String UserName;
        public String PassWorld;
        public int ChucVu;
        public String Name;

        String StrConnect = "Data Source=AS-PC;Initial Catalog=QLQUANCAFE;Integrated Security=True";

        SqlConnection connection = null;

        public static ProcessDataBase Instance {
            get { if (instance == null) instance = new ProcessDataBase(); return ProcessDataBase.instance; }

            private set { ProcessDataBase.instance = value; }
        }
        private ProcessDataBase() { }

        public void OpenConnect(){

            connection = new SqlConnection(StrConnect);
            connection = new SqlConnection(StrConnect);
            if (connection.State != ConnectionState.Open)
                connection.Open();
        
        }

        public void UpdateData(String Sql) {
            OpenConnect();
             SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = Sql;
            command.ExecuteNonQuery();
            CloseConnect();
        
        }
      

        public DataTable LoadData(String Sql) {
            OpenConnect();
            DataTable table = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Sql, connection);
            dataAdapter.Fill(table);
            CloseConnect();
            return table;
        
        }

        public void CloseConnect() {

            if (connection.State != ConnectionState.Closed)
                connection.Close();
            connection.Dispose();


        }
        public object LoadCount(String sql) {
            object data = 0;
            OpenConnect();
            SqlCommand command = new SqlCommand();
             command.Connection = connection;
            command.CommandText = sql;

            data = command.ExecuteScalar();
            CloseConnect();
            return data;
          
        }




    }
}

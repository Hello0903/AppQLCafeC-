using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe
{
    class ConnecttoSql
    {
        String strConnect = "Data Source=AS-PC;Initial Catalog = QLQUANCAFE; Integrated Security = True";
        SqlConnection connection = null;

       public void Openconnection()
        {
            connection = new SqlConnection(strConnect);
            if (connection.State != ConnectionState.Open)
                connection.Open();


        }
        public void CloseConnection() {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
            connection.Dispose();


        }

        public void UpdateData(String sql) {

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = sql;
            command.ExecuteNonQuery();
        
        
        }
        public DataTable LoadTable(String sql) {
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sql);
            adapter.Fill(table);
            return table;
        
   
        }





    }
}

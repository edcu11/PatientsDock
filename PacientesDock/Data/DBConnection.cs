using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacientesDock
{
    public class DBConnection
    {
        private SqlConnection MyConnection { get; set; }

        public DBConnection()
        {
            MyConnection = new SqlConnection("Server=localhost;Database=PatientsDock;integrated security= true");
        }

        private void OpenCon ()
        {
            MyConnection.Open();
        }

        public void Close ()
        {
            MyConnection.Close();
        }


        public SqlDataReader RunQuery (string query)
        {
            SqlDataReader myReader = null;
            try
            {
                SqlCommand myCommand = new SqlCommand(query, MyConnection);
                this.OpenCon();
                myReader = myCommand.ExecuteReader();
                return myReader;
            }
            catch (Exception es)
            {
                return myReader;
            }
        }



    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacientesDock.Data
{
    public class Patients
    {
        private DBConnection myConnection { get; set; }

        public Patients()
        {
            myConnection = new DBConnection();
            
        }

        public List<MyPacienteDTO> GetPatientsFrontData(string filterName)
        {
            var results = new List<MyPacienteDTO>();
            
           /* string query = GetFrontDataQuery(filterName);
            SqlDataReader reader = myConnection.RunQuery(query);
        
            while (reader.Read())
            {
                //Convert.ToInt32(reader["Id"].ToString()), reader["Nombre"].ToString()
                PacienteDTO item = new Pacie();
                results.Add(item);
            }

            myConnection.Close();*/
            return results;                    

        }

        private string GetFrontDataQuery(string filterName)
        {
            string query = "select TOP 1 * from Paciente";
            if(filterName.CompareTo(String.Empty) != 0)
                query += " where Nombre LIKE '%" + filterName + "%'";
            return query;
        }
    }
}

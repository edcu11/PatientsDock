using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using PacientesDock.Data;

namespace PacientesDock.Forms
{
    public partial class Home : MetroForm
    {
        public Patients PatientsConn { get; set; }
        public List<MyPacienteDTO> Patients { get; set; }
        public Home()
        {
            PatientsConn = new Patients();
            Patients = new List<MyPacienteDTO>();
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            PatientsListView.Columns.Add(" ", -1, HorizontalAlignment.Center);
            PatientsListView.Columns.Add("Paciente", -1, HorizontalAlignment.Center);
        }

        private void GetTopPatients(string filter)
        {
            var pats = PatientsConn.GetPatientsFrontData(filter);

            using (var context = new PatientsDockEntities())
            {
                var pacientes = context.Pacientes.Select(pat => new MyPacienteDTO
                {
                    Id = pat.Id,
                    Nombre = pat.Nombre
                }).ToList();
                Console.WriteLine("PacienteDTOs: ", pacientes);
                PatientsListView.Items.Clear();
                PopulateLV(pacientes);
            }
        }

        private void PopulateLV(List<MyPacienteDTO> pats)
        {
            foreach (var pat in pats)
            {
                ListViewItem item = new ListViewItem(pat.Id.ToString());//Add data to MetroListView
                item.SubItems.Add(pat.Nombre);
                PatientsListView.Items.Add(item);
            }
            PatientsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void PatientsTile_Click(object sender, EventArgs e)
        {



        }

        private void PatientsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void PatientSearchBar_TextChanged(object sender, EventArgs e)
        {
            GetTopPatients(patientSearchBar.Text);
        }

        private void AddPatientTile_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var addForm = new PatientForm();
            addForm.ShowDialog();
        }

        private void PacienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



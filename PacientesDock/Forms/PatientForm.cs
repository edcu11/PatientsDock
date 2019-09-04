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
    public partial class PatientForm : MetroForm
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            PastJobsEventsGV.DataSource = new List<PastJob>();
            PastJobsGV.DataSource = new List<PastJob>();

        }

        private void MetroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void MetroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void ChildCountTB_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void SavePatient_Click(object sender, EventArgs e)
        {
            using (var context = new PatientsDockEntities())
            {
                context.Pacientes.Add(new Paciente { Nombre = NombreTB.Text, Edad = 1 });
                context.SaveChanges();
            }
        }
    }
}

namespace PacientesDock.Forms
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PatientsTile = new MetroFramework.Controls.MetroTile();
            this.AddPatientTile = new MetroFramework.Controls.MetroTile();
            this.SearchPatientLbl = new MetroFramework.Controls.MetroLabel();
            this.patientSearchBar = new MetroFramework.Controls.MetroTextBox();
            this.PatientsListView = new MetroFramework.Controls.MetroListView();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientsTile
            // 
            this.PatientsTile.ActiveControl = null;
            this.PatientsTile.Location = new System.Drawing.Point(23, 79);
            this.PatientsTile.Name = "PatientsTile";
            this.PatientsTile.Size = new System.Drawing.Size(129, 102);
            this.PatientsTile.TabIndex = 0;
            this.PatientsTile.Text = "Ver Pacientes";
            this.PatientsTile.UseSelectable = true;
            this.PatientsTile.Click += new System.EventHandler(this.PatientsTile_Click);
            // 
            // AddPatientTile
            // 
            this.AddPatientTile.ActiveControl = null;
            this.AddPatientTile.Location = new System.Drawing.Point(24, 187);
            this.AddPatientTile.Name = "AddPatientTile";
            this.AddPatientTile.Size = new System.Drawing.Size(128, 102);
            this.AddPatientTile.TabIndex = 1;
            this.AddPatientTile.Text = "Ingresar Paciente";
            this.AddPatientTile.UseSelectable = true;
            this.AddPatientTile.Click += new System.EventHandler(this.AddPatientTile_Click);
            // 
            // SearchPatientLbl
            // 
            this.SearchPatientLbl.AutoSize = true;
            this.SearchPatientLbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.SearchPatientLbl.Location = new System.Drawing.Point(237, 79);
            this.SearchPatientLbl.Name = "SearchPatientLbl";
            this.SearchPatientLbl.Size = new System.Drawing.Size(99, 19);
            this.SearchPatientLbl.TabIndex = 3;
            this.SearchPatientLbl.Text = "Buscar Paciente";
            // 
            // patientSearchBar
            // 
            // 
            // 
            // 
            this.patientSearchBar.CustomButton.Image = null;
            this.patientSearchBar.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.patientSearchBar.CustomButton.Name = "";
            this.patientSearchBar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.patientSearchBar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.patientSearchBar.CustomButton.TabIndex = 1;
            this.patientSearchBar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.patientSearchBar.CustomButton.UseSelectable = true;
            this.patientSearchBar.CustomButton.Visible = false;
            this.patientSearchBar.Lines = new string[0];
            this.patientSearchBar.Location = new System.Drawing.Point(342, 79);
            this.patientSearchBar.MaxLength = 32767;
            this.patientSearchBar.Name = "patientSearchBar";
            this.patientSearchBar.PasswordChar = '\0';
            this.patientSearchBar.PromptText = "Escriba Nombre de Paciente";
            this.patientSearchBar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.patientSearchBar.SelectedText = "";
            this.patientSearchBar.SelectionLength = 0;
            this.patientSearchBar.SelectionStart = 0;
            this.patientSearchBar.ShortcutsEnabled = true;
            this.patientSearchBar.Size = new System.Drawing.Size(298, 23);
            this.patientSearchBar.TabIndex = 4;
            this.patientSearchBar.UseSelectable = true;
            this.patientSearchBar.WaterMark = "Escriba Nombre de Paciente";
            this.patientSearchBar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.patientSearchBar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.patientSearchBar.TextChanged += new System.EventHandler(this.PatientSearchBar_TextChanged);
            // 
            // PatientsListView
            // 
            this.PatientsListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PatientsListView.FullRowSelect = true;
            this.PatientsListView.Location = new System.Drawing.Point(237, 108);
            this.PatientsListView.Name = "PatientsListView";
            this.PatientsListView.OwnerDraw = true;
            this.PatientsListView.Size = new System.Drawing.Size(403, 276);
            this.PatientsListView.TabIndex = 5;
            this.PatientsListView.UseCompatibleStateImageBehavior = false;
            this.PatientsListView.UseSelectable = true;
            this.PatientsListView.View = System.Windows.Forms.View.Details;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 466);
            this.Controls.Add(this.PatientsListView);
            this.Controls.Add(this.patientSearchBar);
            this.Controls.Add(this.SearchPatientLbl);
            this.Controls.Add(this.AddPatientTile);
            this.Controls.Add(this.PatientsTile);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile PatientsTile;
        private MetroFramework.Controls.MetroTile AddPatientTile;
        private MetroFramework.Controls.MetroLabel SearchPatientLbl;
        private MetroFramework.Controls.MetroTextBox patientSearchBar;
        private MetroFramework.Controls.MetroListView PatientsListView;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
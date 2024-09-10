using System;
using System.Linq;
using System.Windows.Forms;
using PatientsApp.Models;
using PatientsApp.Repositories;

namespace PatientsApp
{
    public partial class PatientsForm : Form
    {
        public bool IsNewRecord { get; set; } = false;
        public Patient selectedPatient { get; set; }
        private PatientRepository patientRepository = new PatientRepository();
        
        public PatientsForm()
        {
            InitializeComponent();
            ReadData();
        }

        public void ReadData()
        {
            var data  = patientRepository.GetAllPatients();
            patientsGrid.DataSource = data.ToList();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            IsNewRecord = true;
            AddForm addForm = new AddForm(this, IsNewRecord, 0);
            addForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            
            AddForm addForm = new AddForm(this, false, selectedPatient.Id);
            addForm.FillAddForm(selectedPatient);
            addForm.ShowDialog();
        }
        


        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm(this, selectedPatient.Id);
            deleteForm.ShowDialog();
        }

        private void patientsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IsNewRecord = false;
                DataGridView dgv = sender as DataGridView;
                if (dgv == null) return;
                
                int id = int.Parse(dgv.CurrentRow.Cells[0].Value.ToString());
                selectedPatient = patientRepository.GetPatientById(id);
            }
            catch (Exception exception)
            {
                MessageBox.Show("An error occurred while selecting the patient: " + exception.Message);
            }
        }
    }
}
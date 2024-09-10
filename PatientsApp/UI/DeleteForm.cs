using System;
using System.Windows.Forms;
using PatientsApp.Repositories;

namespace PatientsApp;

public partial class DeleteForm : Form
{
    private readonly PatientsForm _patientsForm;
    private readonly PatientRepository _patientRepository = new PatientRepository();
    private readonly int _patientId = default;

    public DeleteForm(PatientsForm patientsForm, int id)
    {
        InitializeComponent();
        _patientsForm = patientsForm;
        _patientId= id;
    }

    private void BtnYes_Click(object sender, EventArgs e)
    {
        _patientRepository.DeletePatient(_patientId);
        Close();
        _patientsForm.ReadData();
    }

    private void btnNo_Click(object sender, EventArgs e)
    {
        Close();
        _patientsForm.ReadData();
    }
}
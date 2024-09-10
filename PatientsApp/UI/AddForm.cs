using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PatientsApp.Models;
using PatientsApp.Repositories;

namespace PatientsApp;

public partial class AddForm : Form
{
    bool isNewRecord = false;
    private readonly int _patientId = default;
    private readonly PatientsForm _patientsForm;
    private PatientRepository _patientRepository = new PatientRepository();
    private GenderRepository _genderRepository = new GenderRepository();

    public AddForm(PatientsForm patientsForm, bool isNewRecord, int id)
    {
        _patientsForm = patientsForm;
        InitializeComponent();
        genderBox.DataSource = _genderRepository.GetAllGenders();
        this.isNewRecord = isNewRecord;
        _patientId = id;
        genderBox.SelectedValue = 0;
    }

    private bool ValidateForm()
    {
        bool isValid = true;

        foreach (Control control in this.Controls)
        {
            if (control is TextBox textBox)
            {
                if (string.IsNullOrEmpty(textBox.Text) && textBox.Name == "txtFullName")
                {
                    errorProviderFullName.SetError(textBox, "სახელი და გვარი სავალდებულოა.");
                    isValid = false;
                }
                else if (textBox.Name == "txtPhoneNumber" && !IsValidPhoneNumber(textBox.Text))
                {
                    errorProviderPhone.SetError(textBox, "მობილურის ნომერი უნდა იწყებოდეს 5-ით და შედგებოდეს 9 ციფრისგან.");
                    isValid = false;
                }
                else
                {
                    errorProviderPhone.Clear();
                    errorProviderFullName.Clear();
                }
            }
            else if (control is ComboBox comboBox)
            {
                if (comboBox.Name == "genderBox" &&
                    (comboBox.SelectedValue == null || Convert.ToInt32(comboBox.SelectedValue) == 0))
                {
                    errorProviderGenderBox.SetError(comboBox, "აირჩიეთ სქესი.");
                    isValid = false;
                }
                else
                {
                    errorProviderGenderBox.Clear();
                }
            }
        }
        return isValid;
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        bool formValidate = ValidateForm();

        if (formValidate)
        {
            Patient patient = new Patient
            {
                Dob = datePickerBirthday.Value,
                Id = _patientId,
                FullName = txtFullName.Text,
                GenderID = Convert.ToInt32(genderBox.SelectedValue),
                Address = txtAddress.Text,
                Phone = txtPhoneNumber.Text,
                Email = txtEmail.Text,
                PersonalNumber = txtPersonalNumber.Text
            };
            
            if (isNewRecord)
            {
                _patientRepository.AddPatient(patient);
            }
            else
            {
                _patientRepository.UpdatePatient(patient, _patientId);
            }

            Close();
            _patientsForm.ReadData();
        }
    }


    public void FillAddForm(Patient patient)
    {
        txtFullName.Text = patient.FullName;
        txtPhoneNumber.Text = patient.Phone;
        txtAddress.Text = patient.Address;
        datePickerBirthday.Value = patient.Dob;
        genderBox.SelectedValue = patient.GenderID;
        txtEmail.Text = patient.Email;
        txtPersonalNumber.Text = patient.PersonalNumber;
    }

    private bool IsValidPhoneNumber(string phoneNumber)
    {
        string pattern = @"^\d{3}-\d{3}-\d{3}$";
        return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, pattern);
    }
}
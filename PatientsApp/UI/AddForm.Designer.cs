using System.ComponentModel;

namespace PatientsApp;

partial class AddForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.label1 = new System.Windows.Forms.Label();
        this.txtFullName = new System.Windows.Forms.TextBox();
        this.label2 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.txtPhoneNumber = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.txtAddress = new System.Windows.Forms.TextBox();
        this.addButton = new System.Windows.Forms.Button();
        this.genderBox = new System.Windows.Forms.ComboBox();
        this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
        this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
        this.errorProviderFullName = new System.Windows.Forms.ErrorProvider(this.components);
        this.errorProviderGenderBox = new System.Windows.Forms.ErrorProvider(this.components);
        this.labelEmail = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.labelPersonalNumber = new System.Windows.Forms.Label();
        this.txtPersonalNumber = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.errorProviderFullName)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.errorProviderGenderBox)).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(12, 9);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(156, 16);
        this.label1.TabIndex = 0;
        this.label1.Text = "პაციენტის გვარი სახელი";
        // 
        // txtFullName
        // 
        this.txtFullName.Location = new System.Drawing.Point(12, 28);
        this.txtFullName.Name = "txtFullName";
        this.txtFullName.Size = new System.Drawing.Size(217, 20);
        this.txtFullName.TabIndex = 3;
        // 
        // label2
        // 
        this.label2.Location = new System.Drawing.Point(12, 51);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(137, 19);
        this.label2.TabIndex = 4;
        this.label2.Text = "დაბ თარიღი";
        // 
        // label3
        // 
        this.label3.Location = new System.Drawing.Point(12, 96);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(137, 19);
        this.label3.TabIndex = 6;
        this.label3.Text = "სქესი";
        // 
        // label4
        // 
        this.label4.Location = new System.Drawing.Point(12, 141);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(137, 19);
        this.label4.TabIndex = 8;
        this.label4.Text = "მობ ნომერი";
        // 
        // txtPhoneNumber
        // 
        this.txtPhoneNumber.Location = new System.Drawing.Point(13, 163);
        this.txtPhoneNumber.Name = "txtPhoneNumber";
        this.txtPhoneNumber.Size = new System.Drawing.Size(216, 20);
        this.txtPhoneNumber.TabIndex = 9;
        // 
        // label5
        // 
        this.label5.Location = new System.Drawing.Point(13, 186);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(137, 19);
        this.label5.TabIndex = 10;
        this.label5.Text = "მისამართი";
        // 
        // txtAddress
        // 
        this.txtAddress.Location = new System.Drawing.Point(12, 208);
        this.txtAddress.Name = "txtAddress";
        this.txtAddress.Size = new System.Drawing.Size(216, 20);
        this.txtAddress.TabIndex = 11;
        // 
        // addButton
        // 
        this.addButton.Location = new System.Drawing.Point(189, 358);
        this.addButton.Name = "addButton";
        this.addButton.Size = new System.Drawing.Size(74, 23);
        this.addButton.TabIndex = 12;
        this.addButton.Text = "დამატება";
        this.addButton.UseVisualStyleBackColor = true;
        this.addButton.Click += new System.EventHandler(this.addButton_Click);
        // 
        // genderBox
        // 
        this.genderBox.DisplayMember = "GenderName";
        this.genderBox.FormattingEnabled = true;
        this.genderBox.Location = new System.Drawing.Point(13, 117);
        this.genderBox.Name = "genderBox";
        this.genderBox.Size = new System.Drawing.Size(214, 21);
        this.genderBox.TabIndex = 13;
        this.genderBox.ValueMember = "GenderId";
        // 
        // datePickerBirthday
        // 
        this.datePickerBirthday.Location = new System.Drawing.Point(12, 73);
        this.datePickerBirthday.Name = "datePickerBirthday";
        this.datePickerBirthday.Size = new System.Drawing.Size(215, 20);
        this.datePickerBirthday.TabIndex = 14;
        // 
        // errorProviderPhone
        // 
        this.errorProviderPhone.ContainerControl = this;
        // 
        // errorProviderFullName
        // 
        this.errorProviderFullName.ContainerControl = this;
        // 
        // errorProviderGenderBox
        // 
        this.errorProviderGenderBox.ContainerControl = this;
        // 
        // labelEmail
        // 
        this.labelEmail.Location = new System.Drawing.Point(13, 231);
        this.labelEmail.Name = "labelEmail";
        this.labelEmail.Size = new System.Drawing.Size(137, 19);
        this.labelEmail.TabIndex = 15;
        this.labelEmail.Text = "ელ.ფოსტა";
        // 
        // txtEmail
        // 
        this.txtEmail.Location = new System.Drawing.Point(13, 253);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(216, 20);
        this.txtEmail.TabIndex = 16;
        // 
        // labelPersonalNumber
        // 
        this.labelPersonalNumber.Location = new System.Drawing.Point(13, 276);
        this.labelPersonalNumber.Name = "labelPersonalNumber";
        this.labelPersonalNumber.Size = new System.Drawing.Size(137, 19);
        this.labelPersonalNumber.TabIndex = 17;
        this.labelPersonalNumber.Text = "პირადი ნომერი";
        // 
        // txtPersonalNumber
        // 
        this.txtPersonalNumber.Location = new System.Drawing.Point(13, 298);
        this.txtPersonalNumber.Name = "txtPersonalNumber";
        this.txtPersonalNumber.Size = new System.Drawing.Size(216, 20);
        this.txtPersonalNumber.TabIndex = 18;
        // 
        // AddForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(275, 393);
        this.Controls.Add(this.txtPersonalNumber);
        this.Controls.Add(this.labelPersonalNumber);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.labelEmail);
        this.Controls.Add(this.datePickerBirthday);
        this.Controls.Add(this.genderBox);
        this.Controls.Add(this.addButton);
        this.Controls.Add(this.txtAddress);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.txtPhoneNumber);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label3);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.txtFullName);
        this.Controls.Add(this.label1);
        this.Name = "AddForm";
        this.Text = "AddForm";
        ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.errorProviderFullName)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.errorProviderGenderBox)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label labelEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label labelPersonalNumber;
    private System.Windows.Forms.TextBox txtPersonalNumber;

    private System.Windows.Forms.ErrorProvider errorProviderGenderBox;

    private System.Windows.Forms.ErrorProvider errorProviderFullName;

    private System.Windows.Forms.ErrorProvider errorProviderPhone;

    private System.Windows.Forms.DateTimePicker datePickerBirthday;

    private System.Windows.Forms.ComboBox genderBox;

    private System.Windows.Forms.Button addButton;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtAddress;

    private System.Windows.Forms.TextBox txtPhoneNumber;

    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.TextBox txtFullName;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}
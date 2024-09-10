using System.ComponentModel;

namespace PatientsApp;

partial class DeleteForm
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
        this.label1 = new System.Windows.Forms.Label();
        this.BtnYes = new System.Windows.Forms.Button();
        this.btnNo = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(38, 43);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(218, 54);
        this.label1.TabIndex = 0;
        this.label1.Text = "„გსურთ მონიშნული ჩანაწერის წაშლა?“";
        // 
        // BtnYes
        // 
        this.BtnYes.Location = new System.Drawing.Point(29, 132);
        this.BtnYes.Name = "BtnYes";
        this.BtnYes.Size = new System.Drawing.Size(76, 29);
        this.BtnYes.TabIndex = 1;
        this.BtnYes.Text = "Yes";
        this.BtnYes.UseVisualStyleBackColor = true;
        this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
        // 
        // btnNo
        // 
        this.btnNo.Location = new System.Drawing.Point(180, 132);
        this.btnNo.Name = "btnNo";
        this.btnNo.Size = new System.Drawing.Size(76, 29);
        this.btnNo.TabIndex = 2;
        this.btnNo.Text = "No";
        this.btnNo.UseVisualStyleBackColor = true;
        this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
        // 
        // DeleteForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(299, 213);
        this.Controls.Add(this.btnNo);
        this.Controls.Add(this.BtnYes);
        this.Controls.Add(this.label1);
        this.Name = "DeleteForm";
        this.Text = "DeleteForm";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnNo;

    private System.Windows.Forms.Button BtnYes;

    private System.Windows.Forms.Label label1;

    #endregion
}
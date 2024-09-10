using System.Windows.Forms;

namespace PatientsApp
{
    partial class PatientsForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.patientsGrid = new System.Windows.Forms.DataGridView();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(18, 15);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 26);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "დამატება";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // patientsGrid
            // 
            this.patientsGrid.AllowUserToOrderColumns = true;
            this.patientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsGrid.Location = new System.Drawing.Point(16, 60);
            this.patientsGrid.Name = "patientsGrid";
            this.patientsGrid.ReadOnly = true;
            this.patientsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientsGrid.Size = new System.Drawing.Size(748, 352);
            this.patientsGrid.TabIndex = 1;
            this.patientsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientsGrid_CellClick);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(129, 15);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(105, 26);
            this.editButton.TabIndex = 2;
            this.editButton.Text = "რედაქტირება";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(240, 15);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 26);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "წაშლა";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.patientsGrid);
            this.Controls.Add(this.addButton);
            this.Name = "PatientsForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.patientsGrid)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;

        private System.Windows.Forms.DataGridView patientsGrid;

        private System.Windows.Forms.Button addButton;

        #endregion
    }
}
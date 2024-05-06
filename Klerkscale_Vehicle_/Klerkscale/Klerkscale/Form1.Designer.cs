using System;
using System.Windows.Forms;

namespace Klerkscale
{
    partial class Form1
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
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.txtVehicleName = new System.Windows.Forms.TextBox();
            this.listBoxVehicles = new System.Windows.Forms.ListBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.btnAddWeight = new System.Windows.Forms.Button();
            this.listBoxWeights = new System.Windows.Forms.ListBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtRegistrationDetails = new System.Windows.Forms.TextBox();
            this.pnlVehicleManagement = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Location = new System.Drawing.Point(291, 12);
            this.btnAddVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(100, 28);
            this.btnAddVehicle.TabIndex = 1;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // txtVehicleName
            // 
            this.txtVehicleName.Location = new System.Drawing.Point(16, 15);
            this.txtVehicleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtVehicleName.Name = "txtVehicleName";
            this.txtVehicleName.Size = new System.Drawing.Size(265, 22);
            this.txtVehicleName.TabIndex = 0;
            // 
            // listBoxVehicles
            // 
            this.listBoxVehicles.FormattingEnabled = true;
            this.listBoxVehicles.ItemHeight = 16;
            this.listBoxVehicles.Location = new System.Drawing.Point(16, 49);
            this.listBoxVehicles.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxVehicles.Name = "listBoxVehicles";
            this.listBoxVehicles.Size = new System.Drawing.Size(265, 116);
            this.listBoxVehicles.TabIndex = 2;
            this.listBoxVehicles.SelectedIndexChanged += new System.EventHandler(this.listBoxVehicles_SelectedIndexChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(16, 174);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(265, 22);
            this.txtWeight.TabIndex = 3;
            // 
            // btnAddWeight
            // 
            this.btnAddWeight.Location = new System.Drawing.Point(291, 171);
            this.btnAddWeight.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddWeight.Name = "btnAddWeight";
            this.btnAddWeight.Size = new System.Drawing.Size(100, 28);
            this.btnAddWeight.TabIndex = 4;
            this.btnAddWeight.Text = "Add Weight";
            this.btnAddWeight.UseVisualStyleBackColor = true;
            this.btnAddWeight.Click += new System.EventHandler(this.btnAddWeight_Click);
            // 
            // listBoxWeights
            // 
            this.listBoxWeights.FormattingEnabled = true;
            this.listBoxWeights.ItemHeight = 16;
            this.listBoxWeights.Location = new System.Drawing.Point(16, 206);
            this.listBoxWeights.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxWeights.Name = "listBoxWeights";
            this.listBoxWeights.Size = new System.Drawing.Size(265, 116);
            this.listBoxWeights.TabIndex = 5;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(16, 330);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(375, 28);
            this.btnGenerateReport.TabIndex = 6;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(291, 268);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 28);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtRegistrationDetails
            // 
            this.txtRegistrationDetails.Location = new System.Drawing.Point(12, 297);
            this.txtRegistrationDetails.Multiline = true;
            this.txtRegistrationDetails.Name = "txtRegistrationDetails";
            this.txtRegistrationDetails.Size = new System.Drawing.Size(281, 82);
            this.txtRegistrationDetails.TabIndex = 8;
            // 
            // pnlVehicleManagement
            // 
            this.pnlVehicleManagement.Location = new System.Drawing.Point(0, 0);
            this.pnlVehicleManagement.Name = "pnlVehicleManagement";
            this.pnlVehicleManagement.Size = new System.Drawing.Size(200, 100);
            this.pnlVehicleManagement.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Register Vehicle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.listBoxWeights);
            this.Controls.Add(this.btnAddWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.listBoxVehicles);
            this.Controls.Add(this.txtVehicleName);
            this.Controls.Add(this.btnAddVehicle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Vehicle Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.TextBox txtVehicleName;
        private System.Windows.Forms.ListBox listBoxVehicles;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnAddWeight;
        private System.Windows.Forms.ListBox listBoxWeights;
        private System.Windows.Forms.Button btnGenerateReport;
        private Button btnRegister;
        private TextBox txtRegistrationDetails;
        private Panel pnlVehicleManagement;
        private Button button1;
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Term_Project
{
    public class fmPromptHours: Form
    {
        private Button bnCancel;
        private Button bnSave;
        private ErrorProvider epHours;
        private IContainer components;
        private TextBox tbHours;
        private TextBox tbEmpID;
        private Label label1;
        private Label lbEmpID;
        private int pfvEmpID;
        private double pfvHours;

        public int EmpID
        {
            set
            {
            }
        }

        public double Hours
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bnCancel = new System.Windows.Forms.Button();
            this.bnSave = new System.Windows.Forms.Button();
            this.epHours = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbEmpID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.tbHours = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epHours)).BeginInit();
            this.SuspendLayout();
            // 
            // bnCancel
            // 
            this.bnCancel.Location = new System.Drawing.Point(186, 91);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(90, 32);
            this.bnCancel.TabIndex = 0;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // bnSave
            // 
            this.bnSave.Location = new System.Drawing.Point(54, 91);
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(90, 32);
            this.bnSave.TabIndex = 1;
            this.bnSave.Text = "Save";
            this.bnSave.UseVisualStyleBackColor = true;
            this.bnSave.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // epHours
            // 
            this.epHours.ContainerControl = this;
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Location = new System.Drawing.Point(67, 30);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(42, 13);
            this.lbEmpID.TabIndex = 2;
            this.lbEmpID.Text = "EmpID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hours Worked:";
            // 
            // tbEmpID
            // 
            this.tbEmpID.Location = new System.Drawing.Point(115, 27);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.ReadOnly = true;
            this.tbEmpID.Size = new System.Drawing.Size(100, 20);
            this.tbEmpID.TabIndex = 4;
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(115, 55);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(100, 20);
            this.tbHours.TabIndex = 5;
            // 
            // fmPromptHours
            // 
            this.ClientSize = new System.Drawing.Size(329, 140);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.tbEmpID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEmpID);
            this.Controls.Add(this.bnSave);
            this.Controls.Add(this.bnCancel);
            this.Name = "fmPromptHours";
            this.Text = "Hourly Prompt";
            this.Load += new System.EventHandler(this.fmPromptHours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void bnCancel_Click(object sender, EventArgs e)
        {

        }

        private void bnSave_Click(object sender, EventArgs e)
        {

        }

        private void fmPromptHours_Load(object sender, EventArgs e)
        {

        }
    }
}
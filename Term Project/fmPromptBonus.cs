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
    public class fmPromptBonus: Form
    {
        private Button bnCancel;
        private ErrorProvider epBonus;
        private IContainer components;
        private Label lbEmpID;
        private Label lbBonus;
        private Button bnSave;
        private double pfvBonus;
        private TextBox textBox1;
        private TextBox tbEmpID;
        private int pfvEmpID;

        public double Bonus
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public int EmpID
        {
            set
            {
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bnCancel = new System.Windows.Forms.Button();
            this.bnSave = new System.Windows.Forms.Button();
            this.epBonus = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbBonus = new System.Windows.Forms.Label();
            this.lbEmpID = new System.Windows.Forms.Label();
            this.tbEmpID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epBonus)).BeginInit();
            this.SuspendLayout();
            // 
            // bnCancel
            // 
            this.bnCancel.Location = new System.Drawing.Point(201, 96);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(100, 31);
            this.bnCancel.TabIndex = 0;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // bnSave
            // 
            this.bnSave.Location = new System.Drawing.Point(82, 96);
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(100, 31);
            this.bnSave.TabIndex = 1;
            this.bnSave.Text = "Save";
            this.bnSave.UseVisualStyleBackColor = true;
            this.bnSave.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // epBonus
            // 
            this.epBonus.ContainerControl = this;
            // 
            // lbBonus
            // 
            this.lbBonus.AutoSize = true;
            this.lbBonus.Location = new System.Drawing.Point(48, 58);
            this.lbBonus.Name = "lbBonus";
            this.lbBonus.Size = new System.Drawing.Size(93, 13);
            this.lbBonus.TabIndex = 2;
            this.lbBonus.Text = "Bonus Amount (%)";
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Location = new System.Drawing.Point(99, 29);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(42, 13);
            this.lbEmpID.TabIndex = 3;
            this.lbEmpID.Text = "EmpID:";
            // 
            // tbEmpID
            // 
            this.tbEmpID.Location = new System.Drawing.Point(147, 26);
            this.tbEmpID.Name = "tbEmpID";
            this.tbEmpID.ReadOnly = true;
            this.tbEmpID.Size = new System.Drawing.Size(119, 20);
            this.tbEmpID.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 5;
            // 
            // fmPromptBonus
            // 
            this.ClientSize = new System.Drawing.Size(388, 165);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbEmpID);
            this.Controls.Add(this.lbEmpID);
            this.Controls.Add(this.lbBonus);
            this.Controls.Add(this.bnSave);
            this.Controls.Add(this.bnCancel);
            this.Name = "fmPromptBonus";
            this.Text = "Bonus Prompt";
            this.Load += new System.EventHandler(this.fmPromptBonus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epBonus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnSave_Click(object sender, EventArgs e)
        {

        }

        private void fmPromptBonus_Load(object sender, EventArgs e)
        {

        }
    }
}
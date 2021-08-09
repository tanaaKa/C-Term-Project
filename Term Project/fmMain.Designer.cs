namespace Term_Project
{
    partial class fmMain
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActionsData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiActionsPay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.bnExit = new System.Windows.Forms.Button();
            this.bnLoad = new System.Windows.Forms.Button();
            this.bnPay = new System.Windows.Forms.Button();
            this.bnPrompt = new System.Windows.Forms.Button();
            this.lbxEmployee = new System.Windows.Forms.ListBox();
            this.lbxPayData = new System.Windows.Forms.ListBox();
            this.sfdMain = new System.Windows.Forms.SaveFileDialog();
            this.tsslCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPay = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiActions,
            this.tsmiHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(783, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileLoad,
            this.tsmiFileSave,
            this.tsmiFileExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiFileLoad
            // 
            this.tsmiFileLoad.Name = "tsmiFileLoad";
            this.tsmiFileLoad.Size = new System.Drawing.Size(152, 22);
            this.tsmiFileLoad.Text = "Load Data";
            this.tsmiFileLoad.Click += new System.EventHandler(this.tsmiFileLoad_Click);
            // 
            // tsmiFileSave
            // 
            this.tsmiFileSave.Name = "tsmiFileSave";
            this.tsmiFileSave.Size = new System.Drawing.Size(152, 22);
            this.tsmiFileSave.Text = "Save As";
            this.tsmiFileSave.Click += new System.EventHandler(this.tsmiFileSave_Click);
            // 
            // tsmiFileExit
            // 
            this.tsmiFileExit.Name = "tsmiFileExit";
            this.tsmiFileExit.Size = new System.Drawing.Size(152, 22);
            this.tsmiFileExit.Text = "Exit";
            this.tsmiFileExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tsmiActions
            // 
            this.tsmiActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiActionsData,
            this.tsmiActionsPay});
            this.tsmiActions.Name = "tsmiActions";
            this.tsmiActions.Size = new System.Drawing.Size(59, 20);
            this.tsmiActions.Text = "Actions";
            // 
            // tsmiActionsData
            // 
            this.tsmiActionsData.Name = "tsmiActionsData";
            this.tsmiActionsData.Size = new System.Drawing.Size(167, 22);
            this.tsmiActionsData.Text = "Enter Payroll Data";
            this.tsmiActionsData.Click += new System.EventHandler(this.tsmiActionsData_Click);
            // 
            // tsmiActionsPay
            // 
            this.tsmiActionsPay.Name = "tsmiActionsPay";
            this.tsmiActionsPay.Size = new System.Drawing.Size(167, 22);
            this.tsmiActionsPay.Text = "Calculate Pay";
            this.tsmiActionsPay.Click += new System.EventHandler(this.tsmiActionsPay_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelpAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiHelpAbout
            // 
            this.tsmiHelpAbout.Name = "tsmiHelpAbout";
            this.tsmiHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.tsmiHelpAbout.Text = "About";
            this.tsmiHelpAbout.Click += new System.EventHandler(this.tsmiHelpAbout_Click);
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCount,
            this.tsslPay});
            this.ssMain.Location = new System.Drawing.Point(0, 415);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(783, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // bnExit
            // 
            this.bnExit.Location = new System.Drawing.Point(473, 375);
            this.bnExit.Name = "bnExit";
            this.bnExit.Size = new System.Drawing.Size(75, 23);
            this.bnExit.TabIndex = 2;
            this.bnExit.Text = "Exit";
            this.bnExit.UseVisualStyleBackColor = true;
            this.bnExit.Click += new System.EventHandler(this.bnExit_Click);
            // 
            // bnLoad
            // 
            this.bnLoad.Location = new System.Drawing.Point(222, 375);
            this.bnLoad.Name = "bnLoad";
            this.bnLoad.Size = new System.Drawing.Size(75, 23);
            this.bnLoad.TabIndex = 3;
            this.bnLoad.Text = "Load";
            this.bnLoad.UseVisualStyleBackColor = true;
            // 
            // bnPay
            // 
            this.bnPay.Location = new System.Drawing.Point(392, 375);
            this.bnPay.Name = "bnPay";
            this.bnPay.Size = new System.Drawing.Size(75, 23);
            this.bnPay.TabIndex = 4;
            this.bnPay.Text = "Calc Pay";
            this.bnPay.UseVisualStyleBackColor = true;
            // 
            // bnPrompt
            // 
            this.bnPrompt.Location = new System.Drawing.Point(303, 375);
            this.bnPrompt.Name = "bnPrompt";
            this.bnPrompt.Size = new System.Drawing.Size(75, 23);
            this.bnPrompt.TabIndex = 5;
            this.bnPrompt.Text = "Enter Data";
            this.bnPrompt.UseVisualStyleBackColor = true;
            // 
            // lbxEmployee
            // 
            this.lbxEmployee.FormattingEnabled = true;
            this.lbxEmployee.Location = new System.Drawing.Point(12, 45);
            this.lbxEmployee.Name = "lbxEmployee";
            this.lbxEmployee.Size = new System.Drawing.Size(366, 316);
            this.lbxEmployee.TabIndex = 6;
            // 
            // lbxPayData
            // 
            this.lbxPayData.FormattingEnabled = true;
            this.lbxPayData.Location = new System.Drawing.Point(392, 45);
            this.lbxPayData.Name = "lbxPayData";
            this.lbxPayData.Size = new System.Drawing.Size(379, 316);
            this.lbxPayData.TabIndex = 7;
            // 
            // sfdMain
            // 
            this.sfdMain.FileOk += new System.ComponentModel.CancelEventHandler(this.sfdMain_FileOk);
            // 
            // tsslCount
            // 
            this.tsslCount.Name = "tsslCount";
            this.tsslCount.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslPay
            // 
            this.tsslPay.Name = "tsslPay";
            this.tsslPay.Size = new System.Drawing.Size(0, 17);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 437);
            this.Controls.Add(this.lbxPayData);
            this.Controls.Add(this.lbxEmployee);
            this.Controls.Add(this.bnPrompt);
            this.Controls.Add(this.bnPay);
            this.Controls.Add(this.bnLoad);
            this.Controls.Add(this.bnExit);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "fmMain";
            this.Text = "Term Project";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileLoad;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiActions;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionsData;
        private System.Windows.Forms.ToolStripMenuItem tsmiActionsPay;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpAbout;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Button bnExit;
        private System.Windows.Forms.Button bnLoad;
        private System.Windows.Forms.Button bnPay;
        private System.Windows.Forms.Button bnPrompt;
        private System.Windows.Forms.ListBox lbxEmployee;
        private System.Windows.Forms.ListBox lbxPayData;
        private System.Windows.Forms.SaveFileDialog sfdMain;
        private System.Windows.Forms.ToolStripStatusLabel tsslCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslPay;
    }
}



namespace Cat_Quest_Cheat
{
    partial class frmMain
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
            this.BGWorker = new System.ComponentModel.BackgroundWorker();
            this.gbProce = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.btMoney = new System.Windows.Forms.Button();
            this.cbHP = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSP = new System.Windows.Forms.CheckBox();
            this.cbDamage = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.speedHack = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProce.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedHack)).BeginInit();
            this.SuspendLayout();
            // 
            // BGWorker
            // 
            this.BGWorker.WorkerReportsProgress = true;
            this.BGWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWorker_DoWork);
            this.BGWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGWorker_ProgressChanged);
            this.BGWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWorker_RunWorkerCompleted);
            // 
            // gbProce
            // 
            this.gbProce.Controls.Add(this.groupBox3);
            this.gbProce.Controls.Add(this.groupBox2);
            this.gbProce.Controls.Add(this.groupBox1);
            this.gbProce.Location = new System.Drawing.Point(12, 12);
            this.gbProce.Name = "gbProce";
            this.gbProce.Size = new System.Drawing.Size(438, 127);
            this.gbProce.TabIndex = 1;
            this.gbProce.TabStop = false;
            this.gbProce.Text = "Game Process : N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btMoney);
            this.groupBox1.Controls.Add(this.tbMoney);
            this.groupBox1.Location = new System.Drawing.Point(14, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Money";
            // 
            // tbMoney
            // 
            this.tbMoney.Location = new System.Drawing.Point(15, 19);
            this.tbMoney.MaxLength = 6;
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(100, 20);
            this.tbMoney.TabIndex = 0;
            this.tbMoney.Text = "99999";
            // 
            // btMoney
            // 
            this.btMoney.Location = new System.Drawing.Point(15, 45);
            this.btMoney.Name = "btMoney";
            this.btMoney.Size = new System.Drawing.Size(100, 37);
            this.btMoney.TabIndex = 1;
            this.btMoney.Text = "Money Hack";
            this.btMoney.UseVisualStyleBackColor = true;
            this.btMoney.Click += new System.EventHandler(this.btMoney_Click);
            // 
            // cbHP
            // 
            this.cbHP.AutoSize = true;
            this.cbHP.Location = new System.Drawing.Point(15, 19);
            this.cbHP.Name = "cbHP";
            this.cbHP.Size = new System.Drawing.Size(70, 17);
            this.cbHP.TabIndex = 1;
            this.cbHP.Text = "HP Hack";
            this.cbHP.UseVisualStyleBackColor = true;
            this.cbHP.CheckedChanged += new System.EventHandler(this.cbHP_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbDamage);
            this.groupBox2.Controls.Add(this.cbSP);
            this.groupBox2.Controls.Add(this.cbHP);
            this.groupBox2.Location = new System.Drawing.Point(153, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other";
            // 
            // cbSP
            // 
            this.cbSP.AutoSize = true;
            this.cbSP.Location = new System.Drawing.Point(15, 42);
            this.cbSP.Name = "cbSP";
            this.cbSP.Size = new System.Drawing.Size(69, 17);
            this.cbSP.TabIndex = 2;
            this.cbSP.Text = "SP Hack";
            this.cbSP.UseVisualStyleBackColor = true;
            this.cbSP.CheckedChanged += new System.EventHandler(this.cbSP_CheckedChanged);
            // 
            // cbDamage
            // 
            this.cbDamage.AutoSize = true;
            this.cbDamage.Location = new System.Drawing.Point(15, 65);
            this.cbDamage.Name = "cbDamage";
            this.cbDamage.Size = new System.Drawing.Size(99, 17);
            this.cbDamage.TabIndex = 3;
            this.cbDamage.Text = "99999 Damage";
            this.cbDamage.UseVisualStyleBackColor = true;
            this.cbDamage.CheckedChanged += new System.EventHandler(this.cbDamage_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.speedHack);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(292, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Speed Hack";
            // 
            // speedHack
            // 
            this.speedHack.Location = new System.Drawing.Point(15, 44);
            this.speedHack.Maximum = 20;
            this.speedHack.Minimum = 2;
            this.speedHack.Name = "speedHack";
            this.speedHack.Size = new System.Drawing.Size(100, 45);
            this.speedHack.TabIndex = 0;
            this.speedHack.TickFrequency = 2;
            this.speedHack.Value = 2;
            this.speedHack.ValueChanged += new System.EventHandler(this.speedHack_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Speed : N/A";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 149);
            this.Controls.Add(this.gbProce);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(477, 188);
            this.MinimumSize = new System.Drawing.Size(477, 188);
            this.Name = "frmMain";
            this.Text = "Cat Quest Cheat";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.gbProce.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedHack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker BGWorker;
        private System.Windows.Forms.GroupBox gbProce;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar speedHack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbDamage;
        private System.Windows.Forms.CheckBox cbSP;
        private System.Windows.Forms.CheckBox cbHP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btMoney;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.Label label1;
    }
}


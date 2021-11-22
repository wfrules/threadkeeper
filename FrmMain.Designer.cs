
namespace threadkeeper
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.btnDebug = new System.Windows.Forms.Button();
            this.tmrCheck = new System.Windows.Forms.Timer(this.components);
            this.btnToggle = new System.Windows.Forms.Button();
            this.nudInterVal = new System.Windows.Forms.NumericUpDown();
            this.tbProc = new System.Windows.Forms.TextBox();
            this.lblProc = new System.Windows.Forms.Label();
            this.lblInterVal = new System.Windows.Forms.Label();
            this.lblCmd = new System.Windows.Forms.Label();
            this.tbCmd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterVal)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(57, 107);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(652, 323);
            this.tbLog.TabIndex = 0;
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(23, 12);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(75, 23);
            this.btnDebug.TabIndex = 1;
            this.btnDebug.Text = "debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Visible = false;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // tmrCheck
            // 
            this.tmrCheck.Tick += new System.EventHandler(this.tmrCheck_Tick);
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(158, 62);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(75, 23);
            this.btnToggle.TabIndex = 2;
            this.btnToggle.Text = "启动";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // nudInterVal
            // 
            this.nudInterVal.Location = new System.Drawing.Point(277, 12);
            this.nudInterVal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudInterVal.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudInterVal.Name = "nudInterVal";
            this.nudInterVal.Size = new System.Drawing.Size(120, 23);
            this.nudInterVal.TabIndex = 3;
            this.nudInterVal.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // tbProc
            // 
            this.tbProc.Location = new System.Drawing.Point(481, 15);
            this.tbProc.Name = "tbProc";
            this.tbProc.Size = new System.Drawing.Size(71, 23);
            this.tbProc.TabIndex = 4;
            this.tbProc.Text = "JAVA";
            // 
            // lblProc
            // 
            this.lblProc.AutoSize = true;
            this.lblProc.Location = new System.Drawing.Point(415, 18);
            this.lblProc.Name = "lblProc";
            this.lblProc.Size = new System.Drawing.Size(44, 17);
            this.lblProc.TabIndex = 5;
            this.lblProc.Text = "进程名";
            // 
            // lblInterVal
            // 
            this.lblInterVal.AutoSize = true;
            this.lblInterVal.Location = new System.Drawing.Point(158, 14);
            this.lblInterVal.Name = "lblInterVal";
            this.lblInterVal.Size = new System.Drawing.Size(88, 17);
            this.lblInterVal.TabIndex = 6;
            this.lblInterVal.Text = "监测间隔(毫秒)";
            // 
            // lblCmd
            // 
            this.lblCmd.AutoSize = true;
            this.lblCmd.Location = new System.Drawing.Point(252, 65);
            this.lblCmd.Name = "lblCmd";
            this.lblCmd.Size = new System.Drawing.Size(56, 17);
            this.lblCmd.TabIndex = 7;
            this.lblCmd.Text = "执行命令";
            // 
            // tbCmd
            // 
            this.tbCmd.Location = new System.Drawing.Point(314, 59);
            this.tbCmd.Name = "tbCmd";
            this.tbCmd.Size = new System.Drawing.Size(390, 23);
            this.tbCmd.TabIndex = 8;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCmd);
            this.Controls.Add(this.lblCmd);
            this.Controls.Add(this.lblInterVal);
            this.Controls.Add(this.lblProc);
            this.Controls.Add(this.tbProc);
            this.Controls.Add(this.nudInterVal);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.tbLog);
            this.Name = "FrmMain";
            this.Text = "进程守护程序";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudInterVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Timer tmrCheck;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.NumericUpDown nudInterVal;
        private System.Windows.Forms.TextBox tbProc;
        private System.Windows.Forms.Label lblProc;
        private System.Windows.Forms.Label lblInterVal;
        private System.Windows.Forms.Label lblCmd;
        private System.Windows.Forms.TextBox tbCmd;
    }
}


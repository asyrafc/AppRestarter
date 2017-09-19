namespace CSSMonitor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerCheckIfAppIsRunning = new System.Windows.Forms.Timer(this.components);
            this.openFileDialogChooseApp = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonChooseApp = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.buttonStartStopMonitor = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.timerMonitorAppStatus = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerCheckIfAppIsRunning
            // 
            this.timerCheckIfAppIsRunning.Interval = 1;
            // 
            // openFileDialogChooseApp
            // 
            this.openFileDialogChooseApp.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "App Path :";
            // 
            // textBoxPath
            // 
            this.textBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPath.Location = new System.Drawing.Point(89, 18);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(307, 26);
            this.textBoxPath.TabIndex = 1;
            // 
            // buttonChooseApp
            // 
            this.buttonChooseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseApp.Location = new System.Drawing.Point(402, 18);
            this.buttonChooseApp.Name = "buttonChooseApp";
            this.buttonChooseApp.Size = new System.Drawing.Size(75, 27);
            this.buttonChooseApp.TabIndex = 2;
            this.buttonChooseApp.Text = "Choose App";
            this.buttonChooseApp.UseVisualStyleBackColor = true;
            this.buttonChooseApp.Click += new System.EventHandler(this.buttonChooseApp_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(7, 118);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(78, 20);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status :-";
            // 
            // buttonStartStopMonitor
            // 
            this.buttonStartStopMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStartStopMonitor.Location = new System.Drawing.Point(365, 104);
            this.buttonStartStopMonitor.Name = "buttonStartStopMonitor";
            this.buttonStartStopMonitor.Size = new System.Drawing.Size(112, 48);
            this.buttonStartStopMonitor.TabIndex = 4;
            this.buttonStartStopMonitor.Text = "Monitor App";
            this.buttonStartStopMonitor.UseVisualStyleBackColor = true;
            this.buttonStartStopMonitor.Click += new System.EventHandler(this.buttonStartStopMonitor_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(7, 70);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(97, 20);
            this.lblAppName.TabIndex = 5;
            this.lblAppName.Text = "App Name :-";
            // 
            // timerMonitorAppStatus
            // 
            this.timerMonitorAppStatus.Interval = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(489, 164);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.buttonStartStopMonitor);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.buttonChooseApp);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Application Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerCheckIfAppIsRunning;
        private System.Windows.Forms.OpenFileDialog openFileDialogChooseApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonChooseApp;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button buttonStartStopMonitor;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Timer timerMonitorAppStatus;
    }
}


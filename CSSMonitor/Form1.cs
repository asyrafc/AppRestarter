using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSSMonitor
{
    public partial class Form1 : Form
    {
        string sFileName;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerCheckIfAppIsRunning.Tick += Timer1_Tick;
            timerMonitorAppStatus.Tick += Timer2_Tick;
            timerMonitorAppStatus.Enabled = true;
            timerMonitorAppStatus.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            checkIfAppIsRunning(sFileName);
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            monitorAppStatus(sFileName);
        }

        private void buttonChooseApp_Click(object sender, EventArgs e)
        {
            if (openFileDialogChooseApp.ShowDialog() == DialogResult.OK)
            {
                sFileName = openFileDialogChooseApp.FileName;
                textBoxPath.Text = sFileName;
                lblAppName.Text = "App Name : " + sFileName.Substring(sFileName.LastIndexOf(@"\") + 1);
                buttonStartStopMonitor.Text = "Start Monitor";
                buttonStartStopMonitor.BackColor = Color.LimeGreen;
            }
        }

        bool isRunning = false;

        private void buttonStartStopMonitor_Click(object sender, EventArgs e)
        {
            if (isRunning == false)
            {
                timerCheckIfAppIsRunning.Enabled = true;
                timerCheckIfAppIsRunning.Start();      
                isRunning = true;
                buttonStartStopMonitor.Text = "Stop Monitor";
                buttonStartStopMonitor.BackColor = Color.OrangeRed;
            }
            else
            {
                timerCheckIfAppIsRunning.Enabled = false;
                timerCheckIfAppIsRunning.Stop();
                isRunning = false;
                buttonStartStopMonitor.Text = "Start Monitor";
                buttonStartStopMonitor.BackColor = Color.LimeGreen;
            }
        }

        private void checkIfAppIsRunning(string appPath)
        {
            string appName = appPath.Substring(appPath.LastIndexOf(@"\")+1).Replace(".exe","");
            Process[] pname = Process.GetProcessesByName(appName);
            if (pname.Length == 0)
            {
                System.Diagnostics.Process.Start(appPath);
                //lblStatus.Text = "Status : Is Not Running";                
                //Console.WriteLine("App successfully started.");
            }
            else
            {
                //lblStatus.Text = "Status : Is Running";
                //Console.WriteLine("App is running.");
            }
        }

        private void monitorAppStatus(string appPath)
        {
            if (appPath != null)
            {
                buttonStartStopMonitor.Enabled = true;
                string appName = appPath.Substring(appPath.LastIndexOf(@"\") + 1).Replace(".exe", "");
                Process[] pname = Process.GetProcessesByName(appName);
                if (pname.Length == 0)
                {
                    lblStatus.ForeColor = Color.IndianRed;
                    lblStatus.Text = "Status : Is Not Running";
                }
                else
                {
                    lblStatus.ForeColor = Color.DarkGreen;
                    lblStatus.Text = "Status : Is Running";
                }
            }
            else
            {
                lblStatus.Text = "Status : Please load application.";
                buttonStartStopMonitor.Enabled = false;
                buttonStartStopMonitor.Text = "Disabled";
                buttonStartStopMonitor.BackColor = Color.DarkGray;
            }
        }
    }
}

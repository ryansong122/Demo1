using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RCAPINet;

namespace Demo1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private Spel m_spel;

        private void frmMain_Load(object sender, EventArgs e)
        {
         
            
            m_spel = new Spel();
            m_spel.Initialize();

            m_spel.Project = "c:\\EpsonRC70\\Projects\\API_Demos\\demo1\\demo1.sprj";
            m_spel.EventReceived += new Spel.EventReceivedEventHandler(m_spel_EventReceived);

            m_spel.EnableEvent(SpelEvents.AllTasksStopped, true);

            

           m_spel.SetVar("g_EventNumber", 2000);


            cmbFunc.Items.Add("main");
            cmbFunc.Items.Add("main1");
            cmbFunc.Items.Add("main2");

            cmbFunc.SelectedIndex = 0;

            cmbVars.Items.Add("g_CycleCount");
            cmbVars.Items.Add("g_CyclesToRun");
            cmbVars.Items.Add("g_EventNumber");

            cmbVars.SelectedIndex = 0;

            btnPause.Enabled = false;
            btnCont.Enabled = false;
            btnStop.Enabled = false;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_spel.Dispose();
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            try
            {
                m_spel.Continue();
                btnPause.Enabled = true;
                btnCont.Enabled = false;

            }
            catch (SpelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnControllerTools_Click(object sender, EventArgs e)
        {
            try
            {
                m_spel.RunDialog(SpelDialogs.ControllerTools, this);
            }
            catch (SpelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void btnIOMonitor_Click(object sender, EventArgs e)
        {
            try
            {
                m_spel.ShowWindow(SpelWindows.IOMonitor, this);
            }
            catch (SpelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            try
            {
                m_spel.Pause();
                btnPause.Enabled = false;
                btnCont.Enabled = true;

            }
            catch (SpelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProgramMode_Click(object sender, EventArgs e)
        {
            try
            {
                m_spel.OperationMode = SpelOperationMode.Program;
            }
            catch (SpelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                Object v;
                v = m_spel.GetVar(cmbVars.Text);
                txtVarValue.Text = v.ToString();
            }
            catch (SpelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                m_spel.Reset();
            }
            catch (SpelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRobotManager_Click(object sender, EventArgs e)
        {
            try
            {
                m_spel.RunDialog(SpelDialogs.RobotManager, this);
            }
            catch (SpelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSimulator_Click(object sender, EventArgs e)
        {
            try {
                m_spel.ShowWindow(SpelWindows.Simulator, this);
            }
            catch (SpelException ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            try
            {
                m_spel.Start(cmbFunc.SelectedIndex);

                btnStart.Enabled = false;
                btnPause.Enabled = true;
                btnCont.Enabled = false;
                btnStop.Enabled = true;
            }
            catch (SpelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                m_spel.Stop();
                btnStart.Enabled = true;
                btnPause.Enabled = false;
                btnCont.Enabled = false;
                btnStop.Enabled = false;
            }
            catch (SpelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTaskManager_Click(object sender, EventArgs e)
        {
            try
            {
                m_spel.ShowWindow(SpelWindows.TaskManager, this);
            }
            catch (SpelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTeachPoint_Click(object sender, EventArgs e)
        {
            try
            {
                m_spel.TeachPoint("robot1.pts", 1, "Teach Pick Position");
            }
            catch (SpelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {

            try
            {
                m_spel.SetVar(cmbVars.Text, txtVarValue.Text);
            }
            catch (SpelException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     public void m_spel_EventReceived(object sender, SpelEventArgs e)
        {

            if (e.Event == SpelEvents.AllTasksStopped)
            {
                btnStart.Enabled = true;
                btnStop.Enabled = false;
                btnPause.Enabled = false;
                btnCont.Enabled = false;
            }
            textBox1.SelectedText = e.Message + "\r\n";
        }
    }

}

namespace Demo1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRobotManager = new System.Windows.Forms.Button();
            this.btnIOMonitor = new System.Windows.Forms.Button();
            this.btnTaskManager = new System.Windows.Forms.Button();
            this.btnControllerTools = new System.Windows.Forms.Button();
            this.btnProgramMode = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTeachPoint = new System.Windows.Forms.Button();
            this.gBoxGlobals = new System.Windows.Forms.GroupBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtVarValue = new System.Windows.Forms.TextBox();
            this.cmbVars = new System.Windows.Forms.ComboBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblVariableName = new System.Windows.Forms.Label();
            this.gBoxRunTasks = new System.Windows.Forms.GroupBox();
            this.btnCont = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbFunc = new System.Windows.Forms.ComboBox();
            this.lblFuncToStart = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEvents = new System.Windows.Forms.Label();
            this.btnSimulator = new System.Windows.Forms.Button();
            this.gBoxGlobals.SuspendLayout();
            this.gBoxRunTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(315, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 22);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnRobotManager
            // 
            this.btnRobotManager.Location = new System.Drawing.Point(315, 50);
            this.btnRobotManager.Name = "btnRobotManager";
            this.btnRobotManager.Size = new System.Drawing.Size(120, 26);
            this.btnRobotManager.TabIndex = 3;
            this.btnRobotManager.Text = "Robot Manager";
            this.btnRobotManager.UseVisualStyleBackColor = true;
            this.btnRobotManager.Click += new System.EventHandler(this.btnRobotManager_Click);
            // 
            // btnIOMonitor
            // 
            this.btnIOMonitor.Location = new System.Drawing.Point(315, 95);
            this.btnIOMonitor.Name = "btnIOMonitor";
            this.btnIOMonitor.Size = new System.Drawing.Size(120, 26);
            this.btnIOMonitor.TabIndex = 4;
            this.btnIOMonitor.Text = "I/O Monitor";
            this.btnIOMonitor.UseVisualStyleBackColor = true;
            this.btnIOMonitor.Click += new System.EventHandler(this.btnIOMonitor_Click);
            // 
            // btnTaskManager
            // 
            this.btnTaskManager.Location = new System.Drawing.Point(315, 138);
            this.btnTaskManager.Name = "btnTaskManager";
            this.btnTaskManager.Size = new System.Drawing.Size(118, 24);
            this.btnTaskManager.TabIndex = 5;
            this.btnTaskManager.Text = "Task Manager";
            this.btnTaskManager.UseVisualStyleBackColor = true;
            this.btnTaskManager.Click += new System.EventHandler(this.btnTaskManager_Click);
            // 
            // btnControllerTools
            // 
            this.btnControllerTools.Location = new System.Drawing.Point(315, 220);
            this.btnControllerTools.Name = "btnControllerTools";
            this.btnControllerTools.Size = new System.Drawing.Size(118, 24);
            this.btnControllerTools.TabIndex = 7;
            this.btnControllerTools.Text = "Controller Tools";
            this.btnControllerTools.UseVisualStyleBackColor = true;
            this.btnControllerTools.Click += new System.EventHandler(this.btnControllerTools_Click);
            // 
            // btnProgramMode
            // 
            this.btnProgramMode.Location = new System.Drawing.Point(315, 262);
            this.btnProgramMode.Name = "btnProgramMode";
            this.btnProgramMode.Size = new System.Drawing.Size(118, 24);
            this.btnProgramMode.TabIndex = 8;
            this.btnProgramMode.Text = "Program Mode";
            this.btnProgramMode.UseVisualStyleBackColor = true;
            this.btnProgramMode.Click += new System.EventHandler(this.btnProgramMode_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(317, 305);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 24);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTeachPoint
            // 
            this.btnTeachPoint.Location = new System.Drawing.Point(317, 346);
            this.btnTeachPoint.Name = "btnTeachPoint";
            this.btnTeachPoint.Size = new System.Drawing.Size(118, 24);
            this.btnTeachPoint.TabIndex = 10;
            this.btnTeachPoint.Text = "Teach Point";
            this.btnTeachPoint.UseVisualStyleBackColor = true;
            this.btnTeachPoint.Click += new System.EventHandler(this.btnTeachPoint_Click);
            // 
            // gBoxGlobals
            // 
            this.gBoxGlobals.Controls.Add(this.btnWrite);
            this.gBoxGlobals.Controls.Add(this.btnRead);
            this.gBoxGlobals.Controls.Add(this.txtVarValue);
            this.gBoxGlobals.Controls.Add(this.cmbVars);
            this.gBoxGlobals.Controls.Add(this.lblValue);
            this.gBoxGlobals.Controls.Add(this.lblVariableName);
            this.gBoxGlobals.Location = new System.Drawing.Point(12, 16);
            this.gBoxGlobals.Name = "gBoxGlobals";
            this.gBoxGlobals.Size = new System.Drawing.Size(284, 149);
            this.gBoxGlobals.TabIndex = 0;
            this.gBoxGlobals.TabStop = false;
            this.gBoxGlobals.Text = "Read / Write Global Preserve variables";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(175, 107);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(81, 24);
            this.btnWrite.TabIndex = 5;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(24, 107);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(81, 24);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtVarValue
            // 
            this.txtVarValue.Location = new System.Drawing.Point(135, 69);
            this.txtVarValue.Name = "txtVarValue";
            this.txtVarValue.Size = new System.Drawing.Size(121, 20);
            this.txtVarValue.TabIndex = 3;
            // 
            // cmbVars
            // 
            this.cmbVars.FormattingEnabled = true;
            this.cmbVars.Location = new System.Drawing.Point(135, 34);
            this.cmbVars.Name = "cmbVars";
            this.cmbVars.Size = new System.Drawing.Size(121, 21);
            this.cmbVars.TabIndex = 1;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(21, 76);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(37, 13);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value:";
            // 
            // lblVariableName
            // 
            this.lblVariableName.AutoSize = true;
            this.lblVariableName.Location = new System.Drawing.Point(21, 37);
            this.lblVariableName.Name = "lblVariableName";
            this.lblVariableName.Size = new System.Drawing.Size(77, 13);
            this.lblVariableName.TabIndex = 0;
            this.lblVariableName.Text = "Variable name:";
            // 
            // gBoxRunTasks
            // 
            this.gBoxRunTasks.Controls.Add(this.btnCont);
            this.gBoxRunTasks.Controls.Add(this.btnStop);
            this.gBoxRunTasks.Controls.Add(this.btnPause);
            this.gBoxRunTasks.Controls.Add(this.btnStart);
            this.gBoxRunTasks.Controls.Add(this.cmbFunc);
            this.gBoxRunTasks.Controls.Add(this.lblFuncToStart);
            this.gBoxRunTasks.Controls.Add(this.textBox1);
            this.gBoxRunTasks.Controls.Add(this.lblEvents);
            this.gBoxRunTasks.Location = new System.Drawing.Point(12, 183);
            this.gBoxRunTasks.Name = "gBoxRunTasks";
            this.gBoxRunTasks.Size = new System.Drawing.Size(284, 284);
            this.gBoxRunTasks.TabIndex = 1;
            this.gBoxRunTasks.TabStop = false;
            this.gBoxRunTasks.Text = "Run Tasks";
            // 
            // btnCont
            // 
            this.btnCont.Location = new System.Drawing.Point(153, 238);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(103, 27);
            this.btnCont.TabIndex = 7;
            this.btnCont.Text = "Continue";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(22, 238);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(103, 27);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(153, 205);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(103, 27);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(22, 205);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 27);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cmbFunc
            // 
            this.cmbFunc.FormattingEnabled = true;
            this.cmbFunc.Location = new System.Drawing.Point(123, 168);
            this.cmbFunc.Name = "cmbFunc";
            this.cmbFunc.Size = new System.Drawing.Size(133, 21);
            this.cmbFunc.TabIndex = 3;
            // 
            // lblFuncToStart
            // 
            this.lblFuncToStart.AutoSize = true;
            this.lblFuncToStart.Location = new System.Drawing.Point(21, 176);
            this.lblFuncToStart.Name = "lblFuncToStart";
            this.lblFuncToStart.Size = new System.Drawing.Size(86, 13);
            this.lblFuncToStart.TabIndex = 2;
            this.lblFuncToStart.Text = "Function to start:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 112);
            this.textBox1.TabIndex = 1;
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(21, 31);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(40, 13);
            this.lblEvents.TabIndex = 0;
            this.lblEvents.Text = "Events";
            // 
            // btnSimulator
            // 
            this.btnSimulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimulator.Location = new System.Drawing.Point(316, 179);
            this.btnSimulator.Name = "btnSimulator";
            this.btnSimulator.Size = new System.Drawing.Size(116, 24);
            this.btnSimulator.TabIndex = 6;
            this.btnSimulator.Text = "Simulator";
            this.btnSimulator.UseVisualStyleBackColor = true;
            this.btnSimulator.Click += new System.EventHandler(this.btnSimulator_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 479);
            this.Controls.Add(this.btnSimulator);
            this.Controls.Add(this.gBoxRunTasks);
            this.Controls.Add(this.gBoxGlobals);
            this.Controls.Add(this.btnTeachPoint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnProgramMode);
            this.Controls.Add(this.btnControllerTools);
            this.Controls.Add(this.btnTaskManager);
            this.Controls.Add(this.btnIOMonitor);
            this.Controls.Add(this.btnRobotManager);
            this.Controls.Add(this.btnExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPSON RC+ 7.0 C# API Demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gBoxGlobals.ResumeLayout(false);
            this.gBoxGlobals.PerformLayout();
            this.gBoxRunTasks.ResumeLayout(false);
            this.gBoxRunTasks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRobotManager;
        private System.Windows.Forms.Button btnIOMonitor;
        private System.Windows.Forms.Button btnTaskManager;
        private System.Windows.Forms.Button btnControllerTools;
        private System.Windows.Forms.Button btnProgramMode;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTeachPoint;
        private System.Windows.Forms.GroupBox gBoxGlobals;
        private System.Windows.Forms.Label lblVariableName;
        private System.Windows.Forms.ComboBox cmbVars;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtVarValue;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox gBoxRunTasks;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.ComboBox cmbFunc;
        private System.Windows.Forms.Label lblFuncToStart;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        public System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.Button btnSimulator;
    }
}


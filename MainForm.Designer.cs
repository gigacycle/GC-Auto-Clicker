namespace GC_Clicker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label2 = new Label();
            endTimePicker = new DateTimePicker();
            btnStartStop = new Button();
            lblDesc = new Label();
            txtDelay = new TextBox();
            label3 = new Label();
            chStopAtTime = new CheckBox();
            chRandomDelay = new CheckBox();
            chTempPause = new CheckBox();
            label1 = new Label();
            txtPauseAfter = new TextBox();
            label4 = new Label();
            txtResumeAfter = new TextBox();
            gbTimer = new GroupBox();
            gbClick = new GroupBox();
            chCheckBlueStacks = new CheckBox();
            txtY = new TextBox();
            lblY = new Label();
            txtX = new TextBox();
            label9 = new Label();
            label6 = new Label();
            chRandomPosition = new CheckBox();
            lblX = new Label();
            label5 = new Label();
            gbTempPause = new GroupBox();
            txtEnergyLimit = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            txtEanPerTap = new TextBox();
            label7 = new Label();
            pbMain = new ProgressBar();
            gbTimer.SuspendLayout();
            gbClick.SuspendLayout();
            gbTempPause.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 47);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 3;
            label2.Text = "Stop At : ";
            // 
            // endTimePicker
            // 
            endTimePicker.Format = DateTimePickerFormat.Time;
            endTimePicker.Location = new Point(90, 47);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.Size = new Size(116, 23);
            endTimePicker.TabIndex = 2;
            endTimePicker.Value = new DateTime(2024, 6, 2, 23, 59, 0, 0);
            // 
            // btnStartStop
            // 
            btnStartStop.Location = new Point(247, 12);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(70, 242);
            btnStartStop.TabIndex = 4;
            btnStartStop.Text = "Start";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += StartButton_Click;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Dock = DockStyle.Bottom;
            lblDesc.Location = new Point(0, 537);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(260, 15);
            lblDesc.TabIndex = 5;
            lblDesc.Text = "F9 - Start/Stop | All time units are in miliseconds";
            // 
            // txtDelay
            // 
            txtDelay.Location = new Point(124, 48);
            txtDelay.Name = "txtDelay";
            txtDelay.Size = new Size(57, 23);
            txtDelay.TabIndex = 6;
            txtDelay.Text = "500";
            txtDelay.TextChanged += txtDelay_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 51);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Delay :";
            // 
            // chStopAtTime
            // 
            chStopAtTime.AutoSize = true;
            chStopAtTime.Location = new Point(90, 22);
            chStopAtTime.Name = "chStopAtTime";
            chStopAtTime.Size = new Size(90, 19);
            chStopAtTime.TabIndex = 8;
            chStopAtTime.Text = "Stop at time";
            chStopAtTime.UseVisualStyleBackColor = true;
            // 
            // chRandomDelay
            // 
            chRandomDelay.AutoSize = true;
            chRandomDelay.Checked = true;
            chRandomDelay.CheckState = CheckState.Checked;
            chRandomDelay.Location = new Point(18, 22);
            chRandomDelay.Name = "chRandomDelay";
            chRandomDelay.Size = new Size(103, 19);
            chRandomDelay.TabIndex = 9;
            chRandomDelay.Text = "Random Delay";
            chRandomDelay.UseVisualStyleBackColor = true;
            chRandomDelay.CheckedChanged += chRandomDelay_CheckedChanged;
            // 
            // chTempPause
            // 
            chTempPause.AutoSize = true;
            chTempPause.Checked = true;
            chTempPause.CheckState = CheckState.Checked;
            chTempPause.Location = new Point(90, 22);
            chTempPause.Name = "chTempPause";
            chTempPause.Size = new Size(116, 19);
            chTempPause.TabIndex = 12;
            chTempPause.Text = "Temporary Pause";
            chTempPause.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 102);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 11;
            label1.Text = "Pause After : ";
            // 
            // txtPauseAfter
            // 
            txtPauseAfter.Location = new Point(112, 102);
            txtPauseAfter.Name = "txtPauseAfter";
            txtPauseAfter.Size = new Size(95, 23);
            txtPauseAfter.TabIndex = 10;
            txtPauseAfter.Text = "160000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 131);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 14;
            label4.Text = "Resume After : ";
            // 
            // txtResumeAfter
            // 
            txtResumeAfter.Location = new Point(112, 131);
            txtResumeAfter.Name = "txtResumeAfter";
            txtResumeAfter.Size = new Size(95, 23);
            txtResumeAfter.TabIndex = 13;
            txtResumeAfter.Text = "666000";
            // 
            // gbTimer
            // 
            gbTimer.Controls.Add(chStopAtTime);
            gbTimer.Controls.Add(endTimePicker);
            gbTimer.Controls.Add(label2);
            gbTimer.Location = new Point(12, 258);
            gbTimer.Name = "gbTimer";
            gbTimer.Size = new Size(305, 84);
            gbTimer.TabIndex = 15;
            gbTimer.TabStop = false;
            gbTimer.Text = "Timer";
            // 
            // gbClick
            // 
            gbClick.Controls.Add(chCheckBlueStacks);
            gbClick.Controls.Add(txtY);
            gbClick.Controls.Add(lblY);
            gbClick.Controls.Add(txtX);
            gbClick.Controls.Add(label9);
            gbClick.Controls.Add(label6);
            gbClick.Controls.Add(chRandomPosition);
            gbClick.Controls.Add(lblX);
            gbClick.Controls.Add(label5);
            gbClick.Controls.Add(chRandomDelay);
            gbClick.Controls.Add(txtDelay);
            gbClick.Controls.Add(label3);
            gbClick.Location = new Point(12, 12);
            gbClick.Name = "gbClick";
            gbClick.Size = new Size(229, 240);
            gbClick.TabIndex = 16;
            gbClick.TabStop = false;
            gbClick.Text = "Click";
            // 
            // chCheckBlueStacks
            // 
            chCheckBlueStacks.AutoSize = true;
            chCheckBlueStacks.Checked = true;
            chCheckBlueStacks.CheckState = CheckState.Checked;
            chCheckBlueStacks.Location = new Point(18, 203);
            chCheckBlueStacks.Name = "chCheckBlueStacks";
            chCheckBlueStacks.Size = new Size(200, 19);
            chCheckBlueStacks.TabIndex = 25;
            chCheckBlueStacks.Text = "Check for BlueStacks Before Start";
            chCheckBlueStacks.UseVisualStyleBackColor = true;
            // 
            // txtY
            // 
            txtY.Location = new Point(124, 108);
            txtY.Name = "txtY";
            txtY.Size = new Size(57, 23);
            txtY.TabIndex = 24;
            txtY.Text = "500";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(102, 111);
            lblY.Name = "lblY";
            lblY.Size = new Size(17, 15);
            lblY.TabIndex = 23;
            lblY.Text = "Y:";
            // 
            // txtX
            // 
            txtX.Location = new Point(124, 83);
            txtX.Name = "txtX";
            txtX.Size = new Size(57, 23);
            txtX.TabIndex = 22;
            txtX.Text = "1120";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(187, 51);
            label9.Name = "label9";
            label9.Size = new Size(23, 15);
            label9.TabIndex = 21;
            label9.Text = "ms";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(18, 155);
            label6.Name = "label6";
            label6.Size = new Size(188, 36);
            label6.TabIndex = 20;
            label6.Text = "Clicks on random positions around your choosen position";
            // 
            // chRandomPosition
            // 
            chRandomPosition.AutoSize = true;
            chRandomPosition.Checked = true;
            chRandomPosition.CheckState = CheckState.Checked;
            chRandomPosition.Location = new Point(18, 133);
            chRandomPosition.Name = "chRandomPosition";
            chRandomPosition.Size = new Size(117, 19);
            chRandomPosition.TabIndex = 19;
            chRandomPosition.Text = "Random Position";
            chRandomPosition.UseVisualStyleBackColor = true;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(102, 86);
            lblX.Name = "lblX";
            lblX.Size = new Size(17, 15);
            lblX.TabIndex = 11;
            lblX.Text = "X:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 86);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 10;
            label5.Text = "Click Position :";
            // 
            // gbTempPause
            // 
            gbTempPause.Controls.Add(txtEnergyLimit);
            gbTempPause.Controls.Add(label11);
            gbTempPause.Controls.Add(label10);
            gbTempPause.Controls.Add(label8);
            gbTempPause.Controls.Add(txtEanPerTap);
            gbTempPause.Controls.Add(label7);
            gbTempPause.Controls.Add(chTempPause);
            gbTempPause.Controls.Add(txtPauseAfter);
            gbTempPause.Controls.Add(label1);
            gbTempPause.Controls.Add(label4);
            gbTempPause.Controls.Add(txtResumeAfter);
            gbTempPause.Location = new Point(12, 348);
            gbTempPause.Name = "gbTempPause";
            gbTempPause.Size = new Size(305, 168);
            gbTempPause.TabIndex = 17;
            gbTempPause.TabStop = false;
            gbTempPause.Text = "Temporary Pause";
            // 
            // txtEnergyLimit
            // 
            txtEnergyLimit.Location = new Point(112, 73);
            txtEnergyLimit.Name = "txtEnergyLimit";
            txtEnergyLimit.Size = new Size(95, 23);
            txtEnergyLimit.TabIndex = 24;
            txtEnergyLimit.Text = "1500";
            txtEnergyLimit.TextChanged += txtEnergyLimit_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(213, 134);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 23;
            label11.Text = "miliseconds";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(213, 105);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 22;
            label10.Text = "miliseconds";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 73);
            label8.Name = "label8";
            label8.Size = new Size(79, 15);
            label8.TabIndex = 18;
            label8.Text = "Energy Level :";
            // 
            // txtEanPerTap
            // 
            txtEanPerTap.Location = new Point(112, 44);
            txtEanPerTap.Name = "txtEanPerTap";
            txtEanPerTap.Size = new Size(95, 23);
            txtEanPerTap.TabIndex = 15;
            txtEanPerTap.Text = "2";
            txtEanPerTap.TextChanged += txtEanPerTap_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(30, 44);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 16;
            label7.Text = "Earn per tap :";
            // 
            // pbMain
            // 
            pbMain.Location = new Point(12, 522);
            pbMain.Name = "pbMain";
            pbMain.Size = new Size(305, 10);
            pbMain.Style = ProgressBarStyle.Continuous;
            pbMain.TabIndex = 25;
            pbMain.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 552);
            Controls.Add(pbMain);
            Controls.Add(gbTempPause);
            Controls.Add(gbClick);
            Controls.Add(gbTimer);
            Controls.Add(lblDesc);
            Controls.Add(btnStartStop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GC Auto Clicker";
            FormClosing += MainForm_FormClosing;
            gbTimer.ResumeLayout(false);
            gbTimer.PerformLayout();
            gbClick.ResumeLayout(false);
            gbClick.PerformLayout();
            gbTempPause.ResumeLayout(false);
            gbTempPause.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private DateTimePicker endTimePicker;
        private Button btnStartStop;
        private Label lblDesc;
        private TextBox txtDelay;
        private Label label3;
        private CheckBox chStopAtTime;
        private CheckBox chRandomDelay;
        private CheckBox chTempPause;
        private Label label1;
        private TextBox txtPauseAfter;
        private Label label4;
        private TextBox txtResumeAfter;
        private GroupBox gbTimer;
        private GroupBox gbClick;
        private GroupBox gbTempPause;
        private Button button1;
        private Label lblX;
        private Label label5;
        private Label label6;
        private CheckBox chRandomPosition;
        private TextBox txtEanPerTap;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label10;
        private TextBox txtEnergyLimit;
        private TextBox txtX;
        private Label lblY;
        private TextBox txtY;
        private ProgressBar pbMain;
        private CheckBox chCheckBlueStacks;
    }
}

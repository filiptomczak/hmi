namespace hmi
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.serviceController2 = new System.ServiceProcess.ServiceController();
            this.serviceController3 = new System.ServiceProcess.ServiceController();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_fail = new System.Windows.Forms.Button();
            this.button_robot = new System.Windows.Forms.Button();
            this.label_robx = new System.Windows.Forms.Label();
            this.label_robY = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_arm = new System.Windows.Forms.Button();
            this.label_clock = new System.Windows.Forms.Label();
            this.button_log = new System.Windows.Forms.Button();
            this.label_user = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(668, 74);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(538, 12);
            this.trackBar1.Maximum = 120;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(250, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(538, 102);
            this.trackBar2.Maximum = 120;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(250, 56);
            this.trackBar2.TabIndex = 3;
            this.trackBar2.Scroll += new System.EventHandler(this.TrackBar2_Scroll);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(668, 164);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1183, 791);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1183, 812);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 7;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(538, 193);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(538, 164);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(795, 13);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 23);
            this.button_reset.TabIndex = 13;
            this.button_reset.Text = "reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.Button_reset_Click);
            // 
            // button_fail
            // 
            this.button_fail.Location = new System.Drawing.Point(880, 13);
            this.button_fail.Name = "button_fail";
            this.button_fail.Size = new System.Drawing.Size(75, 23);
            this.button_fail.TabIndex = 14;
            this.button_fail.Text = "fail";
            this.button_fail.UseVisualStyleBackColor = true;
            this.button_fail.Click += new System.EventHandler(this.Button_fail_Click);
            // 
            // button_robot
            // 
            this.button_robot.Location = new System.Drawing.Point(1000, 163);
            this.button_robot.Name = "button_robot";
            this.button_robot.Size = new System.Drawing.Size(75, 23);
            this.button_robot.TabIndex = 16;
            this.button_robot.Text = "robot";
            this.button_robot.UseVisualStyleBackColor = true;
            this.button_robot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button_robot_KeyDown);
            // 
            // label_robx
            // 
            this.label_robx.AutoSize = true;
            this.label_robx.Location = new System.Drawing.Point(1080, 166);
            this.label_robx.Name = "label_robx";
            this.label_robx.Size = new System.Drawing.Size(46, 17);
            this.label_robx.TabIndex = 17;
            this.label_robx.Text = "robX: ";
            // 
            // label_robY
            // 
            this.label_robY.AutoSize = true;
            this.label_robY.Location = new System.Drawing.Point(1146, 166);
            this.label_robY.Name = "label_robY";
            this.label_robY.Size = new System.Drawing.Size(46, 17);
            this.label_robY.TabIndex = 18;
            this.label_robY.Text = "robY: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1125, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1189, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 20;
            // 
            // button_arm
            // 
            this.button_arm.Location = new System.Drawing.Point(795, 163);
            this.button_arm.Name = "button_arm";
            this.button_arm.Size = new System.Drawing.Size(75, 23);
            this.button_arm.TabIndex = 21;
            this.button_arm.Text = "arm";
            this.button_arm.UseVisualStyleBackColor = true;
            this.button_arm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button_arm_KeyDown);
            // 
            // label_clock
            // 
            this.label_clock.AutoSize = true;
            this.label_clock.Location = new System.Drawing.Point(12, 9);
            this.label_clock.Name = "label_clock";
            this.label_clock.Size = new System.Drawing.Size(46, 17);
            this.label_clock.TabIndex = 5;
            this.label_clock.Text = "label1";
            // 
            // button_log
            // 
            this.button_log.Location = new System.Drawing.Point(1000, 12);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(75, 27);
            this.button_log.TabIndex = 22;
            this.button_log.Text = "log in";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.Button_log_Click);
            // 
            // label_user
            // 
            this.label_user.BackColor = System.Drawing.Color.Lime;
            this.label_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_user.ForeColor = System.Drawing.Color.Navy;
            this.label_user.Location = new System.Drawing.Point(1081, 13);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(111, 52);
            this.label_user.TabIndex = 23;
            this.label_user.Text = "user";
            this.label_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(1000, 38);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 27);
            this.button_logout.TabIndex = 24;
            this.button_logout.Text = "log out";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.Button_logout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 755);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.button_arm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_robY);
            this.Controls.Add(this.label_robx);
            this.Controls.Add(this.button_robot);
            this.Controls.Add(this.button_fail);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_clock);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.ServiceProcess.ServiceController serviceController2;
        private System.ServiceProcess.ServiceController serviceController3;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_fail;
        private System.Windows.Forms.Button button_robot;
        private System.Windows.Forms.Label label_robx;
        private System.Windows.Forms.Label label_robY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_arm;
        private System.Windows.Forms.Label label_clock;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Button button_logout;
    }
}


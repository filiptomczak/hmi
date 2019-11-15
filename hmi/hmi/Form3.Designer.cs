namespace hmi
{
    partial class Form3
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
            this.label_user = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.label_group = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.listBox_users = new System.Windows.Forms.ListBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_group = new System.Windows.Forms.TextBox();
            this.button_newuser = new System.Windows.Forms.Button();
            this.button_log = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(13, 13);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(36, 17);
            this.label_user.TabIndex = 0;
            this.label_user.Text = "user";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(13, 39);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(68, 17);
            this.label_password.TabIndex = 1;
            this.label_password.Text = "password";
            // 
            // label_group
            // 
            this.label_group.AutoSize = true;
            this.label_group.Location = new System.Drawing.Point(13, 65);
            this.label_group.Name = "label_group";
            this.label_group.Size = new System.Drawing.Size(45, 17);
            this.label_group.TabIndex = 2;
            this.label_group.Text = "group";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 65);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // listBox_users
            // 
            this.listBox_users.FormattingEnabled = true;
            this.listBox_users.ItemHeight = 16;
            this.listBox_users.Location = new System.Drawing.Point(88, 13);
            this.listBox_users.Name = "listBox_users";
            this.listBox_users.ScrollAlwaysVisible = true;
            this.listBox_users.Size = new System.Drawing.Size(120, 20);
            this.listBox_users.TabIndex = 4;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(88, 39);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '#';
            this.textBox_pass.Size = new System.Drawing.Size(120, 22);
            this.textBox_pass.TabIndex = 5;
            // 
            // textBox_group
            // 
            this.textBox_group.Enabled = false;
            this.textBox_group.Location = new System.Drawing.Point(88, 65);
            this.textBox_group.Name = "textBox_group";
            this.textBox_group.Size = new System.Drawing.Size(120, 22);
            this.textBox_group.TabIndex = 6;
            // 
            // button_newuser
            // 
            this.button_newuser.Enabled = false;
            this.button_newuser.Location = new System.Drawing.Point(215, 93);
            this.button_newuser.Name = "button_newuser";
            this.button_newuser.Size = new System.Drawing.Size(75, 23);
            this.button_newuser.TabIndex = 7;
            this.button_newuser.Text = "add user";
            this.button_newuser.UseVisualStyleBackColor = true;
            this.button_newuser.Click += new System.EventHandler(this.Button_newuser_Click);
            // 
            // button_log
            // 
            this.button_log.Location = new System.Drawing.Point(215, 11);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(75, 76);
            this.button_log.TabIndex = 9;
            this.button_log.Text = "log";
            this.button_log.UseVisualStyleBackColor = true;
            this.button_log.Click += new System.EventHandler(this.Button_log_Click);
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(88, 93);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(120, 23);
            this.button_create.TabIndex = 14;
            this.button_create.Text = "create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Visible = false;
            this.button_create.Click += new System.EventHandler(this.Button_create_Click);
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(88, 11);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(120, 22);
            this.textBox_user.TabIndex = 15;
            this.textBox_user.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 128);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.button_newuser);
            this.Controls.Add(this.textBox_group);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.listBox_users);
            this.Controls.Add(this.label_group);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_user);
            this.Name = "Form3";
            this.Text = "Form3";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_group;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ListBox listBox_users;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_group;
        private System.Windows.Forms.Button button_newuser;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.TextBox textBox_user;
    }
}
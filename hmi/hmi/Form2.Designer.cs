namespace hmi
{
    partial class Form2
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
            this.label_min = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.label_d = new System.Windows.Forms.Label();
            this.label_unit = new System.Windows.Forms.Label();
            this.textBox_unit = new System.Windows.Forms.TextBox();
            this.textBox_d = new System.Windows.Forms.TextBox();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.button_apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_com = new System.Windows.Forms.TextBox();
            this.textBox_baud = new System.Windows.Forms.TextBox();
            this.label_skala = new System.Windows.Forms.Label();
            this.textBox_skala = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(13, 13);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(52, 17);
            this.label_min.TabIndex = 0;
            this.label_min.Text = "min val";
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(13, 34);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(55, 17);
            this.label_max.TabIndex = 1;
            this.label_max.Text = "max val";
            // 
            // label_d
            // 
            this.label_d.AutoSize = true;
            this.label_d.Location = new System.Drawing.Point(13, 55);
            this.label_d.Name = "label_d";
            this.label_d.Size = new System.Drawing.Size(63, 17);
            this.label_d.TabIndex = 2;
            this.label_d.Text = "diameter";
            // 
            // label_unit
            // 
            this.label_unit.AutoSize = true;
            this.label_unit.Location = new System.Drawing.Point(13, 96);
            this.label_unit.Name = "label_unit";
            this.label_unit.Size = new System.Drawing.Size(31, 17);
            this.label_unit.TabIndex = 3;
            this.label_unit.Text = "unit";
            // 
            // textBox_unit
            // 
            this.textBox_unit.Location = new System.Drawing.Point(78, 96);
            this.textBox_unit.Name = "textBox_unit";
            this.textBox_unit.Size = new System.Drawing.Size(100, 22);
            this.textBox_unit.TabIndex = 4;
            this.textBox_unit.Text = "%";
            // 
            // textBox_d
            // 
            this.textBox_d.Location = new System.Drawing.Point(78, 55);
            this.textBox_d.Name = "textBox_d";
            this.textBox_d.Size = new System.Drawing.Size(100, 22);
            this.textBox_d.TabIndex = 5;
            this.textBox_d.Text = "200";
            // 
            // textBox_max
            // 
            this.textBox_max.Location = new System.Drawing.Point(78, 34);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(100, 22);
            this.textBox_max.TabIndex = 6;
            this.textBox_max.Text = "100";
            // 
            // textBox_min
            // 
            this.textBox_min.Location = new System.Drawing.Point(78, 13);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(100, 22);
            this.textBox_min.TabIndex = 7;
            this.textBox_min.Text = "0";
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(12, 159);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(165, 27);
            this.button_apply.TabIndex = 8;
            this.button_apply.Text = "apply";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.Button_apply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "baud";
            // 
            // textBox_com
            // 
            this.textBox_com.Location = new System.Drawing.Point(78, 117);
            this.textBox_com.Name = "textBox_com";
            this.textBox_com.Size = new System.Drawing.Size(100, 22);
            this.textBox_com.TabIndex = 11;
            this.textBox_com.Text = "COM5";
            // 
            // textBox_baud
            // 
            this.textBox_baud.Location = new System.Drawing.Point(78, 138);
            this.textBox_baud.Name = "textBox_baud";
            this.textBox_baud.Size = new System.Drawing.Size(100, 22);
            this.textBox_baud.TabIndex = 12;
            this.textBox_baud.Text = "9600";
            // 
            // label_skala
            // 
            this.label_skala.AutoSize = true;
            this.label_skala.Location = new System.Drawing.Point(12, 76);
            this.label_skala.Name = "label_skala";
            this.label_skala.Size = new System.Drawing.Size(41, 17);
            this.label_skala.TabIndex = 13;
            this.label_skala.Text = "skala";
            // 
            // textBox_skala
            // 
            this.textBox_skala.Location = new System.Drawing.Point(78, 76);
            this.textBox_skala.Name = "textBox_skala";
            this.textBox_skala.Size = new System.Drawing.Size(100, 22);
            this.textBox_skala.TabIndex = 14;
            this.textBox_skala.Text = "10";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 253);
            this.Controls.Add(this.textBox_skala);
            this.Controls.Add(this.label_skala);
            this.Controls.Add(this.textBox_baud);
            this.Controls.Add(this.textBox_com);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_apply);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.textBox_d);
            this.Controls.Add(this.textBox_unit);
            this.Controls.Add(this.label_unit);
            this.Controls.Add(this.label_d);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.label_min);
            this.Name = "Form2";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label label_d;
        private System.Windows.Forms.Label label_unit;
        private System.Windows.Forms.TextBox textBox_unit;
        private System.Windows.Forms.TextBox textBox_d;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_com;
        private System.Windows.Forms.TextBox textBox_baud;
        private System.Windows.Forms.Label label_skala;
        private System.Windows.Forms.TextBox textBox_skala;
    }
}
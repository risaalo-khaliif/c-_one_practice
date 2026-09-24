namespace Home_assigment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDayoftheweek = new System.Windows.Forms.TextBox();
            this.txtdayofthemonth = new System.Windows.Forms.TextBox();
            this.txtofthemonth = new System.Windows.Forms.TextBox();
            this.txtYEAR = new System.Windows.Forms.TextBox();
            this.lpoutput = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter day of the week:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter name of the month :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the numeric of the month :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter the year :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtDayoftheweek
            // 
            this.txtDayoftheweek.Location = new System.Drawing.Point(340, 70);
            this.txtDayoftheweek.Multiline = true;
            this.txtDayoftheweek.Name = "txtDayoftheweek";
            this.txtDayoftheweek.Size = new System.Drawing.Size(200, 22);
            this.txtDayoftheweek.TabIndex = 4;
            this.txtDayoftheweek.Text = "sabti";
            this.txtDayoftheweek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtdayofthemonth
            // 
            this.txtdayofthemonth.Location = new System.Drawing.Point(340, 104);
            this.txtdayofthemonth.Name = "txtdayofthemonth";
            this.txtdayofthemonth.Size = new System.Drawing.Size(200, 22);
            this.txtdayofthemonth.TabIndex = 5;
            this.txtdayofthemonth.Text = "jun";
            this.txtdayofthemonth.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtofthemonth
            // 
            this.txtofthemonth.Location = new System.Drawing.Point(340, 148);
            this.txtofthemonth.Name = "txtofthemonth";
            this.txtofthemonth.Size = new System.Drawing.Size(200, 22);
            this.txtofthemonth.TabIndex = 6;
            this.txtofthemonth.Text = "23";
            // 
            // txtYEAR
            // 
            this.txtYEAR.Location = new System.Drawing.Point(340, 185);
            this.txtYEAR.Name = "txtYEAR";
            this.txtYEAR.Size = new System.Drawing.Size(200, 22);
            this.txtYEAR.TabIndex = 7;
            this.txtYEAR.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lpoutput
            // 
            this.lpoutput.Location = new System.Drawing.Point(59, 258);
            this.lpoutput.Name = "lpoutput";
            this.lpoutput.Size = new System.Drawing.Size(570, 45);
            this.lpoutput.TabIndex = 8;
            this.lpoutput.UseVisualStyleBackColor = true;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(78, 318);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(133, 58);
            this.btnshow.TabIndex = 9;
            this.btnshow.Text = "Show Done";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(253, 318);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(133, 58);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(433, 318);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(133, 58);
            this.btnclose.TabIndex = 11;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 489);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.lpoutput);
            this.Controls.Add(this.txtYEAR);
            this.Controls.Add(this.txtofthemonth);
            this.Controls.Add(this.txtdayofthemonth);
            this.Controls.Add(this.txtDayoftheweek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDayoftheweek;
        private System.Windows.Forms.TextBox txtdayofthemonth;
        private System.Windows.Forms.TextBox txtofthemonth;
        private System.Windows.Forms.TextBox txtYEAR;
        private System.Windows.Forms.Button lpoutput;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
    }
}


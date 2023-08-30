namespace sqlsoruUygulamasi
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblsoru = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldogru = new System.Windows.Forms.Label();
            this.lblyanlis = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblsure = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.richTextBox1.Font = new System.Drawing.Font("Oswald", 13.8F);
            this.richTextBox1.Location = new System.Drawing.Point(188, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(510, 218);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Oswald", 13.8F);
            this.button1.Location = new System.Drawing.Point(188, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 62);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Oswald", 13.8F);
            this.button2.Location = new System.Drawing.Point(478, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 62);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Oswald", 13.8F);
            this.button3.Location = new System.Drawing.Point(188, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 62);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.Font = new System.Drawing.Font("Oswald", 13.8F);
            this.button4.Location = new System.Drawing.Point(478, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 62);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.Location = new System.Drawing.Point(83, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru:";
            // 
            // lblsoru
            // 
            this.lblsoru.AutoSize = true;
            this.lblsoru.Font = new System.Drawing.Font("Arial", 12F);
            this.lblsoru.Location = new System.Drawing.Point(146, 60);
            this.lblsoru.Name = "lblsoru";
            this.lblsoru.Size = new System.Drawing.Size(21, 23);
            this.lblsoru.TabIndex = 6;
            this.lblsoru.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(209, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Puan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(30, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doğru";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(116, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yanlış";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblpuan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblyanlis);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbldogru);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.Crimson;
            this.groupBox1.Location = new System.Drawing.Point(765, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 164);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puan Durumu";
            // 
            // lbldogru
            // 
            this.lbldogru.AutoSize = true;
            this.lbldogru.Font = new System.Drawing.Font("Arial", 12F);
            this.lbldogru.ForeColor = System.Drawing.SystemColors.Control;
            this.lbldogru.Location = new System.Drawing.Point(53, 97);
            this.lbldogru.Name = "lbldogru";
            this.lbldogru.Size = new System.Drawing.Size(21, 23);
            this.lbldogru.TabIndex = 10;
            this.lbldogru.Text = "0";
            // 
            // lblyanlis
            // 
            this.lblyanlis.AutoSize = true;
            this.lblyanlis.Font = new System.Drawing.Font("Arial", 12F);
            this.lblyanlis.ForeColor = System.Drawing.SystemColors.Control;
            this.lblyanlis.Location = new System.Drawing.Point(140, 97);
            this.lblyanlis.Name = "lblyanlis";
            this.lblyanlis.Size = new System.Drawing.Size(21, 23);
            this.lblyanlis.TabIndex = 11;
            this.lblyanlis.Text = "0";
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Font = new System.Drawing.Font("Arial", 12F);
            this.lblpuan.ForeColor = System.Drawing.SystemColors.Control;
            this.lblpuan.Location = new System.Drawing.Point(226, 97);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(21, 23);
            this.lblpuan.TabIndex = 12;
            this.lblpuan.Text = "0";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LemonChiffon;
            this.button5.Font = new System.Drawing.Font("Oswald", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(853, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 62);
            this.button5.TabIndex = 11;
            this.button5.Text = "BAŞLA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F);
            this.label9.Location = new System.Drawing.Point(82, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Süre:";
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Font = new System.Drawing.Font("Arial", 12F);
            this.lblsure.Location = new System.Drawing.Point(146, 153);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(32, 23);
            this.lblsure.TabIndex = 13;
            this.lblsure.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.Location = new System.Drawing.Point(702, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "doğru cevap:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F);
            this.label6.Location = new System.Drawing.Point(905, 478);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.Font = new System.Drawing.Font("Oswald", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(853, 196);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 62);
            this.button6.TabIndex = 16;
            this.button6.Text = "BİTİR";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1074, 543);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblsoru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblsoru;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label lblyanlis;
        private System.Windows.Forms.Label lbldogru;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button6;
    }
}


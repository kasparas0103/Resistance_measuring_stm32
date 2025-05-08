namespace WindowsFormsApp1
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
            this.labelADC1 = new System.Windows.Forms.Label();
            this.labelADC2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Send = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Ref1 = new System.Windows.Forms.TextBox();
            this.Rref2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelADC1
            // 
            this.labelADC1.AutoSize = true;
            this.labelADC1.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelADC1.Location = new System.Drawing.Point(165, 463);
            this.labelADC1.Name = "labelADC1";
            this.labelADC1.Size = new System.Drawing.Size(72, 46);
            this.labelADC1.TabIndex = 0;
            this.labelADC1.Text = "R1";
            this.labelADC1.Click += new System.EventHandler(this.labelADC1_Click);
            // 
            // labelADC2
            // 
            this.labelADC2.AutoSize = true;
            this.labelADC2.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Bold);
            this.labelADC2.Location = new System.Drawing.Point(714, 463);
            this.labelADC2.Name = "labelADC2";
            this.labelADC2.Size = new System.Drawing.Size(72, 46);
            this.labelADC2.TabIndex = 1;
            this.labelADC2.Text = "R2";
            this.labelADC2.Click += new System.EventHandler(this.labelADC2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(475, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 99);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prisijungti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Disconnect.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Bold);
            this.Disconnect.Location = new System.Drawing.Point(823, 86);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(280, 99);
            this.Disconnect.TabIndex = 3;
            this.Disconnect.Text = "Atsijungti";
            this.Disconnect.UseVisualStyleBackColor = false;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 40;
            this.comboBox1.Location = new System.Drawing.Point(174, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 48);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "COM";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Send.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Bold);
            this.Send.ForeColor = System.Drawing.Color.Black;
            this.Send.Location = new System.Drawing.Point(823, 303);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(224, 74);
            this.Send.TabIndex = 5;
            this.Send.Text = "Siųsti";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ref1
            // 
            this.Ref1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Ref1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Ref1.Location = new System.Drawing.Point(173, 322);
            this.Ref1.Name = "Ref1";
            this.Ref1.Size = new System.Drawing.Size(246, 44);
            this.Ref1.TabIndex = 6;
            this.Ref1.Text = "950";
            this.Ref1.TextChanged += new System.EventHandler(this.Ref1_TextChanged);
            // 
            // Rref2
            // 
            this.Rref2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Rref2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Rref2.Location = new System.Drawing.Point(509, 322);
            this.Rref2.Name = "Rref2";
            this.Rref2.Size = new System.Drawing.Size(246, 44);
            this.Rref2.TabIndex = 7;
            this.Rref2.Text = "8.5";
            this.Rref2.TextChanged += new System.EventHandler(this.Rref2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(166, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 46);
            this.label2.TabIndex = 9;
            this.label2.Text = "Rref1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(503, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rref2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(165, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 46);
            this.label4.TabIndex = 11;
            this.label4.Text = "100 Ω - 10000 Ω:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.1F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(714, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 46);
            this.label5.TabIndex = 12;
            this.label5.Text = "0.1 Ω - 100 Ω:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 630);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Rref2);
            this.Controls.Add(this.Ref1);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelADC2);
            this.Controls.Add(this.labelADC1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelADC1;
        private System.Windows.Forms.Label labelADC2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Send;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox Ref1;
        private System.Windows.Forms.TextBox Rref2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}


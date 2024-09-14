namespace WindowsFormsApp
{
    partial class MaskedTextBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaskedTextBoxForm));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox6 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox7 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox8 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox9 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox10 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox11 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox12 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox5 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox13 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox14 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox15 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox16 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox17 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox18 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BeepOnError = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(26, 42);
            this.maskedTextBox1.Mask = "(999)000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BeepOnError = true;
            this.maskedTextBox2.Location = new System.Drawing.Point(26, 86);
            this.maskedTextBox2.Mask = "000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBox2.TabIndex = 1;
            // 
            // maskedTextBox6
            // 
            this.maskedTextBox6.BeepOnError = true;
            this.maskedTextBox6.Location = new System.Drawing.Point(26, 174);
            this.maskedTextBox6.Mask = "00 /00 /0000 00:00";
            this.maskedTextBox6.Name = "maskedTextBox6";
            this.maskedTextBox6.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBox6.TabIndex = 5;
            this.maskedTextBox6.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox6.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox6_MaskInputRejected);
            // 
            // maskedTextBox7
            // 
            this.maskedTextBox7.BeepOnError = true;
            this.maskedTextBox7.Location = new System.Drawing.Point(26, 218);
            this.maskedTextBox7.Mask = "000-00-0000";
            this.maskedTextBox7.Name = "maskedTextBox7";
            this.maskedTextBox7.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBox7.TabIndex = 6;
            this.maskedTextBox7.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox7_MaskInputRejected);
            // 
            // maskedTextBox8
            // 
            this.maskedTextBox8.BeepOnError = true;
            this.maskedTextBox8.Location = new System.Drawing.Point(26, 262);
            this.maskedTextBox8.Mask = "90:00";
            this.maskedTextBox8.Name = "maskedTextBox8";
            this.maskedTextBox8.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBox8.TabIndex = 7;
            this.maskedTextBox8.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox8.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox8_MaskInputRejected);
            // 
            // maskedTextBox9
            // 
            this.maskedTextBox9.BeepOnError = true;
            this.maskedTextBox9.Location = new System.Drawing.Point(26, 306);
            this.maskedTextBox9.Mask = "00:00";
            this.maskedTextBox9.Name = "maskedTextBox9";
            this.maskedTextBox9.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBox9.TabIndex = 8;
            this.maskedTextBox9.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox9.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox9_MaskInputRejected);
            // 
            // maskedTextBox10
            // 
            this.maskedTextBox10.BeepOnError = true;
            this.maskedTextBox10.Location = new System.Drawing.Point(26, 350);
            this.maskedTextBox10.Mask = "0000:0000:0000:0000";
            this.maskedTextBox10.Name = "maskedTextBox10";
            this.maskedTextBox10.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBox10.TabIndex = 9;
            this.maskedTextBox10.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox10_MaskInputRejected);
            // 
            // maskedTextBox11
            // 
            this.maskedTextBox11.BeepOnError = true;
            this.maskedTextBox11.Location = new System.Drawing.Point(26, 394);
            this.maskedTextBox11.Mask = "999/999/999/999";
            this.maskedTextBox11.Name = "maskedTextBox11";
            this.maskedTextBox11.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBox11.TabIndex = 10;
            this.maskedTextBox11.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox11_MaskInputRejected);
            // 
            // maskedTextBox12
            // 
            this.maskedTextBox12.BeepOnError = true;
            this.maskedTextBox12.Location = new System.Drawing.Point(26, 130);
            this.maskedTextBox12.Mask = "00 /00 /0000";
            this.maskedTextBox12.Name = "maskedTextBox12";
            this.maskedTextBox12.Size = new System.Drawing.Size(132, 20);
            this.maskedTextBox12.TabIndex = 11;
            this.maskedTextBox12.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BeepOnError = true;
            this.maskedTextBox3.Location = new System.Drawing.Point(215, 130);
            this.maskedTextBox3.Mask = "????????????";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox3.TabIndex = 20;
            // 
            // maskedTextBox4
            // 
            this.maskedTextBox4.BeepOnError = true;
            this.maskedTextBox4.Location = new System.Drawing.Point(215, 394);
            this.maskedTextBox4.Mask = "AA/AA/AAAA aa:aa";
            this.maskedTextBox4.Name = "maskedTextBox4";
            this.maskedTextBox4.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox4.TabIndex = 19;
            this.maskedTextBox4.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox5
            // 
            this.maskedTextBox5.BeepOnError = true;
            this.maskedTextBox5.Location = new System.Drawing.Point(215, 350);
            this.maskedTextBox5.Mask = "0000,0000,0000.0000";
            this.maskedTextBox5.Name = "maskedTextBox5";
            this.maskedTextBox5.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox5.TabIndex = 18;
            // 
            // maskedTextBox13
            // 
            this.maskedTextBox13.BeepOnError = true;
            this.maskedTextBox13.Location = new System.Drawing.Point(215, 306);
            this.maskedTextBox13.Mask = "000,000.00";
            this.maskedTextBox13.Name = "maskedTextBox13";
            this.maskedTextBox13.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox13.TabIndex = 17;
            // 
            // maskedTextBox14
            // 
            this.maskedTextBox14.BeepOnError = true;
            this.maskedTextBox14.Location = new System.Drawing.Point(215, 262);
            this.maskedTextBox14.Mask = "999>>99";
            this.maskedTextBox14.Name = "maskedTextBox14";
            this.maskedTextBox14.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox14.TabIndex = 16;
            // 
            // maskedTextBox15
            // 
            this.maskedTextBox15.BeepOnError = true;
            this.maskedTextBox15.Location = new System.Drawing.Point(215, 218);
            this.maskedTextBox15.Mask = "aaa|aaa|aaa";
            this.maskedTextBox15.Name = "maskedTextBox15";
            this.maskedTextBox15.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox15.TabIndex = 15;
            // 
            // maskedTextBox16
            // 
            this.maskedTextBox16.BeepOnError = true;
            this.maskedTextBox16.Location = new System.Drawing.Point(215, 174);
            this.maskedTextBox16.Mask = "$$$$$";
            this.maskedTextBox16.Name = "maskedTextBox16";
            this.maskedTextBox16.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox16.TabIndex = 14;
            // 
            // maskedTextBox17
            // 
            this.maskedTextBox17.BeepOnError = true;
            this.maskedTextBox17.Location = new System.Drawing.Point(215, 86);
            this.maskedTextBox17.Mask = "LLL:LLL:LLL";
            this.maskedTextBox17.Name = "maskedTextBox17";
            this.maskedTextBox17.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox17.TabIndex = 13;
            // 
            // maskedTextBox18
            // 
            this.maskedTextBox18.BeepOnError = true;
            this.maskedTextBox18.Location = new System.Drawing.Point(215, 42);
            this.maskedTextBox18.Mask = "####:####";
            this.maskedTextBox18.Name = "maskedTextBox18";
            this.maskedTextBox18.Size = new System.Drawing.Size(133, 20);
            this.maskedTextBox18.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 448);
            this.label1.TabIndex = 21;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MaskedTextBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maskedTextBox3);
            this.Controls.Add(this.maskedTextBox4);
            this.Controls.Add(this.maskedTextBox5);
            this.Controls.Add(this.maskedTextBox13);
            this.Controls.Add(this.maskedTextBox14);
            this.Controls.Add(this.maskedTextBox15);
            this.Controls.Add(this.maskedTextBox16);
            this.Controls.Add(this.maskedTextBox17);
            this.Controls.Add(this.maskedTextBox18);
            this.Controls.Add(this.maskedTextBox12);
            this.Controls.Add(this.maskedTextBox11);
            this.Controls.Add(this.maskedTextBox10);
            this.Controls.Add(this.maskedTextBox9);
            this.Controls.Add(this.maskedTextBox8);
            this.Controls.Add(this.maskedTextBox7);
            this.Controls.Add(this.maskedTextBox6);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.HelpButton = true;
            this.Name = "MaskedTextBoxForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MaskedTextBoxForm";
            this.Load += new System.EventHandler(this.MaskedTextBoxForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox7;
        private System.Windows.Forms.MaskedTextBox maskedTextBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox9;
        private System.Windows.Forms.MaskedTextBox maskedTextBox10;
        private System.Windows.Forms.MaskedTextBox maskedTextBox11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox13;
        private System.Windows.Forms.MaskedTextBox maskedTextBox14;
        private System.Windows.Forms.MaskedTextBox maskedTextBox15;
        private System.Windows.Forms.MaskedTextBox maskedTextBox16;
        private System.Windows.Forms.MaskedTextBox maskedTextBox17;
        private System.Windows.Forms.MaskedTextBox maskedTextBox18;
        private System.Windows.Forms.Label label1;
    }
}
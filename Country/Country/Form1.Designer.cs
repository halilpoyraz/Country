namespace Country
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.textBoxUKod = new System.Windows.Forms.TextBox();
            this.textBoxPBirim = new System.Windows.Forms.TextBox();
            this.textBoxPKod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ülkeleri Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormatString = "ListBox1";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 329);
            this.listBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ülke Bilgileri Getir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(288, 122);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(63, 13);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "Ülke Kodu :";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(288, 149);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 13);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Para Birimi :";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(288, 176);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(90, 13);
            this.Label3.TabIndex = 5;
            this.Label3.Text = "Para Birimi Kodu :";
            // 
            // textBoxUKod
            // 
            this.textBoxUKod.Location = new System.Drawing.Point(382, 119);
            this.textBoxUKod.Name = "textBoxUKod";
            this.textBoxUKod.Size = new System.Drawing.Size(157, 20);
            this.textBoxUKod.TabIndex = 6;
            // 
            // textBoxPBirim
            // 
            this.textBoxPBirim.Location = new System.Drawing.Point(382, 146);
            this.textBoxPBirim.Name = "textBoxPBirim";
            this.textBoxPBirim.Size = new System.Drawing.Size(157, 20);
            this.textBoxPBirim.TabIndex = 7;
            // 
            // textBoxPKod
            // 
            this.textBoxPKod.Location = new System.Drawing.Point(382, 173);
            this.textBoxPKod.Name = "textBoxPKod";
            this.textBoxPKod.Size = new System.Drawing.Size(157, 20);
            this.textBoxPKod.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 398);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPKod);
            this.Controls.Add(this.textBoxPBirim);
            this.Controls.Add(this.textBoxUKod);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.TextBox textBoxUKod;
        private System.Windows.Forms.TextBox textBoxPBirim;
        private System.Windows.Forms.TextBox textBoxPKod;
        private System.Windows.Forms.Label label4;
    }
}


namespace GenerateID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1_CPU = new System.Windows.Forms.Label();
            this.textBox1_CPU = new System.Windows.Forms.TextBox();
            this.textBox2_Drive = new System.Windows.Forms.TextBox();
            this.label2_Drive = new System.Windows.Forms.Label();
            this.textBox3_MAC = new System.Windows.Forms.TextBox();
            this.label3_MAC = new System.Windows.Forms.Label();
            this.button1_CPU = new System.Windows.Forms.Button();
            this.button2_DriveSerial = new System.Windows.Forms.Button();
            this.button3_MAC = new System.Windows.Forms.Button();
            this.label4_Combine1 = new System.Windows.Forms.Label();
            this.textBox4_Combined1 = new System.Windows.Forms.TextBox();
            this.button4_Combined1 = new System.Windows.Forms.Button();
            this.textBox5_hashComb1 = new System.Windows.Forms.TextBox();
            this.label5_Hash1 = new System.Windows.Forms.Label();
            this.button5_hashCombined1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_CPU
            // 
            this.label1_CPU.AutoSize = true;
            this.label1_CPU.Location = new System.Drawing.Point(12, 12);
            this.label1_CPU.Name = "label1_CPU";
            this.label1_CPU.Size = new System.Drawing.Size(66, 13);
            this.label1_CPU.TabIndex = 0;
            this.label1_CPU.Text = "Get CPU ID:";
            // 
            // textBox1_CPU
            // 
            this.textBox1_CPU.Location = new System.Drawing.Point(85, 9);
            this.textBox1_CPU.Name = "textBox1_CPU";
            this.textBox1_CPU.Size = new System.Drawing.Size(379, 20);
            this.textBox1_CPU.TabIndex = 1;
            // 
            // textBox2_Drive
            // 
            this.textBox2_Drive.Location = new System.Drawing.Point(149, 35);
            this.textBox2_Drive.Name = "textBox2_Drive";
            this.textBox2_Drive.Size = new System.Drawing.Size(315, 20);
            this.textBox2_Drive.TabIndex = 3;
            // 
            // label2_Drive
            // 
            this.label2_Drive.AutoSize = true;
            this.label2_Drive.Location = new System.Drawing.Point(12, 38);
            this.label2_Drive.Name = "label2_Drive";
            this.label2_Drive.Size = new System.Drawing.Size(84, 13);
            this.label2_Drive.TabIndex = 2;
            this.label2_Drive.Text = "Get Drive Serial:";
            // 
            // textBox3_MAC
            // 
            this.textBox3_MAC.Location = new System.Drawing.Point(149, 61);
            this.textBox3_MAC.Name = "textBox3_MAC";
            this.textBox3_MAC.Size = new System.Drawing.Size(315, 20);
            this.textBox3_MAC.TabIndex = 5;
            // 
            // label3_MAC
            // 
            this.label3_MAC.AutoSize = true;
            this.label3_MAC.Location = new System.Drawing.Point(12, 64);
            this.label3_MAC.Name = "label3_MAC";
            this.label3_MAC.Size = new System.Drawing.Size(115, 13);
            this.label3_MAC.TabIndex = 4;
            this.label3_MAC.Text = "Get First Adapter MAC:";
            // 
            // button1_CPU
            // 
            this.button1_CPU.Location = new System.Drawing.Point(13, 100);
            this.button1_CPU.Name = "button1_CPU";
            this.button1_CPU.Size = new System.Drawing.Size(75, 23);
            this.button1_CPU.TabIndex = 6;
            this.button1_CPU.Text = "Get CPU";
            this.button1_CPU.UseVisualStyleBackColor = true;
            this.button1_CPU.Click += new System.EventHandler(this.button1_CPU_Click);
            // 
            // button2_DriveSerial
            // 
            this.button2_DriveSerial.Location = new System.Drawing.Point(94, 100);
            this.button2_DriveSerial.Name = "button2_DriveSerial";
            this.button2_DriveSerial.Size = new System.Drawing.Size(113, 23);
            this.button2_DriveSerial.TabIndex = 7;
            this.button2_DriveSerial.Text = "Get Drive Serial";
            this.button2_DriveSerial.UseVisualStyleBackColor = true;
            this.button2_DriveSerial.Click += new System.EventHandler(this.button2_DriveSerial_Click);
            // 
            // button3_MAC
            // 
            this.button3_MAC.Location = new System.Drawing.Point(213, 100);
            this.button3_MAC.Name = "button3_MAC";
            this.button3_MAC.Size = new System.Drawing.Size(106, 23);
            this.button3_MAC.TabIndex = 8;
            this.button3_MAC.Text = "Get MAC Serial";
            this.button3_MAC.UseVisualStyleBackColor = true;
            this.button3_MAC.Click += new System.EventHandler(this.button3_MAC_Click);
            // 
            // label4_Combine1
            // 
            this.label4_Combine1.AutoSize = true;
            this.label4_Combine1.Location = new System.Drawing.Point(15, 156);
            this.label4_Combine1.Name = "label4_Combine1";
            this.label4_Combine1.Size = new System.Drawing.Size(139, 13);
            this.label4_Combine1.TabIndex = 9;
            this.label4_Combine1.Text = "Combine CPU ID and Drive:";
            // 
            // textBox4_Combined1
            // 
            this.textBox4_Combined1.Location = new System.Drawing.Point(160, 153);
            this.textBox4_Combined1.Name = "textBox4_Combined1";
            this.textBox4_Combined1.Size = new System.Drawing.Size(304, 20);
            this.textBox4_Combined1.TabIndex = 10;
            // 
            // button4_Combined1
            // 
            this.button4_Combined1.Location = new System.Drawing.Point(18, 226);
            this.button4_Combined1.Name = "button4_Combined1";
            this.button4_Combined1.Size = new System.Drawing.Size(75, 23);
            this.button4_Combined1.TabIndex = 11;
            this.button4_Combined1.Text = "CPU + Drive";
            this.button4_Combined1.UseVisualStyleBackColor = true;
            this.button4_Combined1.Click += new System.EventHandler(this.button4_Combined1_Click);
            // 
            // textBox5_hashComb1
            // 
            this.textBox5_hashComb1.Location = new System.Drawing.Point(194, 192);
            this.textBox5_hashComb1.Name = "textBox5_hashComb1";
            this.textBox5_hashComb1.Size = new System.Drawing.Size(270, 20);
            this.textBox5_hashComb1.TabIndex = 13;
            // 
            // label5_Hash1
            // 
            this.label5_Hash1.AutoSize = true;
            this.label5_Hash1.Location = new System.Drawing.Point(15, 195);
            this.label5_Hash1.Name = "label5_Hash1";
            this.label5_Hash1.Size = new System.Drawing.Size(173, 13);
            this.label5_Hash1.TabIndex = 12;
            this.label5_Hash1.Text = "Hash Combined CPU ID and Drive:";
            // 
            // button5_hashCombined1
            // 
            this.button5_hashCombined1.Location = new System.Drawing.Point(99, 226);
            this.button5_hashCombined1.Name = "button5_hashCombined1";
            this.button5_hashCombined1.Size = new System.Drawing.Size(157, 23);
            this.button5_hashCombined1.TabIndex = 14;
            this.button5_hashCombined1.Text = "Hash SHA 1 CPU and Drive";
            this.button5_hashCombined1.UseVisualStyleBackColor = true;
            this.button5_hashCombined1.Click += new System.EventHandler(this.button5_hashCombined1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.button5_hashCombined1);
            this.Controls.Add(this.textBox5_hashComb1);
            this.Controls.Add(this.label5_Hash1);
            this.Controls.Add(this.button4_Combined1);
            this.Controls.Add(this.textBox4_Combined1);
            this.Controls.Add(this.label4_Combine1);
            this.Controls.Add(this.button3_MAC);
            this.Controls.Add(this.button2_DriveSerial);
            this.Controls.Add(this.button1_CPU);
            this.Controls.Add(this.textBox3_MAC);
            this.Controls.Add(this.label3_MAC);
            this.Controls.Add(this.textBox2_Drive);
            this.Controls.Add(this.label2_Drive);
            this.Controls.Add(this.textBox1_CPU);
            this.Controls.Add(this.label1_CPU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Get ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_CPU;
        private System.Windows.Forms.TextBox textBox1_CPU;
        private System.Windows.Forms.TextBox textBox2_Drive;
        private System.Windows.Forms.Label label2_Drive;
        private System.Windows.Forms.TextBox textBox3_MAC;
        private System.Windows.Forms.Label label3_MAC;
        private System.Windows.Forms.Button button1_CPU;
        private System.Windows.Forms.Button button2_DriveSerial;
        private System.Windows.Forms.Button button3_MAC;
        private System.Windows.Forms.Label label4_Combine1;
        private System.Windows.Forms.TextBox textBox4_Combined1;
        private System.Windows.Forms.Button button4_Combined1;
        private System.Windows.Forms.TextBox textBox5_hashComb1;
        private System.Windows.Forms.Label label5_Hash1;
        private System.Windows.Forms.Button button5_hashCombined1;
    }
}


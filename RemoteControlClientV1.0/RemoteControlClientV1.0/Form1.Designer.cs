
namespace RemoteControlClientV1._0
{
    partial class RCC
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RCC));
            this.btc_connect = new System.Windows.Forms.Button();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_test2 = new System.Windows.Forms.Button();
            this.btn_calesc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.tb_z = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_controllerconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btc_connect
            // 
            this.btc_connect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btc_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btc_connect.ForeColor = System.Drawing.Color.DarkBlue;
            this.btc_connect.Location = new System.Drawing.Point(29, 43);
            this.btc_connect.Name = "btc_connect";
            this.btc_connect.Size = new System.Drawing.Size(205, 80);
            this.btc_connect.TabIndex = 0;
            this.btc_connect.Text = "Connect to server";
            this.btc_connect.UseVisualStyleBackColor = false;
            this.btc_connect.Click += new System.EventHandler(this.btc_connect_Click);
            // 
            // tb_ip
            // 
            this.tb_ip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tb_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ip.Location = new System.Drawing.Point(285, 49);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(118, 26);
            this.tb_ip.TabIndex = 1;
            this.tb_ip.Text = "192.168.1.161";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(240, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
            // tb_port
            // 
            this.tb_port.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tb_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_port.Location = new System.Drawing.Point(285, 81);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(118, 26);
            this.tb_port.TabIndex = 3;
            this.tb_port.Text = "65432";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(240, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // btn_test
            // 
            this.btn_test.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_test.Enabled = false;
            this.btn_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_test.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_test.Location = new System.Drawing.Point(29, 162);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(101, 43);
            this.btn_test.TabIndex = 11;
            this.btn_test.Text = "Light on";
            this.btn_test.UseVisualStyleBackColor = false;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_test2
            // 
            this.btn_test2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_test2.Enabled = false;
            this.btn_test2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_test2.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_test2.Location = new System.Drawing.Point(136, 162);
            this.btn_test2.Name = "btn_test2";
            this.btn_test2.Size = new System.Drawing.Size(98, 43);
            this.btn_test2.TabIndex = 12;
            this.btn_test2.Text = "Light off";
            this.btn_test2.UseVisualStyleBackColor = false;
            this.btn_test2.Click += new System.EventHandler(this.btn_test2_Click);
            // 
            // btn_calesc
            // 
            this.btn_calesc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_calesc.Enabled = false;
            this.btn_calesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calesc.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_calesc.Location = new System.Drawing.Point(29, 211);
            this.btn_calesc.Name = "btn_calesc";
            this.btn_calesc.Size = new System.Drawing.Size(205, 26);
            this.btn_calesc.TabIndex = 13;
            this.btn_calesc.Text = "Calibrate ESC";
            this.btn_calesc.UseVisualStyleBackColor = false;
            this.btn_calesc.Click += new System.EventHandler(this.btn_calesc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(29, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "TCP Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(29, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "RC remote";
            // 
            // tb_output
            // 
            this.tb_output.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tb_output.Location = new System.Drawing.Point(244, 162);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ReadOnly = true;
            this.tb_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_output.Size = new System.Drawing.Size(159, 75);
            this.tb_output.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(244, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "(Server):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(187, 274);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Gamepad:";
            // 
            // tb_x
            // 
            this.tb_x.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tb_x.Enabled = false;
            this.tb_x.Location = new System.Drawing.Point(274, 276);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(39, 20);
            this.tb_x.TabIndex = 20;
            // 
            // tb_y
            // 
            this.tb_y.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tb_y.Enabled = false;
            this.tb_y.Location = new System.Drawing.Point(319, 276);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(39, 20);
            this.tb_y.TabIndex = 21;
            // 
            // tb_z
            // 
            this.tb_z.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tb_z.Enabled = false;
            this.tb_z.Location = new System.Drawing.Point(364, 276);
            this.tb_z.Name = "tb_z";
            this.tb_z.Size = new System.Drawing.Size(39, 20);
            this.tb_z.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(283, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(330, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(377, 258);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 15);
            this.label12.TabIndex = 25;
            this.label12.Text = "Z";
            // 
            // btn_controllerconnect
            // 
            this.btn_controllerconnect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_controllerconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_controllerconnect.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_controllerconnect.Location = new System.Drawing.Point(29, 258);
            this.btn_controllerconnect.Name = "btn_controllerconnect";
            this.btn_controllerconnect.Size = new System.Drawing.Size(152, 39);
            this.btn_controllerconnect.TabIndex = 26;
            this.btn_controllerconnect.Text = "Connect with gamepad";
            this.btn_controllerconnect.UseVisualStyleBackColor = false;
            this.btn_controllerconnect.Click += new System.EventHandler(this.btn_controllerconnect_Click);
            // 
            // RCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.btn_controllerconnect);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_z);
            this.Controls.Add(this.tb_y);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_calesc);
            this.Controls.Add(this.btn_test2);
            this.Controls.Add(this.btn_test);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.btc_connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoteControlClientV1.0 BETA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RCC_FormClosing);
            this.Load += new System.EventHandler(this.RCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btc_connect;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_test2;
        private System.Windows.Forms.Button btn_calesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.TextBox tb_z;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_controllerconnect;
    }
}


namespace WindowsFormsApp1
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RegisterEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginRegister = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RegistercheckBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RegisterPassword = new System.Windows.Forms.TextBox();
            this.RegisterUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(565, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(79, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(422, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "CAR MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.RegisterEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LoginRegister);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.RegistercheckBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.RegisterPassword);
            this.panel1.Controls.Add(this.RegisterUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LoginText);
            this.panel1.Location = new System.Drawing.Point(121, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 362);
            this.panel1.TabIndex = 8;
            // 
            // RegisterEmail
            // 
            this.RegisterEmail.Location = new System.Drawing.Point(38, 143);
            this.RegisterEmail.Name = "RegisterEmail";
            this.RegisterEmail.Size = new System.Drawing.Size(247, 20);
            this.RegisterEmail.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(27, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email :";
            // 
            // LoginRegister
            // 
            this.LoginRegister.AutoSize = true;
            this.LoginRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginRegister.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LoginRegister.Location = new System.Drawing.Point(194, 311);
            this.LoginRegister.Name = "LoginRegister";
            this.LoginRegister.Size = new System.Drawing.Size(69, 13);
            this.LoginRegister.TabIndex = 11;
            this.LoginRegister.Text = "Login Here";
            this.LoginRegister.Click += new System.EventHandler(this.LoginRegister_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(53, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Already have an account ?";
            // 
            // RegistercheckBox1
            // 
            this.RegistercheckBox1.AutoSize = true;
            this.RegistercheckBox1.Checked = true;
            this.RegistercheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RegistercheckBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegistercheckBox1.Location = new System.Drawing.Point(205, 252);
            this.RegistercheckBox1.Name = "RegistercheckBox1";
            this.RegistercheckBox1.Size = new System.Drawing.Size(102, 17);
            this.RegistercheckBox1.TabIndex = 9;
            this.RegistercheckBox1.Text = "Show Password";
            this.RegistercheckBox1.UseVisualStyleBackColor = true;
            this.RegistercheckBox1.CheckedChanged += new System.EventHandler(this.LogincheckBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(39, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RegisterPassword
            // 
            this.RegisterPassword.Location = new System.Drawing.Point(39, 207);
            this.RegisterPassword.Name = "RegisterPassword";
            this.RegisterPassword.Size = new System.Drawing.Size(246, 20);
            this.RegisterPassword.TabIndex = 5;
            // 
            // RegisterUserName
            // 
            this.RegisterUserName.Location = new System.Drawing.Point(36, 88);
            this.RegisterUserName.Name = "RegisterUserName";
            this.RegisterUserName.Size = new System.Drawing.Size(247, 20);
            this.RegisterUserName.TabIndex = 4;
            this.RegisterUserName.TextChanged += new System.EventHandler(this.RegisterUserName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(32, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name :";
            // 
            // LoginText
            // 
            this.LoginText.AutoSize = true;
            this.LoginText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginText.Location = new System.Drawing.Point(64, 14);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(176, 33);
            this.LoginText.TabIndex = 0;
            this.LoginText.Text = "Get Started";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 525);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LoginRegister;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox RegistercheckBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox RegisterPassword;
        private System.Windows.Forms.TextBox RegisterUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LoginText;
        private System.Windows.Forms.TextBox RegisterEmail;
        private System.Windows.Forms.Label label5;
    }
}
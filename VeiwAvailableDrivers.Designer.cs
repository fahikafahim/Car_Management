namespace WindowsFormsApp1
{
    partial class VeiwAvailableDrivers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeiwAvailableDrivers));
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmOderBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DriverName = new System.Windows.Forms.Label();
            this.DriverID = new System.Windows.Forms.Label();
            this.ContactNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(563, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(84, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(468, 236);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(62, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 23);
            this.label2.TabIndex = 42;
            this.label2.Text = "Select a Available Driver...";
            // 
            // ConfirmOderBtn
            // 
            this.ConfirmOderBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.ConfirmOderBtn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.ConfirmOderBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.ConfirmOderBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.ConfirmOderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmOderBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmOderBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ConfirmOderBtn.Location = new System.Drawing.Point(427, 436);
            this.ConfirmOderBtn.Name = "ConfirmOderBtn";
            this.ConfirmOderBtn.Padding = new System.Windows.Forms.Padding(5);
            this.ConfirmOderBtn.Size = new System.Drawing.Size(137, 35);
            this.ConfirmOderBtn.TabIndex = 50;
            this.ConfirmOderBtn.Text = "Next";
            this.ConfirmOderBtn.UseVisualStyleBackColor = false;
            this.ConfirmOderBtn.Click += new System.EventHandler(this.ConfirmOderBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.DriverName);
            this.panel1.Controls.Add(this.DriverID);
            this.panel1.Controls.Add(this.ContactNo);
            this.panel1.Location = new System.Drawing.Point(97, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 130);
            this.panel1.TabIndex = 57;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DriverName
            // 
            this.DriverName.AutoSize = true;
            this.DriverName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.DriverName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DriverName.Location = new System.Drawing.Point(5, 14);
            this.DriverName.Name = "DriverName";
            this.DriverName.Size = new System.Drawing.Size(0, 18);
            this.DriverName.TabIndex = 52;
            // 
            // DriverID
            // 
            this.DriverID.AutoSize = true;
            this.DriverID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DriverID.Location = new System.Drawing.Point(5, 59);
            this.DriverID.Name = "DriverID";
            this.DriverID.Size = new System.Drawing.Size(0, 18);
            this.DriverID.TabIndex = 54;
            this.DriverID.Click += new System.EventHandler(this.DriverID_Click);
            // 
            // ContactNo
            // 
            this.ContactNo.AutoSize = true;
            this.ContactNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.ContactNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ContactNo.Location = new System.Drawing.Point(5, 99);
            this.ContactNo.Name = "ContactNo";
            this.ContactNo.Size = new System.Drawing.Size(0, 18);
            this.ContactNo.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(139, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 33);
            this.label1.TabIndex = 56;
            this.label1.Text = "Veiw Available  Driver";
            // 
            // VeiwAvailableDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 525);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConfirmOderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VeiwAvailableDrivers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VeiwAvailableDrivers";
            this.Load += new System.EventHandler(this.VeiwAvailableDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConfirmOderBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DriverName;
        private System.Windows.Forms.Label DriverID;
        private System.Windows.Forms.Label ContactNo;
        private System.Windows.Forms.Label label1;
    }
}
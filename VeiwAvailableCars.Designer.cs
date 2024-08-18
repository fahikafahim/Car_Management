namespace WindowsFormsApp1
{
    partial class VeiwAvailableCars
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeiwAvailableCars));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConfirmOderBtn = new System.Windows.Forms.Button();
            this.Noplate = new System.Windows.Forms.Label();
            this.Carmodel = new System.Windows.Forms.Label();
            this.Carcolor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeight = 45;
            this.dataGridView2.Location = new System.Drawing.Point(59, 95);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(468, 245);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(154, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Veiw Available Cars";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Red;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(565, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Select a Available Car...";
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
            this.ConfirmOderBtn.Location = new System.Drawing.Point(425, 465);
            this.ConfirmOderBtn.Name = "ConfirmOderBtn";
            this.ConfirmOderBtn.Padding = new System.Windows.Forms.Padding(5);
            this.ConfirmOderBtn.Size = new System.Drawing.Size(137, 35);
            this.ConfirmOderBtn.TabIndex = 51;
            this.ConfirmOderBtn.Text = "Next";
            this.ConfirmOderBtn.UseVisualStyleBackColor = false;
            this.ConfirmOderBtn.Click += new System.EventHandler(this.ConfirmOderBtn_Click);
            // 
            // Noplate
            // 
            this.Noplate.AutoSize = true;
            this.Noplate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Noplate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Noplate.Location = new System.Drawing.Point(5, 11);
            this.Noplate.Name = "Noplate";
            this.Noplate.Size = new System.Drawing.Size(0, 18);
            this.Noplate.TabIndex = 52;
            this.Noplate.Click += new System.EventHandler(this.Noplate_Click);
            // 
            // Carmodel
            // 
            this.Carmodel.AutoSize = true;
            this.Carmodel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.Carmodel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Carmodel.Location = new System.Drawing.Point(5, 74);
            this.Carmodel.Name = "Carmodel";
            this.Carmodel.Size = new System.Drawing.Size(0, 18);
            this.Carmodel.TabIndex = 53;
            // 
            // Carcolor
            // 
            this.Carcolor.AutoSize = true;
            this.Carcolor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Carcolor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Carcolor.Location = new System.Drawing.Point(5, 44);
            this.Carcolor.Name = "Carcolor";
            this.Carcolor.Size = new System.Drawing.Size(0, 18);
            this.Carcolor.TabIndex = 54;
            this.Carcolor.Click += new System.EventHandler(this.Carcolor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.Noplate);
            this.panel1.Controls.Add(this.Carcolor);
            this.panel1.Controls.Add(this.Carmodel);
            this.panel1.Location = new System.Drawing.Point(59, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 130);
            this.panel1.TabIndex = 56;
            // 
            // VeiwAvailableCars
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConfirmOderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VeiwAvailableCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VeiwAvailableCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConfirmOderBtn;
        private System.Windows.Forms.Label Noplate;
        private System.Windows.Forms.Label Carmodel;
        private System.Windows.Forms.Label Carcolor;
        private System.Windows.Forms.Panel panel1;
    }
}
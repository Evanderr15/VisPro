namespace RentalApp
{
    partial class Barang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barang));
            this.btnSv = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDBr = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNBr = new System.Windows.Forms.TextBox();
            this.txtSewa = new System.Windows.Forms.TextBox();
            this.txtSt = new System.Windows.Forms.TextBox();
            this.btnCr = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnSh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSv
            // 
            this.btnSv.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSv.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSv.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSv.Location = new System.Drawing.Point(731, 354);
            this.btnSv.Name = "btnSv";
            this.btnSv.Size = new System.Drawing.Size(130, 45);
            this.btnSv.TabIndex = 0;
            this.btnSv.Text = "Add";
            this.btnSv.UseVisualStyleBackColor = false;
            this.btnSv.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(34, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(532, 430);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(728, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "ID Barang";
            // 
            // txtIDBr
            // 
            this.txtIDBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBr.Location = new System.Drawing.Point(868, 76);
            this.txtIDBr.Name = "txtIDBr";
            this.txtIDBr.Size = new System.Drawing.Size(157, 26);
            this.txtIDBr.TabIndex = 3;
            this.txtIDBr.TextChanged += new System.EventHandler(this.textIDB_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(728, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nama Barang";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(728, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "Harga Sewa";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(728, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Stok";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(833, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 24);
            this.label13.TabIndex = 7;
            this.label13.Text = ":";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(833, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 24);
            this.label14.TabIndex = 8;
            this.label14.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(833, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 24);
            this.label15.TabIndex = 9;
            this.label15.Text = ":";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(833, 259);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 24);
            this.label16.TabIndex = 10;
            this.label16.Text = ":";
            // 
            // txtNBr
            // 
            this.txtNBr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNBr.Location = new System.Drawing.Point(868, 137);
            this.txtNBr.Name = "txtNBr";
            this.txtNBr.Size = new System.Drawing.Size(157, 26);
            this.txtNBr.TabIndex = 11;
            // 
            // txtSewa
            // 
            this.txtSewa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSewa.Location = new System.Drawing.Point(868, 197);
            this.txtSewa.Name = "txtSewa";
            this.txtSewa.Size = new System.Drawing.Size(157, 26);
            this.txtSewa.TabIndex = 12;
            // 
            // txtSt
            // 
            this.txtSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSt.Location = new System.Drawing.Point(868, 259);
            this.txtSt.Name = "txtSt";
            this.txtSt.Size = new System.Drawing.Size(157, 26);
            this.txtSt.TabIndex = 13;
            // 
            // btnCr
            // 
            this.btnCr.BackColor = System.Drawing.Color.Tan;
            this.btnCr.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCr.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnCr.Location = new System.Drawing.Point(901, 422);
            this.btnCr.Name = "btnCr";
            this.btnCr.Size = new System.Drawing.Size(124, 45);
            this.btnCr.TabIndex = 14;
            this.btnCr.Text = "Clear";
            this.btnCr.UseVisualStyleBackColor = false;
            this.btnCr.Click += new System.EventHandler(this.btnCr_Click);
            // 
            // btnUP
            // 
            this.btnUP.BackColor = System.Drawing.Color.Tan;
            this.btnUP.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUP.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnUP.Location = new System.Drawing.Point(901, 354);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(124, 45);
            this.btnUP.TabIndex = 15;
            this.btnUP.Text = "Update";
            this.btnUP.UseVisualStyleBackColor = false;
            this.btnUP.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSh
            // 
            this.btnSh.BackColor = System.Drawing.Color.Tan;
            this.btnSh.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSh.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSh.Location = new System.Drawing.Point(731, 422);
            this.btnSh.Name = "btnSh";
            this.btnSh.Size = new System.Drawing.Size(130, 45);
            this.btnSh.TabIndex = 16;
            this.btnSh.Text = "Search";
            this.btnSh.UseVisualStyleBackColor = false;
            this.btnSh.Click += new System.EventHandler(this.btnSh_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1184, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Barang
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSh);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.btnCr);
            this.Controls.Add(this.txtSt);
            this.Controls.Add(this.txtSewa);
            this.Controls.Add(this.txtNBr);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIDBr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnSv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Barang";
            this.Load += new System.EventHandler(this.Barang_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIDB;
        private System.Windows.Forms.TextBox txtHsewa;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtNB;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSv;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDBr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNBr;
        private System.Windows.Forms.TextBox txtSewa;
        private System.Windows.Forms.TextBox txtSt;
        private System.Windows.Forms.Button btnCr;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnSh;
        private System.Windows.Forms.Button button1;
    }
}
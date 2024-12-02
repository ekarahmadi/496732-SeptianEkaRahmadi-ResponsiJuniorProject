namespace Responsi_Junpro2024
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvKaryawan = new DataGridView();
            lblNama = new Label();
            lblDepartemen = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLoad = new Button();
            lblKeterangn = new Label();
            pictureBox1 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tbNama = new TextBox();
            cbDepartemen = new ComboBox();
            lblJabatan = new Label();
            cbJabatan = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvKaryawan
            // 
            dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKaryawan.Location = new Point(25, 229);
            dgvKaryawan.Margin = new Padding(3, 2, 3, 2);
            dgvKaryawan.Name = "dgvKaryawan";
            dgvKaryawan.RowHeadersWidth = 51;
            dgvKaryawan.Size = new Size(637, 141);
            dgvKaryawan.TabIndex = 0;
            dgvKaryawan.CellClick += dgvKaryawan_CellContentClick;
            dgvKaryawan.CellContentClick += dgvKaryawan_CellContentClick;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(25, 73);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(93, 15);
            lblNama.TabIndex = 1;
            lblNama.Text = "Nama Karyawan";
            // 
            // lblDepartemen
            // 
            lblDepartemen.AutoSize = true;
            lblDepartemen.Location = new Point(25, 113);
            lblDepartemen.Name = "lblDepartemen";
            lblDepartemen.Size = new Size(107, 15);
            lblDepartemen.TabIndex = 3;
            lblDepartemen.Text = "Nama Departemen";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(25, 190);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(82, 22);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(137, 190);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(82, 22);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Edit";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(249, 190);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 22);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(360, 190);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(82, 22);
            btnLoad.TabIndex = 8;
            btnLoad.Text = "Reload";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lblKeterangn
            // 
            lblKeterangn.AutoSize = true;
            lblKeterangn.Location = new Point(477, 17);
            lblKeterangn.Name = "lblKeterangn";
            lblKeterangn.Size = new Size(130, 195);
            lblKeterangn.TabIndex = 9;
            lblKeterangn.Text = "Keterangan ID\r\n\r\nID DEP:\r\nHR\t\t: HR\r\nENG\t\t: Engineer\r\nDEV\t\t: Developrer\r\nPM\t\t: Product Manager\r\nFIN\t\t: Finance\r\n\r\nID JABATAN:\r\nLD\t\t: Leader Departemen\r\nTM\t\t: Team Leader\r\nSF\t\t: Staff";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 17);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tbNama
            // 
            tbNama.Location = new Point(150, 68);
            tbNama.Margin = new Padding(3, 2, 3, 2);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(292, 23);
            tbNama.TabIndex = 12;
            tbNama.TextChanged += textBox1_TextChanged;
            // 
            // cbDepartemen
            // 
            cbDepartemen.FormattingEnabled = true;
            cbDepartemen.Location = new Point(150, 105);
            cbDepartemen.Margin = new Padding(3, 2, 3, 2);
            cbDepartemen.Name = "cbDepartemen";
            cbDepartemen.Size = new Size(292, 23);
            cbDepartemen.TabIndex = 13;
            // 
            // lblJabatan
            // 
            lblJabatan.AutoSize = true;
            lblJabatan.Location = new Point(25, 151);
            lblJabatan.Name = "lblJabatan";
            lblJabatan.Size = new Size(47, 15);
            lblJabatan.TabIndex = 14;
            lblJabatan.Text = "Jabatan";
            // 
            // cbJabatan
            // 
            cbJabatan.FormattingEnabled = true;
            cbJabatan.Location = new Point(150, 143);
            cbJabatan.Margin = new Padding(3, 2, 3, 2);
            cbJabatan.Name = "cbJabatan";
            cbJabatan.Size = new Size(292, 23);
            cbJabatan.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 390);
            Controls.Add(cbJabatan);
            Controls.Add(lblJabatan);
            Controls.Add(cbDepartemen);
            Controls.Add(tbNama);
            Controls.Add(pictureBox1);
            Controls.Add(lblKeterangn);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(lblDepartemen);
            Controls.Add(lblNama);
            Controls.Add(dgvKaryawan);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Responsi CRUD Database Karyawan";
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKaryawan;
        private Label lblNama;
        private Label lblDepartemen;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLoad;
        private Label lblKeterangn;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox tbNama;
        private ComboBox cbDepartemen;
        private Label lblJabatan;
        private ComboBox cbJabatan;
    }
}

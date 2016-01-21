namespace Bell
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Today = new System.Windows.Forms.Button();
            this.Days = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.Jam = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamMasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jam1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jam2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jam3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jam4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jam5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jam6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jam7DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jam8DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.istirahatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamPulangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weeksDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jadwalDataSet = new Bell.JadwalDataSet();
            this.jamKe1 = new System.Windows.Forms.TextBox();
            this.jamKe2 = new System.Windows.Forms.TextBox();
            this.jamKe3 = new System.Windows.Forms.TextBox();
            this.jamKe4 = new System.Windows.Forms.TextBox();
            this.jamKe5 = new System.Windows.Forms.TextBox();
            this.jamKe6 = new System.Windows.Forms.TextBox();
            this.jamKe7 = new System.Windows.Forms.TextBox();
            this.jamKe8 = new System.Windows.Forms.TextBox();
            this.jamMasuk = new System.Windows.Forms.TextBox();
            this.jamKeluar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.jamIstirahat = new System.Windows.Forms.TextBox();
            this.InputJam = new System.Windows.Forms.Button();
            this.weeksDBTableAdapter = new Bell.JadwalDataSetTableAdapters.WeeksDBTableAdapter();
            this.alarmStatus = new System.Windows.Forms.Label();
            this.pilihHari = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeksDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Today
            // 
            this.Today.Location = new System.Drawing.Point(1076, 8);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(219, 23);
            this.Today.TabIndex = 0;
            this.Today.Text = "Today";
            this.Today.UseVisualStyleBackColor = true;
            // 
            // Days
            // 
            this.Days.AutoSize = true;
            this.Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Days.Location = new System.Drawing.Point(12, 9);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(77, 31);
            this.Days.TabIndex = 2;
            this.Days.Text = "Days";
            // 
            // Clock
            // 
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // Jam
            // 
            this.Jam.AutoSize = true;
            this.Jam.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jam.Location = new System.Drawing.Point(430, 42);
            this.Jam.Name = "Jam";
            this.Jam.Size = new System.Drawing.Size(412, 76);
            this.Jam.TabIndex = 3;
            this.Jam.Text = "00:00:00 AM";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hariDataGridViewTextBoxColumn,
            this.jamMasukDataGridViewTextBoxColumn,
            this.jam1DataGridViewTextBoxColumn,
            this.jam2DataGridViewTextBoxColumn,
            this.jam3DataGridViewTextBoxColumn,
            this.jam4DataGridViewTextBoxColumn,
            this.jam5DataGridViewTextBoxColumn,
            this.jam6DataGridViewTextBoxColumn,
            this.jam7DataGridViewTextBoxColumn,
            this.jam8DataGridViewTextBoxColumn,
            this.istirahatDataGridViewTextBoxColumn,
            this.jamPulangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.weeksDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(34, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1247, 208);
            this.dataGridView1.TabIndex = 4;
            // 
            // hariDataGridViewTextBoxColumn
            // 
            this.hariDataGridViewTextBoxColumn.DataPropertyName = "Hari";
            this.hariDataGridViewTextBoxColumn.HeaderText = "Hari";
            this.hariDataGridViewTextBoxColumn.Name = "hariDataGridViewTextBoxColumn";
            this.hariDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jamMasukDataGridViewTextBoxColumn
            // 
            this.jamMasukDataGridViewTextBoxColumn.DataPropertyName = "Jam Masuk";
            dataGridViewCellStyle12.Format = "t";
            this.jamMasukDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.jamMasukDataGridViewTextBoxColumn.HeaderText = "Jam Masuk";
            this.jamMasukDataGridViewTextBoxColumn.Name = "jamMasukDataGridViewTextBoxColumn";
            this.jamMasukDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam1DataGridViewTextBoxColumn
            // 
            this.jam1DataGridViewTextBoxColumn.DataPropertyName = "Jam 1";
            dataGridViewCellStyle13.Format = "t";
            dataGridViewCellStyle13.NullValue = null;
            this.jam1DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.jam1DataGridViewTextBoxColumn.HeaderText = "Jam 1";
            this.jam1DataGridViewTextBoxColumn.Name = "jam1DataGridViewTextBoxColumn";
            this.jam1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam2DataGridViewTextBoxColumn
            // 
            this.jam2DataGridViewTextBoxColumn.DataPropertyName = "Jam 2";
            dataGridViewCellStyle14.Format = "t";
            dataGridViewCellStyle14.NullValue = null;
            this.jam2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.jam2DataGridViewTextBoxColumn.HeaderText = "Jam 2";
            this.jam2DataGridViewTextBoxColumn.Name = "jam2DataGridViewTextBoxColumn";
            this.jam2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam3DataGridViewTextBoxColumn
            // 
            this.jam3DataGridViewTextBoxColumn.DataPropertyName = "Jam 3";
            dataGridViewCellStyle15.Format = "t";
            dataGridViewCellStyle15.NullValue = null;
            this.jam3DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.jam3DataGridViewTextBoxColumn.HeaderText = "Jam 3";
            this.jam3DataGridViewTextBoxColumn.Name = "jam3DataGridViewTextBoxColumn";
            this.jam3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam4DataGridViewTextBoxColumn
            // 
            this.jam4DataGridViewTextBoxColumn.DataPropertyName = "Jam 4";
            dataGridViewCellStyle16.Format = "t";
            this.jam4DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle16;
            this.jam4DataGridViewTextBoxColumn.HeaderText = "Jam 4";
            this.jam4DataGridViewTextBoxColumn.Name = "jam4DataGridViewTextBoxColumn";
            this.jam4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam5DataGridViewTextBoxColumn
            // 
            this.jam5DataGridViewTextBoxColumn.DataPropertyName = "Jam 5";
            dataGridViewCellStyle17.Format = "t";
            this.jam5DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.jam5DataGridViewTextBoxColumn.HeaderText = "Jam 5";
            this.jam5DataGridViewTextBoxColumn.Name = "jam5DataGridViewTextBoxColumn";
            this.jam5DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam6DataGridViewTextBoxColumn
            // 
            this.jam6DataGridViewTextBoxColumn.DataPropertyName = "Jam 6";
            dataGridViewCellStyle18.Format = "t";
            this.jam6DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.jam6DataGridViewTextBoxColumn.HeaderText = "Jam 6";
            this.jam6DataGridViewTextBoxColumn.Name = "jam6DataGridViewTextBoxColumn";
            this.jam6DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam7DataGridViewTextBoxColumn
            // 
            this.jam7DataGridViewTextBoxColumn.DataPropertyName = "Jam 7";
            dataGridViewCellStyle19.Format = "t";
            this.jam7DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.jam7DataGridViewTextBoxColumn.HeaderText = "Jam 7";
            this.jam7DataGridViewTextBoxColumn.Name = "jam7DataGridViewTextBoxColumn";
            this.jam7DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam8DataGridViewTextBoxColumn
            // 
            this.jam8DataGridViewTextBoxColumn.DataPropertyName = "Jam 8";
            dataGridViewCellStyle20.Format = "t";
            this.jam8DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle20;
            this.jam8DataGridViewTextBoxColumn.HeaderText = "Jam 8";
            this.jam8DataGridViewTextBoxColumn.Name = "jam8DataGridViewTextBoxColumn";
            this.jam8DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // istirahatDataGridViewTextBoxColumn
            // 
            this.istirahatDataGridViewTextBoxColumn.DataPropertyName = "Istirahat";
            dataGridViewCellStyle21.Format = "t";
            this.istirahatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle21;
            this.istirahatDataGridViewTextBoxColumn.HeaderText = "Istirahat";
            this.istirahatDataGridViewTextBoxColumn.Name = "istirahatDataGridViewTextBoxColumn";
            this.istirahatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jamPulangDataGridViewTextBoxColumn
            // 
            this.jamPulangDataGridViewTextBoxColumn.DataPropertyName = "Jam Pulang";
            dataGridViewCellStyle22.Format = "t";
            this.jamPulangDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle22;
            this.jamPulangDataGridViewTextBoxColumn.HeaderText = "Jam Pulang";
            this.jamPulangDataGridViewTextBoxColumn.Name = "jamPulangDataGridViewTextBoxColumn";
            this.jamPulangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weeksDBBindingSource
            // 
            this.weeksDBBindingSource.DataMember = "WeeksDB";
            this.weeksDBBindingSource.DataSource = this.jadwalDataSet;
            // 
            // jadwalDataSet
            // 
            this.jadwalDataSet.DataSetName = "JadwalDataSet";
            this.jadwalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jamKe1
            // 
            this.jamKe1.Location = new System.Drawing.Point(605, 354);
            this.jamKe1.Name = "jamKe1";
            this.jamKe1.Size = new System.Drawing.Size(100, 20);
            this.jamKe1.TabIndex = 5;
            // 
            // jamKe2
            // 
            this.jamKe2.Location = new System.Drawing.Point(605, 380);
            this.jamKe2.Name = "jamKe2";
            this.jamKe2.Size = new System.Drawing.Size(100, 20);
            this.jamKe2.TabIndex = 6;
            // 
            // jamKe3
            // 
            this.jamKe3.Location = new System.Drawing.Point(605, 406);
            this.jamKe3.Name = "jamKe3";
            this.jamKe3.Size = new System.Drawing.Size(100, 20);
            this.jamKe3.TabIndex = 7;
            // 
            // jamKe4
            // 
            this.jamKe4.Location = new System.Drawing.Point(605, 432);
            this.jamKe4.Name = "jamKe4";
            this.jamKe4.Size = new System.Drawing.Size(100, 20);
            this.jamKe4.TabIndex = 8;
            // 
            // jamKe5
            // 
            this.jamKe5.Location = new System.Drawing.Point(818, 354);
            this.jamKe5.Name = "jamKe5";
            this.jamKe5.Size = new System.Drawing.Size(100, 20);
            this.jamKe5.TabIndex = 9;
            // 
            // jamKe6
            // 
            this.jamKe6.Location = new System.Drawing.Point(818, 380);
            this.jamKe6.Name = "jamKe6";
            this.jamKe6.Size = new System.Drawing.Size(100, 20);
            this.jamKe6.TabIndex = 10;
            // 
            // jamKe7
            // 
            this.jamKe7.Location = new System.Drawing.Point(818, 406);
            this.jamKe7.Name = "jamKe7";
            this.jamKe7.Size = new System.Drawing.Size(100, 20);
            this.jamKe7.TabIndex = 11;
            // 
            // jamKe8
            // 
            this.jamKe8.Location = new System.Drawing.Point(818, 432);
            this.jamKe8.Name = "jamKe8";
            this.jamKe8.Size = new System.Drawing.Size(100, 20);
            this.jamKe8.TabIndex = 12;
            // 
            // jamMasuk
            // 
            this.jamMasuk.Location = new System.Drawing.Point(411, 380);
            this.jamMasuk.Name = "jamMasuk";
            this.jamMasuk.Size = new System.Drawing.Size(100, 20);
            this.jamMasuk.TabIndex = 13;
            // 
            // jamKeluar
            // 
            this.jamKeluar.Location = new System.Drawing.Point(411, 426);
            this.jamKeluar.Name = "jamKeluar";
            this.jamKeluar.Size = new System.Drawing.Size(100, 20);
            this.jamKeluar.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Jam Masuk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Jam Ke 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Jam Ke 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Jam Ke 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Jam Ke 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(751, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Jam Ke 5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(751, 383);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Jam Ke 6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(751, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Jam Ke 7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(751, 435);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Jam Ke 8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(344, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Jam Keluar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 406);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Jam Istirahat";
            // 
            // jamIstirahat
            // 
            this.jamIstirahat.Location = new System.Drawing.Point(411, 403);
            this.jamIstirahat.Name = "jamIstirahat";
            this.jamIstirahat.Size = new System.Drawing.Size(100, 20);
            this.jamIstirahat.TabIndex = 25;
            // 
            // InputJam
            // 
            this.InputJam.Location = new System.Drawing.Point(520, 484);
            this.InputJam.Name = "InputJam";
            this.InputJam.Size = new System.Drawing.Size(234, 23);
            this.InputJam.TabIndex = 27;
            this.InputJam.Text = "Input Data";
            this.InputJam.UseVisualStyleBackColor = true;
            this.InputJam.Click += new System.EventHandler(this.InputJam_Click);
            // 
            // weeksDBTableAdapter
            // 
            this.weeksDBTableAdapter.ClearBeforeFill = true;
            // 
            // alarmStatus
            // 
            this.alarmStatus.AutoSize = true;
            this.alarmStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmStatus.Location = new System.Drawing.Point(1153, 78);
            this.alarmStatus.Name = "alarmStatus";
            this.alarmStatus.Size = new System.Drawing.Size(128, 31);
            this.alarmStatus.TabIndex = 28;
            this.alarmStatus.Text = "Alarm Off";
            // 
            // pilihHari
            // 
            this.pilihHari.FormattingEnabled = true;
            this.pilihHari.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.pilihHari.Location = new System.Drawing.Point(347, 353);
            this.pilihHari.Name = "pilihHari";
            this.pilihHari.Size = new System.Drawing.Size(164, 21);
            this.pilihHari.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 519);
            this.Controls.Add(this.pilihHari);
            this.Controls.Add(this.alarmStatus);
            this.Controls.Add(this.InputJam);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.jamIstirahat);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jamKeluar);
            this.Controls.Add(this.jamMasuk);
            this.Controls.Add(this.jamKe8);
            this.Controls.Add(this.jamKe7);
            this.Controls.Add(this.jamKe6);
            this.Controls.Add(this.jamKe5);
            this.Controls.Add(this.jamKe4);
            this.Controls.Add(this.jamKe3);
            this.Controls.Add(this.jamKe2);
            this.Controls.Add(this.jamKe1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Jam);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.Today);
            this.Name = "Form1";
            this.Text = "Bell";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeksDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Today;
        private System.Windows.Forms.Label Days;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label Jam;
        private System.Windows.Forms.DataGridView dataGridView1;
        private JadwalDataSet jadwalDataSet;
        private System.Windows.Forms.BindingSource weeksDBBindingSource;
        private JadwalDataSetTableAdapters.WeeksDBTableAdapter weeksDBTableAdapter;
        private System.Windows.Forms.TextBox jamKe1;
        private System.Windows.Forms.TextBox jamKe2;
        private System.Windows.Forms.TextBox jamKe3;
        private System.Windows.Forms.TextBox jamKe4;
        private System.Windows.Forms.TextBox jamKe5;
        private System.Windows.Forms.TextBox jamKe6;
        private System.Windows.Forms.TextBox jamKe7;
        private System.Windows.Forms.TextBox jamKe8;
        private System.Windows.Forms.TextBox jamMasuk;
        private System.Windows.Forms.TextBox jamKeluar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox jamIstirahat;
        private System.Windows.Forms.Button InputJam;
        private System.Windows.Forms.DataGridViewTextBoxColumn hariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamMasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn istirahatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamPulangDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label alarmStatus;
        private System.Windows.Forms.ComboBox pilihHari;
    }
}


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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Days = new System.Windows.Forms.Label();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.Jam = new System.Windows.Forms.Label();
            this.TableJadwalView = new System.Windows.Forms.DataGridView();
            this.hariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamMasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.jamKe2 = new System.Windows.Forms.TextBox();
            this.jamKe3 = new System.Windows.Forms.TextBox();
            this.jamKe4 = new System.Windows.Forms.TextBox();
            this.jamKe5 = new System.Windows.Forms.TextBox();
            this.jamKe6 = new System.Windows.Forms.TextBox();
            this.jamKe7 = new System.Windows.Forms.TextBox();
            this.jamKe8 = new System.Windows.Forms.TextBox();
            this.jamMasuk = new System.Windows.Forms.TextBox();
            this.jamPulang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.inputData = new System.Windows.Forms.Button();
            this.alarmStatus = new System.Windows.Forms.Label();
            this.pilihHari = new System.Windows.Forms.ComboBox();
            this.deleteData = new System.Windows.Forms.Button();
            this.updateData = new System.Windows.Forms.Button();
            this.weeksDBTableAdapter = new Bell.JadwalDataSetTableAdapters.WeeksDBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TableJadwalView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeksDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Days
            // 
            this.Days.AutoSize = true;
            this.Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Days.Location = new System.Drawing.Point(28, 82);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(165, 31);
            this.Days.TabIndex = 2;
            this.Days.Text = "Days + Date";
            // 
            // Clock
            // 
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // Jam
            // 
            this.Jam.AutoSize = true;
            this.Jam.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jam.Location = new System.Drawing.Point(21, 6);
            this.Jam.Name = "Jam";
            this.Jam.Size = new System.Drawing.Size(293, 76);
            this.Jam.TabIndex = 3;
            this.Jam.Text = "00:00:00";
            // 
            // TableJadwalView
            // 
            this.TableJadwalView.AllowUserToAddRows = false;
            this.TableJadwalView.AllowUserToDeleteRows = false;
            this.TableJadwalView.AutoGenerateColumns = false;
            this.TableJadwalView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableJadwalView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hariDataGridViewTextBoxColumn,
            this.jamMasukDataGridViewTextBoxColumn,
            this.jam2DataGridViewTextBoxColumn,
            this.jam3DataGridViewTextBoxColumn,
            this.jam4DataGridViewTextBoxColumn,
            this.jam5DataGridViewTextBoxColumn,
            this.jam6DataGridViewTextBoxColumn,
            this.jam7DataGridViewTextBoxColumn,
            this.jam8DataGridViewTextBoxColumn,
            this.istirahatDataGridViewTextBoxColumn,
            this.jamPulangDataGridViewTextBoxColumn});
            this.TableJadwalView.DataSource = this.weeksDBBindingSource;
            this.TableJadwalView.Location = new System.Drawing.Point(34, 147);
            this.TableJadwalView.MultiSelect = false;
            this.TableJadwalView.Name = "TableJadwalView";
            this.TableJadwalView.ReadOnly = true;
            this.TableJadwalView.RowTemplate.ReadOnly = true;
            this.TableJadwalView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TableJadwalView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableJadwalView.Size = new System.Drawing.Size(1160, 224);
            this.TableJadwalView.TabIndex = 4;
            this.TableJadwalView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableJadwalView_CellClick);
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
            dataGridViewCellStyle1.Format = "HH:mm";
            dataGridViewCellStyle1.NullValue = null;
            this.jamMasukDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.jamMasukDataGridViewTextBoxColumn.HeaderText = "Jam Masuk";
            this.jamMasukDataGridViewTextBoxColumn.Name = "jamMasukDataGridViewTextBoxColumn";
            this.jamMasukDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam2DataGridViewTextBoxColumn
            // 
            this.jam2DataGridViewTextBoxColumn.DataPropertyName = "Jam 2";
            dataGridViewCellStyle2.Format = "HH:mm";
            dataGridViewCellStyle2.NullValue = null;
            this.jam2DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.jam2DataGridViewTextBoxColumn.HeaderText = "Jam 2";
            this.jam2DataGridViewTextBoxColumn.Name = "jam2DataGridViewTextBoxColumn";
            this.jam2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam3DataGridViewTextBoxColumn
            // 
            this.jam3DataGridViewTextBoxColumn.DataPropertyName = "Jam 3";
            dataGridViewCellStyle3.Format = "HH:mm";
            dataGridViewCellStyle3.NullValue = null;
            this.jam3DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.jam3DataGridViewTextBoxColumn.HeaderText = "Jam 3";
            this.jam3DataGridViewTextBoxColumn.Name = "jam3DataGridViewTextBoxColumn";
            this.jam3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam4DataGridViewTextBoxColumn
            // 
            this.jam4DataGridViewTextBoxColumn.DataPropertyName = "Jam 4";
            dataGridViewCellStyle4.Format = "HH:mm";
            this.jam4DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.jam4DataGridViewTextBoxColumn.HeaderText = "Jam 4";
            this.jam4DataGridViewTextBoxColumn.Name = "jam4DataGridViewTextBoxColumn";
            this.jam4DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam5DataGridViewTextBoxColumn
            // 
            this.jam5DataGridViewTextBoxColumn.DataPropertyName = "Jam 5";
            dataGridViewCellStyle5.Format = "HH:mm";
            this.jam5DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.jam5DataGridViewTextBoxColumn.HeaderText = "Jam 5";
            this.jam5DataGridViewTextBoxColumn.Name = "jam5DataGridViewTextBoxColumn";
            this.jam5DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam6DataGridViewTextBoxColumn
            // 
            this.jam6DataGridViewTextBoxColumn.DataPropertyName = "Jam 6";
            dataGridViewCellStyle6.Format = "HH:mm";
            this.jam6DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.jam6DataGridViewTextBoxColumn.HeaderText = "Jam 6";
            this.jam6DataGridViewTextBoxColumn.Name = "jam6DataGridViewTextBoxColumn";
            this.jam6DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam7DataGridViewTextBoxColumn
            // 
            this.jam7DataGridViewTextBoxColumn.DataPropertyName = "Jam 7";
            dataGridViewCellStyle7.Format = "HH:mm";
            this.jam7DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.jam7DataGridViewTextBoxColumn.HeaderText = "Jam 7";
            this.jam7DataGridViewTextBoxColumn.Name = "jam7DataGridViewTextBoxColumn";
            this.jam7DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jam8DataGridViewTextBoxColumn
            // 
            this.jam8DataGridViewTextBoxColumn.DataPropertyName = "Jam 8";
            dataGridViewCellStyle8.Format = "HH:mm";
            this.jam8DataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.jam8DataGridViewTextBoxColumn.HeaderText = "Jam 8";
            this.jam8DataGridViewTextBoxColumn.Name = "jam8DataGridViewTextBoxColumn";
            this.jam8DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // istirahatDataGridViewTextBoxColumn
            // 
            this.istirahatDataGridViewTextBoxColumn.DataPropertyName = "Istirahat";
            dataGridViewCellStyle9.Format = "HH:mm";
            this.istirahatDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.istirahatDataGridViewTextBoxColumn.HeaderText = "Istirahat";
            this.istirahatDataGridViewTextBoxColumn.Name = "istirahatDataGridViewTextBoxColumn";
            this.istirahatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jamPulangDataGridViewTextBoxColumn
            // 
            this.jamPulangDataGridViewTextBoxColumn.DataPropertyName = "Jam Pulang";
            dataGridViewCellStyle10.Format = "HH:mm";
            dataGridViewCellStyle10.NullValue = null;
            this.jamPulangDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
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
            // jamKe2
            // 
            this.jamKe2.Location = new System.Drawing.Point(605, 378);
            this.jamKe2.Name = "jamKe2";
            this.jamKe2.Size = new System.Drawing.Size(100, 20);
            this.jamKe2.TabIndex = 6;
            // 
            // jamKe3
            // 
            this.jamKe3.Location = new System.Drawing.Point(605, 404);
            this.jamKe3.Name = "jamKe3";
            this.jamKe3.Size = new System.Drawing.Size(100, 20);
            this.jamKe3.TabIndex = 7;
            // 
            // jamKe4
            // 
            this.jamKe4.Location = new System.Drawing.Point(605, 430);
            this.jamKe4.Name = "jamKe4";
            this.jamKe4.Size = new System.Drawing.Size(100, 20);
            this.jamKe4.TabIndex = 8;
            // 
            // jamKe5
            // 
            this.jamKe5.Location = new System.Drawing.Point(818, 378);
            this.jamKe5.Name = "jamKe5";
            this.jamKe5.Size = new System.Drawing.Size(100, 20);
            this.jamKe5.TabIndex = 9;
            // 
            // jamKe6
            // 
            this.jamKe6.Location = new System.Drawing.Point(818, 404);
            this.jamKe6.Name = "jamKe6";
            this.jamKe6.Size = new System.Drawing.Size(100, 20);
            this.jamKe6.TabIndex = 10;
            // 
            // jamKe7
            // 
            this.jamKe7.Location = new System.Drawing.Point(818, 430);
            this.jamKe7.Name = "jamKe7";
            this.jamKe7.Size = new System.Drawing.Size(100, 20);
            this.jamKe7.TabIndex = 11;
            // 
            // jamKe8
            // 
            this.jamKe8.Location = new System.Drawing.Point(818, 456);
            this.jamKe8.Name = "jamKe8";
            this.jamKe8.Size = new System.Drawing.Size(100, 20);
            this.jamKe8.TabIndex = 12;
            // 
            // jamMasuk
            // 
            this.jamMasuk.Location = new System.Drawing.Point(411, 404);
            this.jamMasuk.Name = "jamMasuk";
            this.jamMasuk.Size = new System.Drawing.Size(100, 20);
            this.jamMasuk.TabIndex = 13;
            // 
            // jamPulang
            // 
            this.jamPulang.Location = new System.Drawing.Point(411, 450);
            this.jamPulang.Name = "jamPulang";
            this.jamPulang.Size = new System.Drawing.Size(100, 20);
            this.jamPulang.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Jam Masuk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(538, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Jam Ke 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Jam Ke 3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(538, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Jam Ke 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(751, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Jam Ke 5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(751, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Jam Ke 6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(751, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Jam Ke 7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(751, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Jam Ke 8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(344, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Jam Pulang";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(538, 459);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Jam Istirahat";
            // 
            // jamIstirahat
            // 
            this.jamIstirahat.Location = new System.Drawing.Point(605, 456);
            this.jamIstirahat.Name = "jamIstirahat";
            this.jamIstirahat.Size = new System.Drawing.Size(100, 20);
            this.jamIstirahat.TabIndex = 25;
            // 
            // inputData
            // 
            this.inputData.Location = new System.Drawing.Point(347, 484);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(164, 23);
            this.inputData.TabIndex = 27;
            this.inputData.Text = "Input Data";
            this.inputData.UseVisualStyleBackColor = true;
            this.inputData.Click += new System.EventHandler(this.InputJam_Click);
            // 
            // alarmStatus
            // 
            this.alarmStatus.AutoSize = true;
            this.alarmStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarmStatus.Location = new System.Drawing.Point(28, 113);
            this.alarmStatus.Name = "alarmStatus";
            this.alarmStatus.Size = new System.Drawing.Size(169, 31);
            this.alarmStatus.TabIndex = 28;
            this.alarmStatus.Text = "Alarm Status";
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
            "Saturday"});
            this.pilihHari.Location = new System.Drawing.Point(347, 377);
            this.pilihHari.Name = "pilihHari";
            this.pilihHari.Size = new System.Drawing.Size(164, 21);
            this.pilihHari.TabIndex = 29;
            // 
            // deleteData
            // 
            this.deleteData.Location = new System.Drawing.Point(754, 484);
            this.deleteData.Name = "deleteData";
            this.deleteData.Size = new System.Drawing.Size(164, 23);
            this.deleteData.TabIndex = 30;
            this.deleteData.Text = "Delete";
            this.deleteData.UseVisualStyleBackColor = true;
            this.deleteData.Click += new System.EventHandler(this.deleteData_Click);
            // 
            // updateData
            // 
            this.updateData.Location = new System.Drawing.Point(541, 484);
            this.updateData.Name = "updateData";
            this.updateData.Size = new System.Drawing.Size(164, 23);
            this.updateData.TabIndex = 31;
            this.updateData.Text = "Update Data";
            this.updateData.UseVisualStyleBackColor = true;
            this.updateData.Click += new System.EventHandler(this.updateData_Click);
            // 
            // weeksDBTableAdapter
            // 
            this.weeksDBTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 519);
            this.Controls.Add(this.updateData);
            this.Controls.Add(this.deleteData);
            this.Controls.Add(this.pilihHari);
            this.Controls.Add(this.alarmStatus);
            this.Controls.Add(this.inputData);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jamPulang);
            this.Controls.Add(this.jamMasuk);
            this.Controls.Add(this.jamKe8);
            this.Controls.Add(this.jamKe7);
            this.Controls.Add(this.jamKe6);
            this.Controls.Add(this.jamKe5);
            this.Controls.Add(this.jamKe4);
            this.Controls.Add(this.jamKe3);
            this.Controls.Add(this.jamKe2);
            this.Controls.Add(this.TableJadwalView);
            this.Controls.Add(this.Jam);
            this.Controls.Add(this.Days);
            this.Name = "Form1";
            this.Text = "Bell";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableJadwalView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weeksDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jadwalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Days;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label Jam;
        private System.Windows.Forms.DataGridView TableJadwalView;
        private JadwalDataSet jadwalDataSet;
        private System.Windows.Forms.BindingSource weeksDBBindingSource;
        private JadwalDataSetTableAdapters.WeeksDBTableAdapter weeksDBTableAdapter;
        private System.Windows.Forms.TextBox jamKe2;
        private System.Windows.Forms.TextBox jamKe3;
        private System.Windows.Forms.TextBox jamKe4;
        private System.Windows.Forms.TextBox jamKe5;
        private System.Windows.Forms.TextBox jamKe6;
        private System.Windows.Forms.TextBox jamKe7;
        private System.Windows.Forms.TextBox jamKe8;
        private System.Windows.Forms.TextBox jamMasuk;
        private System.Windows.Forms.TextBox jamPulang;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button inputData;
        private System.Windows.Forms.Label alarmStatus;
        private System.Windows.Forms.ComboBox pilihHari;
        private System.Windows.Forms.DataGridViewTextBoxColumn hariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamMasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam7DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jam8DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn istirahatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamPulangDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteData;
        private System.Windows.Forms.Button updateData;
    }
}


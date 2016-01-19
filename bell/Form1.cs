using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;
using System.Data.OleDb;

namespace Bell
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jadwalDataSet.WeeksDB' table. You can move, or remove it, as needed.
            DateTime now = DateTime.Now;
            Today.Text = now.Date.ToString("dd-MM-yyyy");
            Days.Text = now.DayOfWeek.ToString();
            Clock.Enabled = true;
            Clock.Interval = 1000;
        }

        public void refresh()
        {
            this.weeksDBTableAdapter.Fill(this.jadwalDataSet.WeeksDB);
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string clocknow = now.ToString("hh:mm:ss tt", CultureInfo.InvariantCulture);
            string alarmset = now.ToString("hh:mm tt", CultureInfo.InvariantCulture);
            Jam.Text = clocknow;
            string alarmJam1 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[0]["Jam 1"].ToString(),CultureInfo.InvariantCulture).ToString("hh:mm tt");
            string alarmJam2 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[0]["Jam 2"].ToString(),CultureInfo.InvariantCulture).ToString("hh:mm tt");
            string alarmJam3 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[0]["Jam 3"].ToString(),CultureInfo.InvariantCulture).ToString("hh:mm tt");
            string alarmJam4 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[0]["Jam 4"].ToString(),CultureInfo.InvariantCulture).ToString("hh:mm tt");
            string alarmJam5 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[0]["Jam 5"].ToString(),CultureInfo.InvariantCulture).ToString("hh:mm tt");
            string alarmJam6 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[0]["Jam 6"].ToString(),CultureInfo.InvariantCulture).ToString("hh:mm tt");
            string alarmJam7 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[0]["Jam 7"].ToString(),CultureInfo.InvariantCulture).ToString("hh:mm tt");
            string alarmJam8 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[0]["Jam 8"].ToString(),CultureInfo.InvariantCulture).ToString("hh:mm tt");
            string alarmJamMasuk = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[0]["Jam Masuk"].ToString(),CultureInfo.InvariantCulture).ToString("hh:mm tt");
            string alarmJamIstirahat = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[0]["Istirahat"].ToString(),CultureInfo.InvariantCulture).ToString("hh:mm tt");
            string alarmJamPulang = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[0]["Jam Pulang"].ToString(),CultureInfo.InvariantCulture).ToString("hh:mm tt");
            if (alarmset == alarmJamMasuk)
            {
                alarmStatus.Text = "Jam Masuk";
            }
            else if (alarmset == alarmJamIstirahat)
            {
                alarmStatus.Text = "Jam Istirahat";
            }
            else if (alarmset == alarmJamPulang)
            {
                alarmStatus.Text = "Jam Pulang";
            }
            else if (alarmset == alarmJam1)
            {
                alarmStatus.Text = "Jam Ke 1";
            }
            else if (alarmset == alarmJam1)
            {
                alarmStatus.Text = "Jam Ke 1";
            }
            else if (alarmset == alarmJam2)
            {
                alarmStatus.Text = "Jam Ke 2";
            }
            else if (alarmset == alarmJam3)
            {
                alarmStatus.Text = "Jam Ke 3";
            }
            else if (alarmset == alarmJam4)
            {
                alarmStatus.Text = "Jam Ke 4";
            }
            else if (alarmset == alarmJam5)
            {
                alarmStatus.Text = "Jam Ke 5";
            }
            else if (alarmset == alarmJam6)
            {
                alarmStatus.Text = "Jam Ke 6";
            }
            else if (alarmset == alarmJam7)
            {
                alarmStatus.Text = "Jam Ke 7";
            }
            else if (alarmset == alarmJam8)
            {
                alarmStatus.Text = "Jam Ke 8";
            }
            else
            {
                alarmStatus.Text = "Alarm Off";
            }
        }

        private void InputJam_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string hari_ini = now.DayOfWeek.ToString();
            DateTime input_jam_masuk = DateTime.ParseExact(jamMasuk.Text, "HH:mm", CultureInfo.InvariantCulture);
            DateTime input_jam_keluar = DateTime.ParseExact(jamKeluar.Text, "HH:mm", CultureInfo.InvariantCulture);
            DateTime input_jam_istirahat = DateTime.ParseExact(jamIstirahat.Text, "HH:mm", CultureInfo.InvariantCulture);
            DateTime input_jam_1 = DateTime.ParseExact(jamKe1.Text, "HH:mm", CultureInfo.InvariantCulture);
            DateTime input_jam_2 = DateTime.ParseExact(jamKe2.Text, "HH:mm", CultureInfo.InvariantCulture);
            DateTime input_jam_3 = DateTime.ParseExact(jamKe3.Text, "HH:mm", CultureInfo.InvariantCulture);
            DateTime input_jam_4 = DateTime.ParseExact(jamKe4.Text, "HH:mm", CultureInfo.InvariantCulture);
            DateTime input_jam_5 = DateTime.ParseExact(jamKe5.Text, "HH:mm", CultureInfo.InvariantCulture);
            DateTime input_jam_6 = DateTime.ParseExact(jamKe6.Text, "HH:mm", CultureInfo.InvariantCulture);
            DateTime input_jam_7 = DateTime.ParseExact(jamKe7.Text, "HH:mm", CultureInfo.InvariantCulture);
            DateTime input_jam_8 = DateTime.ParseExact(jamKe8.Text, "HH:mm", CultureInfo.InvariantCulture);
            try
            {
                if (this.weeksDBTableAdapter.Insert(hari_ini, input_jam_masuk, input_jam_1, input_jam_2, input_jam_3, input_jam_4, input_jam_5, input_jam_6, input_jam_7, input_jam_8, input_jam_istirahat, input_jam_keluar) == 1)
                {
                    refresh();
                    MessageBox.Show("Input Data Sukses");
                }
            }
            catch (OleDbException ex)
            {
                DialogResult updating_option = MessageBox.Show("Maaf Data Hari ini sudah ada, apakah ingin update data yang sudah ada","Warning",MessageBoxButtons.YesNo);
                if (updating_option == DialogResult.Yes)
                {
                    MessageBox.Show("Query Updatenya ntar dulu ya bro");
                }
            }
            catch (FormatException format)
            {
                MessageBox.Show("Input Data tidak valid atau kosong");
            }
        }
    }
}

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
using System.Diagnostics;
using System.Media;

namespace Bell
{
    public partial class Form1 : Form
    {
        DateTime now = new DateTime();

        SoundPlayer alarmBell;
        double duration = 5; //durasi alarm

        string clocknow;
        string alarmset;

        string alarmJam1;
        string alarmJam2;
        string alarmJam3;
        string alarmJam4;
        string alarmJam5;
        string alarmJam6;
        string alarmJam7;
        string alarmJam8;
        string alarmJamMasuk;
        string alarmJamIstirahat;
        string alarmJamPulang;

        string buff_hari;
        string buff_alarmJam1;
        string buff_alarmJam2;
        string buff_alarmJam3;
        string buff_alarmJam4;
        string buff_alarmJam5;
        string buff_alarmJam6;
        string buff_alarmJam7;
        string buff_alarmJam8;
        string buff_alarmJamMasuk;
        string buff_alarmJamIstirahat;
        string buff_alarmJamPulang;

        DateTime tmp_alarmJam1 = new DateTime();
        DateTime tmp_alarmJam2 = new DateTime();
        DateTime tmp_alarmJam3 = new DateTime();
        DateTime tmp_alarmJam4 = new DateTime();
        DateTime tmp_alarmJam5 = new DateTime();
        DateTime tmp_alarmJam6 = new DateTime();
        DateTime tmp_alarmJam7 = new DateTime();
        DateTime tmp_alarmJam8 = new DateTime();
        DateTime tmp_alarmJamMasuk = new DateTime();
        DateTime tmp_alarmJamIstirahat = new DateTime();
        DateTime tmp_alarmJamPulang = new DateTime();

        string[] hariDalamSeminggu = { "Monday","Tuesday","Wednesday","Thursday","Friday","Saturday" };
            
        public Form1()
        {
            InitializeComponent();
            refresh();
            inputData.Visible = true;
            updateData.Visible = false;
            deleteData.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            now = DateTime.Now;
            Clock.Enabled = true;
            Clock.Interval = 1000;
            pilihHari.SelectedText = "-- Pilih Hari --";            
        }

        public void refresh()
        {
            this.weeksDBTableAdapter.Fill(this.jadwalDataSet.WeeksDB);
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            now = DateTime.Now;
            Days.Text = now.DayOfWeek.ToString() + ", " + now.Date.ToString("dd-MM-yyyy");
            clocknow = now.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
            alarmset = now.ToString("HH:mm", CultureInfo.InvariantCulture);
            Jam.Text = clocknow;

            if (jadwalDataSet.Tables[0].Rows.Count > 0)
            {
                inputData.Visible = true;
                updateData.Visible = true;
                deleteData.Visible = true;
                for (int i = 0; i < jadwalDataSet.Tables[0].Rows.Count; i++)
                {
                    if (jadwalDataSet.Tables[0].Rows[i]["Hari"].ToString() == now.DayOfWeek.ToString())
                    {
                        alarmJam1 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[i]["Jam 1"].ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                        alarmJam2 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[i]["Jam 2"].ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                        alarmJam3 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[i]["Jam 3"].ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                        alarmJam4 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[i]["Jam 4"].ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                        alarmJam5 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[i]["Jam 5"].ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                        alarmJam6 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[i]["Jam 6"].ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                        alarmJam7 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[i]["Jam 7"].ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                        alarmJam8 = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[i]["Jam 8"].ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                        alarmJamMasuk = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[i]["Jam Masuk"].ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                        alarmJamIstirahat = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[i]["Istirahat"].ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                        alarmJamPulang = Convert.ToDateTime(jadwalDataSet.Tables[0].Rows[i]["Jam Pulang"].ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                    }
                }
            }
            if (jadwalDataSet.Tables[0].Rows.Count == 6) 
            {
                inputData.Visible = false;
                updateData.Visible = true;
                deleteData.Visible = true;
            }
            if (jadwalDataSet.Tables[0].Rows.Count == 0)
            {
                inputData.Visible = true;
                updateData.Visible = false;
                deleteData.Visible = false;
            }

            if (alarmset == alarmJamMasuk)
            {
                alarmStatus.Text = "Jam Masuk";
                playAlarm(@"alarm\bellMasuk.wav",clocknow, alarmJamMasuk + ":00"); //changed from alarmBell.Play();
            }
            else if (alarmset == alarmJamIstirahat)
            {
                alarmStatus.Text = "Jam Istirahat";
                playAlarm(@"alarm\bellIstirahat.wav", clocknow, alarmJamIstirahat + ":00"); //changed from alarmBell.Play();
            }
            else if (alarmset == alarmJamPulang)
            {
                alarmStatus.Text = "Jam Pulang";
                playAlarm(@"alarm\bellPulang.wav", clocknow, alarmJamPulang + ":00"); //changed from alarmBell.Play();
            }
            else if (alarmset == alarmJam1)
            {
                alarmStatus.Text = "Jam Ke 1";
                playAlarm(@"alarm\bell1.wav",clocknow, alarmJam1 + ":00"); //changed from alarmBell.Play();
            }
            else if (alarmset == alarmJam2)
            {
                alarmStatus.Text = "Jam Ke 2";
                playAlarm(@"alarm\bell2.wav", clocknow, alarmJam2 + ":00"); //changed from alarmBell.Play();
            }
            else if (alarmset == alarmJam3)
            {
                alarmStatus.Text = "Jam Ke 3";
                playAlarm(@"alarm\bell3.wav", clocknow, alarmJam3 + ":00"); //changed from alarmBell.Play();
            }
            else if (alarmset == alarmJam4)
            {
                alarmStatus.Text = "Jam Ke 4";
                playAlarm(@"alarm\bell4.wav", clocknow, alarmJam4 + ":00"); //changed from alarmBell.Play();
            }
            else if (alarmset == alarmJam5)
            {
                alarmStatus.Text = "Jam Ke 5";
                playAlarm(@"alarm\bell5.wav", clocknow, alarmJam5 + ":00"); //changed from alarmBell.Play();
            }
            else if (alarmset == alarmJam6)
            {
                alarmStatus.Text = "Jam Ke 6";
                playAlarm(@"alarm\bell6.wav", clocknow, alarmJam6 + ":00"); //changed from alarmBell.Play();
            }
            else if (alarmset == alarmJam7)
            {
                alarmStatus.Text = "Jam Ke 7";
                playAlarm(@"alarm\bell7.wav", clocknow, alarmJam7 + ":00"); //changed from alarmBell.Play();
            }
            else if (alarmset == alarmJam8)
            {
                alarmStatus.Text = "Jam Ke 8";
                playAlarm(@"alarm\bell8.wav", clocknow, alarmJam8 + ":00"); //changed from alarmBell.Play();
            }
            else
            {
                alarmStatus.Text = "Alarm off";
            }
        }

        private void playAlarm(string filelocation,string clock, string starttime) //New Play Function
        {//
            alarmBell = new SoundPlayer(filelocation); //deklarasinya pindah kesini
            DateTime start = DateTime.ParseExact(starttime, "HH:mm:ss", CultureInfo.InvariantCulture); //start time
            DateTime stop = DateTime.ParseExact(starttime, "HH:mm:ss", CultureInfo.InvariantCulture).AddSeconds(duration); //stop time, add few second from start time
            DateTime now = DateTime.ParseExact(clock, "HH:mm:ss", CultureInfo.InvariantCulture); //current clock
            if ((now >= start) && (now < stop)) //check alarm by duration
            {//
                alarmBell.Play(); //play sound
            }//
            else if (now > stop) //stop ketika udh melebihi waktu
            {
                alarmBell.Stop(); //stop sound
            }
            else //others condition
            {//
                alarmBell.Stop(); //stop sound
            }//
        }//

        private void InputJam_Click(object sender, EventArgs e)
        {
            try
            {
                if (pilihHari.SelectedIndex != -1)
                {
                    DateTime input_jam_masuk = DateTime.ParseExact(jamMasuk.Text, "HH:mm", CultureInfo.InvariantCulture);
                    DateTime input_jam_pulang = DateTime.ParseExact(jamPulang.Text, "HH:mm", CultureInfo.InvariantCulture);
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
                        if (this.weeksDBTableAdapter.Insert(hariDalamSeminggu[pilihHari.SelectedIndex], input_jam_masuk, input_jam_1, input_jam_2, input_jam_3, input_jam_4, input_jam_5, input_jam_6, input_jam_7, input_jam_8, input_jam_istirahat, input_jam_pulang) == 1)
                        {
                            refresh();
                            MessageBox.Show("Input Data Sukses");
                        }
                    }
                    catch (OleDbException ex)
                    {
                        DialogResult updating_option = MessageBox.Show("Maaf Data Hari tersebut sudah ada", "Warning");
                    }
                    catch (FormatException format)
                    {
                        MessageBox.Show("Input Data tidak valid atau kosong");
                    }
                }
                else
                {
                    MessageBox.Show("Pilih terlebih dahulu harinya");
                }
            }
            catch (FormatException format)
            {
                MessageBox.Show("Input Data tidak valid atau kosong");
            }
        }

        private void TableJadwalView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int indexArrayHari = Array.FindIndex(hariDalamSeminggu, item => item == TableJadwalView.Rows[e.RowIndex].Cells[0].Value.ToString());
                pilihHari.SelectedIndex = indexArrayHari;
                buff_hari = hariDalamSeminggu[indexArrayHari];
                buff_alarmJamMasuk = Convert.ToDateTime(TableJadwalView.Rows[e.RowIndex].Cells[1].Value.ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                buff_alarmJamIstirahat = Convert.ToDateTime(TableJadwalView.Rows[e.RowIndex].Cells[10].Value.ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                buff_alarmJamPulang = Convert.ToDateTime(TableJadwalView.Rows[e.RowIndex].Cells[11].Value.ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                buff_alarmJam1 = Convert.ToDateTime(TableJadwalView.Rows[e.RowIndex].Cells[2].Value.ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                buff_alarmJam2 = Convert.ToDateTime(TableJadwalView.Rows[e.RowIndex].Cells[3].Value.ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                buff_alarmJam3 = Convert.ToDateTime(TableJadwalView.Rows[e.RowIndex].Cells[4].Value.ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                buff_alarmJam4 = Convert.ToDateTime(TableJadwalView.Rows[e.RowIndex].Cells[5].Value.ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                buff_alarmJam5 = Convert.ToDateTime(TableJadwalView.Rows[e.RowIndex].Cells[6].Value.ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                buff_alarmJam6 = Convert.ToDateTime(TableJadwalView.Rows[e.RowIndex].Cells[7].Value.ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                buff_alarmJam7 = Convert.ToDateTime(TableJadwalView.Rows[e.RowIndex].Cells[8].Value.ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");
                buff_alarmJam8 = Convert.ToDateTime(TableJadwalView.Rows[e.RowIndex].Cells[9].Value.ToString(), CultureInfo.InvariantCulture).ToString("HH:mm");

                jamMasuk.Text = buff_alarmJamMasuk;
                jamIstirahat.Text = buff_alarmJamIstirahat;
                jamPulang.Text = buff_alarmJamPulang;
                jamKe1.Text = buff_alarmJam1;
                jamKe2.Text = buff_alarmJam2;
                jamKe3.Text = buff_alarmJam3;
                jamKe4.Text = buff_alarmJam4;
                jamKe5.Text = buff_alarmJam5;
                jamKe6.Text = buff_alarmJam6;
                jamKe7.Text = buff_alarmJam7;
                jamKe8.Text = buff_alarmJam8;

                tmp_alarmJam1 = DateTime.ParseExact(buff_alarmJam1, "HH:mm", CultureInfo.InvariantCulture);
                tmp_alarmJam2 = DateTime.ParseExact(buff_alarmJam2, "HH:mm", CultureInfo.InvariantCulture);
                tmp_alarmJam3 = DateTime.ParseExact(buff_alarmJam3, "HH:mm", CultureInfo.InvariantCulture);
                tmp_alarmJam4 = DateTime.ParseExact(buff_alarmJam4, "HH:mm", CultureInfo.InvariantCulture);
                tmp_alarmJam5 = DateTime.ParseExact(buff_alarmJam5, "HH:mm", CultureInfo.InvariantCulture);
                tmp_alarmJam6 = DateTime.ParseExact(buff_alarmJam6, "HH:mm", CultureInfo.InvariantCulture);
                tmp_alarmJam7 = DateTime.ParseExact(buff_alarmJam7, "HH:mm", CultureInfo.InvariantCulture);
                tmp_alarmJam8 = DateTime.ParseExact(buff_alarmJam8, "HH:mm", CultureInfo.InvariantCulture);
                tmp_alarmJamMasuk = DateTime.ParseExact(buff_alarmJamMasuk, "HH:mm", CultureInfo.InvariantCulture);
                tmp_alarmJamIstirahat = DateTime.ParseExact(buff_alarmJamIstirahat, "HH:mm", CultureInfo.InvariantCulture);
                tmp_alarmJamPulang = DateTime.ParseExact(buff_alarmJamPulang, "HH:mm", CultureInfo.InvariantCulture);
            }
            catch (FormatException format)
            {

            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
        }

        private void deleteData_Click(object sender, EventArgs e)
        {
            try
            {
                if (pilihHari.SelectedIndex != -1)
                {
                    DateTime input_jam_masuk = DateTime.ParseExact(jamMasuk.Text, "HH:mm", CultureInfo.InvariantCulture);
                    DateTime input_jam_pulang = DateTime.ParseExact(jamPulang.Text, "HH:mm", CultureInfo.InvariantCulture);
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
                        if (this.weeksDBTableAdapter.Delete(hariDalamSeminggu[pilihHari.SelectedIndex], input_jam_masuk, input_jam_1, input_jam_2, input_jam_3, input_jam_4, input_jam_5, input_jam_6, input_jam_7, input_jam_8, input_jam_istirahat, input_jam_pulang) == 1)
                        {
                            refresh();
                            MessageBox.Show("Delete Data Sukses");
                        }
                    }
                    catch (FormatException format)
                    {
                        MessageBox.Show("Input Data tidak valid atau kosong");
                    }
                }
                else
                {
                    MessageBox.Show("Input tidak sesuai atau kosong");
                }
            }
            catch (FormatException format)
            {
                MessageBox.Show("Input Data tidak valid atau kosong");
            }
        }

        private void updateData_Click(object sender, EventArgs e)
        {
            try
            {
                if (pilihHari.SelectedIndex != -1)
                {
                    DateTime input_jam_masuk = DateTime.ParseExact(jamMasuk.Text, "HH:mm", CultureInfo.InvariantCulture);
                    DateTime input_jam_pulang = DateTime.ParseExact(jamPulang.Text, "HH:mm", CultureInfo.InvariantCulture);
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
                        if (this.weeksDBTableAdapter.Update(hariDalamSeminggu[pilihHari.SelectedIndex], input_jam_masuk, input_jam_1, input_jam_2, input_jam_3, input_jam_4, input_jam_5, input_jam_6, input_jam_7, input_jam_8, input_jam_istirahat, input_jam_pulang, buff_hari, tmp_alarmJamMasuk, tmp_alarmJam1, tmp_alarmJam2, tmp_alarmJam3, tmp_alarmJam4, tmp_alarmJam5, tmp_alarmJam6, tmp_alarmJam7, tmp_alarmJam8, tmp_alarmJamIstirahat, tmp_alarmJamPulang) == 1)
                        {
                            refresh();
                            MessageBox.Show("Update Data Sukses");
                        }
                    }
                    catch (FormatException format)
                    {
                        MessageBox.Show("Input Data tidak valid atau kosong");
                    }
                }
                else
                {
                    MessageBox.Show("Input Data tidak valid atau kosong");
                }
            }
            catch (FormatException format)
            {
                MessageBox.Show("Input Data tidak valid atau kosong");
            }
        }
    }
}

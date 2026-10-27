using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hasta_Kayıt_Ekranı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adSoyad = textBox1.Text;
            string tcNo = textBox2.Text;
            string poliklinik = comboBox1.SelectedItem.ToString();
            string tarih = dateTimePicker1.Text;
            string doktor = comboBox2.SelectedItem.ToString();

            string tamBilgi = adSoyad + " - " + tcNo + " - " + poliklinik + " - " + tarih + " - " + doktor;

            listBox1.Items.Add(tamBilgi);

            MessageBox.Show("Kaydınız Başarıyla Oluşturuldu!");

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox1.Text = "";
            comboBox2.SelectedIndex = -1;
            comboBox2.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Focus();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem == null) return;

            string secilenPoliklinik = comboBox1.SelectedItem.ToString();

            if (secilenPoliklinik == "Dahiliye")
            {
                comboBox2.Items.Add("Dr. Berksoy Çimenci");
                comboBox2.Items.Add("Dr. Fikri Kaan");
            }
            else if (secilenPoliklinik == "Kardiyoloji")
            {
                comboBox2.Items.Add("Dr. Doğukan Özgel");
                comboBox2.Items.Add("Dr. Ahmetcan Yeşilçimen");
            }
            else if (secilenPoliklinik == "Travmatoloji")
            {
                comboBox2.Items.Add("Dr. Serkan Topaloğlu");
                comboBox2.Items.Add("Dr. Özcan Özeke");
            }
            else if (secilenPoliklinik == "Göz Hastalıkları")
            {
                comboBox2.Items.Add("Dr. Meryem Kara");
                comboBox2.Items.Add("Dr. Habibe Kafes");
            }
            else if (secilenPoliklinik == "Kulak Burun Boğaz (KBB)")
            {
                comboBox2.Items.Add("Dr. Ahmet Korkmaz");
                comboBox2.Items.Add("Dr. Fırat Özcan");
            }

            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }
        }
    }
}

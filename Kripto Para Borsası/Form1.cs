using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kripto_Para_Borsası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapılan işlemler");
            listBox1.Items.Add("Tarih:" + dateTimePicker1.Text);
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(comboBox2.Text);
            listBox1.Items.Add(comboBox3.Text);
            listBox1.Items.Add(comboBox4.Text);
            listBox1.Items.Add(comboBox5.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Kullanıcı adı"+ textBox1.Text);
            listBox1.Items.Add("Şifre:" + textBox2.Text);
            MessageBox.Show("Giriş Başarılı");
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace izmirkart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnBakiye_Click(object sender, EventArgs e)
        {
            Bakiye bk = new Bakiye();
            bk.Tutar = Convert.ToDouble(txtBakiye.Text);
            lblKalan.Text = Convert.ToString(bk.Tutar);
            MessageBox.Show("Bakiyeniz="+bk.Tutar);
            btnogrenci.Enabled = true;
            btnogretmen.Enabled = true;
            btntam.Enabled = true;
        }  
        private void btntam_Click(object sender, EventArgs e)
        {
           
            Tam t = new Tam();
            t.Tutar = Convert.ToDouble(lblKalan.Text);
            t.Tutar -= 3.40;
            lblKalan.Text = Convert.ToString(t.Tutar);
            MessageBox.Show("KalanBakiye=" + t.Tutar);
            btnogrenci.Enabled = false;
            btnogretmen.Enabled = false;

        }
        private void btnogrenci_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Tutar = Convert.ToDouble(lblKalan.Text);
            if (control == 0)
            {
                ogr.Tutar--;
            }
            else if (control < 5)
            {
                ogr.Tutar -= 3.40;
            }
            else if (control > 5 && control < 85)
            {
                ogr.Tutar -= 0.10;
            }
            else
            {
                ogr.Tutar--;
            }
            lblKalan.Text = Convert.ToString(ogr.Tutar);
            MessageBox.Show("KalanTutar=" + ogr.Tutar);
            btnogretmen.Enabled = false;
            btntam.Enabled = false;
            timer1.Start();
        }
        private void btnogretmen_Click(object sender, EventArgs e)
        { 
            Ogretmen ogrt = new Ogretmen();
            ogrt.Tutar = Convert.ToDouble(lblKalan.Text);
            ogrt.Tutar -= 1.70;
            lblKalan.Text = Convert.ToString(ogrt.Tutar);
            MessageBox.Show("KalanBakiye=" + ogrt.Tutar);
            btntam.Enabled = false;
            btnogrenci.Enabled = false;
        }
        int sayac = 0;
        int control;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            lblcontrol.Text = Convert.ToString(sayac);
            control = Convert.ToInt32(lblcontrol.Text);
        }
    }
}

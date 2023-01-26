using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ohjelmointi2_VK4_KT2_VKT3
{
    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;
        int arvaus;
        int numero;

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            numero = random.Next(0, 101);
        }

        private void btnArvaa_Click(object sender, EventArgs e)
        {
            int arvaus = int.Parse(tbLuku.Text); 
            
            if(tsslbArvaukset != null)
            tsslbArvaukset.Text = "Monestko arvaus: " + count.ToString(); 
            count++; // lisää arvauksia statusstrippiin

                if (arvaus > numero)
                {
                    tsslbIlmoitss.Text = ("Arvaus pienempi, yritä uudestaan");
                }
                else if (arvaus < numero)
                {
                    tsslbIlmoitss.Text = ("Arvaus suurempi, yritä uudestaan");
                }
                else if (arvaus == numero)
                {
                DialogResult = MessageBox.Show("Hyvin arvattu! Pisteesi:  " + Convert.ToString(count),
                    "Aloitetaanko alusta", MessageBoxButtons.YesNo); 
                    tbLuku.ReadOnly = true;

                    if (DialogResult == DialogResult.Yes)
                    {
                        Application.Restart(); // käynnistää uudestaan
                    }
                    else if (DialogResult == DialogResult.No)
                    {
                        Application.Exit(); //sulkee ohjelman
                    }
                    tbLuku.Clear();
                }  
        }

        private void tbLuku_Leave(object sender, EventArgs e)
        {
            int arvaus = int.Parse(tbLuku.Text);
            if (arvaus <= 0)
                tbLuku.Text = "0";
            else if (arvaus > 100)
                tbLuku.Text = "100";
        }

        private void tbLuku_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            if (tbLuku.Text.Length == 3 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        } // Sallii vain tietyn pituista ja vain numerot
        
        private void tsslbArvaukset_Click(object sender, EventArgs e)
        {
           
        }

        private void tbLuku_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsslbIlmoitss_Click(object sender, EventArgs e)
        {

        }
    }
}

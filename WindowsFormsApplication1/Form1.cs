using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          Hasil.ReadOnly = true;
            operasiHitung.Items.Add("Penambahan");
            operasiHitung.Items.Add("Pengurangan");
            operasiHitung.Items.Add("Perkalian");
            operasiHitung.Items.Add("Pembagian");
            operasiHitung.SelectedItem = "Penambahan";
        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }
        static int pembagian(int a, int b)
        {
            return a / b;
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            var a = Convert.ToInt32(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);
            string ambilOperasi = operasiHitung.Text;

            if (ambilOperasi == "Penambahan")
            {
              Hasil.Text = Convert.ToString(penambahan(a, b));
            }
            else if (ambilOperasi == "Pengurangan")
            {
                Hasil.Text = Convert.ToString(pengurangan(a, b));

            }
            else if (ambilOperasi == "Perkalian")
            {
                Hasil.Text = Convert.ToString(perkalian(a, b));

            }
            else
            {
                Hasil.Text = Convert.ToString(pembagian(a, b));
            }
        }
    }
}

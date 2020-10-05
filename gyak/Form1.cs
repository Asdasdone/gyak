using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyak
{
    public partial class frfmfo : Form
    {
        private double a,b,c;
        
        public frfmfo()
        {
            a = 0;
            b = 0;
            c = 0;
            
            InitializeComponent();
            tba.Text = a.ToString();
            tbb.Text = b.ToString();
            tbc.Text = c.ToString();
            lbharomsz.Items.Clear();
        }

        private void lbharomsz_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btntorol_Click(object sender, EventArgs e)
        {
            if (lbharomsz.Items.Count!=0)
            {
                lbharomsz.Items.Clear();
            }
        }

        private void btnfajl_Click(object sender, EventArgs e)
        {
            lbharomsz.Items.Clear();
            ofdnyit.ShowDialog();

        }

        private void btnkilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnszamol_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(tba.Text);
                b = double.Parse(tbb.Text);
                c = double.Parse(tbc.Text);
                StringBuilder szoveg = new StringBuilder();
                szoveg.Append("A: ");
                szoveg.Append(a.ToString());
                szoveg.Append("B: ");
                szoveg.Append(b.ToString());
                szoveg.Append("C: ");
                szoveg.Append(c.ToString());

                if (a == 0 || b == 0 || c == 0)
                {
                    MessageBox.Show("Az egyik oldal 0", "Nem létező háromszög", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(szoveg.ToString(), "ez most", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var h = new haromszog(a, b, c);
                    if (h.szerkesztheto)
                    {
                        MessageBox.Show("Kerület: " + h.kerulet + " Terület: " + h.terulet, "ez most", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nem szerkesztethető", "lol", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    foreach (var item in h.adatok())
                    {
                        lbharomsz.Items.Add(item);
                    }

                }
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message, "lol",MessageBoxButtons.OK, MessageBoxIcon.Error);
                tba.Focus();
            }
        }
    }
}

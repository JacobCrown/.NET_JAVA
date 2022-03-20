using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using konsola;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tB_N_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tB_N.Text, out int n))
                tB_N.BackColor = Color.LightSeaGreen;
            else
                tB_N.BackColor = Color.MediumVioletRed;
        }

        private void tB_Seed_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tB_Seed.Text, out int n))
                tB_Seed.BackColor = Color.LightSeaGreen;
            else
                tB_Seed.BackColor = Color.MediumVioletRed;
        }

        private void tB_C_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tB_C.Text, out int n))
                tB_C.BackColor = Color.LightSeaGreen;
            else
                tB_C.BackColor = Color.MediumVioletRed;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tB_N.Text);
            int c = int.Parse(tB_C.Text);
            int seed = int.Parse(tB_N.Text);
            Problem p = new Problem(n, seed, c);
            p.generateSeedValues();
            tB_big.Text = "Przed sortowaniem:\r\n";
            tB_big.Text += p.ToString() + "\r\n";
            tB_big.Text += "Po sortowaniu:\r\n";
            p.items.Sort(delegate (Item x, Item y)
            {
                return (y.w * y.val).CompareTo(x.w * x.val);
            });
            tB_big.Text += p.ToString() + "\r\n";
            tB_big.Text += p.solveProblemForGUI();
        }

    }
}

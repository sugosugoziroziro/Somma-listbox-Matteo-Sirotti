using Frazioni;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Somma_listbox_Matteo_Sirotti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            if (Fraction.TryParse(tbx1.Text)==true)
            {
                lst1.Items.Add(Fraction.Parse(tbx1.Text));

            }
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            if (lst1.Items.Count>=2)
            {
                Fraction f =(Fraction)lst1.Items[0];
                for (int i=1; i<=lst1.Items.Count-1; i++)
                {
                    f = f.Somma((Fraction)lst1.Items[i]);
                }
                lbl1.Text=f.ToString();
            }
        }
    }
}

using AplicatieBiblioteca.Models;
using AplicatieBiblioteca.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieBiblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Utilizator utilizator = new Utilizator("1;1;Sava Tudor;tutor@gmail.com;tudor");
            this.Controls.Add(new PnlBibliotecar(this,utilizator));

        }

        public void removePnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {

                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);
        }

    }
}

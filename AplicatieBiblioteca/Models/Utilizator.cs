using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AplicatieBiblioteca.Models
{
    internal class Utilizator
    {

        private int id;
        private int tip;
        private string nume;
        private string email;
        private string parola;

        public Utilizator(int id, int tip, string nume, string email, string parola)
        {
            this.id = id;
            this.tip = tip;
            this.nume = nume;
            this.email = email;
            this.parola = parola;
        }

        public Utilizator(string text)
        {

            string[] prop = text.Split(';');

            this.id = int.Parse(prop[0]);
            this.tip = int.Parse(prop[1]);
            this.nume = prop[2];
            this.email = prop[3];
            if(tip == 1)
            this.parola = prop[4];

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Tip
        {
            get { return tip; }
            set { tip = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Parola
        {
            get { return parola; }
            set { parola = value; }
        }


    }
}

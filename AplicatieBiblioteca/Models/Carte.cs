using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieBiblioteca.Models
{
    internal class Carte
    {

        private int id;
        private string name;
        private string autor;
        private int nrPagini;

        public Carte(int id, string name, string autor, int nrPagini)
        {
            this.id = id;
            this.name = name;
            this.autor = autor;
            this.nrPagini = nrPagini;
        }

        public Carte(string text)
        {

            string[] prop = text.Split(';');

            this.id = int.Parse(prop[0]);
            this.name = prop[1];
            this.autor = prop[2];
            this.nrPagini = int.Parse(prop[3]);

        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Autor
        {
            get { return this.autor; }
            set { this.autor = value; }
        }

        public int NrPagini
        {
            get { return this.nrPagini; }
            set { this.nrPagini = value;}
        }


    }
}

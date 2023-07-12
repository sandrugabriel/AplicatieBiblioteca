using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieBiblioteca.Models
{
    internal class Imprumut
    {

        private int id;
        private int idUtilizator;
        private int idCarte;
        private DateTime dataStart;
        private DateTime dataRestituire;
        public Imprumut(int id, int idUtilizator, int idCarte, DateTime dataStart, DateTime dataRestituire)
        {
            this.id = id;
            this.idUtilizator = idUtilizator;
            this.idCarte = idCarte;
            this.dataStart = dataStart;
            this.dataRestituire = dataRestituire;
        }

        public Imprumut(string text)
        {

            string[] prop = text.Split(';');

            this.id = int.Parse(prop[0]);
            this.idUtilizator = int.Parse(prop[1]);
            this.idCarte = int.Parse(prop[2]);
            this.dataStart = DateTime.Parse(prop[3]);
            this.dataRestituire = DateTime.Parse(prop[4]);

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdUtilizator
        {
            get { return idUtilizator; }
            set { idUtilizator = value; }
        }

        public int IdCarte
        {
            get { return idCarte; }
            set { idCarte = value; }
        }

        public DateTime DataStart
        {
            get { return dataStart; }
            set { dataStart = value; }
        }

        public DateTime DataRestituire
        {
            get { return dataRestituire; }
            set { dataRestituire = value; }
        }


    }
}

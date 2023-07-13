using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AplicatieBiblioteca.Models
{
    internal class Rezervare
    {

        private int id;
        private int idCititor;
        private int idCarte;
        private DateTime dataRezervare;
        private int startus;

        public Rezervare(int id, int idCititor, int idCarte, DateTime dataRezervare, int startus)
        {
            this.id = id;
            this.idCititor = idCititor;
            this.idCarte = idCarte;
            this.dataRezervare = dataRezervare;
            this.startus = startus;
        }

        public Rezervare(string text) {

            string[] prop = text.Split(';');

            this.id = int.Parse(prop[0]);
            this.idCititor = int.Parse(prop[1]);
            this.idCarte = int.Parse(prop[2]);
            this.dataRezervare = DateTime.Parse(prop[3]);
            this.startus = int.Parse(prop[4]);
        
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int IdCititor
        {
            get { return idCititor; }
            set { idCititor = value; }
        }

        public int IdCarte
        {
            get { return idCarte; }
            set { idCarte = value; }
        }

        public DateTime DataRezervari
        {
            get { return dataRezervare; }
            set { dataRezervare = value; }
        }

        public int Status
        {
            get { return startus; }
            set { startus = value; }
        }

        public string toSave()
        {
            return Id.ToString() + ";"+ IdCititor.ToString() + ";" + IdCarte.ToString() + ";" + DataRezervari.ToString() + ";" + Status.ToString();
        }
    }
}

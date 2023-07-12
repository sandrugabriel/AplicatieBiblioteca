using AplicatieBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieBiblioteca.Controllers
{
    internal class ControllerRezervari
    {

        private List<Rezervare> rezervari;

        public ControllerRezervari()
        {

            rezervari = new List<Rezervare>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/rezervari.txt";
            StreamReader streamReader = new StreamReader(path);
            string t;

            while((t = streamReader.ReadLine()) != null)
            {
                Rezervare rezervare = new Rezervare(t);
                rezervari.Add(rezervare);
            }
            streamReader.Close();
        }

    }
}

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
    internal class ControllerCarti
    {

        private List<Carte> carti;

        public ControllerCarti() {
        
            carti = new List<Carte>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/carti.txt";
            StreamReader streamReader = new StreamReader(path);

            string t;

            while ((t = streamReader.ReadLine()) != null)
            {
                Carte carte = new Carte(t);
                carti.Add(carte);

            }
            streamReader.Close();
        }


    }
}

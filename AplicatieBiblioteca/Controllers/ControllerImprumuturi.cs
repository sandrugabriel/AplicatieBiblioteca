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
    internal class ControllerImprumuturi
    {

        private List<Imprumut> imprumuturi;

        public ControllerImprumuturi() { 
        
            imprumuturi = new List<Imprumut>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/imprumuturi.txt";
            StreamReader streamReader = new StreamReader(path);

            string t;

            while ((t = streamReader.ReadLine()) != null)
            {
                Imprumut imprumut = new Imprumut(t);
                imprumuturi.Add(imprumut);
            }
            streamReader.Close();
        }

    }
}

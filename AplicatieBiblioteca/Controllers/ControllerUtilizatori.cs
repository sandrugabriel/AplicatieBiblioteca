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
    internal class ControllerUtilizatori
    {

        private List<Utilizator> utilizatori;

        public ControllerUtilizatori()
        {

            utilizatori = new List<Utilizator>();

            load();

        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/utilizatori.txt";
            StreamReader streamReader = new StreamReader(path);

            string t;

            while((t = streamReader.ReadLine()) != null)
            {
                Utilizator utilizator = new Utilizator(t);
                utilizatori.Add(utilizator);
            }
            streamReader.Close();   
        }

        public bool verificare(string email, string parola)
        {

            for(int i=0;i<utilizatori.Count;i++)
            {

                if (email.Equals(utilizatori[i].Email) && parola.Equals(utilizatori[i].Parola))
                {
                    return true;
                }

            }

            return false;
        }

        public Utilizator getUtilizator(string email, string parola)
        {

            for (int i = 0; i < utilizatori.Count; i++)
            {

                if (email.Equals(utilizatori[i].Email) && parola.Equals(utilizatori[i].Parola))
                {
                    return utilizatori[i];
                }

            }

            return null;
        }


    }
}

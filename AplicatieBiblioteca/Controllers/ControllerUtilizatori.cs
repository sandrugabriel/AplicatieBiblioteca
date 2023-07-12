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

        public Utilizator getClientById(int id)
        {

            for (int i = 0; i < utilizatori.Count; i++)
            {
                if (utilizatori[i].Id == id)
                {
                    return utilizatori[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getClientById(id) != null)
            {

                id = random.Next();

            }


            return id;

        }

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/utilizatori.txt";
            File.AppendAllText(path, text + "\n");


        }


    }
}

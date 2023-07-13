using AplicatieBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/rezervari.txt";
            File.AppendAllText(path, text + "\n");


        }

        public List<Rezervare> getClientRezervare(int idClient)
        {

            List<Rezervare> list = new List<Rezervare>();

            for (int i = 0; i < rezervari.Count; i++)
            {
                //   MessageBox.Show(imprumuturi[i].IdUtilizator.ToString());
                if (rezervari[i].IdCititor == idClient) list.Add(rezervari[i]);
            }

            return list;
        }

        public string toSaveFisier()
        {

            string t = "";

            for (int i = 0; i < rezervari.Count; i++)
            {
                t += rezervari[i].toSave() + "\n";
            }

            return t;
        }

        public int pozID(int id)
        {

            for (int i = 0; i < rezervari.Count; i++)
            {
                if (rezervari[i].Id == id)
                {
                    return i;
                }
            }

            return -1;
        }

        public void stergere(int id)
        {
            int p = pozID(id);
            if (p == pozID(id))
                rezervari.RemoveAt(p);

        }

        public void delete(int id)
        {
            this.stergere(id);

            string path = Application.StartupPath + @"/data/rezervari.txt";
            StreamWriter stream = new StreamWriter(path);

            stream.Write(this.toSaveFisier());

            stream.Close();
        }


        public Rezervare getImprById(int id)
        {

            for (int i = 0; i < rezervari.Count; i++)
            {
                if (rezervari[i].Id == id)
                {
                    return rezervari[i];
                }
            }

            return null;
        }

        public int generareId()
        {
            Random random = new Random();

            int id = random.Next();
            while (this.getImprById(id) != null)
            {

                id = random.Next();

            }


            return id;

        }

    }
}

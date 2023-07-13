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

        public List<Imprumut> getClientImprumut(int idClient)
        {

            List<Imprumut> list = new List<Imprumut>();

            for(int i = 0; i < imprumuturi.Count; i++)
            {
             //   MessageBox.Show(imprumuturi[i].IdUtilizator.ToString());
                if (imprumuturi[i].IdUtilizator == idClient) list.Add(imprumuturi[i]);
            }

            return list;
        }

        public string toSaveFisier()
        {

            string t = "";

            for (int i = 0; i < imprumuturi.Count; i++)
            {
                t += imprumuturi[i].toSave() + "\n";
            }

            return t;
        }

        public int pozID(int id)
        {

            for (int i = 0; i < imprumuturi.Count; i++)
            {
                if (imprumuturi[i].Id == id)
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
                imprumuturi.RemoveAt(p);

        }

        public void delete(int id)
        {
            this.stergere(id);

            string path = Application.StartupPath + @"/data/imprumuturi.txt";
            StreamWriter stream = new StreamWriter(path);

            stream.Write(this.toSaveFisier());

            stream.Close();
        }

        public Imprumut getImprById(int id)
        {

            for (int i = 0; i < imprumuturi.Count; i++)
            {
                if (imprumuturi[i].Id == id)
                {
                    return imprumuturi[i];
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

        public void save(string textul)
        {

            string text = textul;
            string path = Application.StartupPath + @"/data/imprumuturi.txt";
            File.AppendAllText(path, text + "\n");


        }


    }
}

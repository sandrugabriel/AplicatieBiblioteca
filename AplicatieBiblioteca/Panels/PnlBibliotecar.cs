using AplicatieBiblioteca.Controllers;
using AplicatieBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieBiblioteca.Panels
{
    internal class PnlBibliotecar:Panel
    {

        Form1 form;
        Utilizator utilizator;

        private System.Windows.Forms.PictureBox pctPoza;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInregistrare;
        private System.Windows.Forms.TabPage tabAfisare;
        private System.Windows.Forms.TabPage tabCititor;

        ControllerUtilizatori controllerUtilizatori;

        private System.Windows.Forms.TextBox txtReParola;
        private System.Windows.Forms.Label lblReParola;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNumele;
        private System.Windows.Forms.Label lblNumele;
        private System.Windows.Forms.RadioButton radioCititor;
        private System.Windows.Forms.RadioButton radioBibliotecar;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.Button btnInregistarare;

        private List<string> erori;


        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnFiltreaza;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNumelePrenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbNume;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbEmail;
        private System.Windows.Forms.DataGridViewButtonColumn cmbAfisaza;

        private List<Utilizator> cititorii;

        public PnlBibliotecar(Form1 form1, Utilizator utilizator1)
        {
            this.form = form1;
            this.utilizator = utilizator1;
            this.form.Size = new System.Drawing.Size(1300, 823);
            this.form.MinimumSize = new System.Drawing.Size(1300, 823);
            this.form.MaximumSize = new System.Drawing.Size(1300, 823);
            this.form.Location = new Point(0, 0);
            this.form.WindowState = FormWindowState.Maximized;
            this.erori = new List<string>();
            this.cititorii = new List<Utilizator>();
            this.controllerUtilizatori = new ControllerUtilizatori();

            //PnlBibliotecar
            this.Size = new System.Drawing.Size(1300, 823);
            this.Name = "PnlBibliotecar";

            this.pctPoza = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInregistrare = new System.Windows.Forms.TabPage();
            this.tabAfisare = new System.Windows.Forms.TabPage();
            this.tabCititor = new System.Windows.Forms.TabPage();
            this.lblNumele = new System.Windows.Forms.Label();
            this.txtNumele = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtReParola = new System.Windows.Forms.TextBox();
            this.lblReParola = new System.Windows.Forms.Label();
            this.radioBibliotecar = new System.Windows.Forms.RadioButton();
            this.radioCititor = new System.Windows.Forms.RadioButton();
            this.btnInregistarare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.btnFiltreaza = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNumelePrenume = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cmbId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbAfisaza = new System.Windows.Forms.DataGridViewButtonColumn();

            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pctPoza);

            // pctPoza
            this.pctPoza.Location = new System.Drawing.Point(38, 12);
            this.pctPoza.Name = "pctPoza";
            this.pctPoza.Size = new System.Drawing.Size(130, 130);
            this.pctPoza.Image = Image.FromFile(Application.StartupPath + @"/Imagini/utilizatori/" + utilizator.Id.ToString() + ".jpg");
            this.pctPoza.SizeMode = PictureBoxSizeMode.StretchImage;

            // lblData
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblData.Location = new System.Drawing.Point(1000, 35);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(66, 32);
            this.lblData.Text = "Data: " + DateTime.Now;

            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.lblNume.Location = new System.Drawing.Point(221, 61);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(198, 39);
            this.lblNume.Text = "Bibilotecar = " + utilizator.Nume;

            // tabControl1
            this.tabControl1.Controls.Add(this.tabInregistrare);
            this.tabControl1.Controls.Add(this.tabAfisare);
            this.tabControl1.Controls.Add(this.tabCititor);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(15, 162);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1352, 709);

            // tabInregistrare
            this.tabInregistrare.Controls.Add(this.btnRenuntare);
            this.tabInregistrare.Controls.Add(this.btnInregistarare);
            this.tabInregistrare.Controls.Add(this.radioCititor);
            this.tabInregistrare.Controls.Add(this.radioBibliotecar);
            this.tabInregistrare.Controls.Add(this.txtReParola);
            this.tabInregistrare.Controls.Add(this.lblReParola);
            this.tabInregistrare.Controls.Add(this.txtParola);
            this.tabInregistrare.Controls.Add(this.lblParola);
            this.tabInregistrare.Controls.Add(this.txtEmail);
            this.tabInregistrare.Controls.Add(this.lblEmail);
            this.tabInregistrare.Controls.Add(this.txtNumele);
            this.tabInregistrare.Controls.Add(this.lblNumele);
            this.tabInregistrare.Location = new System.Drawing.Point(4, 36);
            this.tabInregistrare.Name = "tabInregistrare";
            this.tabInregistrare.Padding = new System.Windows.Forms.Padding(3);
            this.tabInregistrare.Size = new System.Drawing.Size(1344, 669);
            this.tabInregistrare.Text = "Inregistrare";

            // tabAfisare
            this.tabAfisare.Controls.Add(this.btnFiltreaza);
            this.tabAfisare.Controls.Add(this.txtNume);
            this.tabAfisare.Controls.Add(this.lblNumelePrenume);
            this.tabAfisare.Controls.Add(this.dataGridView);
            this.tabAfisare.Location = new System.Drawing.Point(4, 36);
            this.tabAfisare.Name = "tabAfisare";
            this.tabAfisare.Padding = new System.Windows.Forms.Padding(3);
            this.tabAfisare.Size = new System.Drawing.Size(1344, 669);
            this.tabAfisare.Text = "AfisareCititor ";

            // tabCititor
            this.tabCititor.Location = new System.Drawing.Point(4, 25);
            this.tabCititor.Name = "tabCititor";
            this.tabCititor.Size = new System.Drawing.Size(1344, 680);
            this.tabCititor.Text = "Cititor";

            // lblNumele
            this.lblNumele.AutoSize = true;
            this.lblNumele.Location = new System.Drawing.Point(72, 52);
            this.lblNumele.Name = "lblNumele";
            this.lblNumele.Size = new System.Drawing.Size(175, 27);
            this.lblNumele.Text = "Nume si prenume";

            // txtNumele
            this.txtNumele.Location = new System.Drawing.Point(77, 93);
            this.txtNumele.Name = "txtNumele";
            this.txtNumele.Size = new System.Drawing.Size(294, 34);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(459, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(294, 34);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(454, 52);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 27);
            this.lblEmail.Text = "Email";

            // txtParola
            this.txtParola.Location = new System.Drawing.Point(77, 212);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(294, 34);

            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Location = new System.Drawing.Point(72, 171);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(69, 27);
            this.lblParola.Text = "Parola";

            // txtReParola
            this.txtReParola.Location = new System.Drawing.Point(459, 212);
            this.txtReParola.Name = "txtReParola";
            this.txtReParola.Size = new System.Drawing.Size(294, 34);

            // lblReParola
            this.lblReParola.AutoSize = true;
            this.lblReParola.Location = new System.Drawing.Point(454, 171);
            this.lblReParola.Name = "lblReParola";
            this.lblReParola.Size = new System.Drawing.Size(176, 27);
            this.lblReParola.Text = "Confirmare Parola";

            // radioBibliotecar
            this.radioBibliotecar.AutoSize = true;
            this.radioBibliotecar.Location = new System.Drawing.Point(77, 301);
            this.radioBibliotecar.Name = "radioBibliotecar";
            this.radioBibliotecar.Size = new System.Drawing.Size(126, 31);
            this.radioBibliotecar.Text = "Bibliotecar";
            this.radioBibliotecar.Checked = true;

            // radioCititor
            this.radioCititor.AutoSize = true;
            this.radioCititor.Location = new System.Drawing.Point(263, 301);
            this.radioCititor.Name = "radioCititor";
            this.radioCititor.Size = new System.Drawing.Size(85, 31);
            this.radioCititor.Text = "Cititor";

            // btnInregistarare
            this.btnInregistarare.Location = new System.Drawing.Point(103, 494);
            this.btnInregistarare.Name = "btnInregistarare";
            this.btnInregistarare.Size = new System.Drawing.Size(175, 68);
            this.btnInregistarare.Text = "Inregistrare";
            this.btnInregistarare.Click += new EventHandler(btnInregistarare_Click);

            // btnRenuntare
            this.btnRenuntare.Location = new System.Drawing.Point(425, 494);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(175, 68);
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.Click += new EventHandler(btnRenuntare_Click);

            // btnFiltreaza
            this.btnFiltreaza.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.btnFiltreaza.Location = new System.Drawing.Point(218, 482);
            this.btnFiltreaza.Name = "btnFiltreaza";
            this.btnFiltreaza.Size = new System.Drawing.Size(167, 64);
            this.btnFiltreaza.Text = "Filtreaza";
            this.btnFiltreaza.Click += new EventHandler(btnFiltreaza_Click);

            // txtNume
            this.txtNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.txtNume.Location = new System.Drawing.Point(122, 404);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(398, 40);

            // lblNumelePrenume
            this.lblNumelePrenume.AutoSize = true;
            this.lblNumelePrenume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.lblNumelePrenume.Location = new System.Drawing.Point(173, 353);
            this.lblNumelePrenume.Name = "lblNumelePrenume";
            this.lblNumelePrenume.Size = new System.Drawing.Size(306, 39);
            this.lblNumelePrenume.Text = "Numele si prenumele";

            // dataGridView
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbId,
            this.cmbNume,
            this.cmbEmail,
            this.cmbAfisaza});
            this.dataGridView.Location = new System.Drawing.Point(15, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(865, 307);
            this.dataGridView.CellContentClick += new DataGridViewCellEventHandler(dataGridView_CellContentClick);

            // cmbId
            this.cmbId.HeaderText = "Id";
            this.cmbId.Name = "cmbId";
            this.cmbId.ReadOnly = true;
            this.cmbId.Width = 150;

            // cmbNume
            this.cmbNume.HeaderText = "NumePrenume";
            this.cmbNume.Name = "cmbNume";
            this.cmbNume.ReadOnly = true;
            this.cmbNume.Width = 230;

            // cmbEmail
            this.cmbEmail.HeaderText = "Email";
            this.cmbEmail.Name = "cmbEmail";
            this.cmbEmail.ReadOnly = true;
            this.cmbEmail.Width = 230;

            // cmbAfisaza
            this.cmbAfisaza.HeaderText = "Afiseaza";
            this.cmbAfisaza.Name = "cmbAfisaza";
            this.cmbAfisaza.ReadOnly = true;
            this.cmbAfisaza.Width = 185;

            cititorii = controllerUtilizatori.getCititorii();

            for (int i = 0; i < cititorii.Count; i++)
            {
                dataGridView.Rows.Add(cititorii[i].Id, cititorii[i].Nume, cititorii[i].Email, "Afizare");
            }


        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {

            this.form.removePnl("PnlBibliotecar");
            this.form.Controls.Add(new PnlBibliotecar(form,utilizator));

        }

        public void verificare()
        {
            erori.Clear();


            if (txtEmail.Text.Equals(""))
            {
                erori.Add("Nu ati introdus emailul!");
            }

            if (txtNumele.Text.Equals(""))
            {
                erori.Add("Nu ati introdus numele!");
            }

            if (txtParola.Text.Equals(""))
            {
                erori.Add("Nu ati introdus parola!");
            }

            if (!txtReParola.Text.Equals(txtParola.Text))
            {
                erori.Add("Nu ati introuds corect parola!");
            }

        }

        private void btnInregistarare_Click(Object sender, EventArgs e)
        {
            verificare();

            if(erori.Count > 0)
            {

                for(int i = 0; i < erori.Count; i++)
                {
                    MessageBox.Show(erori[i], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                int id = controllerUtilizatori.generareId();
                string nume = txtNumele.Text;
                string email = txtEmail.Text;
                string parola = txtParola.Text;
                int tip = 1;
                if (radioBibliotecar.Checked) tip = 2;
                string t = id.ToString() + ";" + tip.ToString() + ";" + nume + ";" + email + ";" + parola;
                Utilizator nou = new Utilizator(id, tip, nume, email, parola);
                controllerUtilizatori.save(t);
                this.form.removePnl("PnlBibliotecar");
                this.form.Controls.Add(new PnlBibliotecar(form, utilizator));
            }



        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["cmbId"].Value.ToString());

                Utilizator nou = controllerUtilizatori.findbyId(id);

                tabControl1.SelectedIndex = 2;
            }
        }

        private void btnFiltreaza_Click(object sender, EventArgs e)
        {

            if (txtNume.Text.Equals(""))
            {
                cititorii.Clear();
                cititorii = controllerUtilizatori.getCititorii();
                dataGridView.Rows.Clear();

                for (int i = 0; i < cititorii.Count; i++)
                {
                    dataGridView.Rows.Add(cititorii[i].Id, cititorii[i].Nume, cititorii[i].Email, "Afizare");
                }

            }
            else
            {

                cititorii.Clear();
                cititorii = controllerUtilizatori.getCititoriiFiltrare(txtNume.Text);
                dataGridView.Rows.Clear();

                for (int i = 0; i < cititorii.Count; i++)
                {
                    dataGridView.Rows.Add(cititorii[i].Id, cititorii[i].Nume, cititorii[i].Email, "Afizare");
                }

            }

            


        }

    }
}

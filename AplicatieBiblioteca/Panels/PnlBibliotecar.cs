using AplicatieBiblioteca.Controllers;
using AplicatieBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
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


        private System.Windows.Forms.Label lblRezervare;
        private System.Windows.Forms.Label lblCititor;
        private System.Windows.Forms.Label lblImprumuturi;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabImprumutate;
        private System.Windows.Forms.TabPage tabRezervate;
        private System.Windows.Forms.DataGridView dataGridViewImp;
        private System.Windows.Forms.TabPage tabImprumut;
        private System.Windows.Forms.TabPage tabGenerare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbIdImp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbIdCarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbTitlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbDataImp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbExp;
        private System.Windows.Forms.DataGridViewButtonColumn cmbRest;
        private System.Windows.Forms.DataGridView dataGridViewRezervare;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbReze;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbRezIdCarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbRezTitlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbRezAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbRezDataImp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbRezExp;
        private System.Windows.Forms.DataGridViewButtonColumn cmbAnuleaza;
        private System.Windows.Forms.DataGridViewButtonColumn cmbRezImprumut;
        private System.Windows.Forms.DataGridView dataGridViewCarteImp;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbImpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbImpTitlu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbImpAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmbNrPagini;
        private System.Windows.Forms.DataGridViewButtonColumn cmbImpRezerva;
        private System.Windows.Forms.DataGridViewButtonColumn cmbImpImp;

        Utilizator nou;

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
            nou = null;

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

            this.lblCititor = new System.Windows.Forms.Label();
            this.lblRezervare = new System.Windows.Forms.Label();
            this.lblImprumuturi = new System.Windows.Forms.Label();
            this.dataGridViewImp = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabImprumutate = new System.Windows.Forms.TabPage();
            this.tabRezervate = new System.Windows.Forms.TabPage();
            this.tabImprumut = new System.Windows.Forms.TabPage();
            this.tabGenerare = new System.Windows.Forms.TabPage();
            this.cmbIdImp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbIdCarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTitlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbDataImp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRest = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewRezervare = new System.Windows.Forms.DataGridView();
            this.cmbReze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRezIdCarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRezTitlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRezAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRezDataImp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbRezExp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbAnuleaza = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbRezImprumut = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewCarteImp = new System.Windows.Forms.DataGridView();
            this.cmbImpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbImpTitlu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbImpAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbNrPagini = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbImpRezerva = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbImpImp = new System.Windows.Forms.DataGridViewButtonColumn();

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
            //this.tabControl1.Controls.Add(this.tabCititor);
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
            this.tabCititor.Controls.Add(this.tabControl2);
            this.tabCititor.Controls.Add(this.lblImprumuturi);
            this.tabCititor.Controls.Add(this.lblRezervare);
            this.tabCititor.Controls.Add(this.lblCititor);
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


            this.tabControl1.Controls.Add(this.tabCititor);


            // dataGridViewImp
            this.dataGridViewImp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbIdImp,
            this.cmbIdCarte,
            this.cmbTitlu,
            this.cmbAutor,
            this.cmbDataImp,
            this.cmbExp,
            this.cmbRest});
            this.dataGridViewImp.Location = new System.Drawing.Point(6, 18);
            this.dataGridViewImp.Name = "dataGridViewImp";
            this.dataGridViewImp.RowHeadersWidth = 51;
            this.dataGridViewImp.RowTemplate.Height = 24;
            this.dataGridViewImp.Size = new System.Drawing.Size(1245, 241);
            this.dataGridViewImp.CellContentClick += new DataGridViewCellEventHandler(dataGridViewImp_CellContentClick);

            // dataGridViewRezervare
            this.dataGridViewRezervare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbReze,
            this.cmbRezIdCarte,
            this.cmbRezTitlu,
            this.cmbRezAutor,
            this.cmbRezDataImp,
            this.cmbRezExp,
            this.cmbAnuleaza,
            this.cmbRezImprumut});
            this.dataGridViewRezervare.Location = new System.Drawing.Point(6, 18);
            this.dataGridViewRezervare.Name = "dataGridViewRezervare";
            this.dataGridViewRezervare.RowHeadersWidth = 51;
            this.dataGridViewRezervare.RowTemplate.Height = 24;
            this.dataGridViewRezervare.Size = new System.Drawing.Size(1245, 241);
            this.dataGridViewRezervare.CellContentClick += new DataGridViewCellEventHandler(dataGridViewRezervare_CellContentClick);


            // dataGridViewCarteImp
            this.dataGridViewCarteImp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarteImp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbImpId,
            this.cmbImpTitlu,
            this.cmbImpAutor,
            this.cmbNrPagini,
            this.cmbImpRezerva,
            this.cmbImpImp});
            this.dataGridViewCarteImp.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewCarteImp.Name = "dataGridViewCarteImp";
            this.dataGridViewCarteImp.RowHeadersWidth = 51;
            this.dataGridViewCarteImp.RowTemplate.Height = 24;
            this.dataGridViewCarteImp.Size = new System.Drawing.Size(1245, 241);
            this.dataGridViewCarteImp.CellContentClick += new DataGridViewCellEventHandler(dataGridViewCarteImp_CellContentClick);
            this.dataGridViewCarteImp.CellDoubleClick += new DataGridViewCellEventHandler(dataGridViewCarteImp_CellDoubleClick);

            // tabControl2
            this.tabControl2.Controls.Add(this.tabImprumutate);
            this.tabControl2.Controls.Add(this.tabRezervate);
            this.tabControl2.Controls.Add(this.tabImprumut);
            this.tabControl2.Controls.Add(this.tabGenerare);
            this.tabControl2.Location = new System.Drawing.Point(5, 185);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1290, 381);
            this.tabControl2.TabIndex = 4;

            // tabImprumutate
            this.tabImprumutate.Controls.Add(this.dataGridViewImp);
            this.tabImprumutate.Location = new System.Drawing.Point(4, 36);
            this.tabImprumutate.Name = "tabImprumutate";
            this.tabImprumutate.Padding = new System.Windows.Forms.Padding(3);
            this.tabImprumutate.Size = new System.Drawing.Size(1282, 341);
            this.tabImprumutate.TabIndex = 0;
            this.tabImprumutate.Text = "CartiImprumutate";
            this.tabImprumutate.UseVisualStyleBackColor = true;

            // tabRezervate
            this.tabRezervate.Controls.Add(this.dataGridViewRezervare);
            this.tabRezervate.Location = new System.Drawing.Point(4, 36);
            this.tabRezervate.Name = "tabRezervate";
            this.tabRezervate.Padding = new System.Windows.Forms.Padding(3);
            this.tabRezervate.Size = new System.Drawing.Size(1282, 341);
            this.tabRezervate.TabIndex = 1;
            this.tabRezervate.Text = "CartiRezervate";
            this.tabRezervate.UseVisualStyleBackColor = true;

            // tabImprumut
            this.tabImprumut.Controls.Add(this.dataGridViewCarteImp);
            this.tabImprumut.Location = new System.Drawing.Point(4, 36);
            this.tabImprumut.Name = "tabImprumut";
            this.tabImprumut.Size = new System.Drawing.Size(1282, 341);
            this.tabImprumut.TabIndex = 2;
            this.tabImprumut.Text = "ImprumutaCarte";
            this.tabImprumut.UseVisualStyleBackColor = true;

            // tabGenerare
            this.tabGenerare.Location = new System.Drawing.Point(4, 36);
            this.tabGenerare.Name = "tabGenerare";
            this.tabGenerare.Size = new System.Drawing.Size(1282, 341);
            this.tabGenerare.TabIndex = 3;
            this.tabGenerare.Text = "GeneratCarti";
            this.tabGenerare.UseVisualStyleBackColor = true;

        }





        private List<Rezervare> listRezervare;
        private List<Imprumut> listimp;
        private ControllerCarti controllerCarti;
        private ControllerRezervari controllerRezervari;
        private ControllerImprumuturi controllerImprumuturi;
        private List<Carte> cartii;
        public void load()
        {
          

            listimp = new List<Imprumut>();
            controllerCarti = new ControllerCarti();
            controllerImprumuturi = new ControllerImprumuturi();
            listRezervare = new List<Rezervare>();
            controllerRezervari = new ControllerRezervari();
            cartii = new List<Carte>();

            // lblCititor
            this.lblCititor.AutoSize = true;
            this.lblCititor.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.lblCititor.Location = new System.Drawing.Point(46, 22);
            this.lblCititor.Name = "lblCititor";
            this.lblCititor.Size = new System.Drawing.Size(116, 39);
            this.lblCititor.TabIndex = 0;
            this.lblCititor.Text = "Cititor: \nIdCititor: " + nou.Id + ", Nume si prenume: " + nou.Nume;

            // lblRezervare
            this.lblRezervare.AutoSize = true;
            this.lblRezervare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14F);
            this.lblRezervare.Location = new System.Drawing.Point(47, 95);
            this.lblRezervare.Name = "lblRezervare";
            this.lblRezervare.Size = new System.Drawing.Size(206, 31);
            this.lblRezervare.TabIndex = 1;
            this.lblRezervare.Text = "Rezervari ramase:";

            // lblImprumuturi
            this.lblImprumuturi.AutoSize = true;
            this.lblImprumuturi.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14F);
            this.lblImprumuturi.Location = new System.Drawing.Point(47, 146);
            this.lblImprumuturi.Name = "lblImprumuturi";
            this.lblImprumuturi.Size = new System.Drawing.Size(242, 31);
            this.lblImprumuturi.TabIndex = 2;
            this.lblImprumuturi.Text = "Imprumuturi ramase:";


            dataGridViewImp.Rows.Clear();
            listimp.Clear();
            listimp = controllerImprumuturi.getClientImprumut(nou.Id);
            for(int i = 0; i < listimp.Count; i++)
            {
                Carte carte = controllerCarti.findbyId(listimp[i].IdCarte);
                dataGridViewImp.Rows.Add(listimp[i].Id, listimp[i].IdCarte, carte.Name, carte.Autor, listimp[i].DataStart.ToString("dd.MM.yyyy"), listimp[i].DataRestituire.ToString("dd.MM.yyyy"),"Restituire");
            }

            // cmbIdImp
            this.cmbIdImp.HeaderText = "IdImprumut";
            this.cmbIdImp.MinimumWidth = 6;
            this.cmbIdImp.Name = "cmbIdImp";
            this.cmbIdImp.ReadOnly = true;
            this.cmbIdImp.Width = 125;

            // cmbIdCarte
            this.cmbIdCarte.HeaderText = "IdCarte";
            this.cmbIdCarte.MinimumWidth = 6;
            this.cmbIdCarte.Name = "cmbIdCarte";
            this.cmbIdCarte.ReadOnly = true;
            this.cmbIdCarte.Width = 125;

            // cmbTitlu
            this.cmbTitlu.HeaderText = "Titlu";
            this.cmbTitlu.MinimumWidth = 6;
            this.cmbTitlu.Name = "cmbTitlu";
            this.cmbTitlu.ReadOnly = true;
            this.cmbTitlu.Width = 180;

            // cmbAutor
            this.cmbAutor.HeaderText = "Autor";
            this.cmbAutor.MinimumWidth = 6;
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.ReadOnly = true;
            this.cmbAutor.Width = 180;

            // cmbDataImp
            this.cmbDataImp.HeaderText = "DataImprumut";
            this.cmbDataImp.MinimumWidth = 6;
            this.cmbDataImp.Name = "cmbDataImp";
            this.cmbDataImp.ReadOnly = true;
            this.cmbDataImp.Width = 200;

            // cmbExp
            this.cmbExp.HeaderText = "DataExpirare";
            this.cmbExp.MinimumWidth = 6;
            this.cmbExp.Name = "cmbExp";
            this.cmbExp.ReadOnly = true;
            this.cmbExp.Width = 200;

            // cmbRest
            this.cmbRest.HeaderText = "Restituire";
            this.cmbRest.MinimumWidth = 6;
            this.cmbRest.Name = "cmbRest";
            this.cmbRest.ReadOnly = true;
            this.cmbRest.Width = 180;

            // cmbReze
            this.cmbReze.HeaderText = "Rezervare";
            this.cmbReze.MinimumWidth = 6;
            this.cmbReze.Name = "cmbReze";
            this.cmbReze.ReadOnly = true;
            this.cmbReze.Width = 125;


            dataGridViewRezervare.Rows.Clear();
            listRezervare.Clear();
            listRezervare = controllerRezervari.getClientRezervare(nou.Id);
            for (int i = 0; i < listRezervare.Count; i++)
            {
                Carte carte = controllerCarti.findbyId(listRezervare[i].IdCarte);
                dataGridViewRezervare.Rows.Add(listRezervare[i].Id, listRezervare[i].IdCarte, carte.Name, carte.Autor, listRezervare[i].DataRezervari.ToString("dd.MM.yyyy"), listRezervare[i].DataRezervari.AddDays(2).ToString("dd.MM.yyyy"), "Anulare","Imprumuta");
            }

            // cmbRezIdCarte
            this.cmbRezIdCarte.HeaderText = "IdCarte";
            this.cmbRezIdCarte.MinimumWidth = 6;
            this.cmbRezIdCarte.Name = "cmbRezIdCarte";
            this.cmbRezIdCarte.ReadOnly = true;
            this.cmbRezIdCarte.Width = 125;

            // cmbRezTitlu
            this.cmbRezTitlu.HeaderText = "Titlu";
            this.cmbRezTitlu.MinimumWidth = 6;
            this.cmbRezTitlu.Name = "cmbRezTitlu";
            this.cmbRezTitlu.ReadOnly = true;
            this.cmbRezTitlu.Width = 140;

            // cmbRezAutor
            this.cmbRezAutor.HeaderText = "Autor";
            this.cmbRezAutor.MinimumWidth = 6;
            this.cmbRezAutor.Name = "cmbRezAutor";
            this.cmbRezAutor.ReadOnly = true;
            this.cmbRezAutor.Width = 140;

            // cmbRezDataImp
            this.cmbRezDataImp.HeaderText = "DataImprumut";
            this.cmbRezDataImp.MinimumWidth = 6;
            this.cmbRezDataImp.Name = "cmbRezDataImp";
            this.cmbRezDataImp.ReadOnly = true;
            this.cmbRezDataImp.Width = 190;

            // cmbRezExp
            this.cmbRezExp.HeaderText = "DataExpirare";
            this.cmbRezExp.MinimumWidth = 6;
            this.cmbRezExp.Name = "cmbRezExp";
            this.cmbRezExp.ReadOnly = true;
            this.cmbRezExp.Width = 190;

            // cmbAnuleaza
            this.cmbAnuleaza.HeaderText = "Anuleaza";
            this.cmbAnuleaza.MinimumWidth = 6;
            this.cmbAnuleaza.Name = "cmbAnuleaza";
            this.cmbAnuleaza.ReadOnly = true;
            this.cmbAnuleaza.Width = 140;

            // cmbRezImprumut
            this.cmbRezImprumut.HeaderText = "Imprumuta";
            this.cmbRezImprumut.MinimumWidth = 6;
            this.cmbRezImprumut.Name = "cmbRezImprumut";
            this.cmbRezImprumut.ReadOnly = true;
            this.cmbRezImprumut.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cmbRezImprumut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cmbRezImprumut.Width = 140;


            dataGridViewCarteImp.Rows.Clear();
            cartii.Clear();
            cartii = controllerCarti.getCartii();
            for (int i = 0; i < cartii.Count; i++)
            {
                dataGridViewCarteImp.Rows.Add(cartii[i].Id, cartii[i].Name,cartii[i].Autor, cartii[i].NrPagini.ToString(), "Rezerva", "Imprumuta");
            }

            // cmbImpId
            this.cmbImpId.HeaderText = "IdCarte";
            this.cmbImpId.MinimumWidth = 6;
            this.cmbImpId.Name = "cmbImpId";
            this.cmbImpId.ReadOnly = true;
            this.cmbImpId.Width = 180;

            // cmbImpTitlu
            this.cmbImpTitlu.HeaderText = "Titlu";
            this.cmbImpTitlu.MinimumWidth = 6;
            this.cmbImpTitlu.Name = "cmbImpTitlu";
            this.cmbImpTitlu.ReadOnly = true;
            this.cmbImpTitlu.Width = 230;

            // cmbImpAutor
            this.cmbImpAutor.HeaderText = "Autor";
            this.cmbImpAutor.MinimumWidth = 6;
            this.cmbImpAutor.Name = "cmbImpAutor";
            this.cmbImpAutor.ReadOnly = true;
            this.cmbImpAutor.Width = 230;

            // cmbNrPagini
            this.cmbNrPagini.HeaderText = "NrPagini";
            this.cmbNrPagini.MinimumWidth = 6;
            this.cmbNrPagini.Name = "cmbNrPagini";
            this.cmbNrPagini.ReadOnly = true;
            this.cmbNrPagini.Width = 190;

            // cmbImpRezerva
            this.cmbImpRezerva.HeaderText = "Rezerva";
            this.cmbImpRezerva.Name = "cmbImpRezerva";
            this.cmbImpRezerva.ReadOnly = true;
            this.cmbImpRezerva.Width = 180;

            // cmbImpImp
            this.cmbImpImp.HeaderText = "Imprumuta";
            this.cmbImpImp.Name = "cmbImpImp";
            this.cmbImpImp.ReadOnly = true;
            this.cmbImpImp.Width = 180;








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

                nou = controllerUtilizatori.findbyId(id);
                load();
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

        private void dataGridViewImp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewImp.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewImp.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["cmbIdImp"].Value.ToString());
                controllerImprumuturi.delete(id);
                load();
            }
        }

        private void dataGridViewRezervare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewRezervare.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {

                string columnName = dataGridViewRezervare.Columns[e.ColumnIndex].Name;

                if (columnName == "cmbAnuleaza")
                {

                    DataGridViewRow row = dataGridViewRezervare.Rows[e.RowIndex];
                    int id = int.Parse(row.Cells["cmbReze"].Value.ToString());
                   // MessageBox.Show(id.ToString());
                    controllerRezervari.delete(id);
                    load();

                }

                if (columnName == "cmbRezImprumut")
                {

                    int id = controllerImprumuturi.generareId();
                    int idUtil = nou.Id;
                    DataGridViewRow row = dataGridViewRezervare.Rows[e.RowIndex];
                    int idCarte = int.Parse(row.Cells["cmbRezIdCarte"].Value.ToString());
                    DateTime dateStart = DateTime.Now;
                    DateTime dateEnd = DateTime.Now.AddDays(14);

                    string t = id.ToString() + ";" + idUtil.ToString() + ";" + idCarte.ToString() + ";" + dateStart.ToString() + ";" + dateEnd.ToString();
                    controllerImprumuturi.save(t);
                    load();
                }
            }
        }

        private void dataGridViewCarteImp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridViewCarteImp.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {

                string columnName = dataGridViewCarteImp.Columns[e.ColumnIndex].Name;

                if (columnName == "cmbImpRezerva")
                {

                    DataGridViewRow row = dataGridViewCarteImp.Rows[e.RowIndex];
                    int id = int.Parse(row.Cells["cmbImpId"].Value.ToString());
                    // MessageBox.Show(id.ToString());
                    int idRez = controllerRezervari.generareId();
                    string t = idRez.ToString() + ";" + nou.Id.ToString() + ";" + id.ToString() + ";" + DateTime.Now.ToString() + ";" + 1;
                    controllerRezervari.save(t);
                    load();

                }

                if (columnName == "cmbImpImp")
                {

                    int id = controllerImprumuturi.generareId();
                    int idUtil = nou.Id;
                    DataGridViewRow row = dataGridViewCarteImp.Rows[e.RowIndex];
                    int idCarte = int.Parse(row.Cells["cmbImpId"].Value.ToString());
                    DateTime dateStart = DateTime.Now;
                    DateTime dateEnd = DateTime.Now.AddDays(14);

                    string t = id.ToString() + ";" + idUtil.ToString() + ";" + idCarte.ToString() + ";" + dateStart.ToString() + ";" + dateEnd.ToString();
                    controllerImprumuturi.save(t);
                    load();
                }
            }
        }

        private void dataGridViewCarteImp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewRow row = dataGridViewCarteImp.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["cmbImpId"].Value.ToString());
                //MessageBox.Show("Ai făcut dublu-clic pe linia " + e.RowIndex.ToString());
                Carte carte = controllerCarti.findbyId(id);
                this.form.removePnl("PnlBibliotecar");
                this.form.Controls.Add(new PnlPrevizualizareCarte(carte, form, utilizator));
            }


        }

    }
}

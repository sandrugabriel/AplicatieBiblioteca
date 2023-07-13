using AplicatieBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AplicatieBiblioteca.Panels
{
    internal class PnlPrevizualizareCarte:Panel
    {

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblNrPAgini;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNrPagini;
        private System.Windows.Forms.Button btnBack;

        Carte carte;

        Form1 form;

        Utilizator utilizator;

        public PnlPrevizualizareCarte(Carte carte1, Form1 form1, Utilizator utilizator1)
        {
            this.utilizator = utilizator1;
            this.carte = carte1;
            this.form = form1;
            this.form.Size = new System.Drawing.Size(1019, 719);
            this.form.MinimumSize = new System.Drawing.Size(1019, 719);
            this.form.MaximumSize = new System.Drawing.Size(1019, 719);

            //PnlPrevizualizareCarte
            this.Size = new System.Drawing.Size(1019, 719);
            this.Name = "PnlPrevizualizareCarte";

            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblNrPAgini = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNrPagini = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();

            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNrPagini);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblNrPAgini);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.2F);
            this.lblTitlu.Location = new System.Drawing.Point(14, 15);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(78, 38);
            this.lblTitlu.Text = "Titlu:";
             
            // lblAutor
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.2F);
            this.lblAutor.Location = new System.Drawing.Point(395, 19);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(98, 38);
            this.lblAutor.Text = "Autor:";
             
            // lblNrPAgini
            this.lblNrPAgini.AutoSize = true;
            this.lblNrPAgini.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.2F);
            this.lblNrPAgini.Location = new System.Drawing.Point(609, 170);
            this.lblNrPAgini.Name = "lblNrPAgini";
            this.lblNrPAgini.Size = new System.Drawing.Size(144, 38);
            this.lblNrPAgini.Text = "Nr Pagini:";
             
            // pictureBox
            this.pictureBox.Location = new System.Drawing.Point(28, 75);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(563, 609);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.Image = Image.FromFile(Application.StartupPath+@"/Imagini/carti/"+carte.Id.ToString()+".jpg");
             
            // txtTitlu
            this.txtTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.2F);
            this.txtTitlu.Location = new System.Drawing.Point(98, 12);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(278, 45);
            this.txtTitlu.ReadOnly = true;
            this.txtTitlu.Text = carte.Name;
             
            // txtAutor
            this.txtAutor.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.2F);
            this.txtAutor.Location = new System.Drawing.Point(499, 12);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(258, 45);
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Text = carte.Autor;

            // txtNrPagini
            this.txtNrPagini.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.2F);
            this.txtNrPagini.Location = new System.Drawing.Point(759, 170);
            this.txtNrPagini.Name = "txtNrPagini";
            this.txtNrPagini.Size = new System.Drawing.Size(212, 45);
            this.txtNrPagini.ReadOnly = true;
            this.txtNrPagini.Text = carte.NrPagini.ToString();

            // btnBack
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(699, 382);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(177, 83);
            this.btnBack.Text = "Inapoi";
            this.btnBack.Click += new EventHandler(btnBack_Click);


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.form.removePnl("PnlPrevizualizareCarte");
            this.form.Controls.Add(new PnlBibliotecar(form,utilizator));

        }


    }
}

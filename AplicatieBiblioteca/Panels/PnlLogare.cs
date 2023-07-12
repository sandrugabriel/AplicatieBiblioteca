using AplicatieBiblioteca.Controllers;
using AplicatieBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AplicatieBiblioteca.Panels
{
    internal class PnlLogare:Panel
    {

        Form1 form;

        private System.Windows.Forms.PictureBox pctCarte;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnLogare;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Button btnRenunta;

        private List<string> erori;

        ControllerUtilizatori controllerUtilizatori;


        public PnlLogare(Form1 form1)
        {

            this.form = form1;
            this.form.Size = new System.Drawing.Size(790, 671);
            this.form.MinimumSize = new System.Drawing.Size(790, 671);
            this.form.MaximumSize = new System.Drawing.Size(790, 671);
            erori = new List<string>();

            this.controllerUtilizatori = new ControllerUtilizatori();

            //PnlLogare
            this.Size = new System.Drawing.Size(790,671);
            this.Name = "MockupLogare";

            this.pctCarte = new System.Windows.Forms.PictureBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnLogare = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnRenunta = new System.Windows.Forms.Button();
            
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.pctCarte);

            string path = Application.StartupPath + @"/Imagini/altele/";

            // pctCarte
            this.pctCarte.Location = new System.Drawing.Point(564, 12);
            this.pctCarte.Name = "pctCarte";
            this.pctCarte.Size = new System.Drawing.Size(188, 127);
            this.pctCarte.Image = Image.FromFile(path + "biblioteca2.gif");
            this.pctCarte.SizeMode = PictureBoxSizeMode.StretchImage;

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Segoe Print", 30.2F);
            this.lblTitlu.Location = new System.Drawing.Point(194, 30);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(304, 89);
            this.lblTitlu.TabIndex = 2;
            this.lblTitlu.Text = "Bibiloatica";
             
            // btnLogare
            this.btnLogare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogare.Location = new System.Drawing.Point(242, 459);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(171, 54);
            this.btnLogare.TabIndex = 3;
            this.btnLogare.Text = "Logare";
            this.btnLogare.UseVisualStyleBackColor = true;
             
            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.lblEmail.Location = new System.Drawing.Point(173, 189);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 32);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
             
            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(178, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 38);
            this.txtEmail.TabIndex = 5;
             
            // txtParola
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.Location = new System.Drawing.Point(178, 360);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(307, 38);
            this.txtParola.UseSystemPasswordChar = true;
            
            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.lblParola.Location = new System.Drawing.Point(173, 327);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(85, 32);
            this.lblParola.Text = "Parola";

            // btnRenunta
            this.btnRenunta.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenunta.Location = new System.Drawing.Point(242, 528);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(171, 54);
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.Click += new EventHandler(btnRenunta_Click);

        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {

            this.form.removePnl("PnlLogare");
            this.form.Controls.Add(new PnlStart(form));

        }

        public void verificare()
        {

            erori.Clear();

            if (txtEmail.Text.Equals(""))
            {
                erori.Add("Nu ai introdus emailul!");
            }

            if (txtParola.Text.Equals(""))
            {
                erori.Add("Nu ai introdus parola!");
            }


        }

        private void btnLogare_Click(object sender, EventArgs e) {

            verificare();

            if(erori.Count > 0)
            {
                for(int i=0;i<erori.Count;i++)
                {
                    MessageBox.Show(erori[i], "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (controllerUtilizatori.verificare(txtEmail.Text, txtParola.Text))
                {

                    Utilizator utilizator = controllerUtilizatori.getUtilizator(txtEmail.Text,txtParola.Text);
                    this.form.removePnl("Pnllogare");
                   

                }
                else
                {
                    MessageBox.Show("Email si/ sau parola invalida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        
        
        
        }


    }
}

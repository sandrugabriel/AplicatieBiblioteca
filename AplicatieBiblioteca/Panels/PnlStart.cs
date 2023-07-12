using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieBiblioteca.Panels
{
    internal class PnlStart:Panel
    {

        Form1 form;

        private System.Windows.Forms.PictureBox pctTitlu;
        private System.Windows.Forms.PictureBox pctCarte;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox txtDesc;

        public PnlStart(Form1 form1)
        {
            this.form = form1;
            this.form.Size = new System.Drawing.Size(785, 464);
            this.form.MinimumSize = new System.Drawing.Size(785, 464);
            this.form.MaximumSize = new System.Drawing.Size(785, 464);

            //PnlStart
            this.Size = new System.Drawing.Size(785, 464);
            this.Name = "PnlStart";

            this.pctTitlu = new System.Windows.Forms.PictureBox();
            this.pctCarte = new System.Windows.Forms.PictureBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.RichTextBox();

            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.pctCarte);
            this.Controls.Add(this.pctTitlu);

            string path = Application.StartupPath + @"/Imagini/altele/";

            // pctTitlu
            this.pctTitlu.Location = new System.Drawing.Point(0, 0);
            this.pctTitlu.Name = "pctTitlu";
            this.pctTitlu.Size = new System.Drawing.Size(787, 252);
            this.pctTitlu.Image = Image.FromFile(path + "biblioteca1.jpg");
            this.pctTitlu.SizeMode = PictureBoxSizeMode.StretchImage;
            
            // pctCarte
            this.pctCarte.Location = new System.Drawing.Point(563, 268);
            this.pctCarte.Name = "pctCarte";
            this.pctCarte.Size = new System.Drawing.Size(210, 154);
            this.pctCarte.Image = Image.FromFile(path + "biblioteca2.gif");
            this.pctCarte.SizeMode = PictureBoxSizeMode.StretchImage;
             
            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Segoe Print", 30.2F);
            this.lblTitlu.Location = new System.Drawing.Point(255, 82);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(304, 89);
            this.lblTitlu.ForeColor = System.Drawing.Color.Red;
            this.lblTitlu.Text = "Bibiloatica";
             
            // btnStart
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(165, 368);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(171, 54);
            this.btnStart.Text = "Start";
            this.btnStart.Click += new EventHandler(btnStart_Click);
             
            // txtDesc
            this.txtDesc.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(12, 258);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(519, 98);
            this.txtDesc.TabIndex = 4;
            this.txtDesc.Text = "Biblioteca online serveste interesele de informare, educare,lectrua,\nrecreere al " +
            "utilizatorului din liceul nostru, oferind acces gratuit\n\n";
             

        }


        private void btnStart_Click(object sender, EventArgs e)
        {

            this.form.removePnl("PnlStart");
            this.form.Controls.Add(new PnlLogare(form));
        }


    }
}

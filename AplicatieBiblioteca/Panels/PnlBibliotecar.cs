using AplicatieBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        public PnlBibliotecar(Form1 form1, Utilizator utilizator1)
        {
            this.form = form1;
            this.utilizator = utilizator1;
            this.form.Size = new System.Drawing.Size(1600, 823);
            this.form.MinimumSize = new System.Drawing.Size(1600, 823);
            this.form.MaximumSize = new System.Drawing.Size(1600, 823);
            this.form.AutoScroll = true;
            this.form.Location = new Point(0, 0);
            this.form.WindowState = FormWindowState.Maximized;

            //PnlBibliotecar
            this.Size = new System.Drawing.Size(1600, 823);
            this.Name = "PnlBibliotecar";

            this.pctPoza = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInregistrare = new System.Windows.Forms.TabPage();
            this.tabAfisare = new System.Windows.Forms.TabPage();
            this.tabCititor = new System.Windows.Forms.TabPage();

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
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.lblData.Location = new System.Drawing.Point(1200, 35);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(66, 32);
            this.lblData.Text = "Data: " + DateTime.Now;
             
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F);
            this.lblNume.Location = new System.Drawing.Point(221, 61);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(198, 39);
            this.lblNume.TabIndex = 9;
            this.lblNume.Text = "Bibilotecar = " + utilizator.Nume;
             
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInregistrare);
            this.tabControl1.Controls.Add(this.tabAfisare);
            this.tabControl1.Controls.Add(this.tabCititor);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(15, 162);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1352, 709);
            this.tabControl1.TabIndex = 10;
             
            // tabInregistrare
            // 
            this.tabInregistrare.Location = new System.Drawing.Point(4, 36);
            this.tabInregistrare.Name = "tabInregistrare";
            this.tabInregistrare.Padding = new System.Windows.Forms.Padding(3);
            this.tabInregistrare.Size = new System.Drawing.Size(1344, 669);
            this.tabInregistrare.TabIndex = 0;
            this.tabInregistrare.Text = "Inregistrare";
            this.tabInregistrare.UseVisualStyleBackColor = true;
             
            // tabAfisare
            // 
            this.tabAfisare.Location = new System.Drawing.Point(4, 36);
            this.tabAfisare.Name = "tabAfisare";
            this.tabAfisare.Padding = new System.Windows.Forms.Padding(3);
            this.tabAfisare.Size = new System.Drawing.Size(1344, 669);
            this.tabAfisare.TabIndex = 1;
            this.tabAfisare.Text = "AfisareCititor ";
            this.tabAfisare.UseVisualStyleBackColor = true;
            // 
            // tabCititor
            // 
            this.tabCititor.Location = new System.Drawing.Point(4, 25);
            this.tabCititor.Name = "tabCititor";
            this.tabCititor.Size = new System.Drawing.Size(1344, 680);
            this.tabCititor.TabIndex = 2;
            this.tabCititor.Text = "Cititor";
            this.tabCititor.UseVisualStyleBackColor = true;
             


        }




    }
}

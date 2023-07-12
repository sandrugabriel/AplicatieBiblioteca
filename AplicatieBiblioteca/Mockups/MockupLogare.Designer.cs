namespace AplicatieBiblioteca.Mockups
{
    partial class MockupLogare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pctCarte = new System.Windows.Forms.PictureBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnLogare = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.lblParola = new System.Windows.Forms.Label();
            this.btnRenunta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarte)).BeginInit();
            this.SuspendLayout();
            // 
            // pctCarte
            // 
            this.pctCarte.Location = new System.Drawing.Point(564, 12);
            this.pctCarte.Name = "pctCarte";
            this.pctCarte.Size = new System.Drawing.Size(188, 127);
            this.pctCarte.TabIndex = 1;
            this.pctCarte.TabStop = false;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Segoe Print", 30.2F);
            this.lblTitlu.Location = new System.Drawing.Point(194, 30);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(304, 89);
            this.lblTitlu.TabIndex = 2;
            this.lblTitlu.Text = "Bibiloatica";
            // 
            // btnLogare
            // 
            this.btnLogare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogare.Location = new System.Drawing.Point(242, 459);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(171, 54);
            this.btnLogare.TabIndex = 3;
            this.btnLogare.Text = "Logare";
            this.btnLogare.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.lblEmail.Location = new System.Drawing.Point(173, 189);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(75, 32);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(178, 222);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 38);
            this.txtEmail.TabIndex = 5;
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.Location = new System.Drawing.Point(178, 360);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(307, 38);
            this.txtParola.TabIndex = 7;
            this.txtParola.UseSystemPasswordChar = true;
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 14.8F);
            this.lblParola.Location = new System.Drawing.Point(173, 327);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(85, 32);
            this.lblParola.TabIndex = 6;
            this.lblParola.Text = "Parola";
            // 
            // btnRenunta
            // 
            this.btnRenunta.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenunta.Location = new System.Drawing.Point(242, 528);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(171, 54);
            this.btnRenunta.TabIndex = 8;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            // 
            // MockupLogare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 611);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.pctCarte);
            this.Name = "MockupLogare";
            this.Text = "MockupStart";
            ((System.ComponentModel.ISupportInitialize)(this.pctCarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pctCarte;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnLogare;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Button btnRenunta;
    }
}
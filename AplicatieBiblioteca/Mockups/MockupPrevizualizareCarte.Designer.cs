namespace AplicatieBiblioteca.Mockups
{
    partial class MockupPrevizualizareCarte
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
            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblNrPAgini = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtTitlu = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtNrPagini = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.2F);
            this.lblTitlu.Location = new System.Drawing.Point(14, 15);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(78, 38);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Titlu:";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.2F);
            this.lblAutor.Location = new System.Drawing.Point(395, 19);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(98, 38);
            this.lblAutor.TabIndex = 1;
            this.lblAutor.Text = "Autor:";
            // 
            // lblNrPAgini
            // 
            this.lblNrPAgini.AutoSize = true;
            this.lblNrPAgini.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.2F);
            this.lblNrPAgini.Location = new System.Drawing.Point(609, 170);
            this.lblNrPAgini.Name = "lblNrPAgini";
            this.lblNrPAgini.Size = new System.Drawing.Size(144, 38);
            this.lblNrPAgini.TabIndex = 2;
            this.lblNrPAgini.Text = "Nr Pagini:";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(28, 75);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(563, 609);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // txtTitlu
            // 
            this.txtTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.2F);
            this.txtTitlu.Location = new System.Drawing.Point(98, 12);
            this.txtTitlu.Name = "txtTitlu";
            this.txtTitlu.Size = new System.Drawing.Size(278, 45);
            this.txtTitlu.TabIndex = 4;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.2F);
            this.txtAutor.Location = new System.Drawing.Point(499, 12);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(258, 45);
            this.txtAutor.TabIndex = 5;
            // 
            // txtNrPagini
            // 
            this.txtNrPagini.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 17.2F);
            this.txtNrPagini.Location = new System.Drawing.Point(759, 170);
            this.txtNrPagini.Name = "txtNrPagini";
            this.txtNrPagini.Size = new System.Drawing.Size(212, 45);
            this.txtNrPagini.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(699, 382);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(177, 83);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Inapoi";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // MockupPrevizualizareCarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 719);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtNrPagini);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitlu);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblNrPAgini);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitlu);
            this.Name = "MockupPrevizualizareCarte";
            this.Text = "MockupPrevizualizareCarte";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblNrPAgini;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtTitlu;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtNrPagini;
        private System.Windows.Forms.Button btnBack;
    }
}
namespace AplicatieBiblioteca.Mockups
{
    partial class MockupStart
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
            this.pctTitlu = new System.Windows.Forms.PictureBox();
            this.pctCarte = new System.Windows.Forms.PictureBox();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctTitlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarte)).BeginInit();
            this.SuspendLayout();
            // 
            // pctTitlu
            // 
            this.pctTitlu.Location = new System.Drawing.Point(0, 0);
            this.pctTitlu.Name = "pctTitlu";
            this.pctTitlu.Size = new System.Drawing.Size(787, 252);
            this.pctTitlu.TabIndex = 0;
            this.pctTitlu.TabStop = false;
            // 
            // pctCarte
            // 
            this.pctCarte.Location = new System.Drawing.Point(563, 268);
            this.pctCarte.Name = "pctCarte";
            this.pctCarte.Size = new System.Drawing.Size(210, 154);
            this.pctCarte.TabIndex = 1;
            this.pctCarte.TabStop = false;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Segoe Print", 30.2F);
            this.lblTitlu.Location = new System.Drawing.Point(199, 82);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(304, 89);
            this.lblTitlu.TabIndex = 2;
            this.lblTitlu.Text = "Bibiloatica";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(165, 368);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(171, 54);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(12, 258);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(519, 98);
            this.txtDesc.TabIndex = 4;
            this.txtDesc.Text = "Biblioteca online serveste interesele de informare, educare,lectrua,\nrecreere al " +
    "utilizatorului din liceul nostru, oferind acces gratuit\n\n";
            // 
            // MockupStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 434);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.pctCarte);
            this.Controls.Add(this.pctTitlu);
            this.Name = "MockupStart";
            this.Text = "MockupStart";
            ((System.ComponentModel.ISupportInitialize)(this.pctTitlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCarte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctTitlu;
        private System.Windows.Forms.PictureBox pctCarte;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox txtDesc;
    }
}
namespace scrublords
{
    partial class FRapportsVisite
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbPraticien = new System.Windows.Forms.ComboBox();
            this.rtbBilan = new System.Windows.Forms.RichTextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.Details = new System.Windows.Forms.Button();
            this.Precedent = new System.Windows.Forms.Button();
            this.Suivant = new System.Windows.Forms.Button();
            this.Nouveau = new System.Windows.Forms.Button();
            this.bsRapports = new System.Windows.Forms.BindingSource(this.components);
            this.dgvOffrir = new System.Windows.Forms.DataGridView();
            this.bsOffrir = new System.Windows.Forms.BindingSource(this.components);
            this.bsMedecins = new System.Windows.Forms.BindingSource(this.components);
            this.cbMotif = new System.Windows.Forms.ComboBox();
            this.bsMotifs = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotifs)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "RAPPORTS DE VISITE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Numéro Rapport :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Date Rapport :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Motif Visite :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "BILAN :";
            // 
            // tbNumero
            // 
            this.tbNumero.Location = new System.Drawing.Point(109, 46);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(62, 20);
            this.tbNumero.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Praticien :";
            // 
            // cbPraticien
            // 
            this.cbPraticien.FormattingEnabled = true;
            this.cbPraticien.Location = new System.Drawing.Point(109, 71);
            this.cbPraticien.Name = "cbPraticien";
            this.cbPraticien.Size = new System.Drawing.Size(121, 21);
            this.cbPraticien.TabIndex = 40;
            this.cbPraticien.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CbPraticien_Format);
            // 
            // rtbBilan
            // 
            this.rtbBilan.Location = new System.Drawing.Point(109, 150);
            this.rtbBilan.Name = "rtbBilan";
            this.rtbBilan.Size = new System.Drawing.Size(171, 96);
            this.rtbBilan.TabIndex = 41;
            this.rtbBilan.Text = "";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(109, 99);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(202, 20);
            this.dtpDate.TabIndex = 42;
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(236, 69);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(75, 23);
            this.Details.TabIndex = 43;
            this.Details.Text = "Détails";
            this.Details.UseVisualStyleBackColor = true;
            this.Details.Click += new System.EventHandler(this.Details_Click);
            // 
            // Precedent
            // 
            this.Precedent.Location = new System.Drawing.Point(70, 252);
            this.Precedent.Name = "Precedent";
            this.Precedent.Size = new System.Drawing.Size(75, 23);
            this.Precedent.TabIndex = 44;
            this.Precedent.Text = "Précédent";
            this.Precedent.UseVisualStyleBackColor = true;
            // 
            // Suivant
            // 
            this.Suivant.Location = new System.Drawing.Point(151, 252);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(75, 23);
            this.Suivant.TabIndex = 45;
            this.Suivant.Text = "Suivant";
            this.Suivant.UseVisualStyleBackColor = true;
            // 
            // Nouveau
            // 
            this.Nouveau.Location = new System.Drawing.Point(232, 252);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(75, 23);
            this.Nouveau.TabIndex = 46;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = true;
            // 
            // dgvOffrir
            // 
            this.dgvOffrir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffrir.Location = new System.Drawing.Point(317, 46);
            this.dgvOffrir.Name = "dgvOffrir";
            this.dgvOffrir.Size = new System.Drawing.Size(240, 150);
            this.dgvOffrir.TabIndex = 47;
            // 
            // cbMotif
            // 
            this.cbMotif.FormattingEnabled = true;
            this.cbMotif.Location = new System.Drawing.Point(109, 125);
            this.cbMotif.Name = "cbMotif";
            this.cbMotif.Size = new System.Drawing.Size(121, 21);
            this.cbMotif.TabIndex = 48;
            // 
            // FRapportsVisite
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(755, 298);
            this.Controls.Add(this.cbMotif);
            this.Controls.Add(this.dgvOffrir);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.Suivant);
            this.Controls.Add(this.Precedent);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.rtbBilan);
            this.Controls.Add(this.cbPraticien);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "FRapportsVisite";
            this.Load += new System.EventHandler(this.Rapport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRapports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOffrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedecins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMotifs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbPraticien;
        private System.Windows.Forms.RichTextBox rtbBilan;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button Details;
        private System.Windows.Forms.Button Precedent;
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.BindingSource bsRapports;
        private System.Windows.Forms.DataGridView dgvOffrir;
        private System.Windows.Forms.BindingSource bsOffrir;
        private System.Windows.Forms.BindingSource bsMedecins;
        private System.Windows.Forms.ComboBox cbMotif;
        private System.Windows.Forms.BindingSource bsMotifs;
    }
}
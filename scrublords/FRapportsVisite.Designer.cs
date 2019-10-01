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
            System.Windows.Forms.Label bilanLabel;
            System.Windows.Forms.Label dateRapportLabel;
            System.Windows.Forms.Label idMedecinLabel;
            System.Windows.Forms.Label idRapportLabel;
            System.Windows.Forms.Label libMotifLabel;
            this.bilanTextBox = new System.Windows.Forms.TextBox();
            this.bsRapVis = new System.Windows.Forms.BindingSource(this.components);
            this.dateRapportDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idMedecinTextBox = new System.Windows.Forms.TextBox();
            this.idRapportTextBox = new System.Windows.Forms.TextBox();
            this.libMotifTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            bilanLabel = new System.Windows.Forms.Label();
            dateRapportLabel = new System.Windows.Forms.Label();
            idMedecinLabel = new System.Windows.Forms.Label();
            idRapportLabel = new System.Windows.Forms.Label();
            libMotifLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapVis)).BeginInit();
            this.SuspendLayout();
            // 
            // bilanLabel
            // 
            bilanLabel.AutoSize = true;
            bilanLabel.Location = new System.Drawing.Point(14, 150);
            bilanLabel.Name = "bilanLabel";
            bilanLabel.Size = new System.Drawing.Size(44, 13);
            bilanLabel.TabIndex = 1;
            bilanLabel.Text = "BILAN :";
            // 
            // dateRapportLabel
            // 
            dateRapportLabel.AutoSize = true;
            dateRapportLabel.Location = new System.Drawing.Point(14, 99);
            dateRapportLabel.Name = "dateRapportLabel";
            dateRapportLabel.Size = new System.Drawing.Size(77, 13);
            dateRapportLabel.TabIndex = 3;
            dateRapportLabel.Text = "Date Rapport :";
            // 
            // idMedecinLabel
            // 
            idMedecinLabel.AutoSize = true;
            idMedecinLabel.Location = new System.Drawing.Point(14, 72);
            idMedecinLabel.Name = "idMedecinLabel";
            idMedecinLabel.Size = new System.Drawing.Size(54, 13);
            idMedecinLabel.TabIndex = 5;
            idMedecinLabel.Text = "Praticien :";
            // 
            // idRapportLabel
            // 
            idRapportLabel.AutoSize = true;
            idRapportLabel.Location = new System.Drawing.Point(14, 43);
            idRapportLabel.Name = "idRapportLabel";
            idRapportLabel.Size = new System.Drawing.Size(91, 13);
            idRapportLabel.TabIndex = 9;
            idRapportLabel.Text = "Numéro Rapport :";
            // 
            // libMotifLabel
            // 
            libMotifLabel.AutoSize = true;
            libMotifLabel.Location = new System.Drawing.Point(14, 124);
            libMotifLabel.Name = "libMotifLabel";
            libMotifLabel.Size = new System.Drawing.Size(64, 13);
            libMotifLabel.TabIndex = 29;
            libMotifLabel.Text = "Motif Visite :";
            // 
            // bilanTextBox
            // 
            this.bilanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRapVis, "bilan", true));
            this.bilanTextBox.Location = new System.Drawing.Point(111, 147);
            this.bilanTextBox.Name = "bilanTextBox";
            this.bilanTextBox.Size = new System.Drawing.Size(200, 20);
            this.bilanTextBox.TabIndex = 2;
            // 
            // dateRapportDateTimePicker
            // 
            this.dateRapportDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsRapVis, "dateRapport", true));
            this.dateRapportDateTimePicker.Location = new System.Drawing.Point(111, 95);
            this.dateRapportDateTimePicker.Name = "dateRapportDateTimePicker";
            this.dateRapportDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateRapportDateTimePicker.TabIndex = 4;
            // 
            // idMedecinTextBox
            // 
            this.idMedecinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRapVis, "idMedecin", true));
            this.idMedecinTextBox.Location = new System.Drawing.Point(111, 69);
            this.idMedecinTextBox.Name = "idMedecinTextBox";
            this.idMedecinTextBox.Size = new System.Drawing.Size(200, 20);
            this.idMedecinTextBox.TabIndex = 6;
            // 
            // idRapportTextBox
            // 
            this.idRapportTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRapVis, "idRapport", true));
            this.idRapportTextBox.Location = new System.Drawing.Point(111, 43);
            this.idRapportTextBox.Name = "idRapportTextBox";
            this.idRapportTextBox.Size = new System.Drawing.Size(200, 20);
            this.idRapportTextBox.TabIndex = 10;
            // 
            // libMotifTextBox
            // 
            this.libMotifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsRapVis, "MOTIF.libMotif", true));
            this.libMotifTextBox.Location = new System.Drawing.Point(111, 121);
            this.libMotifTextBox.Name = "libMotifTextBox";
            this.libMotifTextBox.Size = new System.Drawing.Size(100, 20);
            this.libMotifTextBox.TabIndex = 30;
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
            // FRapportsVisite
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(755, 749);
            this.Controls.Add(this.label7);
            this.Controls.Add(libMotifLabel);
            this.Controls.Add(this.libMotifTextBox);
            this.Controls.Add(bilanLabel);
            this.Controls.Add(this.bilanTextBox);
            this.Controls.Add(dateRapportLabel);
            this.Controls.Add(this.dateRapportDateTimePicker);
            this.Controls.Add(idMedecinLabel);
            this.Controls.Add(this.idMedecinTextBox);
            this.Controls.Add(idRapportLabel);
            this.Controls.Add(this.idRapportTextBox);
            this.Name = "FRapportsVisite";
            ((System.ComponentModel.ISupportInitialize)(this.bsRapVis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bAjoutRapVis;
        private System.Windows.Forms.Button bModifRapVis;
        private System.Windows.Forms.ComboBox comboRapVisPrat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bsMed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumRap;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMotVis;
        private System.Windows.Forms.RichTextBox rtbBilan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bPrec;
        private System.Windows.Forms.Button BSuiv;
        private System.Windows.Forms.BindingSource bsRapVis;
        private System.Windows.Forms.TextBox bilanTextBox;
        private System.Windows.Forms.DateTimePicker dateRapportDateTimePicker;
        private System.Windows.Forms.TextBox idMedecinTextBox;
        private System.Windows.Forms.TextBox idRapportTextBox;
        private System.Windows.Forms.TextBox libMotifTextBox;
        private System.Windows.Forms.Label label7;
    }
}
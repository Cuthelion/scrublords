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
            this.bAjoutRapVis = new System.Windows.Forms.Button();
            this.bModifRapVis = new System.Windows.Forms.Button();
            this.comboRapVisPrat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bsRapVis = new System.Windows.Forms.BindingSource(this.components);
            this.bsMed = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumRap = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMotVis = new System.Windows.Forms.TextBox();
            this.rtbBilan = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bPrec = new System.Windows.Forms.Button();
            this.BSuiv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapVis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed)).BeginInit();
            this.SuspendLayout();
            // 
            // bAjoutRapVis
            // 
            this.bAjoutRapVis.Location = new System.Drawing.Point(156, 296);
            this.bAjoutRapVis.Name = "bAjoutRapVis";
            this.bAjoutRapVis.Size = new System.Drawing.Size(125, 23);
            this.bAjoutRapVis.TabIndex = 1;
            this.bAjoutRapVis.Text = "Ajouter un Rapport";
            this.bAjoutRapVis.UseVisualStyleBackColor = true;
            this.bAjoutRapVis.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bModifRapVis
            // 
            this.bModifRapVis.Location = new System.Drawing.Point(156, 325);
            this.bModifRapVis.Name = "bModifRapVis";
            this.bModifRapVis.Size = new System.Drawing.Size(125, 23);
            this.bModifRapVis.TabIndex = 2;
            this.bModifRapVis.Text = "Modifier un Rapport";
            this.bModifRapVis.UseVisualStyleBackColor = true;
            // 
            // comboRapVisPrat
            // 
            this.comboRapVisPrat.FormattingEnabled = true;
            this.comboRapVisPrat.Location = new System.Drawing.Point(120, 84);
            this.comboRapVisPrat.Name = "comboRapVisPrat";
            this.comboRapVisPrat.Size = new System.Drawing.Size(121, 21);
            this.comboRapVisPrat.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Praticien :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Numéro Rapport :";
            // 
            // tbNumRap
            // 
            this.tbNumRap.Location = new System.Drawing.Point(120, 58);
            this.tbNumRap.Name = "tbNumRap";
            this.tbNumRap.Size = new System.Drawing.Size(121, 20);
            this.tbNumRap.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 82);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Détails";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date Rapport :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(120, 111);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(202, 20);
            this.dtpDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Motif Visite :";
            // 
            // tbMotVis
            // 
            this.tbMotVis.Location = new System.Drawing.Point(120, 137);
            this.tbMotVis.Name = "tbMotVis";
            this.tbMotVis.Size = new System.Drawing.Size(121, 20);
            this.tbMotVis.TabIndex = 12;
            // 
            // rtbBilan
            // 
            this.rtbBilan.Location = new System.Drawing.Point(120, 164);
            this.rtbBilan.Name = "rtbBilan";
            this.rtbBilan.Size = new System.Drawing.Size(202, 96);
            this.rtbBilan.TabIndex = 13;
            this.rtbBilan.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "BILAN :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "RAPPORTS DE VISITE";
            // 
            // bPrec
            // 
            this.bPrec.Location = new System.Drawing.Point(120, 267);
            this.bPrec.Name = "bPrec";
            this.bPrec.Size = new System.Drawing.Size(75, 23);
            this.bPrec.TabIndex = 16;
            this.bPrec.Text = "Précedent";
            this.bPrec.UseVisualStyleBackColor = true;
            // 
            // BSuiv
            // 
            this.BSuiv.Location = new System.Drawing.Point(247, 267);
            this.BSuiv.Name = "BSuiv";
            this.BSuiv.Size = new System.Drawing.Size(75, 23);
            this.BSuiv.TabIndex = 17;
            this.BSuiv.Text = "Suivant";
            this.BSuiv.UseVisualStyleBackColor = true;
            // 
            // FRapportsVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BSuiv);
            this.Controls.Add(this.bPrec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbBilan);
            this.Controls.Add(this.tbMotVis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbNumRap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboRapVisPrat);
            this.Controls.Add(this.bModifRapVis);
            this.Controls.Add(this.bAjoutRapVis);
            this.Name = "FRapportsVisite";
            this.Text = "FRapportsVisite";
            ((System.ComponentModel.ISupportInitialize)(this.bsRapVis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsRapVis;
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
    }
}
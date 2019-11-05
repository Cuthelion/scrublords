namespace scrublords
{
    partial class FInfosVistiteurs
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
            System.Windows.Forms.Label dateEmbaucheLabel;
            System.Windows.Forms.Label idVisiteurLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label rueLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label idLaboLabel1;
            this.dateEmbaucheTextBox = new System.Windows.Forms.TextBox();
            this.bsvisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.idVisiteurTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.rueTextBox = new System.Windows.Forms.TextBox();
            this.villeTextBox = new System.Windows.Forms.TextBox();
            this.idLaboTextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bssecteur = new System.Windows.Forms.BindingSource(this.components);
            dateEmbaucheLabel = new System.Windows.Forms.Label();
            idVisiteurLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            rueLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            idLaboLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssecteur)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEmbaucheLabel
            // 
            dateEmbaucheLabel.AutoSize = true;
            dateEmbaucheLabel.Location = new System.Drawing.Point(12, 233);
            dateEmbaucheLabel.Name = "dateEmbaucheLabel";
            dateEmbaucheLabel.Size = new System.Drawing.Size(85, 13);
            dateEmbaucheLabel.TabIndex = 3;
            dateEmbaucheLabel.Text = "date Embauche:";
            // 
            // idVisiteurLabel
            // 
            idVisiteurLabel.AutoSize = true;
            idVisiteurLabel.Location = new System.Drawing.Point(346, 97);
            idVisiteurLabel.Name = "idVisiteurLabel";
            idVisiteurLabel.Size = new System.Drawing.Size(55, 13);
            idVisiteurLabel.TabIndex = 9;
            idVisiteurLabel.Text = "id Visiteur:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(346, 156);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(30, 13);
            nomLabel.TabIndex = 11;
            nomLabel.Text = "nom:";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Location = new System.Drawing.Point(346, 126);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(45, 13);
            prenomLabel.TabIndex = 15;
            prenomLabel.Text = "prenom:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Location = new System.Drawing.Point(546, 97);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(25, 13);
            rueLabel.TabIndex = 17;
            rueLabel.Text = "rue:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Location = new System.Drawing.Point(546, 126);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(28, 13);
            villeLabel.TabIndex = 19;
            villeLabel.Text = "ville:";
            // 
            // idLaboLabel1
            // 
            idLaboLabel1.AutoSize = true;
            idLaboLabel1.Location = new System.Drawing.Point(546, 156);
            idLaboLabel1.Name = "idLaboLabel1";
            idLaboLabel1.Size = new System.Drawing.Size(45, 13);
            idLaboLabel1.TabIndex = 21;
            idLaboLabel1.Text = "id Labo:";
            // 
            // dateEmbaucheTextBox
            // 
            this.dateEmbaucheTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsvisiteur, "dateEmbauche", true));
            this.dateEmbaucheTextBox.Location = new System.Drawing.Point(114, 233);
            this.dateEmbaucheTextBox.Name = "dateEmbaucheTextBox";
            this.dateEmbaucheTextBox.Size = new System.Drawing.Size(100, 20);
            this.dateEmbaucheTextBox.TabIndex = 4;
            // 
            // bsvisiteur
            // 
            this.bsvisiteur.DataSource = typeof(scrublords.Visiteur);
            // 
            // idVisiteurTextBox
            // 
            this.idVisiteurTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsvisiteur, "idVisiteur", true));
            this.idVisiteurTextBox.Location = new System.Drawing.Point(419, 94);
            this.idVisiteurTextBox.Name = "idVisiteurTextBox";
            this.idVisiteurTextBox.Size = new System.Drawing.Size(100, 20);
            this.idVisiteurTextBox.TabIndex = 10;
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsvisiteur, "nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(419, 123);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 12;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsvisiteur, "prenom", true));
            this.prenomTextBox.Location = new System.Drawing.Point(419, 153);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(100, 20);
            this.prenomTextBox.TabIndex = 16;
            // 
            // rueTextBox
            // 
            this.rueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsvisiteur, "rue", true));
            this.rueTextBox.Location = new System.Drawing.Point(604, 94);
            this.rueTextBox.Name = "rueTextBox";
            this.rueTextBox.Size = new System.Drawing.Size(100, 20);
            this.rueTextBox.TabIndex = 18;
            // 
            // villeTextBox
            // 
            this.villeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsvisiteur, "ville", true));
            this.villeTextBox.Location = new System.Drawing.Point(604, 123);
            this.villeTextBox.Name = "villeTextBox";
            this.villeTextBox.Size = new System.Drawing.Size(100, 20);
            this.villeTextBox.TabIndex = 20;
            // 
            // idLaboTextBox1
            // 
            this.idLaboTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsvisiteur, "Laboratoire.idLabo", true));
            this.idLaboTextBox1.Location = new System.Drawing.Point(604, 149);
            this.idLaboTextBox1.Name = "idLaboTextBox1";
            this.idLaboTextBox1.Size = new System.Drawing.Size(100, 20);
            this.idLaboTextBox1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "modifier les informations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Modif_click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.25F);
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 33);
            this.label1.TabIndex = 31;
            this.label1.Text = "Information du visiteur : ";
            // 
            // FInfosVistiteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::scrublords.Properties.Resources.logo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 313);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLaboLabel1);
            this.Controls.Add(this.idLaboTextBox1);
            this.Controls.Add(dateEmbaucheLabel);
            this.Controls.Add(this.dateEmbaucheTextBox);
            this.Controls.Add(idVisiteurLabel);
            this.Controls.Add(this.idVisiteurTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(rueLabel);
            this.Controls.Add(this.rueTextBox);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.villeTextBox);
            this.Name = "FInfosVistiteurs";
            this.Text = "FInfosVisiteurs";

            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssecteur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dateEmbaucheTextBox;
        private System.Windows.Forms.TextBox idVisiteurTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox rueTextBox;
        private System.Windows.Forms.TextBox villeTextBox;
        private System.Windows.Forms.TextBox idLaboTextBox1;
        private System.Windows.Forms.BindingSource bsvisiteur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bssecteur;
    }
}
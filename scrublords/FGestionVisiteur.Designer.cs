namespace scrublords
{
    partial class FGestionVisiteur
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
            this.dgvvisiteur = new System.Windows.Forms.DataGridView();
            this.bsvisiteur = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvvisiteur
            // 
            this.dgvvisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvisiteur.Location = new System.Drawing.Point(20, 12);
            this.dgvvisiteur.Name = "dgvvisiteur";
            this.dgvvisiteur.Size = new System.Drawing.Size(737, 426);
            this.dgvvisiteur.TabIndex = 0;
            // 
            // FGestionVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvvisiteur);
            this.Name = "FGestionVisiteur";
            this.Text = "FGestionVisiteur";
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvvisiteur;
        private System.Windows.Forms.BindingSource bsvisiteur;
    }
}
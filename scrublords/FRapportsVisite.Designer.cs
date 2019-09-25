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
            this.dgvRapVis = new System.Windows.Forms.DataGridView();
            this.bsRapVis = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapVis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapVis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRapVis
            // 
            this.dgvRapVis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapVis.Location = new System.Drawing.Point(276, 88);
            this.dgvRapVis.Name = "dgvRapVis";
            this.dgvRapVis.Size = new System.Drawing.Size(240, 150);
            this.dgvRapVis.TabIndex = 0;
            // 
            // FRapportsVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvRapVis);
            this.Name = "FRapportsVisite";
            this.Text = "FRapportsVisite";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapVis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapVis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRapVis;
        private System.Windows.Forms.BindingSource bsRapVis;
    }
}
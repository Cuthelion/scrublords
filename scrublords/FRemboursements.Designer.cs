namespace scrublords
{
    partial class FRemboursements
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
            this.bsvisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.labelnomUtil = new System.Windows.Forms.Label();
            this.labelMDP = new System.Windows.Forms.Label();
            this.nomUtil = new System.Windows.Forms.TextBox();
            this.mdp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnomUtil
            // 
            this.labelnomUtil.AutoSize = true;
            this.labelnomUtil.Location = new System.Drawing.Point(57, 28);
            this.labelnomUtil.Name = "labelnomUtil";
            this.labelnomUtil.Size = new System.Drawing.Size(90, 13);
            this.labelnomUtil.TabIndex = 0;
            this.labelnomUtil.Text = "Nom d\'utilisateur :";
            // 
            // labelMDP
            // 
            this.labelMDP.AutoSize = true;
            this.labelMDP.Location = new System.Drawing.Point(57, 91);
            this.labelMDP.Name = "labelMDP";
            this.labelMDP.Size = new System.Drawing.Size(77, 13);
            this.labelMDP.TabIndex = 1;
            this.labelMDP.Text = "Mot de passe :";
            // 
            // nomUtil
            // 
            this.nomUtil.Location = new System.Drawing.Point(153, 25);
            this.nomUtil.Name = "nomUtil";
            this.nomUtil.Size = new System.Drawing.Size(153, 20);
            this.nomUtil.TabIndex = 2;
            // 
            // mdp
            // 
            this.mdp.Location = new System.Drawing.Point(153, 91);
            this.mdp.Name = "mdp";
            this.mdp.PasswordChar = '*';
            this.mdp.Size = new System.Drawing.Size(153, 20);
            this.mdp.TabIndex = 3;
            // 
            // FRemboursements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mdp);
            this.Controls.Add(this.nomUtil);
            this.Controls.Add(this.labelMDP);
            this.Controls.Add(this.labelnomUtil);
            this.Name = "FRemboursements";
            this.Text = "FRemboursements";
            this.Load += new System.EventHandler(this.FRemboursements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsvisiteur;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.Label labelnomUtil;
        private System.Windows.Forms.Label labelMDP;
        private System.Windows.Forms.TextBox nomUtil;
        private System.Windows.Forms.TextBox mdp;
    }
}
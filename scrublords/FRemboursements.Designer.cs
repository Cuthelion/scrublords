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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsvisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbNom = new System.Windows.Forms.Label();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.bsFiches = new System.Windows.Forms.BindingSource(this.components);
            this.lbnbfiches = new System.Windows.Forms.Label();
            this.buttonCmplt = new System.Windows.Forms.Button();
            this.buttonCnlt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiches)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(660, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbNom.Location = new System.Drawing.Point(12, 9);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(78, 13);
            this.lbNom.TabIndex = 3;
            this.lbNom.Text = "SAMPLETEXT";
            // 
            // lbnbfiches
            // 
            this.lbnbfiches.AutoSize = true;
            this.lbnbfiches.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbnbfiches.Location = new System.Drawing.Point(12, 35);
            this.lbnbfiches.Name = "lbnbfiches";
            this.lbnbfiches.Size = new System.Drawing.Size(78, 13);
            this.lbnbfiches.TabIndex = 4;
            this.lbnbfiches.Text = "SAMPLETEXT";
            // 
            // buttonCmplt
            // 
            this.buttonCmplt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCmplt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCmplt.Location = new System.Drawing.Point(12, 458);
            this.buttonCmplt.Name = "buttonCmplt";
            this.buttonCmplt.Size = new System.Drawing.Size(75, 41);
            this.buttonCmplt.TabIndex = 5;
            this.buttonCmplt.Text = "Consulter";
            this.buttonCmplt.UseVisualStyleBackColor = true;
            this.buttonCmplt.Click += new System.EventHandler(this.ButtonCmplt_Click);
            // 
            // buttonCnlt
            // 
            this.buttonCnlt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCnlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCnlt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCnlt.Location = new System.Drawing.Point(99, 458);
            this.buttonCnlt.Name = "buttonCnlt";
            this.buttonCnlt.Size = new System.Drawing.Size(75, 41);
            this.buttonCnlt.TabIndex = 6;
            this.buttonCnlt.Text = "Completer";
            this.buttonCnlt.UseVisualStyleBackColor = true;
            this.buttonCnlt.Click += new System.EventHandler(this.ButtonCnlt_Click);
            // 
            // FRemboursements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(684, 530);
            this.Controls.Add(this.buttonCnlt);
            this.Controls.Add(this.buttonCmplt);
            this.Controls.Add(this.lbnbfiches);
            this.Controls.Add(this.lbNom);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FRemboursements";
            this.Text = "FRemboursements";
            this.Load += new System.EventHandler(this.FRemboursements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFiches)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsvisiteur;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.BindingSource bsFiches;
        private System.Windows.Forms.Label lbnbfiches;
        private System.Windows.Forms.Button buttonCmplt;
        private System.Windows.Forms.Button buttonCnlt;
    }
}
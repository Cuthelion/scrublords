namespace scrublords
{
    partial class Flistevisiteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flistevisiteur));
            this.bsvisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.dgvvisiteur = new System.Windows.Forms.DataGridView();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLaboDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmbaucheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identifiantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichefraisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laboratoireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rAPPORTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visiteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bnvisiteur = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnvisiteur)).BeginInit();
            this.bnvisiteur.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvvisiteur
            // 
            this.dgvvisiteur.AutoGenerateColumns = false;
            this.dgvvisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvisiteur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVisiteurDataGridViewTextBoxColumn,
            this.idLaboDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.rueDataGridViewTextBoxColumn,
            this.cpDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.dateEmbaucheDataGridViewTextBoxColumn,
            this.identifiantDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.fichefraisDataGridViewTextBoxColumn,
            this.laboratoireDataGridViewTextBoxColumn,
            this.rAPPORTDataGridViewTextBoxColumn,
            this.regionDataGridViewTextBoxColumn,
            this.secteurDataGridViewTextBoxColumn,
            this.region1DataGridViewTextBoxColumn});
            this.dgvvisiteur.DataSource = this.visiteurBindingSource;
            this.dgvvisiteur.Location = new System.Drawing.Point(12, 24);
            this.dgvvisiteur.Name = "dgvvisiteur";
            this.dgvvisiteur.Size = new System.Drawing.Size(1745, 282);
            this.dgvvisiteur.TabIndex = 0;
            // 
            // idVisiteurDataGridViewTextBoxColumn
            // 
            this.idVisiteurDataGridViewTextBoxColumn.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.HeaderText = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.Name = "idVisiteurDataGridViewTextBoxColumn";
            // 
            // idLaboDataGridViewTextBoxColumn
            // 
            this.idLaboDataGridViewTextBoxColumn.DataPropertyName = "idLabo";
            this.idLaboDataGridViewTextBoxColumn.HeaderText = "idLabo";
            this.idLaboDataGridViewTextBoxColumn.Name = "idLaboDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // rueDataGridViewTextBoxColumn
            // 
            this.rueDataGridViewTextBoxColumn.DataPropertyName = "rue";
            this.rueDataGridViewTextBoxColumn.HeaderText = "rue";
            this.rueDataGridViewTextBoxColumn.Name = "rueDataGridViewTextBoxColumn";
            // 
            // cpDataGridViewTextBoxColumn
            // 
            this.cpDataGridViewTextBoxColumn.DataPropertyName = "cp";
            this.cpDataGridViewTextBoxColumn.HeaderText = "cp";
            this.cpDataGridViewTextBoxColumn.Name = "cpDataGridViewTextBoxColumn";
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            // 
            // dateEmbaucheDataGridViewTextBoxColumn
            // 
            this.dateEmbaucheDataGridViewTextBoxColumn.DataPropertyName = "dateEmbauche";
            this.dateEmbaucheDataGridViewTextBoxColumn.HeaderText = "dateEmbauche";
            this.dateEmbaucheDataGridViewTextBoxColumn.Name = "dateEmbaucheDataGridViewTextBoxColumn";
            // 
            // identifiantDataGridViewTextBoxColumn
            // 
            this.identifiantDataGridViewTextBoxColumn.DataPropertyName = "identifiant";
            this.identifiantDataGridViewTextBoxColumn.HeaderText = "identifiant";
            this.identifiantDataGridViewTextBoxColumn.Name = "identifiantDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // fichefraisDataGridViewTextBoxColumn
            // 
            this.fichefraisDataGridViewTextBoxColumn.DataPropertyName = "fichefrais";
            this.fichefraisDataGridViewTextBoxColumn.HeaderText = "fichefrais";
            this.fichefraisDataGridViewTextBoxColumn.Name = "fichefraisDataGridViewTextBoxColumn";
            // 
            // laboratoireDataGridViewTextBoxColumn
            // 
            this.laboratoireDataGridViewTextBoxColumn.DataPropertyName = "Laboratoire";
            this.laboratoireDataGridViewTextBoxColumn.HeaderText = "Laboratoire";
            this.laboratoireDataGridViewTextBoxColumn.Name = "laboratoireDataGridViewTextBoxColumn";
            // 
            // rAPPORTDataGridViewTextBoxColumn
            // 
            this.rAPPORTDataGridViewTextBoxColumn.DataPropertyName = "RAPPORT";
            this.rAPPORTDataGridViewTextBoxColumn.HeaderText = "RAPPORT";
            this.rAPPORTDataGridViewTextBoxColumn.Name = "rAPPORTDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            this.regionDataGridViewTextBoxColumn.DataPropertyName = "Region";
            this.regionDataGridViewTextBoxColumn.HeaderText = "Region";
            this.regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // secteurDataGridViewTextBoxColumn
            // 
            this.secteurDataGridViewTextBoxColumn.DataPropertyName = "Secteur";
            this.secteurDataGridViewTextBoxColumn.HeaderText = "Secteur";
            this.secteurDataGridViewTextBoxColumn.Name = "secteurDataGridViewTextBoxColumn";
            // 
            // region1DataGridViewTextBoxColumn
            // 
            this.region1DataGridViewTextBoxColumn.DataPropertyName = "Region1";
            this.region1DataGridViewTextBoxColumn.HeaderText = "Region1";
            this.region1DataGridViewTextBoxColumn.Name = "region1DataGridViewTextBoxColumn";
            // 
            // visiteurBindingSource
            // 
            this.visiteurBindingSource.DataSource = typeof(scrublords.Visiteur);
            // 
            // bnvisiteur
            // 
            this.bnvisiteur.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bnvisiteur.CountItem = this.bindingNavigatorCountItem;
            this.bnvisiteur.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bnvisiteur.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bnvisiteur.Location = new System.Drawing.Point(0, 0);
            this.bnvisiteur.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnvisiteur.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnvisiteur.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnvisiteur.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnvisiteur.Name = "bnvisiteur";
            this.bnvisiteur.PositionItem = this.bindingNavigatorPositionItem;
            this.bnvisiteur.Size = new System.Drawing.Size(1920, 25);
            this.bnvisiteur.TabIndex = 1;
            this.bnvisiteur.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // Flistevisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 450);
            this.Controls.Add(this.bnvisiteur);
            this.Controls.Add(this.dgvvisiteur);
            this.Name = "Flistevisiteur";
            this.Text = "Flistevisiteur";
            ((System.ComponentModel.ISupportInitialize)(this.bsvisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnvisiteur)).EndInit();
            this.bnvisiteur.ResumeLayout(false);
            this.bnvisiteur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsvisiteur;
        private System.Windows.Forms.DataGridView dgvvisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLaboDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmbaucheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identifiantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fichefraisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laboratoireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rAPPORTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn region1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource visiteurBindingSource;
        private System.Windows.Forms.BindingNavigator bnvisiteur;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}
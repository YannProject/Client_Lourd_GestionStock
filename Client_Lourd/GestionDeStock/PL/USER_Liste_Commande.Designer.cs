﻿
namespace GestionDeStock.PL
{
    partial class USER_Liste_Commande
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnajouter = new System.Windows.Forms.Button();
            this.dvgCommande = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnrecherche = new System.Windows.Forms.Button();
            this.btnimprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnajouter.FlatAppearance.BorderSize = 0;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnajouter.Image = global::GestionDeStock.Properties.Resources.Actions_list_add_icon;
            this.btnajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouter.Location = new System.Drawing.Point(20, 13);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(245, 60);
            this.btnajouter.TabIndex = 11;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // dvgCommande
            // 
            this.dvgCommande.AllowUserToAddRows = false;
            this.dvgCommande.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgCommande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgCommande.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgCommande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgCommande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCommande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column9,
            this.Date,
            this.Client,
            this.TotalHT,
            this.TVA,
            this.TotalTTC});
            this.dvgCommande.EnableHeadersVisualStyles = false;
            this.dvgCommande.Location = new System.Drawing.Point(3, 79);
            this.dvgCommande.Name = "dvgCommande";
            this.dvgCommande.RowHeadersVisible = false;
            this.dvgCommande.RowHeadersWidth = 51;
            this.dvgCommande.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgCommande.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgCommande.Size = new System.Drawing.Size(1131, 568);
            this.dvgCommande.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            // 
            // TotalHT
            // 
            this.TotalHT.HeaderText = "Total HT";
            this.TotalHT.Name = "TotalHT";
            // 
            // TVA
            // 
            this.TVA.HeaderText = "TVA %";
            this.TVA.Name = "TVA";
            // 
            // TotalTTC
            // 
            this.TotalTTC.HeaderText = "Total TTC";
            this.TotalTTC.Name = "TotalTTC";
            // 
            // dateDebut
            // 
            this.dateDebut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDebut.Location = new System.Drawing.Point(404, 29);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(262, 26);
            this.dateDebut.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.textBox1.Location = new System.Drawing.Point(282, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 26);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Date Début :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dateFin
            // 
            this.dateFin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFin.Location = new System.Drawing.Point(785, 29);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(255, 26);
            this.dateFin.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.textBox2.Location = new System.Drawing.Point(682, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 26);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "Date Fin :";
            // 
            // btnrecherche
            // 
            this.btnrecherche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnrecherche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrecherche.FlatAppearance.BorderSize = 0;
            this.btnrecherche.Image = global::GestionDeStock.Properties.Resources.search;
            this.btnrecherche.Location = new System.Drawing.Point(1065, 17);
            this.btnrecherche.Name = "btnrecherche";
            this.btnrecherche.Size = new System.Drawing.Size(56, 55);
            this.btnrecherche.TabIndex = 26;
            this.btnrecherche.UseVisualStyleBackColor = true;
            // 
            // btnimprimer
            // 
            this.btnimprimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnimprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.btnimprimer.FlatAppearance.BorderSize = 0;
            this.btnimprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimer.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnimprimer.Image = global::GestionDeStock.Properties.Resources.print_icon;
            this.btnimprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimer.Location = new System.Drawing.Point(785, 653);
            this.btnimprimer.Name = "btnimprimer";
            this.btnimprimer.Size = new System.Drawing.Size(349, 60);
            this.btnimprimer.TabIndex = 27;
            this.btnimprimer.Text = "Imprimer Commande";
            this.btnimprimer.UseVisualStyleBackColor = false;
            // 
            // USER_Liste_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnimprimer);
            this.Controls.Add(this.btnrecherche);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dateFin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.dvgCommande);
            this.Controls.Add(this.btnajouter);
            this.Name = "USER_Liste_Commande";
            this.Size = new System.Drawing.Size(1137, 720);
            ((System.ComponentModel.ISupportInitialize)(this.dvgCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.DataGridView dvgCommande;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnrecherche;
        private System.Windows.Forms.Button btnimprimer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTTC;
    }
}

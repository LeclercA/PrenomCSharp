namespace OrdrePrenom
{
    partial class frmPrenom
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTrierLesNoms = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTrierLesNoms
            // 
            this.btnTrierLesNoms.Location = new System.Drawing.Point(56, 12);
            this.btnTrierLesNoms.Name = "btnTrierLesNoms";
            this.btnTrierLesNoms.Size = new System.Drawing.Size(100, 23);
            this.btnTrierLesNoms.TabIndex = 0;
            this.btnTrierLesNoms.Text = "Trier les prénoms";
            this.btnTrierLesNoms.UseVisualStyleBackColor = true;
            this.btnTrierLesNoms.Click += new System.EventHandler(this.btnTrierLesNoms_Click);
            // 
            // frmPrenom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 49);
            this.Controls.Add(this.btnTrierLesNoms);
            this.Name = "frmPrenom";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTrierLesNoms;
    }
}


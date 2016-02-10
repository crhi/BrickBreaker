namespace testMenu
{
    partial class Form2
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
            this.barre1 = new testMenu.barre();
            this.ball1 = new testMenu.ball();
            this.brickBreaker1 = new testMenu.Brick();
            this.SuspendLayout();
            // 
            // barre1
            // 
            this.barre1.Location = new System.Drawing.Point(407, 523);
            this.barre1.Name = "barre1";
            this.barre1.Size = new System.Drawing.Size(120, 45);
            this.barre1.TabIndex = 12;
            this.barre1.Text = "barre1";
            // 
            // ball1
            // 
            this.ball1.Location = new System.Drawing.Point(364, 346);
            this.ball1.Name = "ball1";
            this.ball1.Size = new System.Drawing.Size(35, 35);
            this.ball1.TabIndex = 11;
            this.ball1.Text = "ball1";
            // 
            // brickBreaker1
            // 
            this.brickBreaker1.Location = new System.Drawing.Point(12, 12);
            this.brickBreaker1.Name = "brickBreaker1";
            this.brickBreaker1.Size = new System.Drawing.Size(784, 311);
            this.brickBreaker1.TabIndex = 1;
            this.brickBreaker1.Text = "brickBreaker1";
            this.brickBreaker1.Click += new System.EventHandler(this.brickBreaker1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 580);
            this.Controls.Add(this.barre1);
            this.Controls.Add(this.ball1);
            this.Controls.Add(this.brickBreaker1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private Brick brickBreaker1;
        private ball ball1;
        private barre barre1;

    }
}
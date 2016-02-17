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
            this.brickBreakerControl = new testMenu.BrickBreaker();
            this.SuspendLayout();
            // 
            // brickBreakerControl
            // 
            this.brickBreakerControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.brickBreakerControl.Location = new System.Drawing.Point(0, 0);
            this.brickBreakerControl.Name = "brickBreakerControl";
            this.brickBreakerControl.Size = new System.Drawing.Size(864, 621);
            this.brickBreakerControl.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 580);
            this.Controls.Add(this.brickBreakerControl);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private BrickBreaker brickBreakerControl;

    }
}
namespace testMenu
{
    partial class Form1
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
            this.ConfirmationButton = new System.Windows.Forms.Button();
            this.IDBox1 = new System.Windows.Forms.TextBox();
            this.IDText = new System.Windows.Forms.Label();
            this.IDText2 = new System.Windows.Forms.Label();
            this.IDBox2 = new System.Windows.Forms.TextBox();
            this.brick1 = new testMenu.BrickBreaker();
            this.brick2 = new testMenu.BrickBreaker();
            this.SuspendLayout();
            // 
            // ConfirmationButton
            // 
            this.ConfirmationButton.Location = new System.Drawing.Point(479, 227);
            this.ConfirmationButton.Name = "ConfirmationButton";
            this.ConfirmationButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmationButton.TabIndex = 4;
            this.ConfirmationButton.Text = "Confirmer";
            this.ConfirmationButton.UseVisualStyleBackColor = true;
            this.ConfirmationButton.Click += new System.EventHandler(this.ConfirmationButton_Click);
            // 
            // IDBox1
            // 
            this.IDBox1.Location = new System.Drawing.Point(257, 192);
            this.IDBox1.Name = "IDBox1";
            this.IDBox1.Size = new System.Drawing.Size(212, 20);
            this.IDBox1.TabIndex = 5;
            // 
            // IDText
            // 
            this.IDText.AutoSize = true;
            this.IDText.Location = new System.Drawing.Point(163, 198);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(53, 13);
            this.IDText.TabIndex = 6;
            this.IDText.Text = "Identifiant";
            // 
            // IDText2
            // 
            this.IDText2.AutoSize = true;
            this.IDText2.Location = new System.Drawing.Point(166, 227);
            this.IDText2.Name = "IDText2";
            this.IDText2.Size = new System.Drawing.Size(71, 13);
            this.IDText2.TabIndex = 7;
            this.IDText2.Text = "Mot de passe";
            // 
            // IDBox2
            // 
            this.IDBox2.Location = new System.Drawing.Point(257, 227);
            this.IDBox2.Name = "IDBox2";
            this.IDBox2.Size = new System.Drawing.Size(212, 20);
            this.IDBox2.TabIndex = 8;
            this.IDBox2.UseSystemPasswordChar = true;
            // 
            // brick1
            // 
            this.brick1.Location = new System.Drawing.Point(12, 12);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(745, 174);
            this.brick1.TabIndex = 9;
            this.brick1.Text = "brick1";
            // 
            // brick2
            // 
            this.brick2.Location = new System.Drawing.Point(12, 253);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(745, 183);
            this.brick2.TabIndex = 10;
            this.brick2.Text = "brick2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 462);
            this.Controls.Add(this.IDBox2);
            this.Controls.Add(this.IDText2);
            this.Controls.Add(this.IDText);
            this.Controls.Add(this.IDBox1);
            this.Controls.Add(this.ConfirmationButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmationButton;
        private System.Windows.Forms.TextBox IDBox1;
        private System.Windows.Forms.Label IDText;
        private System.Windows.Forms.Label IDText2;
        private System.Windows.Forms.TextBox IDBox2;
        private BrickBreaker brick1;
        private BrickBreaker brick2;
    }
}


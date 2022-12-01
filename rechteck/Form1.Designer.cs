namespace rechteck
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.berechnen = new System.Windows.Forms.Button();
            this.beenden = new System.Windows.Forms.Button();
            this.breitetext = new System.Windows.Forms.Label();
            this.höhetext = new System.Windows.Forms.Label();
            this.ausgabetext = new System.Windows.Forms.Label();
            this.textbreite = new System.Windows.Forms.TextBox();
            this.texthöhe = new System.Windows.Forms.TextBox();
            this.textausgabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // berechnen
            // 
            this.berechnen.Location = new System.Drawing.Point(516, 59);
            this.berechnen.Name = "berechnen";
            this.berechnen.Size = new System.Drawing.Size(372, 48);
            this.berechnen.TabIndex = 0;
            this.berechnen.Text = "berechnen";
            this.berechnen.UseVisualStyleBackColor = true;
            this.berechnen.Click += new System.EventHandler(this.berechnen_Click);
            // 
            // beenden
            // 
            this.beenden.Location = new System.Drawing.Point(516, 278);
            this.beenden.Name = "beenden";
            this.beenden.Size = new System.Drawing.Size(372, 53);
            this.beenden.TabIndex = 1;
            this.beenden.Text = "beenden";
            this.beenden.UseVisualStyleBackColor = true;
            this.beenden.Click += new System.EventHandler(this.beenden_Click);
            // 
            // breitetext
            // 
            this.breitetext.AutoSize = true;
            this.breitetext.Location = new System.Drawing.Point(40, 32);
            this.breitetext.Name = "breitetext";
            this.breitetext.Size = new System.Drawing.Size(49, 20);
            this.breitetext.TabIndex = 2;
            this.breitetext.Text = "breite";
            // 
            // höhetext
            // 
            this.höhetext.AutoSize = true;
            this.höhetext.Location = new System.Drawing.Point(40, 103);
            this.höhetext.Name = "höhetext";
            this.höhetext.Size = new System.Drawing.Size(45, 20);
            this.höhetext.TabIndex = 3;
            this.höhetext.Text = "höhe";
            // 
            // ausgabetext
            // 
            this.ausgabetext.AutoSize = true;
            this.ausgabetext.Location = new System.Drawing.Point(40, 294);
            this.ausgabetext.Name = "ausgabetext";
            this.ausgabetext.Size = new System.Drawing.Size(71, 20);
            this.ausgabetext.TabIndex = 4;
            this.ausgabetext.Text = "ausgabe";
            // 
            // textbreite
            // 
            this.textbreite.Location = new System.Drawing.Point(178, 36);
            this.textbreite.Name = "textbreite";
            this.textbreite.Size = new System.Drawing.Size(163, 26);
            this.textbreite.TabIndex = 5;
            this.textbreite.TextChanged += new System.EventHandler(this.textbreite_TextChanged);
            // 
            // texthöhe
            // 
            this.texthöhe.Location = new System.Drawing.Point(178, 100);
            this.texthöhe.Name = "texthöhe";
            this.texthöhe.Size = new System.Drawing.Size(163, 26);
            this.texthöhe.TabIndex = 6;
            this.texthöhe.TextChanged += new System.EventHandler(this.texthöhe_TextChanged);
            // 
            // textausgabe
            // 
            this.textausgabe.Location = new System.Drawing.Point(178, 291);
            this.textausgabe.Name = "textausgabe";
            this.textausgabe.Size = new System.Drawing.Size(163, 26);
            this.textausgabe.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 450);
            this.Controls.Add(this.textausgabe);
            this.Controls.Add(this.texthöhe);
            this.Controls.Add(this.textbreite);
            this.Controls.Add(this.ausgabetext);
            this.Controls.Add(this.höhetext);
            this.Controls.Add(this.breitetext);
            this.Controls.Add(this.beenden);
            this.Controls.Add(this.berechnen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button berechnen;
        private System.Windows.Forms.Button beenden;
        private System.Windows.Forms.Label breitetext;
        private System.Windows.Forms.Label höhetext;
        private System.Windows.Forms.Label ausgabetext;
        private System.Windows.Forms.TextBox textbreite;
        private System.Windows.Forms.TextBox texthöhe;
        private System.Windows.Forms.TextBox textausgabe;
    }
}


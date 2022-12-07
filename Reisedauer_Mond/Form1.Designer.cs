namespace Reisedauer_Mond
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
            this.Tage = new System.Windows.Forms.RadioButton();
            this.Stunden = new System.Windows.Forms.RadioButton();
            this.Geschwindigkeit = new System.Windows.Forms.Label();
            this.textBoxgeschwindigkeit = new System.Windows.Forms.TextBox();
            this.Reisedauer = new System.Windows.Forms.Button();
            this.Ausgabe = new System.Windows.Forms.Label();
            this.textBoxausgabe = new System.Windows.Forms.TextBox();
            this.Titel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tage
            // 
            this.Tage.AutoSize = true;
            this.Tage.Location = new System.Drawing.Point(59, 124);
            this.Tage.Name = "Tage";
            this.Tage.Size = new System.Drawing.Size(95, 24);
            this.Tage.TabIndex = 0;
            this.Tage.TabStop = true;
            this.Tage.Text = "in Tagen";
            this.Tage.UseVisualStyleBackColor = true;
            // 
            // Stunden
            // 
            this.Stunden.AutoSize = true;
            this.Stunden.Location = new System.Drawing.Point(327, 124);
            this.Stunden.Name = "Stunden";
            this.Stunden.Size = new System.Drawing.Size(111, 24);
            this.Stunden.TabIndex = 1;
            this.Stunden.TabStop = true;
            this.Stunden.Text = "in Stunden";
            this.Stunden.UseVisualStyleBackColor = true;
            // 
            // Geschwindigkeit
            // 
            this.Geschwindigkeit.AutoSize = true;
            this.Geschwindigkeit.Location = new System.Drawing.Point(55, 181);
            this.Geschwindigkeit.Name = "Geschwindigkeit";
            this.Geschwindigkeit.Size = new System.Drawing.Size(179, 20);
            this.Geschwindigkeit.TabIndex = 2;
            this.Geschwindigkeit.Text = "Geschwindigkeit in km/h";
            // 
            // textBoxgeschwindigkeit
            // 
            this.textBoxgeschwindigkeit.Location = new System.Drawing.Point(290, 178);
            this.textBoxgeschwindigkeit.Name = "textBoxgeschwindigkeit";
            this.textBoxgeschwindigkeit.Size = new System.Drawing.Size(148, 26);
            this.textBoxgeschwindigkeit.TabIndex = 3;
            // 
            // Reisedauer
            // 
            this.Reisedauer.Location = new System.Drawing.Point(59, 256);
            this.Reisedauer.Name = "Reisedauer";
            this.Reisedauer.Size = new System.Drawing.Size(379, 32);
            this.Reisedauer.TabIndex = 4;
            this.Reisedauer.Text = "Reisedauer berechnen";
            this.Reisedauer.UseVisualStyleBackColor = true;
            this.Reisedauer.Click += new System.EventHandler(this.Reisedauer_Click);
            // 
            // Ausgabe
            // 
            this.Ausgabe.AutoSize = true;
            this.Ausgabe.Location = new System.Drawing.Point(55, 335);
            this.Ausgabe.Name = "Ausgabe";
            this.Ausgabe.Size = new System.Drawing.Size(159, 20);
            this.Ausgabe.TabIndex = 5;
            this.Ausgabe.Text = "Ausgabe Reisedauer";
            // 
            // textBoxausgabe
            // 
            this.textBoxausgabe.Location = new System.Drawing.Point(290, 335);
            this.textBoxausgabe.Name = "textBoxausgabe";
            this.textBoxausgabe.Size = new System.Drawing.Size(148, 26);
            this.textBoxausgabe.TabIndex = 6;
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Location = new System.Drawing.Point(128, 63);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(249, 20);
            this.Titel.TabIndex = 7;
            this.Titel.Text = "Reisedauer zum Mond berechnen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.Titel);
            this.Controls.Add(this.textBoxausgabe);
            this.Controls.Add(this.Ausgabe);
            this.Controls.Add(this.Reisedauer);
            this.Controls.Add(this.textBoxgeschwindigkeit);
            this.Controls.Add(this.Geschwindigkeit);
            this.Controls.Add(this.Stunden);
            this.Controls.Add(this.Tage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Tage;
        private System.Windows.Forms.RadioButton Stunden;
        private System.Windows.Forms.Label Geschwindigkeit;
        private System.Windows.Forms.TextBox textBoxgeschwindigkeit;
        private System.Windows.Forms.Button Reisedauer;
        private System.Windows.Forms.Label Ausgabe;
        private System.Windows.Forms.TextBox textBoxausgabe;
        private System.Windows.Forms.Label Titel;
    }
}


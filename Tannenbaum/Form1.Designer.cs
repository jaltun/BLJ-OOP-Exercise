namespace Tannenbaum
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
            this.stammbreite = new System.Windows.Forms.Label();
            this.stammhöhe = new System.Windows.Forms.Label();
            this.kronenhöhe = new System.Windows.Forms.Label();
            this.textstammbreite = new System.Windows.Forms.TextBox();
            this.textstammhöhe = new System.Windows.Forms.TextBox();
            this.textkronenhöhe = new System.Windows.Forms.TextBox();
            this.textBoxZeichnung = new System.Windows.Forms.TextBox();
            this.zeichnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stammbreite
            // 
            this.stammbreite.AutoSize = true;
            this.stammbreite.Location = new System.Drawing.Point(26, 68);
            this.stammbreite.Name = "stammbreite";
            this.stammbreite.Size = new System.Drawing.Size(97, 20);
            this.stammbreite.TabIndex = 0;
            this.stammbreite.Text = "stammbreite";
            // 
            // stammhöhe
            // 
            this.stammhöhe.AutoSize = true;
            this.stammhöhe.Location = new System.Drawing.Point(27, 115);
            this.stammhöhe.Name = "stammhöhe";
            this.stammhöhe.Size = new System.Drawing.Size(93, 20);
            this.stammhöhe.TabIndex = 1;
            this.stammhöhe.Text = "stammhöhe";
            // 
            // kronenhöhe
            // 
            this.kronenhöhe.AutoSize = true;
            this.kronenhöhe.Location = new System.Drawing.Point(26, 169);
            this.kronenhöhe.Name = "kronenhöhe";
            this.kronenhöhe.Size = new System.Drawing.Size(94, 20);
            this.kronenhöhe.TabIndex = 2;
            this.kronenhöhe.Text = "kronenhöhe";
            // 
            // textstammbreite
            // 
            this.textstammbreite.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textstammbreite.Location = new System.Drawing.Point(152, 66);
            this.textstammbreite.Name = "textstammbreite";
            this.textstammbreite.Size = new System.Drawing.Size(141, 26);
            this.textstammbreite.TabIndex = 3;
            // 
            // textstammhöhe
            // 
            this.textstammhöhe.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textstammhöhe.Location = new System.Drawing.Point(152, 114);
            this.textstammhöhe.Name = "textstammhöhe";
            this.textstammhöhe.Size = new System.Drawing.Size(140, 26);
            this.textstammhöhe.TabIndex = 4;
            // 
            // textkronenhöhe
            // 
            this.textkronenhöhe.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textkronenhöhe.Location = new System.Drawing.Point(152, 169);
            this.textkronenhöhe.Name = "textkronenhöhe";
            this.textkronenhöhe.Size = new System.Drawing.Size(140, 26);
            this.textkronenhöhe.TabIndex = 5;
            // 
            // textBoxZeichnung
            // 
            this.textBoxZeichnung.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxZeichnung.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZeichnung.Location = new System.Drawing.Point(27, 257);
            this.textBoxZeichnung.Multiline = true;
            this.textBoxZeichnung.Name = "textBoxZeichnung";
            this.textBoxZeichnung.Size = new System.Drawing.Size(439, 483);
            this.textBoxZeichnung.TabIndex = 6;
            // 
            // zeichnen
            // 
            this.zeichnen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.zeichnen.Location = new System.Drawing.Point(332, 169);
            this.zeichnen.Name = "zeichnen";
            this.zeichnen.Size = new System.Drawing.Size(134, 30);
            this.zeichnen.TabIndex = 7;
            this.zeichnen.Text = "Tanne zeichnen";
            this.zeichnen.UseVisualStyleBackColor = false;
            this.zeichnen.Click += new System.EventHandler(this.zeichnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(588, 752);
            this.Controls.Add(this.zeichnen);
            this.Controls.Add(this.textBoxZeichnung);
            this.Controls.Add(this.textkronenhöhe);
            this.Controls.Add(this.textstammhöhe);
            this.Controls.Add(this.textstammbreite);
            this.Controls.Add(this.kronenhöhe);
            this.Controls.Add(this.stammhöhe);
            this.Controls.Add(this.stammbreite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stammbreite;
        private System.Windows.Forms.Label stammhöhe;
        private System.Windows.Forms.Label kronenhöhe;
        private System.Windows.Forms.TextBox textstammbreite;
        private System.Windows.Forms.TextBox textstammhöhe;
        private System.Windows.Forms.TextBox textkronenhöhe;
        private System.Windows.Forms.TextBox textBoxZeichnung;
        private System.Windows.Forms.Button zeichnen;
    }
}


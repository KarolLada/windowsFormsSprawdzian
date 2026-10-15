namespace windowsFormsSprawdzian
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.parkingLabel = new System.Windows.Forms.Label();
            this.hourText = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // parkingLabel
            // 
            this.parkingLabel.AutoSize = true;
            this.parkingLabel.Location = new System.Drawing.Point(83, 63);
            this.parkingLabel.Name = "parkingLabel";
            this.parkingLabel.Size = new System.Drawing.Size(174, 16);
            this.parkingLabel.TabIndex = 0;
            this.parkingLabel.Text = "liczba pełnych godzin (1-20)";
            // 
            // hourText
            // 
            this.hourText.Location = new System.Drawing.Point(86, 137);
            this.hourText.Name = "hourText";
            this.hourText.Size = new System.Drawing.Size(106, 22);
            this.hourText.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(88, 210);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(104, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Oblicz opłatę";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(329, 137);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(50, 16);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Wynik: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.hourText);
            this.Controls.Add(this.parkingLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label parkingLabel;
        private System.Windows.Forms.TextBox hourText;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
    }
}


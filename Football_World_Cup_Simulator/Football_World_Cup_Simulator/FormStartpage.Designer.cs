namespace WorldCupSimulator2
{
    partial class FormStartpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartpage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Starup = new System.Windows.Forms.Button();
            this.authorsLabel = new System.Windows.Forms.Label();
            this.titleLable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(208, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 197);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Starup
            // 
            this.Btn_Starup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Starup.Location = new System.Drawing.Point(222, 437);
            this.Btn_Starup.Name = "Btn_Starup";
            this.Btn_Starup.Size = new System.Drawing.Size(176, 23);
            this.Btn_Starup.TabIndex = 1;
            this.Btn_Starup.Text = "Kliknij aby rozpocząć";
            this.Btn_Starup.UseVisualStyleBackColor = true;
            this.Btn_Starup.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // authorsLabel
            // 
            this.authorsLabel.AutoSize = true;
            this.authorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.authorsLabel.Location = new System.Drawing.Point(221, 399);
            this.authorsLabel.Name = "authorsLabel";
            this.authorsLabel.Size = new System.Drawing.Size(172, 18);
            this.authorsLabel.TabIndex = 2;
            this.authorsLabel.Text = "Autor: Konrad Tarnowski";
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLable.Location = new System.Drawing.Point(49, 356);
            this.titleLable.Name = "titleLable";
            this.titleLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.titleLable.Size = new System.Drawing.Size(537, 25);
            this.titleLable.TabIndex = 3;
            this.titleLable.Text = "Symulator rozgrywek Mistrzostw Świata w Piłce Nożnej";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Uniwerystet Kardynała Stefana Wyszyńskiego w Warszawie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(108, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wydział Matemtyczno-Przyrodniczy. Szkoła Nauk Ścisłych";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(248, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Warszawa 2019";
            // 
            // FormStartpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 574);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLable);
            this.Controls.Add(this.authorsLabel);
            this.Controls.Add(this.Btn_Starup);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStartpage";
            this.Text = "Okno powitalne UKSW";
            this.Load += new System.EventHandler(this.FormStartpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Starup;
        private System.Windows.Forms.Label authorsLabel;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


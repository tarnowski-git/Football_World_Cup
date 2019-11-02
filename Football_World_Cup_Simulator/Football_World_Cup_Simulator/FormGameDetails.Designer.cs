namespace WorldCupSimulator2
{
    partial class FormGameDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameDetails));
            this.Lbl_Score = new System.Windows.Forms.Label();
            this.lst_details = new System.Windows.Forms.ListBox();
            this.Lbl_fouls = new System.Windows.Forms.Label();
            this.Lbl_yellowCards = new System.Windows.Forms.Label();
            this.Lbl_redCars = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Score
            // 
            resources.ApplyResources(this.Lbl_Score, "Lbl_Score");
            this.Lbl_Score.Name = "Lbl_Score";
            // 
            // lst_details
            // 
            resources.ApplyResources(this.lst_details, "lst_details");
            this.lst_details.FormattingEnabled = true;
            this.lst_details.Name = "lst_details";
            // 
            // Lbl_fouls
            // 
            resources.ApplyResources(this.Lbl_fouls, "Lbl_fouls");
            this.Lbl_fouls.Name = "Lbl_fouls";
            // 
            // Lbl_yellowCards
            // 
            resources.ApplyResources(this.Lbl_yellowCards, "Lbl_yellowCards");
            this.Lbl_yellowCards.Name = "Lbl_yellowCards";
            // 
            // Lbl_redCars
            // 
            resources.ApplyResources(this.Lbl_redCars, "Lbl_redCars");
            this.Lbl_redCars.Name = "Lbl_redCars";
            // 
            // FormGameDetails
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_redCars);
            this.Controls.Add(this.Lbl_yellowCards);
            this.Controls.Add(this.Lbl_fouls);
            this.Controls.Add(this.lst_details);
            this.Controls.Add(this.Lbl_Score);
            this.Name = "FormGameDetails";
            this.Load += new System.EventHandler(this.FormGameDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Score;
        private System.Windows.Forms.ListBox lst_details;
        private System.Windows.Forms.Label Lbl_fouls;
        private System.Windows.Forms.Label Lbl_yellowCards;
        private System.Windows.Forms.Label Lbl_redCars;
    }
}
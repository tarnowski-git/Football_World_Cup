namespace WorldCupSimulator2
{
    partial class FormQualifications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQualifications));
            this.lbl_chooseTeam = new System.Windows.Forms.Label();
            this.lst_AllTeams = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lst_Pot1 = new System.Windows.Forms.ListBox();
            this.Btn_select = new System.Windows.Forms.Button();
            this.lbl_information1 = new System.Windows.Forms.Label();
            this.lbl_information2 = new System.Windows.Forms.Label();
            this.btn_GroupStage = new System.Windows.Forms.Button();
            this.lbl_TeamsCounter = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lst_Pot2 = new System.Windows.Forms.ListBox();
            this.lst_Pot3 = new System.Windows.Forms.ListBox();
            this.lst_Pot4 = new System.Windows.Forms.ListBox();
            this.lst_UEFA_region = new System.Windows.Forms.ListBox();
            this.lst_AFC_region = new System.Windows.Forms.ListBox();
            this.lst_CONCACAF_region = new System.Windows.Forms.ListBox();
            this.lst_CONMEBOL_region = new System.Windows.Forms.ListBox();
            this.lst_CAF_region = new System.Windows.Forms.ListBox();
            this.lbl_information3 = new System.Windows.Forms.Label();
            this.Btn_Pots = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_chooseTeam
            // 
            this.lbl_chooseTeam.AutoSize = true;
            this.lbl_chooseTeam.Location = new System.Drawing.Point(128, 40);
            this.lbl_chooseTeam.Name = "lbl_chooseTeam";
            this.lbl_chooseTeam.Size = new System.Drawing.Size(99, 13);
            this.lbl_chooseTeam.TabIndex = 0;
            this.lbl_chooseTeam.Text = "Wybierz 32 drużyny";
            // 
            // lst_AllTeams
            // 
            this.lst_AllTeams.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lst_AllTeams.FormattingEnabled = true;
            this.lst_AllTeams.Location = new System.Drawing.Point(22, 84);
            this.lst_AllTeams.Name = "lst_AllTeams";
            this.lst_AllTeams.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_AllTeams.Size = new System.Drawing.Size(340, 420);
            this.lst_AllTeams.TabIndex = 1;
            this.lst_AllTeams.DoubleClick += new System.EventHandler(this.UnselectItems_DoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1174, 562);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Wyjście";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // lst_Pot1
            // 
            this.lst_Pot1.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lst_Pot1.FormattingEnabled = true;
            this.lst_Pot1.Location = new System.Drawing.Point(937, 84);
            this.lst_Pot1.Name = "lst_Pot1";
            this.lst_Pot1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Pot1.Size = new System.Drawing.Size(340, 95);
            this.lst_Pot1.TabIndex = 1;
            this.lst_Pot1.DoubleClick += new System.EventHandler(this.UnselectItems_DoubleClick);
            // 
            // Btn_select
            // 
            this.Btn_select.Location = new System.Drawing.Point(390, 110);
            this.Btn_select.Name = "Btn_select";
            this.Btn_select.Size = new System.Drawing.Size(75, 23);
            this.Btn_select.TabIndex = 3;
            this.Btn_select.Text = "Wybierz";
            this.Btn_select.UseVisualStyleBackColor = true;
            this.Btn_select.Click += new System.EventHandler(this.Btn_select_Click);
            // 
            // lbl_information1
            // 
            this.lbl_information1.AutoSize = true;
            this.lbl_information1.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_information1.Location = new System.Drawing.Point(24, 68);
            this.lbl_information1.Name = "lbl_information1";
            this.lbl_information1.Size = new System.Drawing.Size(79, 14);
            this.lbl_information1.TabIndex = 4;
            this.lbl_information1.Text = "Nagłówek1";
            // 
            // lbl_information2
            // 
            this.lbl_information2.AutoSize = true;
            this.lbl_information2.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_information2.Location = new System.Drawing.Point(939, 68);
            this.lbl_information2.Name = "lbl_information2";
            this.lbl_information2.Size = new System.Drawing.Size(79, 14);
            this.lbl_information2.TabIndex = 4;
            this.lbl_information2.Text = "Nagłówek1";
            // 
            // btn_GroupStage
            // 
            this.btn_GroupStage.Location = new System.Drawing.Point(1174, 524);
            this.btn_GroupStage.Name = "btn_GroupStage";
            this.btn_GroupStage.Size = new System.Drawing.Size(75, 23);
            this.btn_GroupStage.TabIndex = 5;
            this.btn_GroupStage.Text = "Dalej";
            this.btn_GroupStage.UseVisualStyleBackColor = true;
            this.btn_GroupStage.Click += new System.EventHandler(this.Btn_GroupStage_Click);
            // 
            // lbl_TeamsCounter
            // 
            this.lbl_TeamsCounter.AutoSize = true;
            this.lbl_TeamsCounter.Location = new System.Drawing.Point(507, 23);
            this.lbl_TeamsCounter.Name = "lbl_TeamsCounter";
            this.lbl_TeamsCounter.Size = new System.Drawing.Size(35, 13);
            this.lbl_TeamsCounter.TabIndex = 6;
            this.lbl_TeamsCounter.Text = "label1";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(390, 169);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Cofnij";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // lst_Pot2
            // 
            this.lst_Pot2.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lst_Pot2.FormattingEnabled = true;
            this.lst_Pot2.Location = new System.Drawing.Point(937, 192);
            this.lst_Pot2.Name = "lst_Pot2";
            this.lst_Pot2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Pot2.Size = new System.Drawing.Size(340, 95);
            this.lst_Pot2.TabIndex = 8;
            this.lst_Pot2.DoubleClick += new System.EventHandler(this.UnselectItems_DoubleClick);
            // 
            // lst_Pot3
            // 
            this.lst_Pot3.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lst_Pot3.FormattingEnabled = true;
            this.lst_Pot3.Location = new System.Drawing.Point(937, 300);
            this.lst_Pot3.Name = "lst_Pot3";
            this.lst_Pot3.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Pot3.Size = new System.Drawing.Size(340, 95);
            this.lst_Pot3.TabIndex = 9;
            this.lst_Pot3.DoubleClick += new System.EventHandler(this.UnselectItems_DoubleClick);
            // 
            // lst_Pot4
            // 
            this.lst_Pot4.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lst_Pot4.FormattingEnabled = true;
            this.lst_Pot4.Location = new System.Drawing.Point(937, 408);
            this.lst_Pot4.Name = "lst_Pot4";
            this.lst_Pot4.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Pot4.Size = new System.Drawing.Size(340, 95);
            this.lst_Pot4.TabIndex = 10;
            this.lst_Pot4.DoubleClick += new System.EventHandler(this.UnselectItems_DoubleClick);
            // 
            // lst_UEFA_region
            // 
            this.lst_UEFA_region.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lst_UEFA_region.FormattingEnabled = true;
            this.lst_UEFA_region.Location = new System.Drawing.Point(487, 84);
            this.lst_UEFA_region.Name = "lst_UEFA_region";
            this.lst_UEFA_region.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_UEFA_region.Size = new System.Drawing.Size(340, 108);
            this.lst_UEFA_region.TabIndex = 11;
            this.lst_UEFA_region.DoubleClick += new System.EventHandler(this.UnselectItems_DoubleClick);
            // 
            // lst_AFC_region
            // 
            this.lst_AFC_region.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lst_AFC_region.FormattingEnabled = true;
            this.lst_AFC_region.Location = new System.Drawing.Point(487, 202);
            this.lst_AFC_region.Name = "lst_AFC_region";
            this.lst_AFC_region.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_AFC_region.Size = new System.Drawing.Size(340, 69);
            this.lst_AFC_region.TabIndex = 12;
            this.lst_AFC_region.DoubleClick += new System.EventHandler(this.UnselectItems_DoubleClick);
            // 
            // lst_CONCACAF_region
            // 
            this.lst_CONCACAF_region.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lst_CONCACAF_region.FormattingEnabled = true;
            this.lst_CONCACAF_region.Location = new System.Drawing.Point(487, 447);
            this.lst_CONCACAF_region.Name = "lst_CONCACAF_region";
            this.lst_CONCACAF_region.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_CONCACAF_region.Size = new System.Drawing.Size(340, 56);
            this.lst_CONCACAF_region.TabIndex = 13;
            this.lst_CONCACAF_region.DoubleClick += new System.EventHandler(this.UnselectItems_DoubleClick);
            // 
            // lst_CONMEBOL_region
            // 
            this.lst_CONMEBOL_region.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lst_CONMEBOL_region.FormattingEnabled = true;
            this.lst_CONMEBOL_region.Location = new System.Drawing.Point(487, 283);
            this.lst_CONMEBOL_region.Name = "lst_CONMEBOL_region";
            this.lst_CONMEBOL_region.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_CONMEBOL_region.Size = new System.Drawing.Size(340, 69);
            this.lst_CONMEBOL_region.TabIndex = 14;
            this.lst_CONMEBOL_region.DoubleClick += new System.EventHandler(this.UnselectItems_DoubleClick);
            // 
            // lst_CAF_region
            // 
            this.lst_CAF_region.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lst_CAF_region.FormattingEnabled = true;
            this.lst_CAF_region.Location = new System.Drawing.Point(487, 363);
            this.lst_CAF_region.Name = "lst_CAF_region";
            this.lst_CAF_region.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_CAF_region.Size = new System.Drawing.Size(340, 69);
            this.lst_CAF_region.TabIndex = 15;
            this.lst_CAF_region.DoubleClick += new System.EventHandler(this.UnselectItems_DoubleClick);
            // 
            // lbl_information3
            // 
            this.lbl_information3.AutoSize = true;
            this.lbl_information3.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_information3.Location = new System.Drawing.Point(484, 68);
            this.lbl_information3.Name = "lbl_information3";
            this.lbl_information3.Size = new System.Drawing.Size(79, 14);
            this.lbl_information3.TabIndex = 18;
            this.lbl_information3.Text = "Nagłówek1";
            // 
            // Btn_Pots
            // 
            this.Btn_Pots.Location = new System.Drawing.Point(843, 123);
            this.Btn_Pots.Name = "Btn_Pots";
            this.Btn_Pots.Size = new System.Drawing.Size(75, 41);
            this.Btn_Pots.TabIndex = 19;
            this.Btn_Pots.Text = "Uzupełnij koszyki";
            this.Btn_Pots.UseVisualStyleBackColor = true;
            this.Btn_Pots.Click += new System.EventHandler(this.Btn_Pots_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(38, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Słownik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "UEFA (Union of European Football Associations) - Europa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "AFC (Asian Football Confederation) - Azja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 583);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "CAF (Confederation of African Football) - Afryka";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(591, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "CONCACAF (Confederation of North, Central American and Caribbean Association Foot" +
    "ball) - Ameryka Północna i Środkowa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(373, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "CONMEBOL (Confederación Sudamericana de Fútbol) - Ameryka Południowa";
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 605);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Pots);
            this.Controls.Add(this.lbl_information3);
            this.Controls.Add(this.lst_CAF_region);
            this.Controls.Add(this.lst_CONMEBOL_region);
            this.Controls.Add(this.lst_CONCACAF_region);
            this.Controls.Add(this.lst_AFC_region);
            this.Controls.Add(this.lst_UEFA_region);
            this.Controls.Add(this.lst_Pot4);
            this.Controls.Add(this.lst_Pot3);
            this.Controls.Add(this.lst_Pot2);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_TeamsCounter);
            this.Controls.Add(this.btn_GroupStage);
            this.Controls.Add(this.lbl_information2);
            this.Controls.Add(this.lbl_information1);
            this.Controls.Add(this.Btn_select);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lst_Pot1);
            this.Controls.Add(this.lst_AllTeams);
            this.Controls.Add(this.lbl_chooseTeam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainWindow";
            this.Text = "Symulator footballowy";
            this.Load += new System.EventHandler(this.FormQualifications_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_chooseTeam;
        private System.Windows.Forms.ListBox lst_AllTeams;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lst_Pot1;
        private System.Windows.Forms.Button Btn_select;
        private System.Windows.Forms.Label lbl_information1;
        private System.Windows.Forms.Label lbl_information2;
        private System.Windows.Forms.Button btn_GroupStage;
        private System.Windows.Forms.Label lbl_TeamsCounter;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ListBox lst_Pot2;
        private System.Windows.Forms.ListBox lst_Pot3;
        private System.Windows.Forms.ListBox lst_Pot4;
        private System.Windows.Forms.ListBox lst_UEFA_region;
        private System.Windows.Forms.ListBox lst_AFC_region;
        private System.Windows.Forms.ListBox lst_CONCACAF_region;
        private System.Windows.Forms.ListBox lst_CONMEBOL_region;
        private System.Windows.Forms.ListBox lst_CAF_region;
        private System.Windows.Forms.Label lbl_information3;
        private System.Windows.Forms.Button Btn_Pots;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
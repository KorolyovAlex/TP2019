namespace Training_app
{
    partial class ExaminationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExaminationForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startButton = new System.Windows.Forms.ToolStripMenuItem();
            this.activateButton = new System.Windows.Forms.ToolStripMenuItem();
            this.dateLabel = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.BP_Ind = new System.Windows.Forms.Label();
            this.Pulse_Ind = new System.Windows.Forms.Label();
            this.EC_Ind = new System.Windows.Forms.Label();
            this.SM_Ind = new System.Windows.Forms.Label();
            this.ST_Ind = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startButton,
            this.activateButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startButton
            // 
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(139, 20);
            this.startButton.Text = "Начать обследование";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // activateButton
            // 
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(142, 20);
            this.activateButton.Text = "Активировать датчики";
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.dateLabel.Location = new System.Drawing.Point(12, 34);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(144, 17);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Дата обследования:";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.date.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.date.Location = new System.Drawing.Point(12, 68);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(0, 17);
            this.date.TabIndex = 2;
            // 
            // BP_Ind
            // 
            this.BP_Ind.AutoSize = true;
            this.BP_Ind.BackColor = System.Drawing.Color.Red;
            this.BP_Ind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BP_Ind.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BP_Ind.Location = new System.Drawing.Point(311, 114);
            this.BP_Ind.Name = "BP_Ind";
            this.BP_Ind.Size = new System.Drawing.Size(46, 20);
            this.BP_Ind.TabIndex = 3;
            this.BP_Ind.Text = "       0";
            // 
            // Pulse_Ind
            // 
            this.Pulse_Ind.AutoSize = true;
            this.Pulse_Ind.BackColor = System.Drawing.Color.Red;
            this.Pulse_Ind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Pulse_Ind.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Pulse_Ind.Location = new System.Drawing.Point(260, 31);
            this.Pulse_Ind.Name = "Pulse_Ind";
            this.Pulse_Ind.Size = new System.Drawing.Size(46, 20);
            this.Pulse_Ind.TabIndex = 4;
            this.Pulse_Ind.Text = "       0";
            // 
            // EC_Ind
            // 
            this.EC_Ind.AutoSize = true;
            this.EC_Ind.BackColor = System.Drawing.Color.Red;
            this.EC_Ind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EC_Ind.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EC_Ind.Location = new System.Drawing.Point(11, 149);
            this.EC_Ind.Name = "EC_Ind";
            this.EC_Ind.Size = new System.Drawing.Size(46, 20);
            this.EC_Ind.TabIndex = 5;
            this.EC_Ind.Text = "       0";
            // 
            // SM_Ind
            // 
            this.SM_Ind.AutoSize = true;
            this.SM_Ind.BackColor = System.Drawing.Color.Red;
            this.SM_Ind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SM_Ind.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SM_Ind.Location = new System.Drawing.Point(275, 368);
            this.SM_Ind.Name = "SM_Ind";
            this.SM_Ind.Size = new System.Drawing.Size(50, 20);
            this.SM_Ind.TabIndex = 6;
            this.SM_Ind.Text = "        0";
            // 
            // ST_Ind
            // 
            this.ST_Ind.AutoSize = true;
            this.ST_Ind.BackColor = System.Drawing.Color.Red;
            this.ST_Ind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ST_Ind.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ST_Ind.Location = new System.Drawing.Point(15, 321);
            this.ST_Ind.Name = "ST_Ind";
            this.ST_Ind.Size = new System.Drawing.Size(46, 20);
            this.ST_Ind.TabIndex = 7;
            this.ST_Ind.Text = "       0";
            // 
            // ExaminationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 512);
            this.Controls.Add(this.ST_Ind);
            this.Controls.Add(this.SM_Ind);
            this.Controls.Add(this.EC_Ind);
            this.Controls.Add(this.Pulse_Ind);
            this.Controls.Add(this.BP_Ind);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExaminationForm";
            this.Text = "Обследование";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startButton;
        private System.Windows.Forms.ToolStripMenuItem activateButton;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label BP_Ind;
        private System.Windows.Forms.Label Pulse_Ind;
        private System.Windows.Forms.Label EC_Ind;
        private System.Windows.Forms.Label SM_Ind;
        private System.Windows.Forms.Label ST_Ind;
    }
}
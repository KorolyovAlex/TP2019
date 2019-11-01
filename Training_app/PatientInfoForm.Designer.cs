namespace Training_app
{
    partial class PatientInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientInfoForm));
            this.patientLabel = new System.Windows.Forms.Label();
            this.patientName = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.patientAge = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.patientSex = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addExamination = new System.Windows.Forms.ToolStripMenuItem();
            this.examPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // patientLabel
            // 
            this.patientLabel.AutoSize = true;
            this.patientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.patientLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientLabel.Location = new System.Drawing.Point(23, 41);
            this.patientLabel.Name = "patientLabel";
            this.patientLabel.Size = new System.Drawing.Size(79, 20);
            this.patientLabel.TabIndex = 0;
            this.patientLabel.Text = "Пациент:";
            // 
            // patientName
            // 
            this.patientName.AutoSize = true;
            this.patientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.patientName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientName.Location = new System.Drawing.Point(146, 44);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(0, 17);
            this.patientName.TabIndex = 1;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ageLabel.Location = new System.Drawing.Point(23, 83);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(76, 20);
            this.ageLabel.TabIndex = 2;
            this.ageLabel.Text = "Возраст:";
            // 
            // patientAge
            // 
            this.patientAge.AutoSize = true;
            this.patientAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.patientAge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientAge.Location = new System.Drawing.Point(146, 86);
            this.patientAge.Name = "patientAge";
            this.patientAge.Size = new System.Drawing.Size(0, 17);
            this.patientAge.TabIndex = 3;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sexLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sexLabel.Location = new System.Drawing.Point(23, 126);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(44, 20);
            this.sexLabel.TabIndex = 4;
            this.sexLabel.Text = "Пол:";
            // 
            // patientSex
            // 
            this.patientSex.AutoSize = true;
            this.patientSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.patientSex.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientSex.Location = new System.Drawing.Point(146, 129);
            this.patientSex.Name = "patientSex";
            this.patientSex.Size = new System.Drawing.Size(0, 17);
            this.patientSex.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addExamination});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(477, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addExamination
            // 
            this.addExamination.Name = "addExamination";
            this.addExamination.Size = new System.Drawing.Size(152, 20);
            this.addExamination.Text = "Добавить обследование";
            this.addExamination.Click += new System.EventHandler(this.addExamination_Click);
            // 
            // examPanel
            // 
            this.examPanel.Location = new System.Drawing.Point(0, 190);
            this.examPanel.Name = "examPanel";
            this.examPanel.Size = new System.Drawing.Size(477, 256);
            this.examPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(23, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Обследования:";
            // 
            // PatientInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(477, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.examPanel);
            this.Controls.Add(this.patientSex);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.patientAge);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.patientName);
            this.Controls.Add(this.patientLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PatientInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пациент";
            this.Load += new System.EventHandler(this.PatientInfoForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patientLabel;
        private System.Windows.Forms.Label patientName;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label patientAge;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label patientSex;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addExamination;
        private System.Windows.Forms.Panel examPanel;
        private System.Windows.Forms.Label label1;
    }
}
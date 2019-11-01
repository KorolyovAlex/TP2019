namespace Training_app
{
    partial class NewPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPatientForm));
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.nameLabel3 = new System.Windows.Forms.Label();
            this.nameBox1 = new System.Windows.Forms.TextBox();
            this.nameBox2 = new System.Windows.Forms.TextBox();
            this.nameBox3 = new System.Windows.Forms.TextBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.ageLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.ageBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel1.Location = new System.Drawing.Point(30, 33);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(70, 17);
            this.nameLabel1.TabIndex = 0;
            this.nameLabel1.Text = "Фамилия";
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel2.Location = new System.Drawing.Point(30, 77);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(35, 17);
            this.nameLabel2.TabIndex = 1;
            this.nameLabel2.Text = "Имя";
            // 
            // nameLabel3
            // 
            this.nameLabel3.AutoSize = true;
            this.nameLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameLabel3.Location = new System.Drawing.Point(30, 120);
            this.nameLabel3.Name = "nameLabel3";
            this.nameLabel3.Size = new System.Drawing.Size(71, 17);
            this.nameLabel3.TabIndex = 2;
            this.nameLabel3.Text = "Отчество";
            // 
            // nameBox1
            // 
            this.nameBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox1.Location = new System.Drawing.Point(139, 33);
            this.nameBox1.MaxLength = 30;
            this.nameBox1.Name = "nameBox1";
            this.nameBox1.Size = new System.Drawing.Size(194, 20);
            this.nameBox1.TabIndex = 3;
            // 
            // nameBox2
            // 
            this.nameBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox2.Location = new System.Drawing.Point(139, 77);
            this.nameBox2.Name = "nameBox2";
            this.nameBox2.Size = new System.Drawing.Size(194, 20);
            this.nameBox2.TabIndex = 4;
            // 
            // nameBox3
            // 
            this.nameBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox3.Location = new System.Drawing.Point(139, 120);
            this.nameBox3.Name = "nameBox3";
            this.nameBox3.Size = new System.Drawing.Size(194, 20);
            this.nameBox3.TabIndex = 5;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sexLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sexLabel.Location = new System.Drawing.Point(30, 166);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(34, 17);
            this.sexLabel.TabIndex = 6;
            this.sexLabel.Text = "Пол";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Checked = true;
            this.maleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.maleRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maleRadioButton.Location = new System.Drawing.Point(139, 164);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(83, 21);
            this.maleRadioButton.TabIndex = 7;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Мужской";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.femaleRadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.femaleRadioButton.Location = new System.Drawing.Point(248, 164);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(85, 21);
            this.femaleRadioButton.TabIndex = 8;
            this.femaleRadioButton.Text = "Женский";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ageLabel.Location = new System.Drawing.Point(30, 210);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(62, 17);
            this.ageLabel.TabIndex = 10;
            this.ageLabel.Text = "Возраст";
            // 
            // addButton
            // 
            this.addButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(98, 260);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 11;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(222, 260);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(139, 210);
            this.ageBox.Maximum = new decimal(new int[] {
            125,
            0,
            0,
            0});
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(49, 20);
            this.ageBox.TabIndex = 9;
            // 
            // NewPatientForm
            // 
            this.AcceptButton = this.addButton;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(379, 312);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.nameBox3);
            this.Controls.Add(this.nameBox2);
            this.Controls.Add(this.nameBox1);
            this.Controls.Add(this.nameLabel3);
            this.Controls.Add(this.nameLabel2);
            this.Controls.Add(this.nameLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый пациент";
            ((System.ComponentModel.ISupportInitialize)(this.ageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.Label nameLabel3;
        private System.Windows.Forms.TextBox nameBox1;
        private System.Windows.Forms.TextBox nameBox2;
        private System.Windows.Forms.TextBox nameBox3;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NumericUpDown ageBox;
    }
}
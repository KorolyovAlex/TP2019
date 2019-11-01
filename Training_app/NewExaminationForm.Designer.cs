namespace Training_app
{
    partial class NewExaminationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewExaminationForm));
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.exerciseBox = new System.Windows.Forms.GroupBox();
            this.exerciseStrength = new System.Windows.Forms.RadioButton();
            this.exerciseRunning = new System.Windows.Forms.RadioButton();
            this.exerciseWalking = new System.Windows.Forms.RadioButton();
            this.exerciseBike = new System.Windows.Forms.RadioButton();
            this.indicatorsBox = new System.Windows.Forms.GroupBox();
            this.pulseInd = new System.Windows.Forms.CheckBox();
            this.electricalConductivityInd = new System.Windows.Forms.CheckBox();
            this.skinMoistureInd = new System.Windows.Forms.CheckBox();
            this.skinTemperatureInd = new System.Windows.Forms.CheckBox();
            this.bloodPressureInd = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.durationLabel = new System.Windows.Forms.Label();
            this.exerciseDuration = new System.Windows.Forms.NumericUpDown();
            this.exerciseBox.SuspendLayout();
            this.indicatorsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateLabel.Location = new System.Drawing.Point(22, 33);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(144, 17);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Дата обследования:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd MM yyyy";
            this.dateTimePicker.Location = new System.Drawing.Point(172, 33);
            this.dateTimePicker.MaxDate = new System.DateTime(2119, 10, 30, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(2019, 10, 30, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(143, 20);
            this.dateTimePicker.TabIndex = 1;
            this.dateTimePicker.Value = new System.DateTime(2019, 10, 30, 0, 0, 0, 0);
            // 
            // exerciseBox
            // 
            this.exerciseBox.Controls.Add(this.exerciseStrength);
            this.exerciseBox.Controls.Add(this.exerciseRunning);
            this.exerciseBox.Controls.Add(this.exerciseWalking);
            this.exerciseBox.Controls.Add(this.exerciseBike);
            this.exerciseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exerciseBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exerciseBox.Location = new System.Drawing.Point(25, 77);
            this.exerciseBox.Name = "exerciseBox";
            this.exerciseBox.Size = new System.Drawing.Size(290, 90);
            this.exerciseBox.TabIndex = 3;
            this.exerciseBox.TabStop = false;
            this.exerciseBox.Text = "Вид нагрузки";
            // 
            // exerciseStrength
            // 
            this.exerciseStrength.AutoSize = true;
            this.exerciseStrength.Location = new System.Drawing.Point(161, 48);
            this.exerciseStrength.Name = "exerciseStrength";
            this.exerciseStrength.Size = new System.Drawing.Size(82, 20);
            this.exerciseStrength.TabIndex = 3;
            this.exerciseStrength.Text = "Силовая";
            this.exerciseStrength.UseVisualStyleBackColor = true;
            // 
            // exerciseRunning
            // 
            this.exerciseRunning.AutoSize = true;
            this.exerciseRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exerciseRunning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exerciseRunning.Location = new System.Drawing.Point(161, 21);
            this.exerciseRunning.Name = "exerciseRunning";
            this.exerciseRunning.Size = new System.Drawing.Size(48, 21);
            this.exerciseRunning.TabIndex = 2;
            this.exerciseRunning.Text = "Бег";
            this.exerciseRunning.UseVisualStyleBackColor = true;
            // 
            // exerciseWalking
            // 
            this.exerciseWalking.AutoSize = true;
            this.exerciseWalking.Location = new System.Drawing.Point(34, 48);
            this.exerciseWalking.Name = "exerciseWalking";
            this.exerciseWalking.Size = new System.Drawing.Size(73, 20);
            this.exerciseWalking.TabIndex = 1;
            this.exerciseWalking.Text = "Ходьба";
            this.exerciseWalking.UseVisualStyleBackColor = true;
            // 
            // exerciseBike
            // 
            this.exerciseBike.AutoSize = true;
            this.exerciseBike.Checked = true;
            this.exerciseBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exerciseBike.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exerciseBike.Location = new System.Drawing.Point(34, 21);
            this.exerciseBike.Name = "exerciseBike";
            this.exerciseBike.Size = new System.Drawing.Size(59, 21);
            this.exerciseBike.TabIndex = 0;
            this.exerciseBike.TabStop = true;
            this.exerciseBike.Text = "Вело";
            this.exerciseBike.UseVisualStyleBackColor = true;
            // 
            // indicatorsBox
            // 
            this.indicatorsBox.Controls.Add(this.pulseInd);
            this.indicatorsBox.Controls.Add(this.electricalConductivityInd);
            this.indicatorsBox.Controls.Add(this.skinMoistureInd);
            this.indicatorsBox.Controls.Add(this.skinTemperatureInd);
            this.indicatorsBox.Controls.Add(this.bloodPressureInd);
            this.indicatorsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.indicatorsBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.indicatorsBox.Location = new System.Drawing.Point(25, 193);
            this.indicatorsBox.Name = "indicatorsBox";
            this.indicatorsBox.Size = new System.Drawing.Size(290, 169);
            this.indicatorsBox.TabIndex = 4;
            this.indicatorsBox.TabStop = false;
            this.indicatorsBox.Text = "Измеряемые показатели";
            // 
            // pulseInd
            // 
            this.pulseInd.AutoSize = true;
            this.pulseInd.Location = new System.Drawing.Point(19, 138);
            this.pulseInd.Name = "pulseInd";
            this.pulseInd.Size = new System.Drawing.Size(253, 20);
            this.pulseInd.TabIndex = 4;
            this.pulseInd.Text = "Частота пульса сердечного ритма";
            this.pulseInd.UseVisualStyleBackColor = true;
            // 
            // electricalConductivityInd
            // 
            this.electricalConductivityInd.AutoSize = true;
            this.electricalConductivityInd.Location = new System.Drawing.Point(19, 111);
            this.electricalConductivityInd.Name = "electricalConductivityInd";
            this.electricalConductivityInd.Size = new System.Drawing.Size(260, 20);
            this.electricalConductivityInd.TabIndex = 3;
            this.electricalConductivityInd.Text = "Электрическая проводимость кожи";
            this.electricalConductivityInd.UseVisualStyleBackColor = true;
            // 
            // skinMoistureInd
            // 
            this.skinMoistureInd.AutoSize = true;
            this.skinMoistureInd.Location = new System.Drawing.Point(19, 84);
            this.skinMoistureInd.Name = "skinMoistureInd";
            this.skinMoistureInd.Size = new System.Drawing.Size(133, 20);
            this.skinMoistureInd.TabIndex = 2;
            this.skinMoistureInd.Text = "Влажность кожи";
            this.skinMoistureInd.UseVisualStyleBackColor = true;
            // 
            // skinTemperatureInd
            // 
            this.skinTemperatureInd.AutoSize = true;
            this.skinTemperatureInd.Location = new System.Drawing.Point(19, 57);
            this.skinTemperatureInd.Name = "skinTemperatureInd";
            this.skinTemperatureInd.Size = new System.Drawing.Size(151, 20);
            this.skinTemperatureInd.TabIndex = 1;
            this.skinTemperatureInd.Text = "Температура кожи";
            this.skinTemperatureInd.UseVisualStyleBackColor = true;
            // 
            // bloodPressureInd
            // 
            this.bloodPressureInd.AutoSize = true;
            this.bloodPressureInd.Location = new System.Drawing.Point(19, 30);
            this.bloodPressureInd.Name = "bloodPressureInd";
            this.bloodPressureInd.Size = new System.Drawing.Size(157, 20);
            this.bloodPressureInd.TabIndex = 0;
            this.bloodPressureInd.Text = "Кровяное давление";
            this.bloodPressureInd.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(75, 415);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Создать";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(193, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.durationLabel.Location = new System.Drawing.Point(22, 383);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(203, 16);
            this.durationLabel.TabIndex = 7;
            this.durationLabel.Text = "Длительность нагрузки (мин):";
            // 
            // exerciseDuration
            // 
            this.exerciseDuration.Location = new System.Drawing.Point(252, 383);
            this.exerciseDuration.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.exerciseDuration.Name = "exerciseDuration";
            this.exerciseDuration.Size = new System.Drawing.Size(63, 20);
            this.exerciseDuration.TabIndex = 8;
            // 
            // NewExaminationForm
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(342, 450);
            this.Controls.Add(this.exerciseDuration);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.indicatorsBox);
            this.Controls.Add(this.exerciseBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dateLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewExaminationForm";
            this.Text = "Новое обследование";
            this.exerciseBox.ResumeLayout(false);
            this.exerciseBox.PerformLayout();
            this.indicatorsBox.ResumeLayout(false);
            this.indicatorsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exerciseDuration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.GroupBox exerciseBox;
        private System.Windows.Forms.RadioButton exerciseStrength;
        private System.Windows.Forms.RadioButton exerciseRunning;
        private System.Windows.Forms.RadioButton exerciseWalking;
        private System.Windows.Forms.RadioButton exerciseBike;
        private System.Windows.Forms.GroupBox indicatorsBox;
        private System.Windows.Forms.CheckBox pulseInd;
        private System.Windows.Forms.CheckBox electricalConductivityInd;
        private System.Windows.Forms.CheckBox skinMoistureInd;
        private System.Windows.Forms.CheckBox skinTemperatureInd;
        private System.Windows.Forms.CheckBox bloodPressureInd;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.NumericUpDown exerciseDuration;
    }
}
namespace NewPatientApp
{
    partial class MarkMedicineTakenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxReceptionTimeInTheMorning = new System.Windows.Forms.CheckBox();
            this.checkBoxReceptionTimeDuringTheDay = new System.Windows.Forms.CheckBox();
            this.checkBoxReceptionTimeInTheEvening = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лекарство";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(309, 108);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(299, 23);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // checkBoxReceptionTimeInTheMorning
            // 
            this.checkBoxReceptionTimeInTheMorning.AutoSize = true;
            this.checkBoxReceptionTimeInTheMorning.Location = new System.Drawing.Point(15, 41);
            this.checkBoxReceptionTimeInTheMorning.Name = "checkBoxReceptionTimeInTheMorning";
            this.checkBoxReceptionTimeInTheMorning.Size = new System.Drawing.Size(165, 19);
            this.checkBoxReceptionTimeInTheMorning.TabIndex = 8;
            this.checkBoxReceptionTimeInTheMorning.Text = "Принял лекарстов утром";
            this.checkBoxReceptionTimeInTheMorning.UseVisualStyleBackColor = true;
            // 
            // checkBoxReceptionTimeDuringTheDay
            // 
            this.checkBoxReceptionTimeDuringTheDay.AutoSize = true;
            this.checkBoxReceptionTimeDuringTheDay.Location = new System.Drawing.Point(15, 66);
            this.checkBoxReceptionTimeDuringTheDay.Name = "checkBoxReceptionTimeDuringTheDay";
            this.checkBoxReceptionTimeDuringTheDay.Size = new System.Drawing.Size(159, 19);
            this.checkBoxReceptionTimeDuringTheDay.TabIndex = 9;
            this.checkBoxReceptionTimeDuringTheDay.Text = "Принял лекарстов днем";
            this.checkBoxReceptionTimeDuringTheDay.UseVisualStyleBackColor = true;
            // 
            // checkBoxReceptionTimeInTheEvening
            // 
            this.checkBoxReceptionTimeInTheEvening.AutoSize = true;
            this.checkBoxReceptionTimeInTheEvening.Location = new System.Drawing.Point(15, 91);
            this.checkBoxReceptionTimeInTheEvening.Name = "checkBoxReceptionTimeInTheEvening";
            this.checkBoxReceptionTimeInTheEvening.Size = new System.Drawing.Size(179, 19);
            this.checkBoxReceptionTimeInTheEvening.TabIndex = 10;
            this.checkBoxReceptionTimeInTheEvening.Text = "Принял лекарстов вечером";
            this.checkBoxReceptionTimeInTheEvening.UseVisualStyleBackColor = true;
            // 
            // MarkMedicineTakenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxReceptionTimeInTheEvening);
            this.Controls.Add(this.checkBoxReceptionTimeDuringTheDay);
            this.Controls.Add(this.checkBoxReceptionTimeInTheMorning);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "MarkMedicineTakenForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.ShowIcon = false;
            this.Text = "Отметить принятое лекарство";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPatientDrag_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button buttonSave;
        private ComboBox comboBox1;
        private CheckBox checkBoxReceptionTimeInTheMorning;
        private CheckBox checkBoxReceptionTimeDuringTheDay;
        private CheckBox checkBoxReceptionTimeInTheEvening;
    }
}
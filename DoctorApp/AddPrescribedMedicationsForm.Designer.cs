namespace DoctorApp
{
    partial class AddPrescribedMedicationsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iD_Doctor_s_appointmentsLabel;
            System.Windows.Forms.Label drug_IDLabel;
            System.Windows.Forms.Label reception_time_in_the_morningLabel;
            System.Windows.Forms.Label reception_time_during_the_dayLabel;
            System.Windows.Forms.Label reception_time_in_the_eveningLabel;
            System.Windows.Forms.Label take_before_mealsLabel;
            System.Windows.Forms.Label take_after_mealsLabel;
            System.Windows.Forms.Label take_with_mealsLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label take_medicine_before_the_dateLabel;
            this.course_backupDataSet = new DoctorApp.Course_backupDataSet();
            this.prescribed_medicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prescribed_medicationsTableAdapter = new DoctorApp.Course_backupDataSetTableAdapters.Prescribed_medicationsTableAdapter();
            this.tableAdapterManager = new DoctorApp.Course_backupDataSetTableAdapters.TableAdapterManager();
            this.drug_directoryTableAdapter = new DoctorApp.Course_backupDataSetTableAdapters.Drug_directoryTableAdapter();
            this.iD_Doctor_s_appointmentsLabel1 = new System.Windows.Forms.Label();
            this.drug_IDComboBox = new System.Windows.Forms.ComboBox();
            this.drugDirectoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reception_time_in_the_morningCheckBox = new System.Windows.Forms.CheckBox();
            this.reception_time_during_the_dayCheckBox = new System.Windows.Forms.CheckBox();
            this.reception_time_in_the_eveningCheckBox = new System.Windows.Forms.CheckBox();
            this.take_before_mealsCheckBox = new System.Windows.Forms.CheckBox();
            this.take_after_mealsCheckBox = new System.Windows.Forms.CheckBox();
            this.take_with_mealsCheckBox = new System.Windows.Forms.CheckBox();
            this.noteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.take_medicine_before_the_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            iD_Doctor_s_appointmentsLabel = new System.Windows.Forms.Label();
            drug_IDLabel = new System.Windows.Forms.Label();
            reception_time_in_the_morningLabel = new System.Windows.Forms.Label();
            reception_time_during_the_dayLabel = new System.Windows.Forms.Label();
            reception_time_in_the_eveningLabel = new System.Windows.Forms.Label();
            take_before_mealsLabel = new System.Windows.Forms.Label();
            take_after_mealsLabel = new System.Windows.Forms.Label();
            take_with_mealsLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            take_medicine_before_the_dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.course_backupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescribed_medicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugDirectoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_Doctor_s_appointmentsLabel
            // 
            iD_Doctor_s_appointmentsLabel.AutoSize = true;
            iD_Doctor_s_appointmentsLabel.Location = new System.Drawing.Point(138, 253);
            iD_Doctor_s_appointmentsLabel.Name = "iD_Doctor_s_appointmentsLabel";
            iD_Doctor_s_appointmentsLabel.Size = new System.Drawing.Size(129, 13);
            iD_Doctor_s_appointmentsLabel.TabIndex = 1;
            iD_Doctor_s_appointmentsLabel.Text = "ID Doctor\'s appointments:";
            // 
            // drug_IDLabel
            // 
            drug_IDLabel.AutoSize = true;
            drug_IDLabel.Location = new System.Drawing.Point(12, 38);
            drug_IDLabel.Name = "drug_IDLabel";
            drug_IDLabel.Size = new System.Drawing.Size(77, 13);
            drug_IDLabel.TabIndex = 3;
            drug_IDLabel.Text = "ID лекарства:";
            // 
            // reception_time_in_the_morningLabel
            // 
            reception_time_in_the_morningLabel.AutoSize = true;
            reception_time_in_the_morningLabel.Location = new System.Drawing.Point(12, 67);
            reception_time_in_the_morningLabel.Name = "reception_time_in_the_morningLabel";
            reception_time_in_the_morningLabel.Size = new System.Drawing.Size(100, 13);
            reception_time_in_the_morningLabel.TabIndex = 5;
            reception_time_in_the_morningLabel.Text = "Принимать утром:";
            // 
            // reception_time_during_the_dayLabel
            // 
            reception_time_during_the_dayLabel.AutoSize = true;
            reception_time_during_the_dayLabel.Location = new System.Drawing.Point(12, 97);
            reception_time_during_the_dayLabel.Name = "reception_time_during_the_dayLabel";
            reception_time_during_the_dayLabel.Size = new System.Drawing.Size(96, 13);
            reception_time_during_the_dayLabel.TabIndex = 7;
            reception_time_during_the_dayLabel.Text = "Принимать днем:";
            // 
            // reception_time_in_the_eveningLabel
            // 
            reception_time_in_the_eveningLabel.AutoSize = true;
            reception_time_in_the_eveningLabel.Location = new System.Drawing.Point(12, 127);
            reception_time_in_the_eveningLabel.Name = "reception_time_in_the_eveningLabel";
            reception_time_in_the_eveningLabel.Size = new System.Drawing.Size(113, 13);
            reception_time_in_the_eveningLabel.TabIndex = 9;
            reception_time_in_the_eveningLabel.Text = "Принимать вечером:";
            // 
            // take_before_mealsLabel
            // 
            take_before_mealsLabel.AutoSize = true;
            take_before_mealsLabel.Location = new System.Drawing.Point(141, 161);
            take_before_mealsLabel.Name = "take_before_mealsLabel";
            take_before_mealsLabel.Size = new System.Drawing.Size(98, 13);
            take_before_mealsLabel.TabIndex = 11;
            take_before_mealsLabel.Text = "Take before meals:";
            // 
            // take_after_mealsLabel
            // 
            take_after_mealsLabel.AutoSize = true;
            take_after_mealsLabel.Location = new System.Drawing.Point(141, 191);
            take_after_mealsLabel.Name = "take_after_mealsLabel";
            take_after_mealsLabel.Size = new System.Drawing.Size(89, 13);
            take_after_mealsLabel.TabIndex = 13;
            take_after_mealsLabel.Text = "Take after meals:";
            // 
            // take_with_mealsLabel
            // 
            take_with_mealsLabel.AutoSize = true;
            take_with_mealsLabel.Location = new System.Drawing.Point(141, 221);
            take_with_mealsLabel.Name = "take_with_mealsLabel";
            take_with_mealsLabel.Size = new System.Drawing.Size(87, 13);
            take_with_mealsLabel.TabIndex = 15;
            take_with_mealsLabel.Text = "Take with meals:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(12, 182);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(54, 13);
            noteLabel.TabIndex = 17;
            noteLabel.Text = "Заметка:";
            // 
            // take_medicine_before_the_dateLabel
            // 
            take_medicine_before_the_dateLabel.AutoSize = true;
            take_medicine_before_the_dateLabel.Location = new System.Drawing.Point(12, 16);
            take_medicine_before_the_dateLabel.Name = "take_medicine_before_the_dateLabel";
            take_medicine_before_the_dateLabel.Size = new System.Drawing.Size(82, 13);
            take_medicine_before_the_dateLabel.TabIndex = 19;
            take_medicine_before_the_dateLabel.Text = "Принимать до:";
            // 
            // course_backupDataSet
            // 
            this.course_backupDataSet.DataSetName = "Course_backupDataSet";
            this.course_backupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescribed_medicationsBindingSource
            // 
            this.prescribed_medicationsBindingSource.DataMember = "Prescribed medications";
            this.prescribed_medicationsBindingSource.DataSource = this.course_backupDataSet;
            // 
            // prescribed_medicationsTableAdapter
            // 
            this.prescribed_medicationsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Doctor_s_appointmentsTableAdapter = null;
            this.tableAdapterManager.DoctorsTableAdapter = null;
            this.tableAdapterManager.Drug_directoryTableAdapter = this.drug_directoryTableAdapter;
            this.tableAdapterManager.Medications_takenTableAdapter = null;
            this.tableAdapterManager.Patient_s_drugsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.Prescribed_medicationsTableAdapter = this.prescribed_medicationsTableAdapter;
            this.tableAdapterManager.Procedures_directoryTableAdapter = null;
            this.tableAdapterManager.ProceduresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoctorApp.Course_backupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Well_being_recordsTableAdapter = null;
            // 
            // drug_directoryTableAdapter
            // 
            this.drug_directoryTableAdapter.ClearBeforeFill = true;
            // 
            // iD_Doctor_s_appointmentsLabel1
            // 
            this.iD_Doctor_s_appointmentsLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescribed_medicationsBindingSource, "ID Doctor\'s appointments", true));
            this.iD_Doctor_s_appointmentsLabel1.Location = new System.Drawing.Point(170, 187);
            this.iD_Doctor_s_appointmentsLabel1.Name = "iD_Doctor_s_appointmentsLabel1";
            this.iD_Doctor_s_appointmentsLabel1.Size = new System.Drawing.Size(80, 23);
            this.iD_Doctor_s_appointmentsLabel1.TabIndex = 2;
            this.iD_Doctor_s_appointmentsLabel1.Text = "label1";
            // 
            // drug_IDComboBox
            // 
            this.drug_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescribed_medicationsBindingSource, "Drug ID", true));
            this.drug_IDComboBox.DataSource = this.drugDirectoryBindingSource;
            this.drug_IDComboBox.DisplayMember = "ID";
            this.drug_IDComboBox.FormattingEnabled = true;
            this.drug_IDComboBox.Location = new System.Drawing.Point(131, 35);
            this.drug_IDComboBox.Name = "drug_IDComboBox";
            this.drug_IDComboBox.Size = new System.Drawing.Size(44, 21);
            this.drug_IDComboBox.TabIndex = 4;
            this.drug_IDComboBox.ValueMember = "ID";
            this.drug_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.drug_IDComboBox_SelectedIndexChanged);
            this.drug_IDComboBox.Leave += new System.EventHandler(this.drug_IDComboBox_Leave);
            // 
            // drugDirectoryBindingSource
            // 
            this.drugDirectoryBindingSource.DataMember = "Drug directory";
            this.drugDirectoryBindingSource.DataSource = this.course_backupDataSet;
            // 
            // reception_time_in_the_morningCheckBox
            // 
            this.reception_time_in_the_morningCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.prescribed_medicationsBindingSource, "Reception time in the morning", true));
            this.reception_time_in_the_morningCheckBox.Location = new System.Drawing.Point(131, 62);
            this.reception_time_in_the_morningCheckBox.Name = "reception_time_in_the_morningCheckBox";
            this.reception_time_in_the_morningCheckBox.Size = new System.Drawing.Size(200, 24);
            this.reception_time_in_the_morningCheckBox.TabIndex = 6;
            this.reception_time_in_the_morningCheckBox.UseVisualStyleBackColor = true;
            // 
            // reception_time_during_the_dayCheckBox
            // 
            this.reception_time_during_the_dayCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.prescribed_medicationsBindingSource, "Reception time during the day", true));
            this.reception_time_during_the_dayCheckBox.Location = new System.Drawing.Point(131, 92);
            this.reception_time_during_the_dayCheckBox.Name = "reception_time_during_the_dayCheckBox";
            this.reception_time_during_the_dayCheckBox.Size = new System.Drawing.Size(200, 24);
            this.reception_time_during_the_dayCheckBox.TabIndex = 8;
            this.reception_time_during_the_dayCheckBox.UseVisualStyleBackColor = true;
            // 
            // reception_time_in_the_eveningCheckBox
            // 
            this.reception_time_in_the_eveningCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.prescribed_medicationsBindingSource, "Reception time in the evening", true));
            this.reception_time_in_the_eveningCheckBox.Location = new System.Drawing.Point(131, 122);
            this.reception_time_in_the_eveningCheckBox.Name = "reception_time_in_the_eveningCheckBox";
            this.reception_time_in_the_eveningCheckBox.Size = new System.Drawing.Size(200, 24);
            this.reception_time_in_the_eveningCheckBox.TabIndex = 10;
            this.reception_time_in_the_eveningCheckBox.UseVisualStyleBackColor = true;
            // 
            // take_before_mealsCheckBox
            // 
            this.take_before_mealsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.prescribed_medicationsBindingSource, "Take before meals", true));
            this.take_before_mealsCheckBox.Location = new System.Drawing.Point(251, 182);
            this.take_before_mealsCheckBox.Name = "take_before_mealsCheckBox";
            this.take_before_mealsCheckBox.Size = new System.Drawing.Size(80, 24);
            this.take_before_mealsCheckBox.TabIndex = 12;
            this.take_before_mealsCheckBox.Text = "checkBox1";
            this.take_before_mealsCheckBox.UseVisualStyleBackColor = true;
            // 
            // take_after_mealsCheckBox
            // 
            this.take_after_mealsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.prescribed_medicationsBindingSource, "Take after meals", true));
            this.take_after_mealsCheckBox.Location = new System.Drawing.Point(251, 212);
            this.take_after_mealsCheckBox.Name = "take_after_mealsCheckBox";
            this.take_after_mealsCheckBox.Size = new System.Drawing.Size(80, 24);
            this.take_after_mealsCheckBox.TabIndex = 14;
            this.take_after_mealsCheckBox.Text = "checkBox1";
            this.take_after_mealsCheckBox.UseVisualStyleBackColor = true;
            // 
            // take_with_mealsCheckBox
            // 
            this.take_with_mealsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.prescribed_medicationsBindingSource, "Take with meals", true));
            this.take_with_mealsCheckBox.Location = new System.Drawing.Point(251, 242);
            this.take_with_mealsCheckBox.Name = "take_with_mealsCheckBox";
            this.take_with_mealsCheckBox.Size = new System.Drawing.Size(80, 24);
            this.take_with_mealsCheckBox.TabIndex = 16;
            this.take_with_mealsCheckBox.Text = "checkBox1";
            this.take_with_mealsCheckBox.UseVisualStyleBackColor = true;
            // 
            // noteRichTextBox
            // 
            this.noteRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescribed_medicationsBindingSource, "Note", true));
            this.noteRichTextBox.Location = new System.Drawing.Point(131, 179);
            this.noteRichTextBox.Name = "noteRichTextBox";
            this.noteRichTextBox.Size = new System.Drawing.Size(200, 96);
            this.noteRichTextBox.TabIndex = 18;
            this.noteRichTextBox.Text = "";
            // 
            // take_medicine_before_the_dateDateTimePicker
            // 
            this.take_medicine_before_the_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prescribed_medicationsBindingSource, "Take medicine before the date", true));
            this.take_medicine_before_the_dateDateTimePicker.Location = new System.Drawing.Point(131, 12);
            this.take_medicine_before_the_dateDateTimePicker.Name = "take_medicine_before_the_dateDateTimePicker";
            this.take_medicine_before_the_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.take_medicine_before_the_dateDateTimePicker.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "До еды",
            "Во время еды",
            "После еды"});
            this.comboBox1.Location = new System.Drawing.Point(131, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Время приема:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Выберите лекарство";
            // 
            // AddPrescribedMedicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noteRichTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_Doctor_s_appointmentsLabel);
            this.Controls.Add(this.iD_Doctor_s_appointmentsLabel1);
            this.Controls.Add(drug_IDLabel);
            this.Controls.Add(this.drug_IDComboBox);
            this.Controls.Add(reception_time_in_the_morningLabel);
            this.Controls.Add(this.reception_time_in_the_morningCheckBox);
            this.Controls.Add(reception_time_during_the_dayLabel);
            this.Controls.Add(this.reception_time_during_the_dayCheckBox);
            this.Controls.Add(reception_time_in_the_eveningLabel);
            this.Controls.Add(this.reception_time_in_the_eveningCheckBox);
            this.Controls.Add(take_before_mealsLabel);
            this.Controls.Add(this.take_before_mealsCheckBox);
            this.Controls.Add(take_after_mealsLabel);
            this.Controls.Add(this.take_after_mealsCheckBox);
            this.Controls.Add(take_with_mealsLabel);
            this.Controls.Add(this.take_with_mealsCheckBox);
            this.Controls.Add(noteLabel);
            this.Controls.Add(take_medicine_before_the_dateLabel);
            this.Controls.Add(this.take_medicine_before_the_dateDateTimePicker);
            this.Name = "AddPrescribedMedicationsForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.ShowIcon = false;
            this.Text = "Прописать лекарство";
            this.Load += new System.EventHandler(this.AddPrescribedMedicationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.course_backupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescribed_medicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugDirectoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Course_backupDataSet course_backupDataSet;
        private System.Windows.Forms.BindingSource prescribed_medicationsBindingSource;
        private Course_backupDataSetTableAdapters.Prescribed_medicationsTableAdapter prescribed_medicationsTableAdapter;
        private Course_backupDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Course_backupDataSetTableAdapters.Drug_directoryTableAdapter drug_directoryTableAdapter;
        private System.Windows.Forms.Label iD_Doctor_s_appointmentsLabel1;
        private System.Windows.Forms.ComboBox drug_IDComboBox;
        private System.Windows.Forms.CheckBox reception_time_in_the_morningCheckBox;
        private System.Windows.Forms.CheckBox reception_time_during_the_dayCheckBox;
        private System.Windows.Forms.CheckBox reception_time_in_the_eveningCheckBox;
        private System.Windows.Forms.CheckBox take_before_mealsCheckBox;
        private System.Windows.Forms.CheckBox take_after_mealsCheckBox;
        private System.Windows.Forms.CheckBox take_with_mealsCheckBox;
        private System.Windows.Forms.RichTextBox noteRichTextBox;
        private System.Windows.Forms.DateTimePicker take_medicine_before_the_dateDateTimePicker;
        private System.Windows.Forms.BindingSource drugDirectoryBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace DoctorApp
{
    partial class AddPatientProcedureForm
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
            System.Windows.Forms.Label dateTimeLabel;
            System.Windows.Forms.Label procedure_IDLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label visitedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPatientProcedureForm));
            this.course_backupDataSet = new DoctorApp.Course_backupDataSet();
            this.proceduresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proceduresTableAdapter = new DoctorApp.Course_backupDataSetTableAdapters.ProceduresTableAdapter();
            this.tableAdapterManager = new DoctorApp.Course_backupDataSetTableAdapters.TableAdapterManager();
            this.patientsTableAdapter = new DoctorApp.Course_backupDataSetTableAdapters.PatientsTableAdapter();
            this.procedures_directoryTableAdapter = new DoctorApp.Course_backupDataSetTableAdapters.Procedures_directoryTableAdapter();
            this.proceduresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.proceduresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.proceduresDirectoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.procedure_IDComboBox = new System.Windows.Forms.ComboBox();
            this.noteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.patient_IDComboBox = new System.Windows.Forms.ComboBox();
            this.visitedCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            dateTimeLabel = new System.Windows.Forms.Label();
            procedure_IDLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            patient_IDLabel = new System.Windows.Forms.Label();
            visitedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.course_backupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceduresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceduresBindingNavigator)).BeginInit();
            this.proceduresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proceduresDirectoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Location = new System.Drawing.Point(3, 32);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new System.Drawing.Size(103, 13);
            dateTimeLabel.TabIndex = 3;
            dateTimeLabel.Text = "Время посещения:";
            // 
            // procedure_IDLabel
            // 
            procedure_IDLabel.AutoSize = true;
            procedure_IDLabel.Location = new System.Drawing.Point(3, 57);
            procedure_IDLabel.Name = "procedure_IDLabel";
            procedure_IDLabel.Size = new System.Drawing.Size(79, 13);
            procedure_IDLabel.TabIndex = 5;
            procedure_IDLabel.Text = "ID процедуры:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(3, 84);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(54, 13);
            noteLabel.TabIndex = 7;
            noteLabel.Text = "Заметка:";
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Location = new System.Drawing.Point(3, 186);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(71, 13);
            patient_IDLabel.TabIndex = 9;
            patient_IDLabel.Text = "ID пациента:";
            // 
            // visitedLabel
            // 
            visitedLabel.AutoSize = true;
            visitedLabel.Location = new System.Drawing.Point(3, 215);
            visitedLabel.Name = "visitedLabel";
            visitedLabel.Size = new System.Drawing.Size(86, 13);
            visitedLabel.TabIndex = 11;
            visitedLabel.Text = "Посещенность:";
            // 
            // course_backupDataSet
            // 
            this.course_backupDataSet.DataSetName = "Course_backupDataSet";
            this.course_backupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proceduresBindingSource
            // 
            this.proceduresBindingSource.DataMember = "Procedures";
            this.proceduresBindingSource.DataSource = this.course_backupDataSet;
            // 
            // proceduresTableAdapter
            // 
            this.proceduresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Doctor_s_appointmentsTableAdapter = null;
            this.tableAdapterManager.DoctorsTableAdapter = null;
            this.tableAdapterManager.Drug_directoryTableAdapter = null;
            this.tableAdapterManager.Medications_takenTableAdapter = null;
            this.tableAdapterManager.Patient_s_drugsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = this.patientsTableAdapter;
            this.tableAdapterManager.Prescribed_medicationsTableAdapter = null;
            this.tableAdapterManager.Procedures_directoryTableAdapter = this.procedures_directoryTableAdapter;
            this.tableAdapterManager.ProceduresTableAdapter = this.proceduresTableAdapter;
            this.tableAdapterManager.UpdateOrder = DoctorApp.Course_backupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Well_being_recordsTableAdapter = null;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // procedures_directoryTableAdapter
            // 
            this.procedures_directoryTableAdapter.ClearBeforeFill = true;
            // 
            // proceduresBindingNavigator
            // 
            this.proceduresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.proceduresBindingNavigator.BindingSource = this.proceduresBindingSource;
            this.proceduresBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.proceduresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.proceduresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.proceduresBindingNavigatorSaveItem});
            this.proceduresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.proceduresBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.proceduresBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.proceduresBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.proceduresBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.proceduresBindingNavigator.Name = "proceduresBindingNavigator";
            this.proceduresBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.proceduresBindingNavigator.Size = new System.Drawing.Size(785, 25);
            this.proceduresBindingNavigator.TabIndex = 0;
            this.proceduresBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // proceduresBindingNavigatorSaveItem
            // 
            this.proceduresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.proceduresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("proceduresBindingNavigatorSaveItem.Image")));
            this.proceduresBindingNavigatorSaveItem.Name = "proceduresBindingNavigatorSaveItem";
            this.proceduresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.proceduresBindingNavigatorSaveItem.Text = "Save Data";
            this.proceduresBindingNavigatorSaveItem.Click += new System.EventHandler(this.proceduresBindingNavigatorSaveItem_Click);
            // 
            // proceduresDirectoryBindingSource
            // 
            this.proceduresDirectoryBindingSource.DataMember = "Procedures directory";
            this.proceduresDirectoryBindingSource.DataSource = this.course_backupDataSet;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.course_backupDataSet;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(DoctorApp.Patient);
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataSource = typeof(DoctorApp.Patient);
            // 
            // dateTimeDateTimePicker
            // 
            this.dateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.proceduresBindingSource, "DateTime", true));
            this.dateTimeDateTimePicker.Location = new System.Drawing.Point(112, 28);
            this.dateTimeDateTimePicker.Name = "dateTimeDateTimePicker";
            this.dateTimeDateTimePicker.Size = new System.Drawing.Size(274, 20);
            this.dateTimeDateTimePicker.TabIndex = 4;
            // 
            // procedure_IDComboBox
            // 
            this.procedure_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proceduresBindingSource, "Procedure ID", true));
            this.procedure_IDComboBox.DataSource = this.proceduresDirectoryBindingSource;
            this.procedure_IDComboBox.DisplayMember = "ID";
            this.procedure_IDComboBox.FormattingEnabled = true;
            this.procedure_IDComboBox.Location = new System.Drawing.Point(112, 54);
            this.procedure_IDComboBox.Name = "procedure_IDComboBox";
            this.procedure_IDComboBox.Size = new System.Drawing.Size(46, 21);
            this.procedure_IDComboBox.TabIndex = 6;
            this.procedure_IDComboBox.ValueMember = "ID";
            this.procedure_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.procedure_IDComboBox_SelectedIndexChanged_1);
            this.procedure_IDComboBox.Leave += new System.EventHandler(this.procedure_IDComboBox_Leave_1);
            // 
            // noteRichTextBox
            // 
            this.noteRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proceduresBindingSource, "Note", true));
            this.noteRichTextBox.Location = new System.Drawing.Point(112, 81);
            this.noteRichTextBox.Name = "noteRichTextBox";
            this.noteRichTextBox.Size = new System.Drawing.Size(274, 96);
            this.noteRichTextBox.TabIndex = 8;
            this.noteRichTextBox.Text = "";
            // 
            // patient_IDComboBox
            // 
            this.patient_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proceduresBindingSource, "Patient ID", true));
            this.patient_IDComboBox.DataSource = this.patientsBindingSource;
            this.patient_IDComboBox.DisplayMember = "ID";
            this.patient_IDComboBox.FormattingEnabled = true;
            this.patient_IDComboBox.Location = new System.Drawing.Point(112, 183);
            this.patient_IDComboBox.Name = "patient_IDComboBox";
            this.patient_IDComboBox.Size = new System.Drawing.Size(46, 21);
            this.patient_IDComboBox.TabIndex = 10;
            this.patient_IDComboBox.ValueMember = "ID";
            this.patient_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.patient_IDComboBox_SelectedIndexChanged_1);
            this.patient_IDComboBox.Leave += new System.EventHandler(this.patient_IDComboBox_Leave_1);
            // 
            // visitedCheckBox
            // 
            this.visitedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.proceduresBindingSource, "Visited", true));
            this.visitedCheckBox.Location = new System.Drawing.Point(112, 210);
            this.visitedCheckBox.Name = "visitedCheckBox";
            this.visitedCheckBox.Size = new System.Drawing.Size(274, 24);
            this.visitedCheckBox.TabIndex = 12;
            this.visitedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Выберите процедуру";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Выберите пациента";
            // 
            // AddPatientProcedureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(dateTimeLabel);
            this.Controls.Add(this.dateTimeDateTimePicker);
            this.Controls.Add(procedure_IDLabel);
            this.Controls.Add(this.procedure_IDComboBox);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.noteRichTextBox);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDComboBox);
            this.Controls.Add(visitedLabel);
            this.Controls.Add(this.visitedCheckBox);
            this.Controls.Add(this.proceduresBindingNavigator);
            this.Name = "AddPatientProcedureForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.ShowIcon = false;
            this.Text = "Запись пациента на процедуру";
            this.Load += new System.EventHandler(this.AddPatientProcedureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.course_backupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceduresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proceduresBindingNavigator)).EndInit();
            this.proceduresBindingNavigator.ResumeLayout(false);
            this.proceduresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proceduresDirectoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Course_backupDataSet course_backupDataSet;
        private System.Windows.Forms.BindingSource proceduresBindingSource;
        private Course_backupDataSetTableAdapters.ProceduresTableAdapter proceduresTableAdapter;
        private Course_backupDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator proceduresBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton proceduresBindingNavigatorSaveItem;
        private Course_backupDataSetTableAdapters.Procedures_directoryTableAdapter procedures_directoryTableAdapter;
        private System.Windows.Forms.BindingSource proceduresDirectoryBindingSource;
        private Course_backupDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DateTimePicker dateTimeDateTimePicker;
        private System.Windows.Forms.ComboBox procedure_IDComboBox;
        private System.Windows.Forms.RichTextBox noteRichTextBox;
        private System.Windows.Forms.ComboBox patient_IDComboBox;
        private System.Windows.Forms.CheckBox visitedCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace DoctorApp
{
    partial class AddDoctorsAppointmentsForm
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
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label doctor_IDLabel;
            System.Windows.Forms.Label patient_temperatureLabel;
            System.Windows.Forms.Label dateTimeLabel;
            System.Windows.Forms.Label word_fileLabel;
            System.Windows.Forms.Label noteLabel;
            System.Windows.Forms.Label visitedLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDoctorsAppointmentsForm));
            this.course_backupDataSet = new DoctorApp.Course_backupDataSet();
            this.doctor_s_appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctor_s_appointmentsTableAdapter = new DoctorApp.Course_backupDataSetTableAdapters.Doctor_s_appointmentsTableAdapter();
            this.tableAdapterManager = new DoctorApp.Course_backupDataSetTableAdapters.TableAdapterManager();
            this.prescribed_medicationsTableAdapter = new DoctorApp.Course_backupDataSetTableAdapters.Prescribed_medicationsTableAdapter();
            this.doctor_s_appointmentsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.doctor_s_appointmentsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.prescribed_medicationsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescribed_medicationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddDrug = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new DoctorApp.Course_backupDataSetTableAdapters.PatientsTableAdapter();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new DoctorApp.Course_backupDataSetTableAdapters.DoctorsTableAdapter();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.patient_IDComboBox = new System.Windows.Forms.ComboBox();
            this.doctor_IDComboBox = new System.Windows.Forms.ComboBox();
            this.patient_temperatureTextBox = new System.Windows.Forms.TextBox();
            this.dateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.word_fileLabel1 = new System.Windows.Forms.Label();
            this.noteRichTextBox = new System.Windows.Forms.RichTextBox();
            this.visitedCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            patient_IDLabel = new System.Windows.Forms.Label();
            doctor_IDLabel = new System.Windows.Forms.Label();
            patient_temperatureLabel = new System.Windows.Forms.Label();
            dateTimeLabel = new System.Windows.Forms.Label();
            word_fileLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            visitedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.course_backupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_s_appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_s_appointmentsBindingNavigator)).BeginInit();
            this.doctor_s_appointmentsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescribed_medicationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescribed_medicationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(553, 145);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 15;
            iDLabel.Text = "ID:";
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Location = new System.Drawing.Point(12, 31);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(74, 13);
            patient_IDLabel.TabIndex = 17;
            patient_IDLabel.Text = "ID пациента: ";
            // 
            // doctor_IDLabel
            // 
            doctor_IDLabel.AutoSize = true;
            doctor_IDLabel.Location = new System.Drawing.Point(553, 174);
            doctor_IDLabel.Name = "doctor_IDLabel";
            doctor_IDLabel.Size = new System.Drawing.Size(56, 13);
            doctor_IDLabel.TabIndex = 19;
            doctor_IDLabel.Text = "Doctor ID:";
            // 
            // patient_temperatureLabel
            // 
            patient_temperatureLabel.AutoSize = true;
            patient_temperatureLabel.Location = new System.Drawing.Point(12, 58);
            patient_temperatureLabel.Name = "patient_temperatureLabel";
            patient_temperatureLabel.Size = new System.Drawing.Size(127, 13);
            patient_temperatureLabel.TabIndex = 21;
            patient_temperatureLabel.Text = "Температура пациента:";
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Location = new System.Drawing.Point(12, 85);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new System.Drawing.Size(84, 13);
            dateTimeLabel.TabIndex = 23;
            dateTimeLabel.Text = "Время приема:";
            // 
            // word_fileLabel
            // 
            word_fileLabel.AutoSize = true;
            word_fileLabel.Location = new System.Drawing.Point(747, 243);
            word_fileLabel.Name = "word_fileLabel";
            word_fileLabel.Size = new System.Drawing.Size(52, 13);
            word_fileLabel.TabIndex = 25;
            word_fileLabel.Text = "Word file:";
            word_fileLabel.Visible = false;
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Location = new System.Drawing.Point(12, 133);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(54, 13);
            noteLabel.TabIndex = 27;
            noteLabel.Text = "Заметка:";
            // 
            // visitedLabel
            // 
            visitedLabel.AutoSize = true;
            visitedLabel.Location = new System.Drawing.Point(12, 237);
            visitedLabel.Name = "visitedLabel";
            visitedLabel.Size = new System.Drawing.Size(121, 13);
            visitedLabel.TabIndex = 29;
            visitedLabel.Text = "Посещено пациентом:";
            // 
            // course_backupDataSet
            // 
            this.course_backupDataSet.DataSetName = "Course_backupDataSet";
            this.course_backupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctor_s_appointmentsBindingSource
            // 
            this.doctor_s_appointmentsBindingSource.DataMember = "Doctor\'s appointments";
            this.doctor_s_appointmentsBindingSource.DataSource = this.course_backupDataSet;
            // 
            // doctor_s_appointmentsTableAdapter
            // 
            this.doctor_s_appointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Doctor_s_appointmentsTableAdapter = this.doctor_s_appointmentsTableAdapter;
            this.tableAdapterManager.DoctorsTableAdapter = null;
            this.tableAdapterManager.Drug_directoryTableAdapter = null;
            this.tableAdapterManager.Medications_takenTableAdapter = null;
            this.tableAdapterManager.Patient_s_drugsTableAdapter = null;
            this.tableAdapterManager.PatientsTableAdapter = null;
            this.tableAdapterManager.Prescribed_medicationsTableAdapter = this.prescribed_medicationsTableAdapter;
            this.tableAdapterManager.Procedures_directoryTableAdapter = null;
            this.tableAdapterManager.ProceduresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoctorApp.Course_backupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Well_being_recordsTableAdapter = null;
            // 
            // prescribed_medicationsTableAdapter
            // 
            this.prescribed_medicationsTableAdapter.ClearBeforeFill = true;
            // 
            // doctor_s_appointmentsBindingNavigator
            // 
            this.doctor_s_appointmentsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.doctor_s_appointmentsBindingNavigator.BindingSource = this.doctor_s_appointmentsBindingSource;
            this.doctor_s_appointmentsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.doctor_s_appointmentsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.doctor_s_appointmentsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.doctor_s_appointmentsBindingNavigatorSaveItem});
            this.doctor_s_appointmentsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.doctor_s_appointmentsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.doctor_s_appointmentsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.doctor_s_appointmentsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.doctor_s_appointmentsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.doctor_s_appointmentsBindingNavigator.Name = "doctor_s_appointmentsBindingNavigator";
            this.doctor_s_appointmentsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.doctor_s_appointmentsBindingNavigator.Size = new System.Drawing.Size(1291, 25);
            this.doctor_s_appointmentsBindingNavigator.TabIndex = 0;
            this.doctor_s_appointmentsBindingNavigator.Text = "bindingNavigator1";
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
            // doctor_s_appointmentsBindingNavigatorSaveItem
            // 
            this.doctor_s_appointmentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doctor_s_appointmentsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("doctor_s_appointmentsBindingNavigatorSaveItem.Image")));
            this.doctor_s_appointmentsBindingNavigatorSaveItem.Name = "doctor_s_appointmentsBindingNavigatorSaveItem";
            this.doctor_s_appointmentsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.doctor_s_appointmentsBindingNavigatorSaveItem.Text = "Save Data";
            this.doctor_s_appointmentsBindingNavigatorSaveItem.Click += new System.EventHandler(this.doctor_s_appointmentsBindingNavigatorSaveItem_Click);
            // 
            // prescribed_medicationsDataGridView
            // 
            this.prescribed_medicationsDataGridView.AllowUserToAddRows = false;
            this.prescribed_medicationsDataGridView.AllowUserToDeleteRows = false;
            this.prescribed_medicationsDataGridView.AllowUserToOrderColumns = true;
            this.prescribed_medicationsDataGridView.AutoGenerateColumns = false;
            this.prescribed_medicationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prescribed_medicationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn6,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.prescribed_medicationsDataGridView.DataSource = this.prescribed_medicationsBindingSource;
            this.prescribed_medicationsDataGridView.Location = new System.Drawing.Point(362, 28);
            this.prescribed_medicationsDataGridView.Name = "prescribed_medicationsDataGridView";
            this.prescribed_medicationsDataGridView.ReadOnly = true;
            this.prescribed_medicationsDataGridView.Size = new System.Drawing.Size(735, 203);
            this.prescribed_medicationsDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID Doctor\'s appointments";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID Doctor\'s appointments";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Drug ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ID лекарства";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Take medicine before the date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Принимать лекарство до";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Reception time in the morning";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Принимать утром";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 70;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Reception time during the day";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Принимать днем";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 70;
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Reception time in the evening";
            this.dataGridViewCheckBoxColumn3.HeaderText = "Принимать вечером";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.ReadOnly = true;
            this.dataGridViewCheckBoxColumn3.Width = 70;
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Take before meals";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Принимать до еды";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.ReadOnly = true;
            this.dataGridViewCheckBoxColumn4.Width = 70;
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "Take with meals";
            this.dataGridViewCheckBoxColumn6.HeaderText = "Принимать вместе с едой";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            this.dataGridViewCheckBoxColumn6.ReadOnly = true;
            this.dataGridViewCheckBoxColumn6.Width = 70;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "Take after meals";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Принимать после еды";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.ReadOnly = true;
            this.dataGridViewCheckBoxColumn5.Width = 70;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn4.HeaderText = "Заметка";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // prescribed_medicationsBindingSource
            // 
            this.prescribed_medicationsBindingSource.DataMember = "FK_Prescribed medications_Doctor\'s appointments";
            this.prescribed_medicationsBindingSource.DataSource = this.doctor_s_appointmentsBindingSource;
            // 
            // buttonAddDrug
            // 
            this.buttonAddDrug.Location = new System.Drawing.Point(362, 237);
            this.buttonAddDrug.Name = "buttonAddDrug";
            this.buttonAddDrug.Size = new System.Drawing.Size(139, 23);
            this.buttonAddDrug.TabIndex = 14;
            this.buttonAddDrug.Text = "Прописать лекраство";
            this.buttonAddDrug.UseVisualStyleBackColor = true;
            this.buttonAddDrug.Click += new System.EventHandler(this.buttonAddDrug_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Удалить выделенное из прописанных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.course_backupDataSet;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.course_backupDataSet;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctor_s_appointmentsBindingSource, "ID", true));
            this.iDLabel1.Location = new System.Drawing.Point(661, 145);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(200, 23);
            this.iDLabel1.TabIndex = 16;
            this.iDLabel1.Text = "label1";
            // 
            // patient_IDComboBox
            // 
            this.patient_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctor_s_appointmentsBindingSource, "Patient ID", true));
            this.patient_IDComboBox.DataSource = this.patientsBindingSource;
            this.patient_IDComboBox.DisplayMember = "ID";
            this.patient_IDComboBox.FormattingEnabled = true;
            this.patient_IDComboBox.Location = new System.Drawing.Point(144, 28);
            this.patient_IDComboBox.Name = "patient_IDComboBox";
            this.patient_IDComboBox.Size = new System.Drawing.Size(42, 21);
            this.patient_IDComboBox.TabIndex = 18;
            this.patient_IDComboBox.ValueMember = "ID";
            this.patient_IDComboBox.SelectedIndexChanged += new System.EventHandler(this.patient_IDComboBox_SelectedIndexChanged);
            this.patient_IDComboBox.Leave += new System.EventHandler(this.patient_IDComboBox_Leave);
            // 
            // doctor_IDComboBox
            // 
            this.doctor_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctor_s_appointmentsBindingSource, "Doctor ID", true));
            this.doctor_IDComboBox.DataSource = this.doctorsBindingSource;
            this.doctor_IDComboBox.DisplayMember = "ID";
            this.doctor_IDComboBox.FormattingEnabled = true;
            this.doctor_IDComboBox.Location = new System.Drawing.Point(661, 171);
            this.doctor_IDComboBox.Name = "doctor_IDComboBox";
            this.doctor_IDComboBox.Size = new System.Drawing.Size(200, 21);
            this.doctor_IDComboBox.TabIndex = 20;
            this.doctor_IDComboBox.ValueMember = "ID";
            // 
            // patient_temperatureTextBox
            // 
            this.patient_temperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctor_s_appointmentsBindingSource, "Patient temperature", true));
            this.patient_temperatureTextBox.Location = new System.Drawing.Point(144, 55);
            this.patient_temperatureTextBox.Name = "patient_temperatureTextBox";
            this.patient_temperatureTextBox.Size = new System.Drawing.Size(212, 20);
            this.patient_temperatureTextBox.TabIndex = 22;
            // 
            // dateTimeDateTimePicker
            // 
            this.dateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.doctor_s_appointmentsBindingSource, "DateTime", true));
            this.dateTimeDateTimePicker.Location = new System.Drawing.Point(144, 81);
            this.dateTimeDateTimePicker.Name = "dateTimeDateTimePicker";
            this.dateTimeDateTimePicker.Size = new System.Drawing.Size(212, 20);
            this.dateTimeDateTimePicker.TabIndex = 24;
            // 
            // word_fileLabel1
            // 
            this.word_fileLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctor_s_appointmentsBindingSource, "Word file", true));
            this.word_fileLabel1.Location = new System.Drawing.Point(855, 243);
            this.word_fileLabel1.Name = "word_fileLabel1";
            this.word_fileLabel1.Size = new System.Drawing.Size(200, 23);
            this.word_fileLabel1.TabIndex = 26;
            this.word_fileLabel1.Text = "label1";
            this.word_fileLabel1.Visible = false;
            // 
            // noteRichTextBox
            // 
            this.noteRichTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctor_s_appointmentsBindingSource, "Note", true));
            this.noteRichTextBox.Location = new System.Drawing.Point(144, 130);
            this.noteRichTextBox.Name = "noteRichTextBox";
            this.noteRichTextBox.Size = new System.Drawing.Size(212, 96);
            this.noteRichTextBox.TabIndex = 28;
            this.noteRichTextBox.Text = "";
            // 
            // visitedCheckBox
            // 
            this.visitedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.doctor_s_appointmentsBindingSource, "Visited", true));
            this.visitedCheckBox.Location = new System.Drawing.Point(144, 232);
            this.visitedCheckBox.Name = "visitedCheckBox";
            this.visitedCheckBox.Size = new System.Drawing.Size(212, 24);
            this.visitedCheckBox.TabIndex = 30;
            this.visitedCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "label1";
            // 
            // AddDoctorsAppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1291, 620);
            this.Controls.Add(this.prescribed_medicationsDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDLabel1);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDComboBox);
            this.Controls.Add(doctor_IDLabel);
            this.Controls.Add(this.doctor_IDComboBox);
            this.Controls.Add(patient_temperatureLabel);
            this.Controls.Add(this.patient_temperatureTextBox);
            this.Controls.Add(dateTimeLabel);
            this.Controls.Add(this.dateTimeDateTimePicker);
            this.Controls.Add(word_fileLabel);
            this.Controls.Add(this.word_fileLabel1);
            this.Controls.Add(noteLabel);
            this.Controls.Add(this.noteRichTextBox);
            this.Controls.Add(visitedLabel);
            this.Controls.Add(this.visitedCheckBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddDrug);
            this.Controls.Add(this.doctor_s_appointmentsBindingNavigator);
            this.Name = "AddDoctorsAppointmentsForm";
            this.ShowIcon = false;
            this.Text = "Добавить посещение доктора";
            this.Load += new System.EventHandler(this.AddDoctorsAppointmentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.course_backupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_s_appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctor_s_appointmentsBindingNavigator)).EndInit();
            this.doctor_s_appointmentsBindingNavigator.ResumeLayout(false);
            this.doctor_s_appointmentsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prescribed_medicationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescribed_medicationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Course_backupDataSet course_backupDataSet;
        private System.Windows.Forms.BindingSource doctor_s_appointmentsBindingSource;
        private Course_backupDataSetTableAdapters.Doctor_s_appointmentsTableAdapter doctor_s_appointmentsTableAdapter;
        private Course_backupDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator doctor_s_appointmentsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton doctor_s_appointmentsBindingNavigatorSaveItem;
        private Course_backupDataSetTableAdapters.Prescribed_medicationsTableAdapter prescribed_medicationsTableAdapter;
        private System.Windows.Forms.BindingSource prescribed_medicationsBindingSource;
        private System.Windows.Forms.DataGridView prescribed_medicationsDataGridView;
        private System.Windows.Forms.Button buttonAddDrug;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private Course_backupDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private Course_backupDataSetTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.ComboBox patient_IDComboBox;
        private System.Windows.Forms.ComboBox doctor_IDComboBox;
        private System.Windows.Forms.TextBox patient_temperatureTextBox;
        private System.Windows.Forms.DateTimePicker dateTimeDateTimePicker;
        private System.Windows.Forms.Label word_fileLabel1;
        private System.Windows.Forms.RichTextBox noteRichTextBox;
        private System.Windows.Forms.CheckBox visitedCheckBox;
        private System.Windows.Forms.Label label1;
    }
}
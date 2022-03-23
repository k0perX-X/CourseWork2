namespace NewPatientApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.monthCalendarDoctor = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выбратьПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перечниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переченьПроцедурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переченьЛекарсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переченьДокторовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddWellBeing = new System.Windows.Forms.Button();
            this.buttonAddDoctorAppointments = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDrugRunningOut = new System.Windows.Forms.DataGridView();
            this.Лекарство = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Кончается = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonMarkDoctorVisit = new System.Windows.Forms.Button();
            this.buttonMarkVisitProcedure = new System.Windows.Forms.Button();
            this.buttonAddProcedure = new System.Windows.Forms.Button();
            this.buttonAddPatientDrug = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPatientDrugList = new System.Windows.Forms.Button();
            this.buttonMarkMedicineTaken = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendarProcedure = new System.Windows.Forms.MonthCalendar();
            this.buttonProcedureList = new System.Windows.Forms.Button();
            this.buttonDoctorAppointmentsList = new System.Windows.Forms.Button();
            this.dataGridViewPrescribedMedications = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugRunningOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescribedMedications)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendarDoctor
            // 
            this.monthCalendarDoctor.Location = new System.Drawing.Point(14, 53);
            this.monthCalendarDoctor.Margin = new System.Windows.Forms.Padding(10);
            this.monthCalendarDoctor.Name = "monthCalendarDoctor";
            this.monthCalendarDoctor.ShowToday = false;
            this.monthCalendarDoctor.ShowWeekNumbers = true;
            this.monthCalendarDoctor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Даты посещения врача";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьПациентаToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.перечниToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выбратьПациентаToolStripMenuItem
            // 
            this.выбратьПациентаToolStripMenuItem.Name = "выбратьПациентаToolStripMenuItem";
            this.выбратьПациентаToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.выбратьПациентаToolStripMenuItem.Text = "Сменить пользователя";
            this.выбратьПациентаToolStripMenuItem.Click += new System.EventHandler(this.выбратьПациентаToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // перечниToolStripMenuItem
            // 
            this.перечниToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переченьПроцедурToolStripMenuItem,
            this.переченьЛекарсовToolStripMenuItem,
            this.переченьДокторовToolStripMenuItem});
            this.перечниToolStripMenuItem.Name = "перечниToolStripMenuItem";
            this.перечниToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.перечниToolStripMenuItem.Text = "Библеотека";
            // 
            // переченьПроцедурToolStripMenuItem
            // 
            this.переченьПроцедурToolStripMenuItem.Name = "переченьПроцедурToolStripMenuItem";
            this.переченьПроцедурToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.переченьПроцедурToolStripMenuItem.Text = "Перечень процедур";
            this.переченьПроцедурToolStripMenuItem.Click += new System.EventHandler(this.переченьПроцедурToolStripMenuItem_Click);
            // 
            // переченьЛекарсовToolStripMenuItem
            // 
            this.переченьЛекарсовToolStripMenuItem.Name = "переченьЛекарсовToolStripMenuItem";
            this.переченьЛекарсовToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.переченьЛекарсовToolStripMenuItem.Text = "Перечень лекарств";
            this.переченьЛекарсовToolStripMenuItem.Click += new System.EventHandler(this.переченьЛекарсовToolStripMenuItem_Click);
            // 
            // переченьДокторовToolStripMenuItem
            // 
            this.переченьДокторовToolStripMenuItem.Name = "переченьДокторовToolStripMenuItem";
            this.переченьДокторовToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.переченьДокторовToolStripMenuItem.Text = "Перечень докторов";
            this.переченьДокторовToolStripMenuItem.Click += new System.EventHandler(this.переченьДокторовToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПриложенииToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПриложенииToolStripMenuItem
            // 
            this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.оПриложенииToolStripMenuItem.Text = "О приложении...";
            this.оПриложенииToolStripMenuItem.Click += new System.EventHandler(this.оПриложенииToolStripMenuItem_Click);
            // 
            // buttonAddWellBeing
            // 
            this.buttonAddWellBeing.Location = new System.Drawing.Point(915, 317);
            this.buttonAddWellBeing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddWellBeing.Name = "buttonAddWellBeing";
            this.buttonAddWellBeing.Size = new System.Drawing.Size(186, 63);
            this.buttonAddWellBeing.TabIndex = 3;
            this.buttonAddWellBeing.Text = "Добавить самочувствие";
            this.buttonAddWellBeing.UseVisualStyleBackColor = true;
            this.buttonAddWellBeing.Click += new System.EventHandler(this.buttonAddWellBeing_Click);
            // 
            // buttonAddDoctorAppointments
            // 
            this.buttonAddDoctorAppointments.Location = new System.Drawing.Point(14, 230);
            this.buttonAddDoctorAppointments.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddDoctorAppointments.Name = "buttonAddDoctorAppointments";
            this.buttonAddDoctorAppointments.Size = new System.Drawing.Size(186, 63);
            this.buttonAddDoctorAppointments.TabIndex = 4;
            this.buttonAddDoctorAppointments.Text = "Добавить посещение врача";
            this.buttonAddDoctorAppointments.UseVisualStyleBackColor = true;
            this.buttonAddDoctorAppointments.Click += new System.EventHandler(this.buttonAddDoctorAppointments_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Лекарства кончаются";
            // 
            // dataGridViewDrugRunningOut
            // 
            this.dataGridViewDrugRunningOut.AllowUserToAddRows = false;
            this.dataGridViewDrugRunningOut.AllowUserToDeleteRows = false;
            this.dataGridViewDrugRunningOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrugRunningOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Лекарство,
            this.Кончается});
            this.dataGridViewDrugRunningOut.Location = new System.Drawing.Point(402, 53);
            this.dataGridViewDrugRunningOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewDrugRunningOut.Name = "dataGridViewDrugRunningOut";
            this.dataGridViewDrugRunningOut.ReadOnly = true;
            this.dataGridViewDrugRunningOut.RowHeadersVisible = false;
            this.dataGridViewDrugRunningOut.Size = new System.Drawing.Size(505, 164);
            this.dataGridViewDrugRunningOut.TabIndex = 6;
            // 
            // Лекарство
            // 
            this.Лекарство.HeaderText = "Лекарство";
            this.Лекарство.Name = "Лекарство";
            this.Лекарство.ReadOnly = true;
            this.Лекарство.Width = 200;
            // 
            // Кончается
            // 
            this.Кончается.HeaderText = "Кончается";
            this.Кончается.Name = "Кончается";
            this.Кончается.ReadOnly = true;
            this.Кончается.Width = 300;
            // 
            // buttonMarkDoctorVisit
            // 
            this.buttonMarkDoctorVisit.Location = new System.Drawing.Point(16, 299);
            this.buttonMarkDoctorVisit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMarkDoctorVisit.Name = "buttonMarkDoctorVisit";
            this.buttonMarkDoctorVisit.Size = new System.Drawing.Size(184, 63);
            this.buttonMarkDoctorVisit.TabIndex = 7;
            this.buttonMarkDoctorVisit.Text = "Отметить посещение врача ";
            this.buttonMarkDoctorVisit.UseVisualStyleBackColor = true;
            this.buttonMarkDoctorVisit.Click += new System.EventHandler(this.buttonMarkDoctorVisit_Click);
            // 
            // buttonMarkVisitProcedure
            // 
            this.buttonMarkVisitProcedure.Location = new System.Drawing.Point(208, 299);
            this.buttonMarkVisitProcedure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMarkVisitProcedure.Name = "buttonMarkVisitProcedure";
            this.buttonMarkVisitProcedure.Size = new System.Drawing.Size(186, 63);
            this.buttonMarkVisitProcedure.TabIndex = 9;
            this.buttonMarkVisitProcedure.Text = "Отметить посещение процедуры";
            this.buttonMarkVisitProcedure.UseVisualStyleBackColor = true;
            this.buttonMarkVisitProcedure.Click += new System.EventHandler(this.buttonMarkVisitProcedure_Click);
            // 
            // buttonAddProcedure
            // 
            this.buttonAddProcedure.Location = new System.Drawing.Point(208, 230);
            this.buttonAddProcedure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddProcedure.Name = "buttonAddProcedure";
            this.buttonAddProcedure.Size = new System.Drawing.Size(186, 63);
            this.buttonAddProcedure.TabIndex = 8;
            this.buttonAddProcedure.Text = "Добавить процедуру";
            this.buttonAddProcedure.UseVisualStyleBackColor = true;
            this.buttonAddProcedure.Click += new System.EventHandler(this.buttonAddProcedure_Click);
            // 
            // buttonAddPatientDrug
            // 
            this.buttonAddPatientDrug.Location = new System.Drawing.Point(915, 53);
            this.buttonAddPatientDrug.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddPatientDrug.Name = "buttonAddPatientDrug";
            this.buttonAddPatientDrug.Size = new System.Drawing.Size(186, 63);
            this.buttonAddPatientDrug.TabIndex = 10;
            this.buttonAddPatientDrug.Text = "Добавить лекарство в список имеющихся";
            this.buttonAddPatientDrug.UseVisualStyleBackColor = true;
            this.buttonAddPatientDrug.Click += new System.EventHandler(this.buttonAddPatientDrag_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 230);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Принять лекарства";
            // 
            // buttonPatientDrugList
            // 
            this.buttonPatientDrugList.Location = new System.Drawing.Point(915, 122);
            this.buttonPatientDrugList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPatientDrugList.Name = "buttonPatientDrugList";
            this.buttonPatientDrugList.Size = new System.Drawing.Size(186, 63);
            this.buttonPatientDrugList.TabIndex = 13;
            this.buttonPatientDrugList.Text = "Список лекарств пациента";
            this.buttonPatientDrugList.UseVisualStyleBackColor = true;
            this.buttonPatientDrugList.Click += new System.EventHandler(this.buttonPatientDragList_Click);
            // 
            // buttonMarkMedicineTaken
            // 
            this.buttonMarkMedicineTaken.Location = new System.Drawing.Point(915, 248);
            this.buttonMarkMedicineTaken.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonMarkMedicineTaken.Name = "buttonMarkMedicineTaken";
            this.buttonMarkMedicineTaken.Size = new System.Drawing.Size(186, 63);
            this.buttonMarkMedicineTaken.TabIndex = 14;
            this.buttonMarkMedicineTaken.Text = "Отметить принятое лекарство";
            this.buttonMarkMedicineTaken.UseVisualStyleBackColor = true;
            this.buttonMarkMedicineTaken.Click += new System.EventHandler(this.buttonMarkMedicineTaken_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "Даты процедур";
            // 
            // monthCalendarProcedure
            // 
            this.monthCalendarProcedure.Location = new System.Drawing.Point(208, 53);
            this.monthCalendarProcedure.Margin = new System.Windows.Forms.Padding(10);
            this.monthCalendarProcedure.Name = "monthCalendarProcedure";
            this.monthCalendarProcedure.ShowToday = false;
            this.monthCalendarProcedure.ShowWeekNumbers = true;
            this.monthCalendarProcedure.TabIndex = 15;
            // 
            // buttonProcedureList
            // 
            this.buttonProcedureList.Location = new System.Drawing.Point(208, 368);
            this.buttonProcedureList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonProcedureList.Name = "buttonProcedureList";
            this.buttonProcedureList.Size = new System.Drawing.Size(186, 63);
            this.buttonProcedureList.TabIndex = 17;
            this.buttonProcedureList.Text = "Список процкдур пациента";
            this.buttonProcedureList.UseVisualStyleBackColor = true;
            this.buttonProcedureList.Click += new System.EventHandler(this.buttonProcedureList_Click);
            // 
            // buttonDoctorAppointmentsList
            // 
            this.buttonDoctorAppointmentsList.Location = new System.Drawing.Point(16, 368);
            this.buttonDoctorAppointmentsList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDoctorAppointmentsList.Name = "buttonDoctorAppointmentsList";
            this.buttonDoctorAppointmentsList.Size = new System.Drawing.Size(184, 63);
            this.buttonDoctorAppointmentsList.TabIndex = 18;
            this.buttonDoctorAppointmentsList.Text = "Список посещений врача пациента";
            this.buttonDoctorAppointmentsList.UseVisualStyleBackColor = true;
            this.buttonDoctorAppointmentsList.Click += new System.EventHandler(this.buttonDoctorAppointmentsList_Click);
            // 
            // dataGridViewPrescribedMedications
            // 
            this.dataGridViewPrescribedMedications.AllowUserToAddRows = false;
            this.dataGridViewPrescribedMedications.AllowUserToDeleteRows = false;
            this.dataGridViewPrescribedMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrescribedMedications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewPrescribedMedications.Location = new System.Drawing.Point(402, 248);
            this.dataGridViewPrescribedMedications.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewPrescribedMedications.Name = "dataGridViewPrescribedMedications";
            this.dataGridViewPrescribedMedications.ReadOnly = true;
            this.dataGridViewPrescribedMedications.RowHeadersVisible = false;
            this.dataGridViewPrescribedMedications.Size = new System.Drawing.Size(505, 183);
            this.dataGridViewPrescribedMedications.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Лекарство";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Когда принять";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1194, 546);
            this.Controls.Add(this.dataGridViewPrescribedMedications);
            this.Controls.Add(this.buttonDoctorAppointmentsList);
            this.Controls.Add(this.buttonProcedureList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendarProcedure);
            this.Controls.Add(this.buttonMarkMedicineTaken);
            this.Controls.Add(this.buttonPatientDrugList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddPatientDrug);
            this.Controls.Add(this.buttonMarkVisitProcedure);
            this.Controls.Add(this.buttonAddProcedure);
            this.Controls.Add(this.buttonMarkDoctorVisit);
            this.Controls.Add(this.dataGridViewDrugRunningOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddDoctorAppointments);
            this.Controls.Add(this.buttonAddWellBeing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendarDoctor);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 18, 17);
            this.Text = "Информация о паценте";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugRunningOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescribedMedications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выбратьПациентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПриложенииToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddWellBeing;
        private System.Windows.Forms.Button buttonAddDoctorAppointments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewDrugRunningOut;
        private System.Windows.Forms.Button buttonMarkDoctorVisit;
        private System.Windows.Forms.Button buttonMarkVisitProcedure;
        private System.Windows.Forms.Button buttonAddProcedure;
        private System.Windows.Forms.ToolStripMenuItem перечниToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddPatientDrug;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переченьПроцедурToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переченьЛекарсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переченьДокторовToolStripMenuItem;
        private System.Windows.Forms.Button buttonPatientDrugList;
        private System.Windows.Forms.Button buttonMarkMedicineTaken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendarProcedure;
        private System.Windows.Forms.Button buttonProcedureList;
        private System.Windows.Forms.Button buttonDoctorAppointmentsList;
        private DataGridViewTextBoxColumn Лекарство;
        private DataGridViewTextBoxColumn Кончается;
        private DataGridView dataGridViewPrescribedMedications;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}


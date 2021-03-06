namespace PatientApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendarDoctor = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddWellBeing = new System.Windows.Forms.Button();
            this.buttonAddDoctorAppointments = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewDragRunnigOut = new System.Windows.Forms.DataGridView();
            this.buttonMarkDoctorVisit = new System.Windows.Forms.Button();
            this.buttonMarkVisitProcedure = new System.Windows.Forms.Button();
            this.buttonAddProcedure = new System.Windows.Forms.Button();
            this.выбратьПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAddPatientDrag = new System.Windows.Forms.Button();
            this.dataGridViewPrescribedMedications = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.перечниToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переченьПроцедурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переченьЛекарсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переченьДокторовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPatientDragList = new System.Windows.Forms.Button();
            this.buttonMarkMedicineTaken = new System.Windows.Forms.Button();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendarProcedure = new System.Windows.Forms.MonthCalendar();
            this.buttonProcedureList = new System.Windows.Forms.Button();
            this.buttonDoctorAppointmentsList = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDragRunnigOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrescribedMedications)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendarDoctor
            // 
            this.monthCalendarDoctor.Location = new System.Drawing.Point(15, 46);
            this.monthCalendarDoctor.Name = "monthCalendarDoctor";
            this.monthCalendarDoctor.ShowToday = false;
            this.monthCalendarDoctor.ShowWeekNumbers = true;
            this.monthCalendarDoctor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
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
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
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
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПриложенииToolStripMenuItem.Text = "О приложении...";
            this.оПриложенииToolStripMenuItem.Click += new System.EventHandler(this.оПриложенииToolStripMenuItem_Click);
            // 
            // buttonAddWellBeing
            // 
            this.buttonAddWellBeing.Location = new System.Drawing.Point(589, 220);
            this.buttonAddWellBeing.Name = "buttonAddWellBeing";
            this.buttonAddWellBeing.Size = new System.Drawing.Size(186, 55);
            this.buttonAddWellBeing.TabIndex = 3;
            this.buttonAddWellBeing.Text = "Добавить самочувствие";
            this.buttonAddWellBeing.UseVisualStyleBackColor = true;
            this.buttonAddWellBeing.Click += new System.EventHandler(this.buttonAddWellBeing_Click);
            // 
            // buttonAddDoctorAppointments
            // 
            this.buttonAddDoctorAppointments.Location = new System.Drawing.Point(15, 220);
            this.buttonAddDoctorAppointments.Name = "buttonAddDoctorAppointments";
            this.buttonAddDoctorAppointments.Size = new System.Drawing.Size(186, 55);
            this.buttonAddDoctorAppointments.TabIndex = 4;
            this.buttonAddDoctorAppointments.Text = "Добавить посещение врача";
            this.buttonAddDoctorAppointments.UseVisualStyleBackColor = true;
            this.buttonAddDoctorAppointments.Click += new System.EventHandler(this.buttonAddDoctorAppointments_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Лекарства кончаются";
            // 
            // dataGridViewDragRunnigOut
            // 
            this.dataGridViewDragRunnigOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDragRunnigOut.Location = new System.Drawing.Point(397, 46);
            this.dataGridViewDragRunnigOut.Name = "dataGridViewDragRunnigOut";
            this.dataGridViewDragRunnigOut.Size = new System.Drawing.Size(186, 162);
            this.dataGridViewDragRunnigOut.TabIndex = 6;
            // 
            // buttonMarkDoctorVisit
            // 
            this.buttonMarkDoctorVisit.Location = new System.Drawing.Point(15, 281);
            this.buttonMarkDoctorVisit.Name = "buttonMarkDoctorVisit";
            this.buttonMarkDoctorVisit.Size = new System.Drawing.Size(186, 55);
            this.buttonMarkDoctorVisit.TabIndex = 7;
            this.buttonMarkDoctorVisit.Text = "Отметить посещение врача ";
            this.buttonMarkDoctorVisit.UseVisualStyleBackColor = true;
            this.buttonMarkDoctorVisit.Click += new System.EventHandler(this.buttonMarkDoctorVisit_Click);
            // 
            // buttonMarkVisitProcedure
            // 
            this.buttonMarkVisitProcedure.Location = new System.Drawing.Point(205, 281);
            this.buttonMarkVisitProcedure.Name = "buttonMarkVisitProcedure";
            this.buttonMarkVisitProcedure.Size = new System.Drawing.Size(186, 55);
            this.buttonMarkVisitProcedure.TabIndex = 9;
            this.buttonMarkVisitProcedure.Text = "Отметить посещение процедуры";
            this.buttonMarkVisitProcedure.UseVisualStyleBackColor = true;
            this.buttonMarkVisitProcedure.Click += new System.EventHandler(this.buttonMarkVisitProcedure_Click);
            // 
            // buttonAddProcedure
            // 
            this.buttonAddProcedure.Location = new System.Drawing.Point(207, 220);
            this.buttonAddProcedure.Name = "buttonAddProcedure";
            this.buttonAddProcedure.Size = new System.Drawing.Size(186, 55);
            this.buttonAddProcedure.TabIndex = 8;
            this.buttonAddProcedure.Text = "Добавить процедуру";
            this.buttonAddProcedure.UseVisualStyleBackColor = true;
            this.buttonAddProcedure.Click += new System.EventHandler(this.buttonAddProcedure_Click);
            // 
            // выбратьПациентаToolStripMenuItem
            // 
            this.выбратьПациентаToolStripMenuItem.Name = "выбратьПациентаToolStripMenuItem";
            this.выбратьПациентаToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.выбратьПациентаToolStripMenuItem.Text = "Выбрать пациента";
            this.выбратьПациентаToolStripMenuItem.Click += new System.EventHandler(this.выбратьПациентаToolStripMenuItem_Click);
            // 
            // buttonAddPatientDrag
            // 
            this.buttonAddPatientDrag.Location = new System.Drawing.Point(397, 220);
            this.buttonAddPatientDrag.Name = "buttonAddPatientDrag";
            this.buttonAddPatientDrag.Size = new System.Drawing.Size(186, 55);
            this.buttonAddPatientDrag.TabIndex = 10;
            this.buttonAddPatientDrag.Text = "Добавить лекарство в список имеющихся";
            this.buttonAddPatientDrag.UseVisualStyleBackColor = true;
            this.buttonAddPatientDrag.Click += new System.EventHandler(this.buttonAddPatientDrag_Click);
            // 
            // dataGridViewPrescribedMedications
            // 
            this.dataGridViewPrescribedMedications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrescribedMedications.Location = new System.Drawing.Point(589, 46);
            this.dataGridViewPrescribedMedications.Name = "dataGridViewPrescribedMedications";
            this.dataGridViewPrescribedMedications.Size = new System.Drawing.Size(186, 162);
            this.dataGridViewPrescribedMedications.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(586, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Принять лекарства";
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
            this.перечниToolStripMenuItem.Click += new System.EventHandler(this.перечниToolStripMenuItem_Click);
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
            this.переченьЛекарсовToolStripMenuItem.Text = "Перечень лекарсов";
            this.переченьЛекарсовToolStripMenuItem.Click += new System.EventHandler(this.переченьЛекарсовToolStripMenuItem_Click);
            // 
            // переченьДокторовToolStripMenuItem
            // 
            this.переченьДокторовToolStripMenuItem.Name = "переченьДокторовToolStripMenuItem";
            this.переченьДокторовToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.переченьДокторовToolStripMenuItem.Text = "Перечень докторов";
            this.переченьДокторовToolStripMenuItem.Click += new System.EventHandler(this.переченьДокторовToolStripMenuItem_Click);
            // 
            // buttonPatientDragList
            // 
            this.buttonPatientDragList.Location = new System.Drawing.Point(397, 281);
            this.buttonPatientDragList.Name = "buttonPatientDragList";
            this.buttonPatientDragList.Size = new System.Drawing.Size(186, 55);
            this.buttonPatientDragList.TabIndex = 13;
            this.buttonPatientDragList.Text = "Список лекарств пациента";
            this.buttonPatientDragList.UseVisualStyleBackColor = true;
            this.buttonPatientDragList.Click += new System.EventHandler(this.buttonPatientDragList_Click);
            // 
            // buttonMarkMedicineTaken
            // 
            this.buttonMarkMedicineTaken.Location = new System.Drawing.Point(589, 281);
            this.buttonMarkMedicineTaken.Name = "buttonMarkMedicineTaken";
            this.buttonMarkMedicineTaken.Size = new System.Drawing.Size(186, 55);
            this.buttonMarkMedicineTaken.TabIndex = 14;
            this.buttonMarkMedicineTaken.Text = "Отметить приянтое лекарство";
            this.buttonMarkMedicineTaken.UseVisualStyleBackColor = true;
            this.buttonMarkMedicineTaken.Click += new System.EventHandler(this.buttonMarkMedicineTaken_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            this.отчетыToolStripMenuItem.Click += new System.EventHandler(this.отчетыToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Даты процедур";
            // 
            // monthCalendarProcedure
            // 
            this.monthCalendarProcedure.Location = new System.Drawing.Point(207, 46);
            this.monthCalendarProcedure.Name = "monthCalendarProcedure";
            this.monthCalendarProcedure.ShowToday = false;
            this.monthCalendarProcedure.ShowWeekNumbers = true;
            this.monthCalendarProcedure.TabIndex = 15;
            // 
            // buttonProcedureList
            // 
            this.buttonProcedureList.Location = new System.Drawing.Point(205, 342);
            this.buttonProcedureList.Name = "buttonProcedureList";
            this.buttonProcedureList.Size = new System.Drawing.Size(186, 55);
            this.buttonProcedureList.TabIndex = 17;
            this.buttonProcedureList.Text = "Список процкдур пациента";
            this.buttonProcedureList.UseVisualStyleBackColor = true;
            this.buttonProcedureList.Click += new System.EventHandler(this.buttonProcedureList_Click);
            // 
            // buttonDoctorAppointmentsList
            // 
            this.buttonDoctorAppointmentsList.Location = new System.Drawing.Point(15, 342);
            this.buttonDoctorAppointmentsList.Name = "buttonDoctorAppointmentsList";
            this.buttonDoctorAppointmentsList.Size = new System.Drawing.Size(186, 55);
            this.buttonDoctorAppointmentsList.TabIndex = 18;
            this.buttonDoctorAppointmentsList.Text = "Список посещений врача пациента";
            this.buttonDoctorAppointmentsList.UseVisualStyleBackColor = true;
            this.buttonDoctorAppointmentsList.Click += new System.EventHandler(this.buttonDoctorAppointmentsList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1023, 473);
            this.Controls.Add(this.buttonDoctorAppointmentsList);
            this.Controls.Add(this.buttonProcedureList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.monthCalendarProcedure);
            this.Controls.Add(this.buttonMarkMedicineTaken);
            this.Controls.Add(this.buttonPatientDragList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewPrescribedMedications);
            this.Controls.Add(this.buttonAddPatientDrag);
            this.Controls.Add(this.buttonMarkVisitProcedure);
            this.Controls.Add(this.buttonAddProcedure);
            this.Controls.Add(this.buttonMarkDoctorVisit);
            this.Controls.Add(this.dataGridViewDragRunnigOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddDoctorAppointments);
            this.Controls.Add(this.buttonAddWellBeing);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendarDoctor);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 15, 15);
            this.Text = "Информация о паценте";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDragRunnigOut)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewDragRunnigOut;
        private System.Windows.Forms.Button buttonMarkDoctorVisit;
        private System.Windows.Forms.Button buttonMarkVisitProcedure;
        private System.Windows.Forms.Button buttonAddProcedure;
        private System.Windows.Forms.ToolStripMenuItem перечниToolStripMenuItem;
        private System.Windows.Forms.Button buttonAddPatientDrag;
        private System.Windows.Forms.DataGridView dataGridViewPrescribedMedications;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переченьПроцедурToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переченьЛекарсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переченьДокторовToolStripMenuItem;
        private System.Windows.Forms.Button buttonPatientDragList;
        private System.Windows.Forms.Button buttonMarkMedicineTaken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendarProcedure;
        private System.Windows.Forms.Button buttonProcedureList;
        private System.Windows.Forms.Button buttonDoctorAppointmentsList;
    }
}


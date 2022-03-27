namespace DoctorApp
{
    partial class DrugsChangerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrugsChangerForm));
            this.course_backupDataSet = new DoctorApp.Course_backupDataSet();
            this.drug_directoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drug_directoryTableAdapter = new DoctorApp.Course_backupDataSetTableAdapters.Drug_directoryTableAdapter();
            this.tableAdapterManager = new DoctorApp.Course_backupDataSetTableAdapters.TableAdapterManager();
            this.drug_directoryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.drug_directoryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.drug_directoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.course_backupDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drug_directoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drug_directoryBindingNavigator)).BeginInit();
            this.drug_directoryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drug_directoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // course_backupDataSet
            // 
            this.course_backupDataSet.DataSetName = "Course_backupDataSet";
            this.course_backupDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // drug_directoryBindingSource
            // 
            this.drug_directoryBindingSource.DataMember = "Drug directory";
            this.drug_directoryBindingSource.DataSource = this.course_backupDataSet;
            // 
            // drug_directoryTableAdapter
            // 
            this.drug_directoryTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Prescribed_medicationsTableAdapter = null;
            this.tableAdapterManager.Procedures_directoryTableAdapter = null;
            this.tableAdapterManager.ProceduresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DoctorApp.Course_backupDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Well_being_recordsTableAdapter = null;
            // 
            // drug_directoryBindingNavigator
            // 
            this.drug_directoryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.drug_directoryBindingNavigator.BindingSource = this.drug_directoryBindingSource;
            this.drug_directoryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.drug_directoryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.drug_directoryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.drug_directoryBindingNavigatorSaveItem});
            this.drug_directoryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.drug_directoryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.drug_directoryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.drug_directoryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.drug_directoryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.drug_directoryBindingNavigator.Name = "drug_directoryBindingNavigator";
            this.drug_directoryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.drug_directoryBindingNavigator.Size = new System.Drawing.Size(644, 25);
            this.drug_directoryBindingNavigator.TabIndex = 0;
            this.drug_directoryBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // drug_directoryBindingNavigatorSaveItem
            // 
            this.drug_directoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drug_directoryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("drug_directoryBindingNavigatorSaveItem.Image")));
            this.drug_directoryBindingNavigatorSaveItem.Name = "drug_directoryBindingNavigatorSaveItem";
            this.drug_directoryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.drug_directoryBindingNavigatorSaveItem.Text = "Save Data";
            this.drug_directoryBindingNavigatorSaveItem.Click += new System.EventHandler(this.drug_directoryBindingNavigatorSaveItem_Click);
            // 
            // drug_directoryDataGridView
            // 
            this.drug_directoryDataGridView.AutoGenerateColumns = false;
            this.drug_directoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drug_directoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.drug_directoryDataGridView.DataSource = this.drug_directoryBindingSource;
            this.drug_directoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drug_directoryDataGridView.Location = new System.Drawing.Point(0, 25);
            this.drug_directoryDataGridView.Name = "drug_directoryDataGridView";
            this.drug_directoryDataGridView.Size = new System.Drawing.Size(644, 340);
            this.drug_directoryDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Drug Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название лекарства";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Note";
            this.dataGridViewTextBoxColumn3.HeaderText = "Заметка";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Expiration date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Срок годности в месяцах";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // DrugsChangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 365);
            this.Controls.Add(this.drug_directoryDataGridView);
            this.Controls.Add(this.drug_directoryBindingNavigator);
            this.Name = "DrugsChangerForm";
            this.ShowIcon = false;
            this.Text = "Изменить список лекарств";
            this.Load += new System.EventHandler(this.DrugsChangerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.course_backupDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drug_directoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drug_directoryBindingNavigator)).EndInit();
            this.drug_directoryBindingNavigator.ResumeLayout(false);
            this.drug_directoryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drug_directoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Course_backupDataSet course_backupDataSet;
        private System.Windows.Forms.BindingSource drug_directoryBindingSource;
        private Course_backupDataSetTableAdapters.Drug_directoryTableAdapter drug_directoryTableAdapter;
        private Course_backupDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator drug_directoryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton drug_directoryBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView drug_directoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
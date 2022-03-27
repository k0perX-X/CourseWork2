namespace DoctorApp
{
    partial class DoctorMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.процедурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеЗаписиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посещениеДоктораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПосещениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВсехПосещенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.менюСуперПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сменитьПользователяToolStripMenuItem,
            this.процедурыToolStripMenuItem,
            this.посещениеДоктораToolStripMenuItem,
            this.менюСуперПользователяToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            this.сменитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.сменитьПользователяToolStripMenuItem_Click);
            // 
            // процедурыToolStripMenuItem
            // 
            this.процедурыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаписьToolStripMenuItem,
            this.всеЗаписиToolStripMenuItem});
            this.процедурыToolStripMenuItem.Name = "процедурыToolStripMenuItem";
            this.процедурыToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.процедурыToolStripMenuItem.Text = "Процедуры пациентов";
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить запись";
            this.добавитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаписьToolStripMenuItem_Click);
            // 
            // всеЗаписиToolStripMenuItem
            // 
            this.всеЗаписиToolStripMenuItem.Name = "всеЗаписиToolStripMenuItem";
            this.всеЗаписиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.всеЗаписиToolStripMenuItem.Text = "Все записи";
            this.всеЗаписиToolStripMenuItem.Click += new System.EventHandler(this.всеЗаписиToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // посещениеДоктораToolStripMenuItem
            // 
            this.посещениеДоктораToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьПосещениеToolStripMenuItem,
            this.списокВсехПосещенийToolStripMenuItem});
            this.посещениеДоктораToolStripMenuItem.Name = "посещениеДоктораToolStripMenuItem";
            this.посещениеДоктораToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.посещениеДоктораToolStripMenuItem.Text = "Посещение доктора";
            // 
            // добавитьПосещениеToolStripMenuItem
            // 
            this.добавитьПосещениеToolStripMenuItem.Name = "добавитьПосещениеToolStripMenuItem";
            this.добавитьПосещениеToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.добавитьПосещениеToolStripMenuItem.Text = "Добавить посещение";
            this.добавитьПосещениеToolStripMenuItem.Click += new System.EventHandler(this.добавитьПосещениеToolStripMenuItem_Click);
            // 
            // списокВсехПосещенийToolStripMenuItem
            // 
            this.списокВсехПосещенийToolStripMenuItem.Name = "списокВсехПосещенийToolStripMenuItem";
            this.списокВсехПосещенийToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.списокВсехПосещенийToolStripMenuItem.Text = "Список всех посещений";
            this.списокВсехПосещенийToolStripMenuItem.Click += new System.EventHandler(this.списокВсехПосещенийToolStripMenuItem_Click);
            // 
            // менюСуперПользователяToolStripMenuItem
            // 
            this.менюСуперПользователяToolStripMenuItem.Name = "менюСуперПользователяToolStripMenuItem";
            this.менюСуперПользователяToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
            this.менюСуперПользователяToolStripMenuItem.Text = "Меню супер пользователя";
            this.менюСуперПользователяToolStripMenuItem.Visible = false;
            // 
            // DoctorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 611);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DoctorMainForm";
            this.Text = "База данных поликлиники";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem процедурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеЗаписиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посещениеДоктораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПосещениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВсехПосещенийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюСуперПользователяToolStripMenuItem;
    }
}


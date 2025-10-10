namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    partial class ModuleADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleADMIN));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.fileTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.statementTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.make_statementTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.logFolder_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.studentsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.carsTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CancelBUTTON = new System.Windows.Forms.Button();
            this.DoneBUTTON = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(838, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTSM,
            this.statementTSM,
            this.serviceTSM,
            this.helpTSM});
            this.toolStripButton1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(156, 22);
            this.toolStripButton1.Text = "ГЛАВНОЕ МЕНЮ";
            // 
            // fileTSM
            // 
            this.fileTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitTSM});
            this.fileTSM.Name = "fileTSM";
            this.fileTSM.Size = new System.Drawing.Size(131, 22);
            this.fileTSM.Text = "Файл";
            // 
            // exitTSM
            // 
            this.exitTSM.Name = "exitTSM";
            this.exitTSM.Size = new System.Drawing.Size(122, 22);
            this.exitTSM.Text = "Выход";
            this.exitTSM.Click += new System.EventHandler(this.exitTSM_Click);
            // 
            // statementTSM
            // 
            this.statementTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.make_statementTSM});
            this.statementTSM.Name = "statementTSM";
            this.statementTSM.Size = new System.Drawing.Size(131, 22);
            this.statementTSM.Text = "Отчёты";
            // 
            // make_statementTSM
            // 
            this.make_statementTSM.Name = "make_statementTSM";
            this.make_statementTSM.Size = new System.Drawing.Size(291, 22);
            this.make_statementTSM.Text = "Сформировать отчёт по группе";
            this.make_statementTSM.Click += new System.EventHandler(this.make_statementTSM_Click);
            // 
            // serviceTSM
            // 
            this.serviceTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsTSM});
            this.serviceTSM.Name = "serviceTSM";
            this.serviceTSM.Size = new System.Drawing.Size(131, 22);
            this.serviceTSM.Text = "Сервис";
            // 
            // settingsTSM
            // 
            this.settingsTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logFolder_TSM});
            this.settingsTSM.Name = "settingsTSM";
            this.settingsTSM.Size = new System.Drawing.Size(150, 22);
            this.settingsTSM.Text = "Настройки";
            // 
            // logFolder_TSM
            // 
            this.logFolder_TSM.Name = "logFolder_TSM";
            this.logFolder_TSM.Size = new System.Drawing.Size(311, 22);
            this.logFolder_TSM.Text = "Изменить папку для логирования";
            this.logFolder_TSM.Click += new System.EventHandler(this.logFolder_TSM_Click);
            // 
            // helpTSM
            // 
            this.helpTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTSM});
            this.helpTSM.Name = "helpTSM";
            this.helpTSM.Size = new System.Drawing.Size(131, 22);
            this.helpTSM.Text = "Помощь";
            // 
            // aboutTSM
            // 
            this.aboutTSM.Name = "aboutTSM";
            this.aboutTSM.Size = new System.Drawing.Size(163, 22);
            this.aboutTSM.Text = "О программе";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsTSM,
            this.instructorsTSM,
            this.carsTSM,
            this.scheduleTSM});
            this.toolStripSplitButton1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(202, 22);
            this.toolStripSplitButton1.Text = "ОБЛАСТЬ НАВИГАЦИИ";
            // 
            // studentsTSM
            // 
            this.studentsTSM.Name = "studentsTSM";
            this.studentsTSM.Size = new System.Drawing.Size(182, 22);
            this.studentsTSM.Text = "УЧЕНИКИ";
            this.studentsTSM.Click += new System.EventHandler(this.studentsTSM_Click);
            // 
            // instructorsTSM
            // 
            this.instructorsTSM.Name = "instructorsTSM";
            this.instructorsTSM.Size = new System.Drawing.Size(182, 22);
            this.instructorsTSM.Text = "ИНСТРУКТОРЫ";
            this.instructorsTSM.Click += new System.EventHandler(this.instructorsTSM_Click);
            // 
            // carsTSM
            // 
            this.carsTSM.Name = "carsTSM";
            this.carsTSM.Size = new System.Drawing.Size(182, 22);
            this.carsTSM.Text = "АВТОМОБИЛИ";
            this.carsTSM.Click += new System.EventHandler(this.carsTSM_Click);
            // 
            // scheduleTSM
            // 
            this.scheduleTSM.Name = "scheduleTSM";
            this.scheduleTSM.Size = new System.Drawing.Size(182, 22);
            this.scheduleTSM.Text = "РАСПИСАНИЕ";
            this.scheduleTSM.Click += new System.EventHandler(this.scheduleTSM_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(715, 350);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // CancelBUTTON
            // 
            this.CancelBUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBUTTON.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBUTTON.Location = new System.Drawing.Point(535, 428);
            this.CancelBUTTON.Name = "CancelBUTTON";
            this.CancelBUTTON.Size = new System.Drawing.Size(90, 36);
            this.CancelBUTTON.TabIndex = 3;
            this.CancelBUTTON.Text = "Отменить";
            this.CancelBUTTON.UseVisualStyleBackColor = true;
            this.CancelBUTTON.Visible = false;
            this.CancelBUTTON.Click += new System.EventHandler(this.CancelBUTTON_Click);
            // 
            // DoneBUTTON
            // 
            this.DoneBUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneBUTTON.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoneBUTTON.Location = new System.Drawing.Point(631, 428);
            this.DoneBUTTON.Name = "DoneBUTTON";
            this.DoneBUTTON.Size = new System.Drawing.Size(128, 36);
            this.DoneBUTTON.TabIndex = 4;
            this.DoneBUTTON.Text = "Проведено";
            this.DoneBUTTON.UseVisualStyleBackColor = true;
            this.DoneBUTTON.Visible = false;
            this.DoneBUTTON.Click += new System.EventHandler(this.DoneBUTTON_Click);
            // 
            // buttonADD
            // 
            this.buttonADD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonADD.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonADD.Location = new System.Drawing.Point(44, 428);
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.Size = new System.Drawing.Size(90, 36);
            this.buttonADD.TabIndex = 5;
            this.buttonADD.Text = "Добавить";
            this.buttonADD.UseVisualStyleBackColor = true;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDELETE.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDELETE.Location = new System.Drawing.Point(140, 428);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(128, 36);
            this.buttonDELETE.TabIndex = 6;
            this.buttonDELETE.Text = "Удалить";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            this.buttonDELETE.Click += new System.EventHandler(this.buttonDELETE_Click);
            // 
            // ModuleADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 488);
            this.Controls.Add(this.buttonDELETE);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.DoneBUTTON);
            this.Controls.Add(this.CancelBUTTON);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.MinimumSize = new System.Drawing.Size(854, 527);
            this.Name = "ModuleADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Модуль администратора";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem studentsTSM;
        private System.Windows.Forms.ToolStripMenuItem instructorsTSM;
        private System.Windows.Forms.ToolStripMenuItem carsTSM;
        private System.Windows.Forms.ToolStripMenuItem scheduleTSM;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem fileTSM;
        private System.Windows.Forms.ToolStripMenuItem exitTSM;
        private System.Windows.Forms.ToolStripMenuItem statementTSM;
        private System.Windows.Forms.ToolStripMenuItem make_statementTSM;
        private System.Windows.Forms.ToolStripMenuItem serviceTSM;
        private System.Windows.Forms.ToolStripMenuItem settingsTSM;
        private System.Windows.Forms.ToolStripMenuItem helpTSM;
        private System.Windows.Forms.ToolStripMenuItem aboutTSM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CancelBUTTON;
        private System.Windows.Forms.Button DoneBUTTON;
        private System.Windows.Forms.ToolStripMenuItem logFolder_TSM;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonDELETE;
    }
}
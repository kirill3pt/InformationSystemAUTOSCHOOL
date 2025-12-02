namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    partial class ModuleINSTRUCTOR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuleINSTRUCTOR));
            this.DoneBUTTON = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CancelBUTTON = new System.Windows.Forms.Button();
            this.aboutTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.fileTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.scheduleTSM = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DoneBUTTON
            // 
            this.DoneBUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DoneBUTTON.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoneBUTTON.Location = new System.Drawing.Point(596, 421);
            this.DoneBUTTON.Name = "DoneBUTTON";
            this.DoneBUTTON.Size = new System.Drawing.Size(128, 36);
            this.DoneBUTTON.TabIndex = 8;
            this.DoneBUTTON.Text = "Проведено";
            this.DoneBUTTON.UseVisualStyleBackColor = true;
            this.DoneBUTTON.Visible = false;
            this.DoneBUTTON.Click += new System.EventHandler(this.DoneBUTTON_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(680, 350);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // CancelBUTTON
            // 
            this.CancelBUTTON.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBUTTON.Font = new System.Drawing.Font("Bahnschrift Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBUTTON.Location = new System.Drawing.Point(500, 421);
            this.CancelBUTTON.Name = "CancelBUTTON";
            this.CancelBUTTON.Size = new System.Drawing.Size(90, 36);
            this.CancelBUTTON.TabIndex = 7;
            this.CancelBUTTON.Text = "Отменить";
            this.CancelBUTTON.UseVisualStyleBackColor = true;
            this.CancelBUTTON.Visible = false;
            this.CancelBUTTON.Click += new System.EventHandler(this.CancelBUTTON_Click);
            // 
            // aboutTSM
            // 
            this.aboutTSM.Name = "aboutTSM";
            this.aboutTSM.Size = new System.Drawing.Size(180, 22);
            this.aboutTSM.Text = "О программе";
            this.aboutTSM.Click += new System.EventHandler(this.aboutTSM_Click);
            // 
            // helpTSM
            // 
            this.helpTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTSM});
            this.helpTSM.Name = "helpTSM";
            this.helpTSM.Size = new System.Drawing.Size(180, 22);
            this.helpTSM.Text = "Помощь";
            // 
            // exitTSM
            // 
            this.exitTSM.Name = "exitTSM";
            this.exitTSM.Size = new System.Drawing.Size(122, 22);
            this.exitTSM.Text = "Выход";
            this.exitTSM.Click += new System.EventHandler(this.exitTSM_Click);
            // 
            // fileTSM
            // 
            this.fileTSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitTSM});
            this.fileTSM.Name = "fileTSM";
            this.fileTSM.Size = new System.Drawing.Size(180, 22);
            this.fileTSM.Text = "Файл";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileTSM,
            this.helpTSM});
            this.toolStripButton1.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(156, 22);
            this.toolStripButton1.Text = "ГЛАВНОЕ МЕНЮ";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.scheduleTSM});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(796, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // scheduleTSM
            // 
            this.scheduleTSM.Font = new System.Drawing.Font("Bahnschrift Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scheduleTSM.Image = ((System.Drawing.Image)(resources.GetObject("scheduleTSM.Image")));
            this.scheduleTSM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.scheduleTSM.Name = "scheduleTSM";
            this.scheduleTSM.Size = new System.Drawing.Size(125, 22);
            this.scheduleTSM.Text = "РАСПИСАНИЕ";
            this.scheduleTSM.Click += new System.EventHandler(this.scheduleTSM_ButtonClick);
            // 
            // ModuleINSTRUCTOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 488);
            this.Controls.Add(this.DoneBUTTON);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CancelBUTTON);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(812, 527);
            this.MinimumSize = new System.Drawing.Size(812, 527);
            this.Name = "ModuleINSTRUCTOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Модуль инструктора";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoneBUTTON;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CancelBUTTON;
        private System.Windows.Forms.ToolStripMenuItem aboutTSM;
        private System.Windows.Forms.ToolStripMenuItem helpTSM;
        private System.Windows.Forms.ToolStripMenuItem exitTSM;
        private System.Windows.Forms.ToolStripMenuItem fileTSM;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton scheduleTSM;
    }
}
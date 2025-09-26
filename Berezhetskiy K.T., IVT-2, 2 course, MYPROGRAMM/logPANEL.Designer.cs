namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    partial class loginPanel
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.goToProgramm = new System.Windows.Forms.Button();
            this.UserRoleChoice = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.passwordBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.loginBox, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(84, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(216, 79);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.passwordBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.Location = new System.Drawing.Point(3, 49);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(210, 27);
            this.passwordBox.TabIndex = 1;
            // 
            // loginBox
            // 
            this.loginBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(3, 9);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(210, 27);
            this.loginBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ЛОГИН:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ПАРОЛЬ:";
            // 
            // goToProgramm
            // 
            this.goToProgramm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.goToProgramm.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToProgramm.Location = new System.Drawing.Point(84, 134);
            this.goToProgramm.Name = "goToProgramm";
            this.goToProgramm.Size = new System.Drawing.Size(216, 42);
            this.goToProgramm.TabIndex = 3;
            this.goToProgramm.Text = "ВХОД";
            this.goToProgramm.UseVisualStyleBackColor = false;
            this.goToProgramm.Click += new System.EventHandler(this.goToProgramm_Click);
            // 
            // UserRoleChoice
            // 
            this.UserRoleChoice.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserRoleChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserRoleChoice.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserRoleChoice.Items.AddRange(new object[] {
            "Администратор",
            "Инструктор"});
            this.UserRoleChoice.Location = new System.Drawing.Point(84, 101);
            this.UserRoleChoice.MaxDropDownItems = 2;
            this.UserRoleChoice.Name = "UserRoleChoice";
            this.UserRoleChoice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserRoleChoice.Size = new System.Drawing.Size(216, 27);
            this.UserRoleChoice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(32, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "РОЛЬ:";
            // 
            // loginPanel
            // 
            this.AcceptButton = this.goToProgramm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 189);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserRoleChoice);
            this.Controls.Add(this.goToProgramm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "loginPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель входа";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goToProgramm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox UserRoleChoice;
    }
}


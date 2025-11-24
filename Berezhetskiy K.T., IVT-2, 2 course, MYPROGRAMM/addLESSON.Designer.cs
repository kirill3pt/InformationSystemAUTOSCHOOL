namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    partial class addLESSON
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
            this.addBUTTON = new System.Windows.Forms.Button();
            this.SelectDATE = new System.Windows.Forms.DateTimePicker();
            this.SelectTIME = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentSELECT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CarSELECT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.InstructorSELECT = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBUTTON
            // 
            this.addBUTTON.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBUTTON.Location = new System.Drawing.Point(29, 201);
            this.addBUTTON.Name = "addBUTTON";
            this.addBUTTON.Size = new System.Drawing.Size(248, 56);
            this.addBUTTON.TabIndex = 27;
            this.addBUTTON.Text = "ДОБАВИТЬ";
            this.addBUTTON.UseVisualStyleBackColor = true;
            this.addBUTTON.Click += new System.EventHandler(this.addBUTTON_Click);
            // 
            // SelectDATE
            // 
            this.SelectDATE.CalendarFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectDATE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDATE.Location = new System.Drawing.Point(137, 39);
            this.SelectDATE.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.SelectDATE.MinDate = new System.DateTime(2025, 9, 25, 0, 0, 0, 0);
            this.SelectDATE.Name = "SelectDATE";
            this.SelectDATE.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectDATE.Size = new System.Drawing.Size(151, 21);
            this.SelectDATE.TabIndex = 28;
            // 
            // SelectTIME
            // 
            this.SelectTIME.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectTIME.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.SelectTIME.Location = new System.Drawing.Point(137, 65);
            this.SelectTIME.MaxDate = new System.DateTime(2029, 12, 31, 0, 0, 0, 0);
            this.SelectTIME.MinDate = new System.DateTime(2025, 9, 25, 0, 0, 0, 0);
            this.SelectTIME.Name = "SelectTIME";
            this.SelectTIME.Size = new System.Drawing.Size(151, 21);
            this.SelectTIME.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(90, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(82, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Время";
            // 
            // StudentSELECT
            // 
            this.StudentSELECT.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentSELECT.FormattingEnabled = true;
            this.StudentSELECT.Location = new System.Drawing.Point(137, 91);
            this.StudentSELECT.Name = "StudentSELECT";
            this.StudentSELECT.Size = new System.Drawing.Size(151, 22);
            this.StudentSELECT.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(76, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ученик";
            // 
            // CarSELECT
            // 
            this.CarSELECT.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarSELECT.FormattingEnabled = true;
            this.CarSELECT.Location = new System.Drawing.Point(137, 123);
            this.CarSELECT.Name = "CarSELECT";
            this.CarSELECT.Size = new System.Drawing.Size(151, 22);
            this.CarSELECT.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(47, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Автомобиль";
            // 
            // InstructorSELECT
            // 
            this.InstructorSELECT.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstructorSELECT.FormattingEnabled = true;
            this.InstructorSELECT.Location = new System.Drawing.Point(137, 156);
            this.InstructorSELECT.Name = "InstructorSELECT";
            this.InstructorSELECT.Size = new System.Drawing.Size(151, 22);
            this.InstructorSELECT.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(49, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Инструктор";
            // 
            // addLESSON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 305);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InstructorSELECT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CarSELECT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentSELECT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectTIME);
            this.Controls.Add(this.SelectDATE);
            this.Controls.Add(this.addBUTTON);
            this.MinimumSize = new System.Drawing.Size(316, 295);
            this.Name = "addLESSON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить занятие";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addBUTTON;
        private System.Windows.Forms.DateTimePicker SelectDATE;
        private System.Windows.Forms.DateTimePicker SelectTIME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StudentSELECT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CarSELECT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox InstructorSELECT;
        private System.Windows.Forms.Label label5;
    }
}
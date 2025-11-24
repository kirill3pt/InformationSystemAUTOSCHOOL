namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    partial class addSTUDENT
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
            this.fioBOX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberBOX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBOX = new System.Windows.Forms.TextBox();
            this.addBUTTON = new System.Windows.Forms.Button();
            this.paidOrNot = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fioBOX
            // 
            this.fioBOX.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioBOX.Location = new System.Drawing.Point(12, 36);
            this.fioBOX.Name = "fioBOX";
            this.fioBOX.Size = new System.Drawing.Size(226, 30);
            this.fioBOX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Телефон";
            // 
            // numberBOX
            // 
            this.numberBOX.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberBOX.Location = new System.Drawing.Point(12, 99);
            this.numberBOX.Name = "numberBOX";
            this.numberBOX.Size = new System.Drawing.Size(226, 30);
            this.numberBOX.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Группа";
            // 
            // groupBOX
            // 
            this.groupBOX.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBOX.Location = new System.Drawing.Point(12, 165);
            this.groupBOX.Name = "groupBOX";
            this.groupBOX.Size = new System.Drawing.Size(226, 30);
            this.groupBOX.TabIndex = 4;
            // 
            // addBUTTON
            // 
            this.addBUTTON.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBUTTON.Location = new System.Drawing.Point(12, 254);
            this.addBUTTON.Name = "addBUTTON";
            this.addBUTTON.Size = new System.Drawing.Size(226, 56);
            this.addBUTTON.TabIndex = 6;
            this.addBUTTON.Text = "ДОБАВИТЬ";
            this.addBUTTON.UseVisualStyleBackColor = true;
            this.addBUTTON.Click += new System.EventHandler(this.addBUTTON_Click);
            // 
            // paidOrNot
            // 
            this.paidOrNot.AutoSize = true;
            this.paidOrNot.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paidOrNot.Location = new System.Drawing.Point(12, 209);
            this.paidOrNot.Name = "paidOrNot";
            this.paidOrNot.Size = new System.Drawing.Size(150, 37);
            this.paidOrNot.TabIndex = 9;
            this.paidOrNot.Text = "Оплачено?";
            this.paidOrNot.UseVisualStyleBackColor = true;
            // 
            // addSTUDENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 366);
            this.Controls.Add(this.paidOrNot);
            this.Controls.Add(this.addBUTTON);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBOX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fioBOX);
            this.Name = "addSTUDENT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление студента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fioBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox groupBOX;
        private System.Windows.Forms.Button addBUTTON;
        private System.Windows.Forms.CheckBox paidOrNot;
    }
}
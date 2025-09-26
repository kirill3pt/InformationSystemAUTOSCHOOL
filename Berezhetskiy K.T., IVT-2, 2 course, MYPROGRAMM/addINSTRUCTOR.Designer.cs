namespace Berezhetskiy_K.T.__IVT_2__2_course__MYPROGRAMM
{
    partial class addINSTRUCTOR
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
            this.addBUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fioBOX
            // 
            this.fioBOX.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fioBOX.Location = new System.Drawing.Point(91, 31);
            this.fioBOX.Name = "fioBOX";
            this.fioBOX.Size = new System.Drawing.Size(132, 27);
            this.fioBOX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Телефон";
            // 
            // numberBOX
            // 
            this.numberBOX.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberBOX.Location = new System.Drawing.Point(91, 67);
            this.numberBOX.Name = "numberBOX";
            this.numberBOX.Size = new System.Drawing.Size(132, 27);
            this.numberBOX.TabIndex = 2;
            // 
            // addBUTTON
            // 
            this.addBUTTON.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBUTTON.Location = new System.Drawing.Point(27, 112);
            this.addBUTTON.Name = "addBUTTON";
            this.addBUTTON.Size = new System.Drawing.Size(196, 46);
            this.addBUTTON.TabIndex = 28;
            this.addBUTTON.Text = "ДОБАВИТЬ";
            this.addBUTTON.UseVisualStyleBackColor = true;
            this.addBUTTON.Click += new System.EventHandler(this.addBUTTON_Click);
            // 
            // addINSTRUCTOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 170);
            this.Controls.Add(this.addBUTTON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberBOX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fioBOX);
            this.Name = "addINSTRUCTOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить инструктора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fioBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberBOX;
        private System.Windows.Forms.Button addBUTTON;
    }
}
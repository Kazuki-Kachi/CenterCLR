namespace RP2
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
            if(disposing)
            {
                components?.Dispose();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbLeft = new System.Windows.Forms.TextBox();
            this.tbRight = new System.Windows.Forms.TextBox();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("NicoMoji+", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(1833, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(689, 29);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("RiiTegakiN-R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(1543, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 36);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("RiiTegakiN-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(1543, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 54);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1915, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "▲";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1915, 68);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "▼";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbLeft
            // 
            this.tbLeft.Font = new System.Drawing.Font("RiiTegakiN-R", 24F);
            this.tbLeft.Location = new System.Drawing.Point(475, 394);
            this.tbLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(299, 47);
            this.tbLeft.TabIndex = 6;
            this.tbLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbRight
            // 
            this.tbRight.Font = new System.Drawing.Font("RiiTegakiN-R", 24F);
            this.tbRight.Location = new System.Drawing.Point(897, 394);
            this.tbRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(299, 47);
            this.tbRight.TabIndex = 7;
            this.tbRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbOperator
            // 
            this.cbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperator.Font = new System.Drawing.Font("RiiTegakiN-R", 24F);
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Location = new System.Drawing.Point(783, 394);
            this.cbOperator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(105, 48);
            this.cbOperator.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("RiiTegakiN-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(1220, 390);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 54);
            this.label4.TabIndex = 9;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbAnswer
            // 
            this.lbAnswer.Font = new System.Drawing.Font("RiiTegakiN-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbAnswer.Location = new System.Drawing.Point(1325, 389);
            this.lbAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(364, 54);
            this.lbAnswer.TabIndex = 10;
            this.lbAnswer.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.button3.Location = new System.Drawing.Point(2183, 1152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 74);
            this.button3.TabIndex = 11;
            this.button3.Text = "Draw";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2536, 1291);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.tbRight);
            this.Controls.Add(this.tbLeft);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2554, 1338);
            this.MinimumSize = new System.Drawing.Size(2554, 1338);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbLeft;
        private System.Windows.Forms.TextBox tbRight;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.Button button3;
    }
}


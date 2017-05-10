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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("NicoMoji+", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(1375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 23);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("RiiTegakiN-R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(1157, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 29);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("RiiTegakiN-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(1157, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 43);
            this.label3.TabIndex = 3;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1436, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "▲";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1436, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 22);
            this.button2.TabIndex = 5;
            this.button2.Text = "▼";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tbLeft
            // 
            this.tbLeft.Font = new System.Drawing.Font("RiiTegakiN-R", 24F);
            this.tbLeft.Location = new System.Drawing.Point(356, 315);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(225, 39);
            this.tbLeft.TabIndex = 6;
            this.tbLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbRight
            // 
            this.tbRight.Font = new System.Drawing.Font("RiiTegakiN-R", 24F);
            this.tbRight.Location = new System.Drawing.Point(673, 315);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(225, 39);
            this.tbRight.TabIndex = 7;
            this.tbRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbOperator
            // 
            this.cbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperator.Font = new System.Drawing.Font("RiiTegakiN-R", 24F);
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Location = new System.Drawing.Point(587, 315);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(80, 40);
            this.cbOperator.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("RiiTegakiN-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(915, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 43);
            this.label4.TabIndex = 9;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbAnswer
            // 
            this.lbAnswer.Font = new System.Drawing.Font("RiiTegakiN-R", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbAnswer.Location = new System.Drawing.Point(994, 311);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(273, 43);
            this.lbAnswer.TabIndex = 10;
            this.lbAnswer.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
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
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
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
    }
}


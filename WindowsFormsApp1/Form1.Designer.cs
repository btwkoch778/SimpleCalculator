using System;

namespace WindowsFormsApp1
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
            this.lblNumberOne = new System.Windows.Forms.Label();
            this.txtNumberOne = new System.Windows.Forms.TextBox();
            this.lblNumberTwo = new System.Windows.Forms.Label();
            this.txtNumberTwo = new System.Windows.Forms.TextBox();
            this.lblCommand = new System.Windows.Forms.Label();
            this.cmbCommand = new System.Windows.Forms.ComboBox();
            this.lblAnswerText = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumberOne
            // 
            this.lblNumberOne.AutoSize = true;
            this.lblNumberOne.Location = new System.Drawing.Point(74, 36);
            this.lblNumberOne.Name = "lblNumberOne";
            this.lblNumberOne.Size = new System.Drawing.Size(53, 13);
            this.lblNumberOne.TabIndex = 0;
            this.lblNumberOne.Text = "Number 1";
            this.lblNumberOne.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumberOne
            // 
            this.txtNumberOne.Location = new System.Drawing.Point(77, 52);
            this.txtNumberOne.Name = "txtNumberOne";
            this.txtNumberOne.Size = new System.Drawing.Size(120, 20);
            this.txtNumberOne.TabIndex = 1;
            this.txtNumberOne.Text = "0";
            // 
            // lblNumberTwo
            // 
            this.lblNumberTwo.AutoSize = true;
            this.lblNumberTwo.Location = new System.Drawing.Point(74, 107);
            this.lblNumberTwo.Name = "lblNumberTwo";
            this.lblNumberTwo.Size = new System.Drawing.Size(53, 13);
            this.lblNumberTwo.TabIndex = 2;
            this.lblNumberTwo.Text = "Number 2";
            // 
            // txtNumberTwo
            // 
            this.txtNumberTwo.Location = new System.Drawing.Point(77, 123);
            this.txtNumberTwo.Name = "txtNumberTwo";
            this.txtNumberTwo.Size = new System.Drawing.Size(120, 20);
            this.txtNumberTwo.TabIndex = 3;
            this.txtNumberTwo.Text = "0";
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(73, 174);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(54, 13);
            this.lblCommand.TabIndex = 4;
            this.lblCommand.Text = "Command";
            // 
            // cmbCommand
            // 
            this.cmbCommand.FormattingEnabled = true;
            this.cmbCommand.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbCommand.Location = new System.Drawing.Point(76, 190);
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(121, 21);
            this.cmbCommand.TabIndex = 5;
            // 
            // lblAnswerText
            // 
            this.lblAnswerText.AutoSize = true;
            this.lblAnswerText.Location = new System.Drawing.Point(73, 231);
            this.lblAnswerText.Name = "lblAnswerText";
            this.lblAnswerText.Size = new System.Drawing.Size(45, 13);
            this.lblAnswerText.TabIndex = 6;
            this.lblAnswerText.Text = "Answer:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(147, 231);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(13, 13);
            this.lblAnswer.TabIndex = 7;
            this.lblAnswer.Text = "0";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(76, 263);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(110, 23);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(76, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(270, 377);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblAnswerText);
            this.Controls.Add(this.cmbCommand);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.txtNumberTwo);
            this.Controls.Add(this.lblNumberTwo);
            this.Controls.Add(this.txtNumberOne);
            this.Controls.Add(this.lblNumberOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblNumberOne;
        private System.Windows.Forms.TextBox txtNumberOne;
        private System.Windows.Forms.Label lblNumberTwo;
        private System.Windows.Forms.TextBox txtNumberTwo;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.ComboBox cmbCommand;
        private System.Windows.Forms.Label lblAnswerText;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnClear;
    }
}


using System;

namespace NGGUI
{
    partial class Numbers_Game
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
            this.textBoxSolution = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedNumber1 = new System.Windows.Forms.TextBox();
            this.selectedNumber2 = new System.Windows.Forms.TextBox();
            this.selectedNumber4 = new System.Windows.Forms.TextBox();
            this.selectedNumber3 = new System.Windows.Forms.TextBox();
            this.selectedNumber6 = new System.Windows.Forms.TextBox();
            this.selectedNumber5 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.ResultLable = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSolution
            // 
            this.textBoxSolution.Location = new System.Drawing.Point(91, 281);
            this.textBoxSolution.Name = "textBoxSolution";
            this.textBoxSolution.Size = new System.Drawing.Size(603, 22);
            this.textBoxSolution.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your solution:";
            // 
            // selectedNumber1
            // 
            this.selectedNumber1.Location = new System.Drawing.Point(91, 141);
            this.selectedNumber1.MinimumSize = new System.Drawing.Size(50, 50);
            this.selectedNumber1.Name = "selectedNumber1";
            this.selectedNumber1.ReadOnly = true;
            this.selectedNumber1.Size = new System.Drawing.Size(50, 22);
            this.selectedNumber1.TabIndex = 2;
            // 
            // selectedNumber2
            // 
            this.selectedNumber2.Location = new System.Drawing.Point(191, 141);
            this.selectedNumber2.MinimumSize = new System.Drawing.Size(50, 50);
            this.selectedNumber2.Name = "selectedNumber2";
            this.selectedNumber2.ReadOnly = true;
            this.selectedNumber2.Size = new System.Drawing.Size(50, 22);
            this.selectedNumber2.TabIndex = 3;
            // 
            // selectedNumber4
            // 
            this.selectedNumber4.Location = new System.Drawing.Point(421, 141);
            this.selectedNumber4.MinimumSize = new System.Drawing.Size(50, 50);
            this.selectedNumber4.Name = "selectedNumber4";
            this.selectedNumber4.ReadOnly = true;
            this.selectedNumber4.Size = new System.Drawing.Size(50, 22);
            this.selectedNumber4.TabIndex = 5;
            // 
            // selectedNumber3
            // 
            this.selectedNumber3.Location = new System.Drawing.Point(304, 141);
            this.selectedNumber3.MinimumSize = new System.Drawing.Size(50, 50);
            this.selectedNumber3.Name = "selectedNumber3";
            this.selectedNumber3.ReadOnly = true;
            this.selectedNumber3.Size = new System.Drawing.Size(50, 22);
            this.selectedNumber3.TabIndex = 4;
            // 
            // selectedNumber6
            // 
            this.selectedNumber6.Location = new System.Drawing.Point(644, 141);
            this.selectedNumber6.MinimumSize = new System.Drawing.Size(50, 50);
            this.selectedNumber6.Name = "selectedNumber6";
            this.selectedNumber6.ReadOnly = true;
            this.selectedNumber6.Size = new System.Drawing.Size(50, 22);
            this.selectedNumber6.TabIndex = 7;
            // 
            // selectedNumber5
            // 
            this.selectedNumber5.Location = new System.Drawing.Point(529, 141);
            this.selectedNumber5.MinimumSize = new System.Drawing.Size(50, 50);
            this.selectedNumber5.Name = "selectedNumber5";
            this.selectedNumber5.ReadOnly = true;
            this.selectedNumber5.Size = new System.Drawing.Size(50, 22);
            this.selectedNumber5.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(344, 52);
            this.textBox8.MinimumSize = new System.Drawing.Size(100, 50);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 8;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(713, 280);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(23, 21);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(105, 23);
            this.newGameButton.TabIndex = 10;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameBtn_Click);
            // 
            // ResultLable
            // 
            this.ResultLable.AutoSize = true;
            this.ResultLable.Location = new System.Drawing.Point(361, 361);
            this.ResultLable.Name = "ResultLable";
            this.ResultLable.Size = new System.Drawing.Size(48, 17);
            this.ResultLable.TabIndex = 11;
            this.ResultLable.Text = "Result";
            this.ResultLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResultLable.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(144, 22);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown_SelectBig);
            // 
            // Numbers_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ResultLable);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.selectedNumber6);
            this.Controls.Add(this.selectedNumber5);
            this.Controls.Add(this.selectedNumber4);
            this.Controls.Add(this.selectedNumber3);
            this.Controls.Add(this.selectedNumber2);
            this.Controls.Add(this.selectedNumber1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSolution);
            this.Name = "Numbers_Game";
            this.Text = "Numbers Game";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectedNumber1;
        private System.Windows.Forms.TextBox selectedNumber2;
        private System.Windows.Forms.TextBox selectedNumber4;
        private System.Windows.Forms.TextBox selectedNumber3;
        private System.Windows.Forms.TextBox selectedNumber6;
        private System.Windows.Forms.TextBox selectedNumber5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label ResultLable;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }    
}


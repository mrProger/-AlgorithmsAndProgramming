namespace Хребтов_Илья__практические
{
    partial class Form1
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
            this.FirstDegreeButton = new System.Windows.Forms.Button();
            this.SecondDegreeButton = new System.Windows.Forms.Button();
            this.ThirdDegreeButton = new System.Windows.Forms.Button();
            this.FourthDegreeButton = new System.Windows.Forms.Button();
            this.FifthDegreeButton = new System.Windows.Forms.Button();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.FirstDegreeOutput = new System.Windows.Forms.TextBox();
            this.SecondDegreeOutput = new System.Windows.Forms.TextBox();
            this.ThirdDegreeOutput = new System.Windows.Forms.TextBox();
            this.FourthDegreeOutput = new System.Windows.Forms.TextBox();
            this.FifthDegreeOutput = new System.Windows.Forms.TextBox();
            this.NextFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstDegreeButton
            // 
            this.FirstDegreeButton.Location = new System.Drawing.Point(12, 12);
            this.FirstDegreeButton.Name = "FirstDegreeButton";
            this.FirstDegreeButton.Size = new System.Drawing.Size(75, 23);
            this.FirstDegreeButton.TabIndex = 0;
            this.FirstDegreeButton.Text = "1-ая";
            this.FirstDegreeButton.UseVisualStyleBackColor = true;
            this.FirstDegreeButton.Click += new System.EventHandler(this.FirstDegreeButton_Click);
            // 
            // SecondDegreeButton
            // 
            this.SecondDegreeButton.Location = new System.Drawing.Point(12, 41);
            this.SecondDegreeButton.Name = "SecondDegreeButton";
            this.SecondDegreeButton.Size = new System.Drawing.Size(75, 23);
            this.SecondDegreeButton.TabIndex = 1;
            this.SecondDegreeButton.Text = "2-ая";
            this.SecondDegreeButton.UseVisualStyleBackColor = true;
            this.SecondDegreeButton.Click += new System.EventHandler(this.SecondDegreeButton_Click);
            // 
            // ThirdDegreeButton
            // 
            this.ThirdDegreeButton.Location = new System.Drawing.Point(12, 70);
            this.ThirdDegreeButton.Name = "ThirdDegreeButton";
            this.ThirdDegreeButton.Size = new System.Drawing.Size(75, 23);
            this.ThirdDegreeButton.TabIndex = 2;
            this.ThirdDegreeButton.Text = "3-я";
            this.ThirdDegreeButton.UseVisualStyleBackColor = true;
            this.ThirdDegreeButton.Click += new System.EventHandler(this.ThirdDegreeButton_Click);
            // 
            // FourthDegreeButton
            // 
            this.FourthDegreeButton.Location = new System.Drawing.Point(12, 99);
            this.FourthDegreeButton.Name = "FourthDegreeButton";
            this.FourthDegreeButton.Size = new System.Drawing.Size(75, 23);
            this.FourthDegreeButton.TabIndex = 3;
            this.FourthDegreeButton.Text = "4-ая";
            this.FourthDegreeButton.UseVisualStyleBackColor = true;
            this.FourthDegreeButton.Click += new System.EventHandler(this.FourthDegreeButton_Click);
            // 
            // FifthDegreeButton
            // 
            this.FifthDegreeButton.Location = new System.Drawing.Point(12, 128);
            this.FifthDegreeButton.Name = "FifthDegreeButton";
            this.FifthDegreeButton.Size = new System.Drawing.Size(75, 23);
            this.FifthDegreeButton.TabIndex = 4;
            this.FifthDegreeButton.Text = "5-ая";
            this.FifthDegreeButton.UseVisualStyleBackColor = true;
            this.FifthDegreeButton.Click += new System.EventHandler(this.FifthDegreeButton_Click);
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(12, 168);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(75, 23);
            this.ClearAllButton.TabIndex = 5;
            this.ClearAllButton.Text = "Отчистить";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // FirstDegreeOutput
            // 
            this.FirstDegreeOutput.Location = new System.Drawing.Point(93, 14);
            this.FirstDegreeOutput.Name = "FirstDegreeOutput";
            this.FirstDegreeOutput.ReadOnly = true;
            this.FirstDegreeOutput.Size = new System.Drawing.Size(175, 20);
            this.FirstDegreeOutput.TabIndex = 6;
            // 
            // SecondDegreeOutput
            // 
            this.SecondDegreeOutput.Location = new System.Drawing.Point(93, 41);
            this.SecondDegreeOutput.Name = "SecondDegreeOutput";
            this.SecondDegreeOutput.ReadOnly = true;
            this.SecondDegreeOutput.Size = new System.Drawing.Size(175, 20);
            this.SecondDegreeOutput.TabIndex = 7;
            // 
            // ThirdDegreeOutput
            // 
            this.ThirdDegreeOutput.Location = new System.Drawing.Point(93, 72);
            this.ThirdDegreeOutput.Name = "ThirdDegreeOutput";
            this.ThirdDegreeOutput.ReadOnly = true;
            this.ThirdDegreeOutput.Size = new System.Drawing.Size(175, 20);
            this.ThirdDegreeOutput.TabIndex = 8;
            // 
            // FourthDegreeOutput
            // 
            this.FourthDegreeOutput.Location = new System.Drawing.Point(93, 101);
            this.FourthDegreeOutput.Name = "FourthDegreeOutput";
            this.FourthDegreeOutput.ReadOnly = true;
            this.FourthDegreeOutput.Size = new System.Drawing.Size(175, 20);
            this.FourthDegreeOutput.TabIndex = 9;
            // 
            // FifthDegreeOutput
            // 
            this.FifthDegreeOutput.Location = new System.Drawing.Point(93, 130);
            this.FifthDegreeOutput.Name = "FifthDegreeOutput";
            this.FifthDegreeOutput.ReadOnly = true;
            this.FifthDegreeOutput.Size = new System.Drawing.Size(175, 20);
            this.FifthDegreeOutput.TabIndex = 10;
            // 
            // NextFormButton
            // 
            this.NextFormButton.Location = new System.Drawing.Point(193, 244);
            this.NextFormButton.Name = "NextFormButton";
            this.NextFormButton.Size = new System.Drawing.Size(75, 23);
            this.NextFormButton.TabIndex = 11;
            this.NextFormButton.Text = "Далее";
            this.NextFormButton.UseVisualStyleBackColor = true;
            this.NextFormButton.Click += new System.EventHandler(this.NextFormButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 279);
            this.Controls.Add(this.NextFormButton);
            this.Controls.Add(this.FifthDegreeOutput);
            this.Controls.Add(this.FourthDegreeOutput);
            this.Controls.Add(this.ThirdDegreeOutput);
            this.Controls.Add(this.SecondDegreeOutput);
            this.Controls.Add(this.FirstDegreeOutput);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.FifthDegreeButton);
            this.Controls.Add(this.FourthDegreeButton);
            this.Controls.Add(this.ThirdDegreeButton);
            this.Controls.Add(this.SecondDegreeButton);
            this.Controls.Add(this.FirstDegreeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Степени числа 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FirstDegreeButton;
        private System.Windows.Forms.Button SecondDegreeButton;
        private System.Windows.Forms.Button ThirdDegreeButton;
        private System.Windows.Forms.Button FourthDegreeButton;
        private System.Windows.Forms.Button FifthDegreeButton;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.TextBox FirstDegreeOutput;
        private System.Windows.Forms.TextBox SecondDegreeOutput;
        private System.Windows.Forms.TextBox ThirdDegreeOutput;
        private System.Windows.Forms.TextBox FourthDegreeOutput;
        private System.Windows.Forms.TextBox FifthDegreeOutput;
        private System.Windows.Forms.Button NextFormButton;
    }
}


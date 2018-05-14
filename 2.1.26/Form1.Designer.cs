namespace _2._1._26
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
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.Positive = new System.Windows.Forms.Button();
            this.Negative = new System.Windows.Forms.Button();
            this.Even = new System.Windows.Forms.Button();
            this.Odd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFile";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "ОТКРЫТЬ ФАЙЛ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Positive
            // 
            this.Positive.Location = new System.Drawing.Point(465, 24);
            this.Positive.Name = "Positive";
            this.Positive.Size = new System.Drawing.Size(292, 38);
            this.Positive.TabIndex = 1;
            this.Positive.Text = "УДАЛИТЬ ПОЛОЖИТЕЛЬНЫЕ";
            this.Positive.UseVisualStyleBackColor = true;
            this.Positive.Click += new System.EventHandler(this.Positive_Click);
            // 
            // Negative
            // 
            this.Negative.Location = new System.Drawing.Point(465, 93);
            this.Negative.Name = "Negative";
            this.Negative.Size = new System.Drawing.Size(292, 37);
            this.Negative.TabIndex = 2;
            this.Negative.Text = "УДАЛИТЬ ОТРИЦАТЕЛЬНЫ";
            this.Negative.UseVisualStyleBackColor = true;
            this.Negative.Click += new System.EventHandler(this.Negative_Click);
            // 
            // Even
            // 
            this.Even.Location = new System.Drawing.Point(465, 158);
            this.Even.Name = "Even";
            this.Even.Size = new System.Drawing.Size(292, 35);
            this.Even.TabIndex = 3;
            this.Even.Text = "УДАЛИТЬ ЧЕТНЫЕ";
            this.Even.UseVisualStyleBackColor = true;
            this.Even.Click += new System.EventHandler(this.Even_Click);
            // 
            // Odd
            // 
            this.Odd.Location = new System.Drawing.Point(465, 220);
            this.Odd.Name = "Odd";
            this.Odd.Size = new System.Drawing.Size(292, 38);
            this.Odd.TabIndex = 4;
            this.Odd.Text = "УДАЛИТЬ НЕЧЕТНЫЕ";
            this.Odd.UseVisualStyleBackColor = true;
            this.Odd.Click += new System.EventHandler(this.Odd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Odd);
            this.Controls.Add(this.Even);
            this.Controls.Add(this.Negative);
            this.Controls.Add(this.Positive);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Positive;
        private System.Windows.Forms.Button Negative;
        private System.Windows.Forms.Button Even;
        private System.Windows.Forms.Button Odd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


namespace Game_Task
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.usedDigitsTextLabel = new System.Windows.Forms.Label();
            this.usedDigitsLabel = new System.Windows.Forms.Label();
            this.remainingAttemptsLabel = new System.Windows.Forms.Label();
            this.countOfRemainingAttemptsLabel = new System.Windows.Forms.Label();
            this.tipLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(55, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputButton
            // 
            this.inputButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputButton.Location = new System.Drawing.Point(55, 95);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(160, 45);
            this.inputButton.TabIndex = 1;
            this.inputButton.Text = "Мне повезёт";
            this.inputButton.UseVisualStyleBackColor = false;
            this.inputButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // usedDigitsTextLabel
            // 
            this.usedDigitsTextLabel.AutoSize = true;
            this.usedDigitsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usedDigitsTextLabel.Location = new System.Drawing.Point(12, 181);
            this.usedDigitsTextLabel.Name = "usedDigitsTextLabel";
            this.usedDigitsTextLabel.Size = new System.Drawing.Size(241, 25);
            this.usedDigitsTextLabel.TabIndex = 2;
            this.usedDigitsTextLabel.Text = "Использованные цифры";
            // 
            // usedDigitsLabel
            // 
            this.usedDigitsLabel.AutoSize = true;
            this.usedDigitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usedDigitsLabel.Location = new System.Drawing.Point(95, 220);
            this.usedDigitsLabel.Name = "usedDigitsLabel";
            this.usedDigitsLabel.Size = new System.Drawing.Size(0, 25);
            this.usedDigitsLabel.TabIndex = 3;
            this.usedDigitsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // remainingAttemptsLabel
            // 
            this.remainingAttemptsLabel.AutoSize = true;
            this.remainingAttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.remainingAttemptsLabel.ForeColor = System.Drawing.Color.Crimson;
            this.remainingAttemptsLabel.Location = new System.Drawing.Point(41, 265);
            this.remainingAttemptsLabel.Name = "remainingAttemptsLabel";
            this.remainingAttemptsLabel.Size = new System.Drawing.Size(193, 25);
            this.remainingAttemptsLabel.TabIndex = 4;
            this.remainingAttemptsLabel.Text = "Осталось попыток:";
            // 
            // countOfRemainingAttemptsLabel
            // 
            this.countOfRemainingAttemptsLabel.AutoSize = true;
            this.countOfRemainingAttemptsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOfRemainingAttemptsLabel.Location = new System.Drawing.Point(112, 305);
            this.countOfRemainingAttemptsLabel.Name = "countOfRemainingAttemptsLabel";
            this.countOfRemainingAttemptsLabel.Size = new System.Drawing.Size(46, 51);
            this.countOfRemainingAttemptsLabel.TabIndex = 5;
            this.countOfRemainingAttemptsLabel.Text = "3";
            this.countOfRemainingAttemptsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tipLabel
            // 
            this.tipLabel.AutoSize = true;
            this.tipLabel.Location = new System.Drawing.Point(43, 151);
            this.tipLabel.Name = "tipLabel";
            this.tipLabel.Size = new System.Drawing.Size(0, 17);
            this.tipLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 370);
            this.Controls.Add(this.tipLabel);
            this.Controls.Add(this.countOfRemainingAttemptsLabel);
            this.Controls.Add(this.remainingAttemptsLabel);
            this.Controls.Add(this.usedDigitsLabel);
            this.Controls.Add(this.usedDigitsTextLabel);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SimpleGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.Label usedDigitsTextLabel;
        private System.Windows.Forms.Label usedDigitsLabel;
        private System.Windows.Forms.Label remainingAttemptsLabel;
        private System.Windows.Forms.Label countOfRemainingAttemptsLabel;
        private System.Windows.Forms.Label tipLabel;
    }
}


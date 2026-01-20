namespace TextForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.CheckButton = new System.Windows.Forms.Button();
            this.OutputTimer = new System.Windows.Forms.DateTimePicker();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.StatisticTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.NumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckButton.Location = new System.Drawing.Point(345, 244);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(148, 32);
            this.CheckButton.TabIndex = 0;
            this.CheckButton.Text = "Проверить";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // OutputTimer
            // 
            this.OutputTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTimer.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.OutputTimer.Location = new System.Drawing.Point(393, 168);
            this.OutputTimer.Name = "OutputTimer";
            this.OutputTimer.Size = new System.Drawing.Size(74, 32);
            this.OutputTimer.TabIndex = 1;
            this.OutputTimer.Value = new System.DateTime(2026, 1, 20, 5, 0, 0, 0);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLabel.Location = new System.Drawing.Point(179, 168);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(208, 26);
            this.TimerLabel.TabIndex = 2;
            this.TimerLabel.Text = "Времени осталось:";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextLabel.Location = new System.Drawing.Point(98, 206);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(289, 26);
            this.TextLabel.TabIndex = 3;
            this.TextLabel.Text = "Введите число от 1 до 100:";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(393, 206);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 32);
            this.InputTextBox.TabIndex = 4;
            // 
            // StatisticTextBox
            // 
            this.StatisticTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatisticTextBox.Location = new System.Drawing.Point(0, 354);
            this.StatisticTextBox.Name = "StatisticTextBox";
            this.StatisticTextBox.Size = new System.Drawing.Size(800, 96);
            this.StatisticTextBox.TabIndex = 5;
            this.StatisticTextBox.Text = "";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputLabel.Location = new System.Drawing.Point(205, 248);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(125, 26);
            this.OutputLabel.TabIndex = 6;
            this.OutputLabel.Text = "Правильно";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberLabel.Location = new System.Drawing.Point(785, 9);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(7, 7);
            this.NumberLabel.TabIndex = 7;
            this.NumberLabel.Text = "1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.StatisticTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.OutputTimer);
            this.Controls.Add(this.CheckButton);
            this.MaximumSize = new System.Drawing.Size(816, 900);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.DateTimePicker OutputTimer;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.RichTextBox StatisticTextBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label NumberLabel;
    }
}


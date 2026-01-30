namespace LR3
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
            this.MedicineGroupListBox = new System.Windows.Forms.ListBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MedicineComboBox = new System.Windows.Forms.ComboBox();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.MainTextBox = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.TextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MedicineGroupListBox
            // 
            this.MedicineGroupListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MedicineGroupListBox.FormattingEnabled = true;
            this.MedicineGroupListBox.Location = new System.Drawing.Point(0, 0);
            this.MedicineGroupListBox.Name = "MedicineGroupListBox";
            this.MedicineGroupListBox.Size = new System.Drawing.Size(120, 450);
            this.MedicineGroupListBox.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TextPanel);
            this.MainPanel.Controls.Add(this.MainPictureBox);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(120, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(680, 450);
            this.MainPanel.TabIndex = 2;
            // 
            // MedicineComboBox
            // 
            this.MedicineComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MedicineComboBox.FormattingEnabled = true;
            this.MedicineComboBox.Location = new System.Drawing.Point(0, 0);
            this.MedicineComboBox.Name = "MedicineComboBox";
            this.MedicineComboBox.Size = new System.Drawing.Size(343, 21);
            this.MedicineComboBox.TabIndex = 0;
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(680, 450);
            this.MainPictureBox.TabIndex = 1;
            this.MainPictureBox.TabStop = false;
            // 
            // TextPanel
            // 
            this.TextPanel.Controls.Add(this.MainTextBox);
            this.TextPanel.Controls.Add(this.MedicineComboBox);
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TextPanel.Location = new System.Drawing.Point(0, 0);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(343, 450);
            this.TextPanel.TabIndex = 2;
            // 
            // MainTextBox
            // 
            this.MainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTextBox.Location = new System.Drawing.Point(0, 21);
            this.MainTextBox.Multiline = true;
            this.MainTextBox.Name = "MainTextBox";
            this.MainTextBox.Size = new System.Drawing.Size(343, 429);
            this.MainTextBox.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.MedicineGroupListBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.TextPanel.ResumeLayout(false);
            this.TextPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MedicineGroupListBox;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.ComboBox MedicineComboBox;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.TextBox MainTextBox;
    }
}


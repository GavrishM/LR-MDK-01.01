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
            this.components = new System.ComponentModel.Container();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ListBoxPanel = new System.Windows.Forms.Panel();
            this.ImageBoxPanel = new System.Windows.Forms.Panel();
            this.TextBoxPanel = new System.Windows.Forms.Panel();
            this.GroupListBox = new System.Windows.Forms.ListBox();
            this.MedicineComboBox = new System.Windows.Forms.ComboBox();
            this.OrderButton = new System.Windows.Forms.Button();
            this.MedicineTextBox = new System.Windows.Forms.TextBox();
            this.OrderTextBox = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.ListBoxPanel.SuspendLayout();
            this.ImageBoxPanel.SuspendLayout();
            this.TextBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.TextBoxPanel);
            this.MainPanel.Controls.Add(this.ImageBoxPanel);
            this.MainPanel.Controls.Add(this.ListBoxPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // ListBoxPanel
            // 
            this.ListBoxPanel.Controls.Add(this.GroupListBox);
            this.ListBoxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.ListBoxPanel.Name = "ListBoxPanel";
            this.ListBoxPanel.Size = new System.Drawing.Size(166, 450);
            this.ListBoxPanel.TabIndex = 0;
            // 
            // ImageBoxPanel
            // 
            this.ImageBoxPanel.Controls.Add(this.MainPictureBox);
            this.ImageBoxPanel.Controls.Add(this.OrderTextBox);
            this.ImageBoxPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ImageBoxPanel.Location = new System.Drawing.Point(365, 0);
            this.ImageBoxPanel.Name = "ImageBoxPanel";
            this.ImageBoxPanel.Size = new System.Drawing.Size(435, 450);
            this.ImageBoxPanel.TabIndex = 1;
            // 
            // TextBoxPanel
            // 
            this.TextBoxPanel.Controls.Add(this.MedicineTextBox);
            this.TextBoxPanel.Controls.Add(this.OrderButton);
            this.TextBoxPanel.Controls.Add(this.MedicineComboBox);
            this.TextBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxPanel.Location = new System.Drawing.Point(166, 0);
            this.TextBoxPanel.Name = "TextBoxPanel";
            this.TextBoxPanel.Size = new System.Drawing.Size(199, 450);
            this.TextBoxPanel.TabIndex = 2;
            // 
            // GroupListBox
            // 
            this.GroupListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupListBox.FormattingEnabled = true;
            this.GroupListBox.Location = new System.Drawing.Point(0, 0);
            this.GroupListBox.Name = "GroupListBox";
            this.GroupListBox.Size = new System.Drawing.Size(166, 450);
            this.GroupListBox.TabIndex = 0;
            // 
            // MedicineComboBox
            // 
            this.MedicineComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MedicineComboBox.FormattingEnabled = true;
            this.MedicineComboBox.Location = new System.Drawing.Point(0, 0);
            this.MedicineComboBox.Name = "MedicineComboBox";
            this.MedicineComboBox.Size = new System.Drawing.Size(199, 21);
            this.MedicineComboBox.TabIndex = 0;
            // 
            // OrderButton
            // 
            this.OrderButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderButton.Location = new System.Drawing.Point(0, 427);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(199, 23);
            this.OrderButton.TabIndex = 1;
            this.OrderButton.Text = "Заказать";
            this.OrderButton.UseVisualStyleBackColor = true;
            // 
            // MedicineTextBox
            // 
            this.MedicineTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MedicineTextBox.Location = new System.Drawing.Point(0, 21);
            this.MedicineTextBox.Multiline = true;
            this.MedicineTextBox.Name = "MedicineTextBox";
            this.MedicineTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MedicineTextBox.Size = new System.Drawing.Size(199, 406);
            this.MedicineTextBox.TabIndex = 2;
            // 
            // OrderTextBox
            // 
            this.OrderTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OrderTextBox.Location = new System.Drawing.Point(0, 341);
            this.OrderTextBox.Multiline = true;
            this.OrderTextBox.Name = "OrderTextBox";
            this.OrderTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OrderTextBox.Size = new System.Drawing.Size(435, 109);
            this.OrderTextBox.TabIndex = 0;
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(435, 341);
            this.MainPictureBox.TabIndex = 1;
            this.MainPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "MainForm";
            this.Text = "Лекарства";
            this.MainPanel.ResumeLayout(false);
            this.ListBoxPanel.ResumeLayout(false);
            this.ImageBoxPanel.ResumeLayout(false);
            this.ImageBoxPanel.PerformLayout();
            this.TextBoxPanel.ResumeLayout(false);
            this.TextBoxPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ListBoxPanel;
        private System.Windows.Forms.Panel TextBoxPanel;
        private System.Windows.Forms.Panel ImageBoxPanel;
        private System.Windows.Forms.Button OrderButton;
        private System.Windows.Forms.ComboBox MedicineComboBox;
        private System.Windows.Forms.ListBox GroupListBox;
        private System.Windows.Forms.TextBox MedicineTextBox;
        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.TextBox OrderTextBox;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}


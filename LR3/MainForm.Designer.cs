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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ListBoxPanel = new System.Windows.Forms.Panel();
            this.ImageBoxPanel = new System.Windows.Forms.Panel();
            this.TextBoxPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
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
            this.ListBoxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.ListBoxPanel.Name = "ListBoxPanel";
            this.ListBoxPanel.Size = new System.Drawing.Size(166, 450);
            this.ListBoxPanel.TabIndex = 0;
            // 
            // ImageBoxPanel
            // 
            this.ImageBoxPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ImageBoxPanel.Location = new System.Drawing.Point(365, 0);
            this.ImageBoxPanel.Name = "ImageBoxPanel";
            this.ImageBoxPanel.Size = new System.Drawing.Size(435, 450);
            this.ImageBoxPanel.TabIndex = 1;
            // 
            // TextBoxPanel
            // 
            this.TextBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxPanel.Location = new System.Drawing.Point(166, 0);
            this.TextBoxPanel.Name = "TextBoxPanel";
            this.TextBoxPanel.Size = new System.Drawing.Size(199, 450);
            this.TextBoxPanel.TabIndex = 2;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ListBoxPanel;
        private System.Windows.Forms.Panel TextBoxPanel;
        private System.Windows.Forms.Panel ImageBoxPanel;
    }
}


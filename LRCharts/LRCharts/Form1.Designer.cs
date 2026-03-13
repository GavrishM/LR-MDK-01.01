namespace LRCharts
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.CartesianListBox = new System.Windows.Forms.ListBox();
            this.CartesianPanel = new System.Windows.Forms.Panel();
            this.Pie = new LiveCharts.WinForms.PieChart();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 450);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cartesianChart1);
            this.tabPage1.Controls.Add(this.CartesianPanel);
            this.tabPage1.Controls.Add(this.CartesianListBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "График";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Pie);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Круговая диаграмма";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(123, 3);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(666, 418);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // CartesianListBox
            // 
            this.CartesianListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.CartesianListBox.FormattingEnabled = true;
            this.CartesianListBox.Location = new System.Drawing.Point(3, 3);
            this.CartesianListBox.Name = "CartesianListBox";
            this.CartesianListBox.Size = new System.Drawing.Size(120, 418);
            this.CartesianListBox.TabIndex = 1;
            // 
            // CartesianPanel
            // 
            this.CartesianPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartesianPanel.Location = new System.Drawing.Point(123, 3);
            this.CartesianPanel.Name = "CartesianPanel";
            this.CartesianPanel.Size = new System.Drawing.Size(666, 418);
            this.CartesianPanel.TabIndex = 2;
            // 
            // Pie
            // 
            this.Pie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pie.Location = new System.Drawing.Point(3, 3);
            this.Pie.Name = "Pie";
            this.Pie.Size = new System.Drawing.Size(786, 418);
            this.Pie.TabIndex = 0;
            this.Pie.Text = "pieChart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "Напитки";
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.ListBox CartesianListBox;
        private System.Windows.Forms.Panel CartesianPanel;
        private LiveCharts.WinForms.PieChart Pie;
    }
}


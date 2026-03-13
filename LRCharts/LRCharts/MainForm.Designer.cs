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
            this.CartesianPanel = new System.Windows.Forms.Panel();
            this.cartesian = new LRCharts.Views.SalesCartesianChart();
            this.ItemsList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pie = new LRCharts.Views.SalesPieChart();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CartesianPanel.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.CartesianPanel);
            this.tabPage1.Controls.Add(this.ItemsList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "График";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CartesianPanel
            // 
            this.CartesianPanel.Controls.Add(this.cartesian);
            this.CartesianPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartesianPanel.Location = new System.Drawing.Point(123, 3);
            this.CartesianPanel.Name = "CartesianPanel";
            this.CartesianPanel.Size = new System.Drawing.Size(666, 418);
            this.CartesianPanel.TabIndex = 2;
            // 
            // cartesian
            // 
            this.cartesian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesian.Location = new System.Drawing.Point(0, 0);
            this.cartesian.Name = "cartesian";
            this.cartesian.Size = new System.Drawing.Size(666, 418);
            this.cartesian.TabIndex = 0;
            // 
            // ItemsList
            // 
            this.ItemsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.Location = new System.Drawing.Point(3, 3);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(120, 418);
            this.ItemsList.TabIndex = 1;
            this.ItemsList.SelectedIndexChanged += new System.EventHandler(this.ItemsList_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pie);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Круговая диаграмма";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pie
            // 
            this.pie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pie.Location = new System.Drawing.Point(3, 3);
            this.pie.Name = "pie";
            this.pie.Size = new System.Drawing.Size(786, 418);
            this.pie.TabIndex = 0;
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
            this.CartesianPanel.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        //private LRCharts.Views.SalesCartesianChart cartesian;
        private System.Windows.Forms.ListBox ItemsList;
        private System.Windows.Forms.Panel CartesianPanel;
        private LRCharts.Views.SalesPieChart pie;
        private Views.SalesCartesianChart cartesian;
    }
}


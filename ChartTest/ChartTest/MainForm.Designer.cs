using ChartTest.Views;

namespace ChartTest
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ItemsList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.angular = new LiveCharts.WinForms.AngularGauge();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.solid = new LiveCharts.WinForms.SolidGauge();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pie = new LiveCharts.WinForms.PieChart();
            this.cartesian = new ChartTest.Views.SalesCartesianChart();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.FillPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.SalesCartesian = new ChartTest.Views.SalesCartesianChart();
            this.SalesListBox = new System.Windows.Forms.ListBox();
            this.SalesAngular = new LiveCharts.WinForms.AngularGauge();
            this.SalesSolid = new LiveCharts.WinForms.SolidGauge();
            this.SalesPie = new ChartTest.Views.SalesPieChart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.FillPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cartesian);
            this.tabPage1.Controls.Add(this.ItemsList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CartesianChart";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Controls.Add(this.angular);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AngularChart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // angular
            // 
            this.angular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.angular.Location = new System.Drawing.Point(3, 3);
            this.angular.Name = "angular";
            this.angular.Size = new System.Drawing.Size(786, 418);
            this.angular.TabIndex = 0;
            this.angular.Text = "angular";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.solid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SolidChart";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // solid
            // 
            this.solid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solid.Location = new System.Drawing.Point(0, 0);
            this.solid.Name = "solid";
            this.solid.Size = new System.Drawing.Size(792, 424);
            this.solid.TabIndex = 0;
            this.solid.Text = "solid";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pie);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "PieChart";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pie
            // 
            this.pie.Location = new System.Drawing.Point(61, 43);
            this.pie.Name = "pie";
            this.pie.Size = new System.Drawing.Size(653, 325);
            this.pie.TabIndex = 0;
            this.pie.Text = "pieChart1";
            // 
            // cartesian
            // 
            this.cartesian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesian.Location = new System.Drawing.Point(123, 3);
            this.cartesian.Name = "cartesian";
            this.cartesian.Size = new System.Drawing.Size(666, 418);
            this.cartesian.TabIndex = 0;
            this.cartesian.Text = "cartesian";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.FillPanel);
            this.tabPage5.Controls.Add(this.RightPanel);
            this.tabPage5.Controls.Add(this.LeftPanel);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 424);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Графики";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.SalesListBox);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(140, 424);
            this.LeftPanel.TabIndex = 0;
            // 
            // RightPanel
            // 
            this.RightPanel.Controls.Add(this.CenterPanel);
            this.RightPanel.Controls.Add(this.BottomPanel);
            this.RightPanel.Controls.Add(this.TopPanel);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(592, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(200, 424);
            this.RightPanel.TabIndex = 1;
            // 
            // FillPanel
            // 
            this.FillPanel.Controls.Add(this.SalesCartesian);
            this.FillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FillPanel.Location = new System.Drawing.Point(140, 0);
            this.FillPanel.Name = "FillPanel";
            this.FillPanel.Size = new System.Drawing.Size(452, 424);
            this.FillPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.SalesPie);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(200, 100);
            this.TopPanel.TabIndex = 0;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.panel1);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 324);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(200, 100);
            this.BottomPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SalesSolid);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.SalesAngular);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(0, 100);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(200, 224);
            this.CenterPanel.TabIndex = 2;
            // 
            // SalesCartesian
            // 
            this.SalesCartesian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesCartesian.Location = new System.Drawing.Point(0, 0);
            this.SalesCartesian.Name = "SalesCartesian";
            this.SalesCartesian.Size = new System.Drawing.Size(452, 424);
            this.SalesCartesian.TabIndex = 0;
            this.SalesCartesian.Text = "salesCartesianChart1";
            // 
            // SalesListBox
            // 
            this.SalesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesListBox.FormattingEnabled = true;
            this.SalesListBox.Location = new System.Drawing.Point(0, 0);
            this.SalesListBox.Name = "SalesListBox";
            this.SalesListBox.Size = new System.Drawing.Size(140, 424);
            this.SalesListBox.TabIndex = 0;
            // 
            // SalesAngular
            // 
            this.SalesAngular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesAngular.Location = new System.Drawing.Point(0, 0);
            this.SalesAngular.Name = "SalesAngular";
            this.SalesAngular.Size = new System.Drawing.Size(200, 224);
            this.SalesAngular.TabIndex = 0;
            this.SalesAngular.Text = "angularGauge1";
            // 
            // SalesSolid
            // 
            this.SalesSolid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesSolid.Location = new System.Drawing.Point(0, 0);
            this.SalesSolid.Name = "SalesSolid";
            this.SalesSolid.Size = new System.Drawing.Size(200, 100);
            this.SalesSolid.TabIndex = 0;
            this.SalesSolid.Text = "solidGauge1";
            // 
            // SalesPie
            // 
            this.SalesPie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesPie.Location = new System.Drawing.Point(0, 0);
            this.SalesPie.Name = "SalesPie";
            this.SalesPie.Size = new System.Drawing.Size(200, 100);
            this.SalesPie.TabIndex = 0;
            this.SalesPie.Text = "salesPieChart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "LiveCharts-диаграммы";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            this.FillPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private SalesCartesianChart cartesian;
        private LiveCharts.WinForms.AngularGauge angular;
        private LiveCharts.WinForms.SolidGauge solid;
        private System.Windows.Forms.ListBox ItemsList;
        private System.Windows.Forms.TabPage tabPage4;
        private LiveCharts.WinForms.PieChart pie;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel FillPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private SalesCartesianChart SalesCartesian;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.ListBox SalesListBox;
        private LiveCharts.WinForms.AngularGauge SalesAngular;
        private LiveCharts.WinForms.SolidGauge SalesSolid;
        private SalesPieChart SalesPie;
    }
}


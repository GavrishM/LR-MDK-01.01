using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17012026
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            /*
            {
             public partial class MainForm : Form
        {
            public MainForm()
            {
                InitializeComponent();
                List<string> objectList = new List<string>();
                objectList.Add("Пупкин");
                MainListBox.DataSource = objectList;
            }

            private void MainListBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                MessageBox.Show(MainListBox.SelectedIndex.ToString() + " " + MainListBox.SelectedItem);

            }

            private void LoadButton_Click(object sender, EventArgs e)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.S
            }

            private void MainForm_Load(object sender, EventArgs e)
            {

            }
        }
    }
            */
            /*
            {
                    #region Код, автоматически созданный конструктором форм Windows

            /// <summary>
            /// Требуемый метод для поддержки конструктора — не изменяйте 
            /// содержимое этого метода с помощью редактора кода.
            /// </summary>
            private void InitializeComponent()
            {
            this.ListBoxPanel = new System.Windows.Forms.Panel();
            this.PictureBoxPanel = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MainListBox = new System.Windows.Forms.ListBox();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.ListBoxPanel.SuspendLayout();
            this.PictureBoxPanel.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxPanel
            // 
            this.ListBoxPanel.Controls.Add(this.MainListBox);
            this.ListBoxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.ListBoxPanel.Name = "ListBoxPanel";
            this.ListBoxPanel.Size = new System.Drawing.Size(200, 450);
            this.ListBoxPanel.TabIndex = 0;
            // 
            // PictureBoxPanel
            // 
            this.PictureBoxPanel.Controls.Add(this.MainPictureBox);
            this.PictureBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBoxPanel.Location = new System.Drawing.Point(200, 0);
            this.PictureBoxPanel.Name = "PictureBoxPanel";
            this.PictureBoxPanel.Size = new System.Drawing.Size(600, 450);
            this.PictureBoxPanel.TabIndex = 1;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Controls.Add(this.DeleteButton);
            this.ButtonPanel.Controls.Add(this.EditButton);
            this.ButtonPanel.Controls.Add(this.LoadButton);
            this.ButtonPanel.Controls.Add(this.SaveButton);
            this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonPanel.Location = new System.Drawing.Point(200, 350);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(600, 100);
            this.ButtonPanel.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.Location = new System.Drawing.Point(0, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(165, 100);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // LoadButton
            // 
            this.LoadButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.LoadButton.Location = new System.Drawing.Point(165, 0);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(151, 100);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.EditButton.Location = new System.Drawing.Point(432, 0);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(168, 100);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Редактировать";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(316, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(116, 100);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // MainListBox
            // 
            this.MainListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainListBox.FormattingEnabled = true;
            this.MainListBox.Location = new System.Drawing.Point(0, 0);
            this.MainListBox.Name = "MainListBox";
            this.MainListBox.Size = new System.Drawing.Size(200, 450);
            this.MainListBox.TabIndex = 0;
            this.MainListBox.SelectedIndexChanged += new System.EventHandler(this.MainListBox_SelectedIndexChanged);
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPictureBox.Location = new System.Drawing.Point(0, 0);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(600, 450);
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.PictureBoxPanel);
            this.Controls.Add(this.ListBoxPanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ListBoxPanel.ResumeLayout(false);
            this.PictureBoxPanel.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

                    private System.Windows.Forms.Panel ListBoxPanel;
                    private System.Windows.Forms.Panel PictureBoxPanel;
                    private System.Windows.Forms.ListBox MainListBox;
                    private System.Windows.Forms.PictureBox MainPictureBox;
                    private System.Windows.Forms.Panel ButtonPanel;
                    private System.Windows.Forms.Button DeleteButton;
                    private System.Windows.Forms.Button EditButton;
                    private System.Windows.Forms.Button LoadButton;
                    private System.Windows.Forms.Button SaveButton;
            }
            */
        }
    }
}

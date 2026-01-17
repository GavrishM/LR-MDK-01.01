using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _17012026
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            List<string> objectList = new List<string>();
            objectList.Add("Пупкин");
            MainListBox.Items.Add(objectList);
        }

        private void MainListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    MainListBox.Items.Add(filePath);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string message = "Точно хотите удалить?";
            var result = MessageBox.Show(message, "o", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes) 
            {
                MainListBox.Items.RemoveAt(MainListBox.SelectedIndex);
            }
        }
    }
}

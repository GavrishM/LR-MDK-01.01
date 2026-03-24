namespace TestBd
{
    partial class EditUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ELoginLabel = new System.Windows.Forms.Label();
            this.ELoginTextBox = new System.Windows.Forms.TextBox();
            this.ENameLabel = new System.Windows.Forms.Label();
            this.ENameTextBox = new System.Windows.Forms.TextBox();
            this.EPasswordLabel = new System.Windows.Forms.Label();
            this.EPasswordTextBox = new System.Windows.Forms.TextBox();
            this.ELastNameLabel = new System.Windows.Forms.Label();
            this.ELastNameTextBox = new System.Windows.Forms.TextBox();
            this.EAgeLabel = new System.Windows.Forms.Label();
            this.EAgeTextBox = new System.Windows.Forms.TextBox();
            this.EAddButton = new System.Windows.Forms.Button();
            this.ECancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ELoginLabel
            // 
            this.ELoginLabel.AutoSize = true;
            this.ELoginLabel.Location = new System.Drawing.Point(20, 15);
            this.ELoginLabel.Name = "ELoginLabel";
            this.ELoginLabel.Size = new System.Drawing.Size(38, 13);
            this.ELoginLabel.TabIndex = 0;
            this.ELoginLabel.Text = "Логин";
            // 
            // ELoginTextBox
            // 
            this.ELoginTextBox.Location = new System.Drawing.Point(92, 12);
            this.ELoginTextBox.Name = "ELoginTextBox";
            this.ELoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.ELoginTextBox.TabIndex = 1;
            // 
            // ENameLabel
            // 
            this.ENameLabel.AutoSize = true;
            this.ENameLabel.Location = new System.Drawing.Point(20, 41);
            this.ENameLabel.Name = "ENameLabel";
            this.ENameLabel.Size = new System.Drawing.Size(29, 13);
            this.ENameLabel.TabIndex = 2;
            this.ENameLabel.Text = "Имя";
            // 
            // ENameTextBox
            // 
            this.ENameTextBox.Location = new System.Drawing.Point(92, 38);
            this.ENameTextBox.Name = "ENameTextBox";
            this.ENameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ENameTextBox.TabIndex = 3;
            // 
            // EPasswordLabel
            // 
            this.EPasswordLabel.AutoSize = true;
            this.EPasswordLabel.Location = new System.Drawing.Point(20, 67);
            this.EPasswordLabel.Name = "EPasswordLabel";
            this.EPasswordLabel.Size = new System.Drawing.Size(45, 13);
            this.EPasswordLabel.TabIndex = 4;
            this.EPasswordLabel.Text = "Пароль";
            // 
            // EPasswordTextBox
            // 
            this.EPasswordTextBox.Location = new System.Drawing.Point(92, 64);
            this.EPasswordTextBox.Name = "EPasswordTextBox";
            this.EPasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.EPasswordTextBox.TabIndex = 5;
            // 
            // ELastNameLabel
            // 
            this.ELastNameLabel.AutoSize = true;
            this.ELastNameLabel.Location = new System.Drawing.Point(20, 93);
            this.ELastNameLabel.Name = "ELastNameLabel";
            this.ELastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.ELastNameLabel.TabIndex = 6;
            this.ELastNameLabel.Text = "Фамилия";
            // 
            // ELastNameTextBox
            // 
            this.ELastNameTextBox.Location = new System.Drawing.Point(92, 90);
            this.ELastNameTextBox.Name = "ELastNameTextBox";
            this.ELastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ELastNameTextBox.TabIndex = 7;
            // 
            // EAgeLabel
            // 
            this.EAgeLabel.AutoSize = true;
            this.EAgeLabel.Location = new System.Drawing.Point(20, 119);
            this.EAgeLabel.Name = "EAgeLabel";
            this.EAgeLabel.Size = new System.Drawing.Size(55, 13);
            this.EAgeLabel.TabIndex = 8;
            this.EAgeLabel.Text = "Возвраст";
            // 
            // EAgeTextBox
            // 
            this.EAgeTextBox.Location = new System.Drawing.Point(92, 116);
            this.EAgeTextBox.Name = "EAgeTextBox";
            this.EAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.EAgeTextBox.TabIndex = 9;
            // 
            // EAddButton
            // 
            this.EAddButton.Location = new System.Drawing.Point(108, 142);
            this.EAddButton.Name = "EAddButton";
            this.EAddButton.Size = new System.Drawing.Size(90, 26);
            this.EAddButton.TabIndex = 10;
            this.EAddButton.Text = "Добавить";
            this.EAddButton.UseVisualStyleBackColor = true;
            this.EAddButton.Click += new System.EventHandler(this.EAddButton_Click);
            // 
            // ECancelButton
            // 
            this.ECancelButton.Location = new System.Drawing.Point(12, 142);
            this.ECancelButton.Name = "ECancelButton";
            this.ECancelButton.Size = new System.Drawing.Size(90, 26);
            this.ECancelButton.TabIndex = 11;
            this.ECancelButton.Text = "Отменить";
            this.ECancelButton.UseVisualStyleBackColor = true;
            this.ECancelButton.Click += new System.EventHandler(this.ECancelButton_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 171);
            this.Controls.Add(this.ECancelButton);
            this.Controls.Add(this.EAddButton);
            this.Controls.Add(this.EAgeTextBox);
            this.Controls.Add(this.EAgeLabel);
            this.Controls.Add(this.ELastNameTextBox);
            this.Controls.Add(this.ELastNameLabel);
            this.Controls.Add(this.EPasswordTextBox);
            this.Controls.Add(this.EPasswordLabel);
            this.Controls.Add(this.ENameTextBox);
            this.Controls.Add(this.ENameLabel);
            this.Controls.Add(this.ELoginTextBox);
            this.Controls.Add(this.ELoginLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditUserForm";
            this.Text = "Редактировать пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ELoginLabel;
        private System.Windows.Forms.TextBox ELoginTextBox;
        private System.Windows.Forms.Label ENameLabel;
        private System.Windows.Forms.TextBox ENameTextBox;
        private System.Windows.Forms.Label EPasswordLabel;
        private System.Windows.Forms.TextBox EPasswordTextBox;
        private System.Windows.Forms.Label ELastNameLabel;
        private System.Windows.Forms.TextBox ELastNameTextBox;
        private System.Windows.Forms.Label EAgeLabel;
        private System.Windows.Forms.TextBox EAgeTextBox;
        private System.Windows.Forms.Button EAddButton;
        private System.Windows.Forms.Button ECancelButton;
    }
}
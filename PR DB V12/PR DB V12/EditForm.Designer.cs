namespace PR_DB_V12
{
    partial class EditForm
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
            this.ENameLabel = new System.Windows.Forms.Label();
            this.ENameTextBox = new System.Windows.Forms.TextBox();
            this.ETypeLabel = new System.Windows.Forms.Label();
            this.ETypeTextBox = new System.Windows.Forms.TextBox();
            this.EPriceLabel = new System.Windows.Forms.Label();
            this.EPriceTextBox = new System.Windows.Forms.TextBox();
            this.EDeliveryLabel = new System.Windows.Forms.Label();
            this.EDeliveryComboBox = new System.Windows.Forms.ComboBox();
            this.ECancelButton = new System.Windows.Forms.Button();
            this.EAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ENameLabel
            // 
            this.ENameLabel.AutoSize = true;
            this.ENameLabel.Location = new System.Drawing.Point(20, 15);
            this.ENameLabel.Name = "ENameLabel";
            this.ENameLabel.Size = new System.Drawing.Size(57, 13);
            this.ENameLabel.TabIndex = 0;
            this.ENameLabel.Text = "Название";
            // 
            // ENameTextBox
            // 
            this.ENameTextBox.Location = new System.Drawing.Point(92, 12);
            this.ENameTextBox.Name = "ENameTextBox";
            this.ENameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ENameTextBox.TabIndex = 1;
            // 
            // ETypeLabel
            // 
            this.ETypeLabel.AutoSize = true;
            this.ETypeLabel.Location = new System.Drawing.Point(20, 41);
            this.ETypeLabel.Name = "ETypeLabel";
            this.ETypeLabel.Size = new System.Drawing.Size(60, 13);
            this.ETypeLabel.TabIndex = 2;
            this.ETypeLabel.Text = "Категория";
            // 
            // ETypeTextBox
            // 
            this.ETypeTextBox.Location = new System.Drawing.Point(92, 38);
            this.ETypeTextBox.Name = "ETypeTextBox";
            this.ETypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.ETypeTextBox.TabIndex = 3;
            // 
            // EPriceLabel
            // 
            this.EPriceLabel.AutoSize = true;
            this.EPriceLabel.Location = new System.Drawing.Point(20, 67);
            this.EPriceLabel.Name = "EPriceLabel";
            this.EPriceLabel.Size = new System.Drawing.Size(33, 13);
            this.EPriceLabel.TabIndex = 4;
            this.EPriceLabel.Text = "Цена";
            // 
            // EPriceTextBox
            // 
            this.EPriceTextBox.Location = new System.Drawing.Point(92, 64);
            this.EPriceTextBox.Name = "EPriceTextBox";
            this.EPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.EPriceTextBox.TabIndex = 5;
            // 
            // EDeliveryLabel
            // 
            this.EDeliveryLabel.AutoSize = true;
            this.EDeliveryLabel.Location = new System.Drawing.Point(20, 93);
            this.EDeliveryLabel.Name = "EDeliveryLabel";
            this.EDeliveryLabel.Size = new System.Drawing.Size(57, 13);
            this.EDeliveryLabel.TabIndex = 6;
            this.EDeliveryLabel.Text = "Доставка";
            // 
            // EDeliveryComboBox
            // 
            this.EDeliveryComboBox.FormattingEnabled = true;
            this.EDeliveryComboBox.Items.AddRange(new object[] {
            "true",
            "false"});
            this.EDeliveryComboBox.Location = new System.Drawing.Point(92, 90);
            this.EDeliveryComboBox.Name = "EDeliveryComboBox";
            this.EDeliveryComboBox.Size = new System.Drawing.Size(100, 21);
            this.EDeliveryComboBox.TabIndex = 7;
            // 
            // ECancelButton
            // 
            this.ECancelButton.Location = new System.Drawing.Point(12, 142);
            this.ECancelButton.Name = "ECancelButton";
            this.ECancelButton.Size = new System.Drawing.Size(90, 26);
            this.ECancelButton.TabIndex = 8;
            this.ECancelButton.Text = "Отменить";
            this.ECancelButton.UseVisualStyleBackColor = true;
            this.ECancelButton.Click += new System.EventHandler(this.ECancelButton_Click);
            // 
            // EAddButton
            // 
            this.EAddButton.Location = new System.Drawing.Point(108, 142);
            this.EAddButton.Name = "EAddButton";
            this.EAddButton.Size = new System.Drawing.Size(90, 26);
            this.EAddButton.TabIndex = 9;
            this.EAddButton.Text = "Изменить";
            this.EAddButton.UseVisualStyleBackColor = true;
            this.EAddButton.Click += new System.EventHandler(this.EAddButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 171);
            this.Controls.Add(this.EAddButton);
            this.Controls.Add(this.ECancelButton);
            this.Controls.Add(this.EDeliveryComboBox);
            this.Controls.Add(this.EDeliveryLabel);
            this.Controls.Add(this.EPriceTextBox);
            this.Controls.Add(this.EPriceLabel);
            this.Controls.Add(this.ETypeTextBox);
            this.Controls.Add(this.ETypeLabel);
            this.Controls.Add(this.ENameTextBox);
            this.Controls.Add(this.ENameLabel);
            this.Name = "EditForm";
            this.Text = "Редактировать блюдо";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ENameLabel;
        private System.Windows.Forms.TextBox ENameTextBox;
        private System.Windows.Forms.Label ETypeLabel;
        private System.Windows.Forms.TextBox ETypeTextBox;
        private System.Windows.Forms.Label EPriceLabel;
        private System.Windows.Forms.TextBox EPriceTextBox;
        private System.Windows.Forms.Label EDeliveryLabel;
        private System.Windows.Forms.ComboBox EDeliveryComboBox;
        private System.Windows.Forms.Button ECancelButton;
        private System.Windows.Forms.Button EAddButton;
    }
}
namespace ImportCarsWinForm
{
    partial class ImportCarsMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ImportCarsFormTitleLabel = new Label();
            CarNumberLabel = new Label();
            carNumberTextBox = new TextBox();
            carModelTextBox = new TextBox();
            carModelLabel = new Label();
            carColorTextBox = new TextBox();
            carColorLabel = new Label();
            saveCarDetailsButton = new Button();
            carSearchButton = new Button();
            companyNameTextBox = new TextBox();
            companyNameLabel = new Label();
            companyNumberTextBox = new TextBox();
            companyNumberLabel = new Label();
            addNewCarButton = new Button();
            readOrderFromFileButton = new Button();
            SuspendLayout();
            // 
            // ImportCarsFormTitleLabel
            // 
            ImportCarsFormTitleLabel.AutoSize = true;
            ImportCarsFormTitleLabel.Font = new Font("Segoe UI", 20F);
            ImportCarsFormTitleLabel.Location = new Point(393, 30);
            ImportCarsFormTitleLabel.Margin = new Padding(7, 0, 7, 0);
            ImportCarsFormTitleLabel.Name = "ImportCarsFormTitleLabel";
            ImportCarsFormTitleLabel.Size = new Size(332, 54);
            ImportCarsFormTitleLabel.TabIndex = 0;
            ImportCarsFormTitleLabel.Text = "Import Cars Form";
            // 
            // CarNumberLabel
            // 
            CarNumberLabel.AutoSize = true;
            CarNumberLabel.Font = new Font("Segoe UI", 15F);
            CarNumberLabel.Location = new Point(12, 133);
            CarNumberLabel.Name = "CarNumberLabel";
            CarNumberLabel.Size = new Size(132, 41);
            CarNumberLabel.TabIndex = 1;
            CarNumberLabel.Text = "Car No. :";
            // 
            // carNumberTextBox
            // 
            carNumberTextBox.Font = new Font("Segoe UI", 15F);
            carNumberTextBox.Location = new Point(272, 133);
            carNumberTextBox.Name = "carNumberTextBox";
            carNumberTextBox.Size = new Size(300, 47);
            carNumberTextBox.TabIndex = 2;
            // 
            // carModelTextBox
            // 
            carModelTextBox.Font = new Font("Segoe UI", 15F);
            carModelTextBox.Location = new Point(272, 231);
            carModelTextBox.Name = "carModelTextBox";
            carModelTextBox.Size = new Size(300, 47);
            carModelTextBox.TabIndex = 4;
            // 
            // carModelLabel
            // 
            carModelLabel.AutoSize = true;
            carModelLabel.Font = new Font("Segoe UI", 15F);
            carModelLabel.Location = new Point(12, 231);
            carModelLabel.Name = "carModelLabel";
            carModelLabel.Size = new Size(171, 41);
            carModelLabel.TabIndex = 3;
            carModelLabel.Text = "Car Model: ";
            // 
            // carColorTextBox
            // 
            carColorTextBox.Font = new Font("Segoe UI", 15F);
            carColorTextBox.Location = new Point(272, 319);
            carColorTextBox.Name = "carColorTextBox";
            carColorTextBox.Size = new Size(300, 47);
            carColorTextBox.TabIndex = 6;
            // 
            // carColorLabel
            // 
            carColorLabel.AutoSize = true;
            carColorLabel.Font = new Font("Segoe UI", 15F);
            carColorLabel.Location = new Point(12, 322);
            carColorLabel.Name = "carColorLabel";
            carColorLabel.Size = new Size(157, 41);
            carColorLabel.TabIndex = 5;
            carColorLabel.Text = "Car Color: ";
            // 
            // saveCarDetailsButton
            // 
            saveCarDetailsButton.Location = new Point(838, 382);
            saveCarDetailsButton.Name = "saveCarDetailsButton";
            saveCarDetailsButton.Size = new Size(259, 73);
            saveCarDetailsButton.TabIndex = 7;
            saveCarDetailsButton.Text = "Save Order";
            saveCarDetailsButton.UseVisualStyleBackColor = true;
            saveCarDetailsButton.Click += SaveCarDetailsButton_Click;
            // 
            // carSearchButton
            // 
            carSearchButton.Location = new Point(838, 84);
            carSearchButton.Name = "carSearchButton";
            carSearchButton.Size = new Size(259, 67);
            carSearchButton.TabIndex = 8;
            carSearchButton.Text = "Search Car";
            carSearchButton.UseVisualStyleBackColor = true;
            carSearchButton.Click += CarSearchButton_Click;
            // 
            // companyNameTextBox
            // 
            companyNameTextBox.Font = new Font("Segoe UI", 15F);
            companyNameTextBox.Location = new Point(272, 414);
            companyNameTextBox.Name = "companyNameTextBox";
            companyNameTextBox.Size = new Size(300, 47);
            companyNameTextBox.TabIndex = 10;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Font = new Font("Segoe UI", 15F);
            companyNameLabel.Location = new Point(12, 414);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(240, 41);
            companyNameLabel.TabIndex = 9;
            companyNameLabel.Text = "Company Name:";
            // 
            // companyNumberTextBox
            // 
            companyNumberTextBox.Font = new Font("Segoe UI", 15F);
            companyNumberTextBox.Location = new Point(272, 498);
            companyNumberTextBox.Name = "companyNumberTextBox";
            companyNumberTextBox.Size = new Size(300, 47);
            companyNumberTextBox.TabIndex = 12;
            // 
            // companyNumberLabel
            // 
            companyNumberLabel.AutoSize = true;
            companyNumberLabel.Font = new Font("Segoe UI", 15F);
            companyNumberLabel.Location = new Point(12, 498);
            companyNumberLabel.Name = "companyNumberLabel";
            companyNumberLabel.Size = new Size(216, 41);
            companyNumberLabel.TabIndex = 11;
            companyNumberLabel.Text = "Company No. :";
            // 
            // addNewCarButton
            // 
            addNewCarButton.Location = new Point(235, 578);
            addNewCarButton.Name = "addNewCarButton";
            addNewCarButton.Size = new Size(376, 73);
            addNewCarButton.TabIndex = 13;
            addNewCarButton.Text = "Add Car To Order";
            addNewCarButton.UseVisualStyleBackColor = true;
            addNewCarButton.Click += AddNewCarButton_Click;
            // 
            // readOrderFromFileButton
            // 
            readOrderFromFileButton.Location = new Point(838, 210);
            readOrderFromFileButton.Name = "readOrderFromFileButton";
            readOrderFromFileButton.Size = new Size(259, 116);
            readOrderFromFileButton.TabIndex = 14;
            readOrderFromFileButton.Text = "Read Order From File";
            readOrderFromFileButton.UseVisualStyleBackColor = true;
            readOrderFromFileButton.Click += ReadOrderFromFileButton_Click;
            // 
            // ImportCarsMainForm
            // 
            AutoScaleDimensions = new SizeF(22F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 687);
            Controls.Add(readOrderFromFileButton);
            Controls.Add(addNewCarButton);
            Controls.Add(companyNumberTextBox);
            Controls.Add(companyNumberLabel);
            Controls.Add(companyNameTextBox);
            Controls.Add(companyNameLabel);
            Controls.Add(carSearchButton);
            Controls.Add(saveCarDetailsButton);
            Controls.Add(carColorTextBox);
            Controls.Add(carColorLabel);
            Controls.Add(carModelTextBox);
            Controls.Add(carModelLabel);
            Controls.Add(carNumberTextBox);
            Controls.Add(CarNumberLabel);
            Controls.Add(ImportCarsFormTitleLabel);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(7, 6, 7, 6);
            Name = "ImportCarsMainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ImportCarsFormTitleLabel;
        private Label CarNumberLabel;
        private TextBox carNumberTextBox;
        private TextBox carModelTextBox;
        private Label carModelLabel;
        private TextBox carColorTextBox;
        private Label carColorLabel;
        private Button saveCarDetailsButton;
        private Button carSearchButton;
        private TextBox companyNameTextBox;
        private Label companyNameLabel;
        private TextBox companyNumberTextBox;
        private Label companyNumberLabel;
        private Button addNewCarButton;
        private Button readOrderFromFileButton;
    }
}

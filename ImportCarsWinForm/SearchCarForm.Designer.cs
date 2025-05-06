namespace ImportCarsWinForm
{
    partial class SearchCarForm
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
            searchCarTitleLabel = new Label();
            carNumberLabel = new Label();
            searchCarNumberTextBox = new TextBox();
            searchCarButton = new Button();
            SuspendLayout();
            // 
            // searchCarTitleLabel
            // 
            searchCarTitleLabel.AutoSize = true;
            searchCarTitleLabel.Font = new Font("Segoe UI", 20F);
            searchCarTitleLabel.Location = new Point(349, 39);
            searchCarTitleLabel.Name = "searchCarTitleLabel";
            searchCarTitleLabel.Size = new Size(210, 54);
            searchCarTitleLabel.TabIndex = 0;
            searchCarTitleLabel.Text = "Search Car";
            // 
            // carNumberLabel
            // 
            carNumberLabel.AutoSize = true;
            carNumberLabel.Font = new Font("Segoe UI", 15F);
            carNumberLabel.Location = new Point(101, 147);
            carNumberLabel.Name = "carNumberLabel";
            carNumberLabel.Size = new Size(132, 41);
            carNumberLabel.TabIndex = 1;
            carNumberLabel.Text = "Car No. :";
            // 
            // searchCarNumberTextBox
            // 
            searchCarNumberTextBox.Location = new Point(266, 157);
            searchCarNumberTextBox.Name = "searchCarNumberTextBox";
            searchCarNumberTextBox.Size = new Size(179, 31);
            searchCarNumberTextBox.TabIndex = 2;
            // 
            // searchCarButton
            // 
            searchCarButton.Font = new Font("Segoe UI", 15F);
            searchCarButton.Location = new Point(567, 224);
            searchCarButton.Name = "searchCarButton";
            searchCarButton.Size = new Size(156, 74);
            searchCarButton.TabIndex = 3;
            searchCarButton.Text = "Search";
            searchCarButton.UseVisualStyleBackColor = true;
            searchCarButton.Click += SearchCarButton_Click;
            // 
            // SearchCarForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 569);
            Controls.Add(searchCarButton);
            Controls.Add(searchCarNumberTextBox);
            Controls.Add(carNumberLabel);
            Controls.Add(searchCarTitleLabel);
            Name = "SearchCarForm";
            Text = "SearchCarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label searchCarTitleLabel;
        private Label carNumberLabel;
        private TextBox searchCarNumberTextBox;
        private Button searchCarButton;
    }
}
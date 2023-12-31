
namespace CheckedListBoxExtensionsApp
{
    partial class CheckedToDataGridViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckedToDataGridViewForm));
            CompaniesCheckedListBox = new CheckedListBox();
            ResultsDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            CopyFromCheckedListBoxToDataGridViewButton = new Button();
            ClearDataGridViewRowsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ResultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CompaniesCheckedListBox
            // 
            CompaniesCheckedListBox.FormattingEnabled = true;
            CompaniesCheckedListBox.Location = new Point(14, 16);
            CompaniesCheckedListBox.Margin = new Padding(3, 4, 3, 4);
            CompaniesCheckedListBox.Name = "CompaniesCheckedListBox";
            CompaniesCheckedListBox.Size = new Size(332, 334);
            CompaniesCheckedListBox.TabIndex = 0;
            // 
            // ResultsDataGridView
            // 
            ResultsDataGridView.AllowUserToAddRows = false;
            ResultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ResultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            ResultsDataGridView.Location = new Point(368, 16);
            ResultsDataGridView.Margin = new Padding(3, 4, 3, 4);
            ResultsDataGridView.Name = "ResultsDataGridView";
            ResultsDataGridView.RowHeadersWidth = 51;
            ResultsDataGridView.RowTemplate.Height = 25;
            ResultsDataGridView.Size = new Size(443, 334);
            ResultsDataGridView.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Name";
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // CopyFromCheckedListBoxToDataGridViewButton
            // 
            CopyFromCheckedListBoxToDataGridViewButton.Location = new Point(12, 356);
            CopyFromCheckedListBoxToDataGridViewButton.Margin = new Padding(3, 4, 3, 4);
            CopyFromCheckedListBoxToDataGridViewButton.Name = "CopyFromCheckedListBoxToDataGridViewButton";
            CopyFromCheckedListBoxToDataGridViewButton.Size = new Size(334, 31);
            CopyFromCheckedListBoxToDataGridViewButton.TabIndex = 2;
            CopyFromCheckedListBoxToDataGridViewButton.Text = "Copy checked to DataGridView no duplicates";
            CopyFromCheckedListBoxToDataGridViewButton.UseVisualStyleBackColor = true;
            CopyFromCheckedListBoxToDataGridViewButton.Click += CopyFromCheckedListBoxToDataGridViewButton_Click;
            // 
            // ClearDataGridViewRowsButton
            // 
            ClearDataGridViewRowsButton.Location = new Point(14, 398);
            ClearDataGridViewRowsButton.Margin = new Padding(3, 4, 3, 4);
            ClearDataGridViewRowsButton.Name = "ClearDataGridViewRowsButton";
            ClearDataGridViewRowsButton.Size = new Size(332, 31);
            ClearDataGridViewRowsButton.TabIndex = 3;
            ClearDataGridViewRowsButton.Text = "Clear DataGridView rows";
            ClearDataGridViewRowsButton.UseVisualStyleBackColor = true;
            ClearDataGridViewRowsButton.Click += ClearDataGridViewRowsButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 457);
            Controls.Add(ClearDataGridViewRowsButton);
            Controls.Add(CopyFromCheckedListBoxToDataGridViewButton);
            Controls.Add(ResultsDataGridView);
            Controls.Add(CompaniesCheckedListBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generic CheckedListBox example";
            ((System.ComponentModel.ISupportInitialize)ResultsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.CheckedListBox CompaniesCheckedListBox;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
        private System.Windows.Forms.Button CopyFromCheckedListBoxToDataGridViewButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button ClearDataGridViewRowsButton;
    }
}


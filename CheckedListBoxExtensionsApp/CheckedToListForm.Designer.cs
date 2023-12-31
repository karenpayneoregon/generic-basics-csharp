namespace CheckedListBoxExtensionsApp;

partial class CheckedToListForm
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
            this.ClearListBoxButton = new System.Windows.Forms.Button();
            this.ClearCheckedButton = new System.Windows.Forms.Button();
            this.PeekButton = new System.Windows.Forms.Button();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.MoveLeftButton = new System.Windows.Forms.Button();
            this.ProductsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // ClearListBoxButton
            // 
            this.ClearListBoxButton.Location = new System.Drawing.Point(400, 361);
            this.ClearListBoxButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearListBoxButton.Name = "ClearListBoxButton";
            this.ClearListBoxButton.Size = new System.Drawing.Size(272, 31);
            this.ClearListBoxButton.TabIndex = 13;
            this.ClearListBoxButton.Text = "Clear list";
            this.ClearListBoxButton.UseVisualStyleBackColor = true;
            this.ClearListBoxButton.Click += new System.EventHandler(this.ClearListBoxButton_Click);
            // 
            // ClearCheckedButton
            // 
            this.ClearCheckedButton.Location = new System.Drawing.Point(12, 325);
            this.ClearCheckedButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearCheckedButton.Name = "ClearCheckedButton";
            this.ClearCheckedButton.Size = new System.Drawing.Size(272, 31);
            this.ClearCheckedButton.TabIndex = 12;
            this.ClearCheckedButton.Text = "Clear checked items";
            this.ClearCheckedButton.UseVisualStyleBackColor = true;
            this.ClearCheckedButton.Click += new System.EventHandler(this.ClearCheckedButton_Click);
            // 
            // PeekButton
            // 
            this.PeekButton.Location = new System.Drawing.Point(400, 325);
            this.PeekButton.Name = "PeekButton";
            this.PeekButton.Size = new System.Drawing.Size(272, 29);
            this.PeekButton.TabIndex = 11;
            this.PeekButton.Text = "Iterate items";
            this.PeekButton.UseVisualStyleBackColor = true;
            this.PeekButton.Click += new System.EventHandler(this.PeekButton_Click);
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 20;
            this.ResultsListBox.Location = new System.Drawing.Point(400, 24);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(272, 284);
            this.ResultsListBox.Sorted = true;
            this.ResultsListBox.TabIndex = 10;
            // 
            // MoveLeftButton
            // 
            this.MoveLeftButton.Location = new System.Drawing.Point(290, 50);
            this.MoveLeftButton.Name = "MoveLeftButton";
            this.MoveLeftButton.Size = new System.Drawing.Size(104, 29);
            this.MoveLeftButton.TabIndex = 9;
            this.MoveLeftButton.Text = ">>";
            this.MoveLeftButton.UseVisualStyleBackColor = true;
            this.MoveLeftButton.Click += new System.EventHandler(this.MoveLeftButton_Click);
            // 
            // ProductsCheckedListBox
            // 
            this.ProductsCheckedListBox.FormattingEnabled = true;
            this.ProductsCheckedListBox.Location = new System.Drawing.Point(12, 25);
            this.ProductsCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductsCheckedListBox.Name = "ProductsCheckedListBox";
            this.ProductsCheckedListBox.Size = new System.Drawing.Size(272, 290);
            this.ProductsCheckedListBox.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 416);
            this.Controls.Add(this.ClearListBoxButton);
            this.Controls.Add(this.ClearCheckedButton);
            this.Controls.Add(this.PeekButton);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.MoveLeftButton);
            this.Controls.Add(this.ProductsCheckedListBox);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.ResumeLayout(false);

    }

    #endregion

    private Button ClearListBoxButton;
    private Button ClearCheckedButton;
    private Button PeekButton;
    private ListBox ResultsListBox;
    private Button MoveLeftButton;
    private CheckedListBox ProductsCheckedListBox;
}
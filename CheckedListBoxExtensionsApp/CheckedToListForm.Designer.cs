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
        ClearListBoxButton = new Button();
        ClearCheckedButton = new Button();
        PeekButton = new Button();
        ResultsListBox = new ListBox();
        MoveLeftButton = new Button();
        ProductsCheckedListBox = new CheckedListBox();
        ReadSaveListBoxButton = new Button();
        SuspendLayout();
        // 
        // ClearListBoxButton
        // 
        ClearListBoxButton.Location = new Point(400, 361);
        ClearListBoxButton.Margin = new Padding(3, 4, 3, 4);
        ClearListBoxButton.Name = "ClearListBoxButton";
        ClearListBoxButton.Size = new Size(272, 31);
        ClearListBoxButton.TabIndex = 13;
        ClearListBoxButton.Text = "Clear list";
        ClearListBoxButton.UseVisualStyleBackColor = true;
        ClearListBoxButton.Click += ClearListBoxButton_Click;
        // 
        // ClearCheckedButton
        // 
        ClearCheckedButton.Location = new Point(12, 325);
        ClearCheckedButton.Margin = new Padding(3, 4, 3, 4);
        ClearCheckedButton.Name = "ClearCheckedButton";
        ClearCheckedButton.Size = new Size(272, 31);
        ClearCheckedButton.TabIndex = 12;
        ClearCheckedButton.Text = "Clear checked items";
        ClearCheckedButton.UseVisualStyleBackColor = true;
        ClearCheckedButton.Click += ClearCheckedButton_Click;
        // 
        // PeekButton
        // 
        PeekButton.Location = new Point(400, 325);
        PeekButton.Name = "PeekButton";
        PeekButton.Size = new Size(272, 29);
        PeekButton.TabIndex = 11;
        PeekButton.Text = "Iterate items";
        PeekButton.UseVisualStyleBackColor = true;
        PeekButton.Click += PeekButton_Click;
        // 
        // ResultsListBox
        // 
        ResultsListBox.FormattingEnabled = true;
        ResultsListBox.Location = new Point(400, 24);
        ResultsListBox.Name = "ResultsListBox";
        ResultsListBox.Size = new Size(272, 284);
        ResultsListBox.Sorted = true;
        ResultsListBox.TabIndex = 10;
        // 
        // MoveLeftButton
        // 
        MoveLeftButton.Location = new Point(290, 50);
        MoveLeftButton.Name = "MoveLeftButton";
        MoveLeftButton.Size = new Size(104, 29);
        MoveLeftButton.TabIndex = 9;
        MoveLeftButton.Text = ">>";
        MoveLeftButton.UseVisualStyleBackColor = true;
        MoveLeftButton.Click += MoveLeftButton_Click;
        // 
        // ProductsCheckedListBox
        // 
        ProductsCheckedListBox.FormattingEnabled = true;
        ProductsCheckedListBox.Location = new Point(12, 25);
        ProductsCheckedListBox.Margin = new Padding(3, 4, 3, 4);
        ProductsCheckedListBox.Name = "ProductsCheckedListBox";
        ProductsCheckedListBox.Size = new Size(272, 290);
        ProductsCheckedListBox.TabIndex = 8;
        // 
        // ReadSaveListBoxButton
        // 
        ReadSaveListBoxButton.Location = new Point(400, 408);
        ReadSaveListBoxButton.Name = "ReadSaveListBoxButton";
        ReadSaveListBoxButton.Size = new Size(272, 29);
        ReadSaveListBoxButton.TabIndex = 14;
        ReadSaveListBoxButton.Text = "Save/read json ListBox";
        ReadSaveListBoxButton.UseVisualStyleBackColor = true;
        ReadSaveListBoxButton.Click += ReadSaveListBoxButton_Click;
        // 
        // CheckedToListForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(684, 476);
        Controls.Add(ReadSaveListBoxButton);
        Controls.Add(ClearListBoxButton);
        Controls.Add(ClearCheckedButton);
        Controls.Add(PeekButton);
        Controls.Add(ResultsListBox);
        Controls.Add(MoveLeftButton);
        Controls.Add(ProductsCheckedListBox);
        Name = "CheckedToListForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Products";
        ResumeLayout(false);
    }

    #endregion

    private Button ClearListBoxButton;
    private Button ClearCheckedButton;
    private Button PeekButton;
    private ListBox ResultsListBox;
    private Button MoveLeftButton;
    private CheckedListBox ProductsCheckedListBox;
    private Button ReadSaveListBoxButton;
}
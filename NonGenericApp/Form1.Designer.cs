namespace NonGenericApp;

partial class Form1
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
        CompaniesCheckedListBox = new CheckedListBox();
        GetCheckedAsStringButton = new Button();
        GetCheckedExtensionMethodButton = new Button();
        label1 = new Label();
        SuspendLayout();
        // 
        // CompaniesCheckedListBox
        // 
        CompaniesCheckedListBox.FormattingEnabled = true;
        CompaniesCheckedListBox.Location = new Point(18, 13);
        CompaniesCheckedListBox.Margin = new Padding(3, 4, 3, 4);
        CompaniesCheckedListBox.Name = "CompaniesCheckedListBox";
        CompaniesCheckedListBox.Size = new Size(363, 334);
        CompaniesCheckedListBox.TabIndex = 1;
        // 
        // GetCheckedAsStringButton
        // 
        GetCheckedAsStringButton.Location = new Point(18, 354);
        GetCheckedAsStringButton.Name = "GetCheckedAsStringButton";
        GetCheckedAsStringButton.Size = new Size(363, 29);
        GetCheckedAsStringButton.TabIndex = 2;
        GetCheckedAsStringButton.Text = "Get checked version 1";
        GetCheckedAsStringButton.UseVisualStyleBackColor = true;
        GetCheckedAsStringButton.Click += GetCheckedAsStringButton_Click;
        // 
        // GetCheckedExtensionMethodButton
        // 
        GetCheckedExtensionMethodButton.Location = new Point(18, 389);
        GetCheckedExtensionMethodButton.Name = "GetCheckedExtensionMethodButton";
        GetCheckedExtensionMethodButton.Size = new Size(363, 29);
        GetCheckedExtensionMethodButton.TabIndex = 3;
        GetCheckedExtensionMethodButton.Text = "Get checked version 2";
        GetCheckedExtensionMethodButton.UseVisualStyleBackColor = true;
        GetCheckedExtensionMethodButton.Click += GetCheckedExtensionMethodButton_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label1.Location = new Point(12, 433);
        label1.Name = "label1";
        label1.Size = new Size(375, 20);
        label1.TabIndex = 4;
        label1.Text = "Results for buttons are shown in the output window";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(399, 474);
        Controls.Add(label1);
        Controls.Add(GetCheckedExtensionMethodButton);
        Controls.Add(GetCheckedAsStringButton);
        Controls.Add(CompaniesCheckedListBox);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Non-Generic";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CheckedListBox CompaniesCheckedListBox;
    private Button GetCheckedAsStringButton;
    private Button GetCheckedExtensionMethodButton;
    private Label label1;
}
